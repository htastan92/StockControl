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
	public partial class FrmLogin : Form
	{
		public FrmMain MasterForm { get; set; }
		private readonly IPersonelService _personelService;
		public FrmLogin(IPersonelService personelService)
		{
			this._personelService = personelService;
			InitializeComponent();
		
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtIdentity.Text))
			{
				MessageBox.Show("You Have To Enter Identity Numb");
				return;
			}
			else if (string.IsNullOrEmpty(txtPassword.Text))
			{
				MessageBox.Show("You Have To Enter Password");
				return;
			}
			var personel = _personelService.Login(txtIdentity.Text, txtPassword.Text);
			if (personel!=null)
			{
				MessageBox.Show("Login Succesfull");
				MasterForm.WindowState = FormWindowState.Normal;
				this.Hide();
			
			}
			else
			{
				MessageBox.Show("Invalid Identity Number Or Password");
			}
		}

		public void ClearLoginForm()
		{
			txtIdentity.Text = string.Empty;
			txtPassword.Text = string.Empty;
		}

		private void FrmLogin_Load(object sender, EventArgs e)
		{

		}
	}
}
