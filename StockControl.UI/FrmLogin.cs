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
		private readonly IPersonelService _personelService;
		public FrmLogin(IPersonelService personelService)
		{
			this._personelService = personelService;
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			var personel = _personelService.Login(txtIdentity.Text, txtPassword.Text);
			if (personel!=null)
			{
				MessageBox.Show("Login Succesfull");
			}
			else
			{
				MessageBox.Show("Invalid Identity Number Or Password");
			}
		}
	}
}
