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
		private readonly IPersonelService _personelService;

		public FrmMain(FrmRegister frmRegister,FrmLogin frmLogin, IPersonelService personelService )
		{			
			this._personelService = personelService;
			InitializeComponent();
			this._frmRegister = frmRegister;
			this._frmLogin = frmLogin;

		}

		private void FrmMain_Load(object sender, EventArgs e)
		{
			var personelcount = _personelService.GetAll().Count();
			if (personelcount == 0)
			{
				_frmRegister.Show();
				this.WindowState = FormWindowState.Minimized;
				this.ShowInTaskbar = false;
			}
			else
			{
				_frmLogin.Show();
				this.WindowState = FormWindowState.Minimized;
				this.ShowInTaskbar = false;
			}
		}
	}
}