namespace StockControl.UI
{
	partial class FrmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSale = new System.Windows.Forms.Button();
			this.btnStock = new System.Windows.Forms.Button();
			this.btnPersonel = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnCategory = new System.Windows.Forms.Button();
			this.btnShipment = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel1.Controls.Add(this.btnShipment);
			this.panel1.Controls.Add(this.btnCategory);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.btnLogout);
			this.panel1.Controls.Add(this.btnPersonel);
			this.panel1.Controls.Add(this.btnStock);
			this.panel1.Controls.Add(this.btnSale);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1279, 665);
			this.panel1.TabIndex = 1;
			// 
			// btnSale
			// 
			this.btnSale.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSale.Location = new System.Drawing.Point(326, 359);
			this.btnSale.Name = "btnSale";
			this.btnSale.Size = new System.Drawing.Size(100, 75);
			this.btnSale.TabIndex = 0;
			this.btnSale.Text = "Sale";
			this.btnSale.UseVisualStyleBackColor = true;
			this.btnSale.Click += new System.EventHandler(this.BtnSale_Click);
			// 
			// btnStock
			// 
			this.btnStock.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnStock.Location = new System.Drawing.Point(827, 359);
			this.btnStock.Name = "btnStock";
			this.btnStock.Size = new System.Drawing.Size(100, 75);
			this.btnStock.TabIndex = 2;
			this.btnStock.Text = "Stock";
			this.btnStock.UseVisualStyleBackColor = true;
			// 
			// btnPersonel
			// 
			this.btnPersonel.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnPersonel.Location = new System.Drawing.Point(326, 463);
			this.btnPersonel.Name = "btnPersonel";
			this.btnPersonel.Size = new System.Drawing.Size(100, 75);
			this.btnPersonel.TabIndex = 3;
			this.btnPersonel.Text = "Personel";
			this.btnPersonel.UseVisualStyleBackColor = true;
			// 
			// btnLogout
			// 
			this.btnLogout.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnLogout.Location = new System.Drawing.Point(827, 463);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(100, 75);
			this.btnLogout.TabIndex = 5;
			this.btnLogout.Text = "Logout";
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
			// 
			// btnCategory
			// 
			this.btnCategory.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCategory.Location = new System.Drawing.Point(574, 359);
			this.btnCategory.Name = "btnCategory";
			this.btnCategory.Size = new System.Drawing.Size(100, 75);
			this.btnCategory.TabIndex = 1;
			this.btnCategory.Text = "Category";
			this.btnCategory.UseVisualStyleBackColor = true;
			// 
			// btnShipment
			// 
			this.btnShipment.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnShipment.Location = new System.Drawing.Point(574, 463);
			this.btnShipment.Name = "btnShipment";
			this.btnShipment.Size = new System.Drawing.Size(100, 75);
			this.btnShipment.TabIndex = 4;
			this.btnShipment.Text = "Shipment";
			this.btnShipment.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(423, 85);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(402, 268);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1279, 665);
			this.Controls.Add(this.panel1);
			this.IsMdiContainer = true;
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmMain";
			this.Load += new System.EventHandler(this.FrmMain_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Button btnPersonel;
		private System.Windows.Forms.Button btnStock;
		private System.Windows.Forms.Button btnSale;
		private System.Windows.Forms.Button btnShipment;
		private System.Windows.Forms.Button btnCategory;
	}
}