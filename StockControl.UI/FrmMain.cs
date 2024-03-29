﻿using StockControl.Service;
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
	public partial class FrmMain : Form
	{
		private readonly FrmLogin _frmLogin;
		private readonly FrmRegister _frmRegister;
		private readonly FrmSale _frmSale;
		private readonly IPersonelService _personelService;

		public FrmMain(FrmRegister frmRegister,FrmLogin frmLogin, IPersonelService personelService,FrmSale frmSale )
		{			
			this._personelService = personelService;
			InitializeComponent();
			this._frmRegister = frmRegister;
			
			this._frmLogin = frmLogin;
			this._frmLogin.MasterForm = this;
			
			this._frmSale = frmSale;

		}

		private void FrmMain_Load(object sender, EventArgs e)
		{
			var personelcount = _personelService.GetAll().Count();
			if (personelcount == 0)
			{
				_frmRegister.Show();
				this.Hide();
				
			}
			else
			{
				_frmLogin.Show();
				this.Hide();
			}

		}

		private void BtnLogout_Click(object sender, EventArgs e)
		{
			this._frmLogin.Show();			
			this._frmLogin.ClearLoginForm();
		}

		private void BtnSale_Click(object sender, EventArgs e)
		{
			_frmSale.Show();			
			
			
		}
	}
}
