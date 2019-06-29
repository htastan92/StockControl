using StockControl.Data;
using StockControl.Model;
using StockControl.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl.UI
{	
	public partial class FrmRegister : Form
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly FrmLogin _frmLogin; 
		private readonly IPersonelService _personelService;
		public FrmRegister(FrmLogin frmLogin, IPersonelService personelService,IUnitOfWork unitOfWork)
		{
			this._unitOfWork = unitOfWork;
			this._personelService = personelService;
			InitializeComponent();
			this._frmLogin = frmLogin;
		}

		private void BtnSignIn_Click(object sender, EventArgs e)
		{
			var personel = new Personel();
			if (string.IsNullOrEmpty(txtIdentity.Text))
			{
				MessageBox.Show("You Have To Enter Identity Number");
				return;
			}
			else if (string.IsNullOrEmpty(txtPassword.Text))
			{
				MessageBox.Show("You Have To Enter Password");
				return;
			}
			else if (string.IsNullOrEmpty(txtConfirmP.Text))
			{
				MessageBox.Show("You Have To Confirm Identity Number");
				return;
			}
			else if (txtPassword.Text!=txtConfirmP.Text)
			{
				MessageBox.Show("Passwords Dont Match");
				return;
			}
			else if (string.IsNullOrEmpty(txtFirstName.Text))
			{
				MessageBox.Show("You Have To Enter FirstName");
				return;
			}
			else if (string.IsNullOrEmpty(txtLastName.Text))
			{
				MessageBox.Show("You Have To Enter FirstName");
				return;
			}
			else if (cmbAuthority.SelectedIndex < 0)
			{
				MessageBox.Show("You Have To Choose Authority Level");
				return;
			}
			else if (string.IsNullOrEmpty(txtPhone.Text))
			{
				MessageBox.Show("You Have To Enter Phone Number");
				return;
			}
			else if (string.IsNullOrEmpty(txtLastName.Text))
			{
				MessageBox.Show("You Have To Enter Email Adress");
				return;
			}
			personel.IdentityNumber = txtIdentity.Text;
			personel.Password = txtPassword.Text;
			personel.FirstName = txtFirstName.Text;
			personel.LastName = txtLastName.Text;
			if (rbMale.Checked)
			{
				personel.Gender = Gender.Male;
			}
			else if(rbFemale.Checked)
			{
				personel.Gender = Gender.Female;
			}
			else
			{
				MessageBox.Show("You Have To Choose Gender");
			}
			personel.AuthorityLevel = (AuthorityLevel)(cmbAuthority.SelectedIndex + 1);
			personel.BirthDate = dtpBirthDate.Value;
			personel.Phone = txtPhone.Text;
			personel.Email = txtEmail.Text;
			_unitOfWork.SaveChanges();

			


			var status = _personelService.Register(personel);
			switch (status)
			{
				case RegisterStatus.Success:
					MessageBox.Show("Registration Successful");
					this.Close();
					_frmLogin.Show();

					break;
			
				case RegisterStatus.UserAlreadyExists:
					MessageBox.Show("This Identity Number Is Already Used");
					this.Close();
					break;

			}
		}

		private void FrmRegister_Load(object sender, EventArgs e)
		{

		}
	}
}
