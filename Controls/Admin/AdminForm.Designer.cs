
namespace QLTT.Controls.Admin
{
    partial class AdminForm
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
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.BTNHoSo = new FontAwesome.Sharp.IconButton();
            this.BTNDangXuat = new FontAwesome.Sharp.IconButton();
            this.BTNQuanLyNV = new FontAwesome.Sharp.IconButton();
            this.BTNThongKe = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.BTNTrangChu = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTime = new System.Windows.Forms.Panel();
            this.Titel = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.panelTiTle = new System.Windows.Forms.Panel();
            this.LabellTiTle = new System.Windows.Forms.Label();
            this.IconCurrent = new FontAwesome.Sharp.IconPictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel_Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelTime.SuspendLayout();
            this.panelTiTle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel_Menu.Controls.Add(this.BTNHoSo);
            this.panel_Menu.Controls.Add(this.BTNDangXuat);
            this.panel_Menu.Controls.Add(this.BTNQuanLyNV);
            this.panel_Menu.Controls.Add(this.BTNThongKe);
            this.panel_Menu.Controls.Add(this.panel1);
            this.panel_Menu.Controls.Add(this.BTNTrangChu);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(222, 671);
            this.panel_Menu.TabIndex = 3;
            // 
            // BTNHoSo
            // 
            this.BTNHoSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BTNHoSo.FlatAppearance.BorderSize = 0;
            this.BTNHoSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNHoSo.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNHoSo.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTNHoSo.IconChar = FontAwesome.Sharp.IconChar.User;
            this.BTNHoSo.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNHoSo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BTNHoSo.IconSize = 45;
            this.BTNHoSo.Location = new System.Drawing.Point(0, 366);
            this.BTNHoSo.Name = "BTNHoSo";
            this.BTNHoSo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BTNHoSo.Size = new System.Drawing.Size(222, 60);
            this.BTNHoSo.TabIndex = 8;
            this.BTNHoSo.Text = "        Hồ Sơ              Cá Nhân";
            this.BTNHoSo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNHoSo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNHoSo.UseVisualStyleBackColor = false;
            this.BTNHoSo.Click += new System.EventHandler(this.BTNHoSo_Click);
            // 
            // BTNDangXuat
            // 
            this.BTNDangXuat.AutoSize = true;
            this.BTNDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BTNDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTNDangXuat.FlatAppearance.BorderSize = 0;
            this.BTNDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDangXuat.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDangXuat.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTNDangXuat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.BTNDangXuat.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNDangXuat.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BTNDangXuat.IconSize = 45;
            this.BTNDangXuat.Location = new System.Drawing.Point(0, 599);
            this.BTNDangXuat.Name = "BTNDangXuat";
            this.BTNDangXuat.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BTNDangXuat.Size = new System.Drawing.Size(222, 72);
            this.BTNDangXuat.TabIndex = 9;
            this.BTNDangXuat.Text = "    Đăng Xuất    ";
            this.BTNDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNDangXuat.UseVisualStyleBackColor = false;
            // 
            // BTNQuanLyNV
            // 
            this.BTNQuanLyNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BTNQuanLyNV.FlatAppearance.BorderSize = 0;
            this.BTNQuanLyNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNQuanLyNV.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNQuanLyNV.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTNQuanLyNV.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.BTNQuanLyNV.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNQuanLyNV.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BTNQuanLyNV.IconSize = 45;
            this.BTNQuanLyNV.Location = new System.Drawing.Point(6, 280);
            this.BTNQuanLyNV.Name = "BTNQuanLyNV";
            this.BTNQuanLyNV.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BTNQuanLyNV.Size = new System.Drawing.Size(216, 60);
            this.BTNQuanLyNV.TabIndex = 7;
            this.BTNQuanLyNV.Text = "     Quản Lý          Nhân Viên";
            this.BTNQuanLyNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNQuanLyNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNQuanLyNV.UseVisualStyleBackColor = false;
            this.BTNQuanLyNV.Click += new System.EventHandler(this.BTNQuanLyNV_Click);
            // 
            // BTNThongKe
            // 
            this.BTNThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BTNThongKe.FlatAppearance.BorderSize = 0;
            this.BTNThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNThongKe.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNThongKe.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTNThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.BTNThongKe.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNThongKe.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BTNThongKe.IconSize = 45;
            this.BTNThongKe.Location = new System.Drawing.Point(0, 202);
            this.BTNThongKe.Name = "BTNThongKe";
            this.BTNThongKe.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BTNThongKe.Size = new System.Drawing.Size(220, 60);
            this.BTNThongKe.TabIndex = 6;
            this.BTNThongKe.Text = "     Thống Kê";
            this.BTNThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNThongKe.UseVisualStyleBackColor = false;
            this.BTNThongKe.Click += new System.EventHandler(this.BTNThongKe_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 100);
            this.panel1.TabIndex = 5;
            // 
            // Logo
            // 
            this.Logo.Image = global::QLTT.Properties.Resources.LogoFinal2;
            this.Logo.Location = new System.Drawing.Point(33, 8);
            this.Logo.Name = "Logo";
            this.Logo.Padding = new System.Windows.Forms.Padding(10);
            this.Logo.Size = new System.Drawing.Size(169, 92);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // BTNTrangChu
            // 
            this.BTNTrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BTNTrangChu.FlatAppearance.BorderSize = 0;
            this.BTNTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNTrangChu.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNTrangChu.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTNTrangChu.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.BTNTrangChu.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNTrangChu.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BTNTrangChu.IconSize = 45;
            this.BTNTrangChu.Location = new System.Drawing.Point(0, 125);
            this.BTNTrangChu.Name = "BTNTrangChu";
            this.BTNTrangChu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BTNTrangChu.Size = new System.Drawing.Size(220, 60);
            this.BTNTrangChu.TabIndex = 0;
            this.BTNTrangChu.Text = "     Trang Chủ    ";
            this.BTNTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNTrangChu.UseVisualStyleBackColor = false;
            this.BTNTrangChu.Click += new System.EventHandler(this.BTNTrangChu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelTime);
            this.panel2.Controls.Add(this.panelTiTle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(222, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 100);
            this.panel2.TabIndex = 4;
            // 
            // panelTime
            // 
            this.panelTime.Controls.Add(this.Titel);
            this.panelTime.Controls.Add(this.Date);
            this.panelTime.Controls.Add(this.Time);
            this.panelTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTime.Location = new System.Drawing.Point(276, 0);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(686, 100);
            this.panelTime.TabIndex = 4;
            // 
            // Titel
            // 
            this.Titel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Titel.AutoSize = true;
            this.Titel.Font = new System.Drawing.Font("Mongolian Baiti", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titel.ForeColor = System.Drawing.Color.Gainsboro;
            this.Titel.Location = new System.Drawing.Point(182, -103);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(295, 24);
            this.Titel.TabIndex = 13;
            this.Titel.Text = "Mang bình an đến mọi người";
            // 
            // Date
            // 
            this.Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.Gainsboro;
            this.Date.Location = new System.Drawing.Point(201, 60);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(159, 30);
            this.Date.TabIndex = 12;
            this.Date.Text = "15/15/2021";
            // 
            // Time
            // 
            this.Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.Gainsboro;
            this.Time.Location = new System.Drawing.Point(234, 12);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(82, 31);
            this.Time.TabIndex = 10;
            this.Time.Text = "20:20";
            // 
            // panelTiTle
            // 
            this.panelTiTle.Controls.Add(this.LabellTiTle);
            this.panelTiTle.Controls.Add(this.IconCurrent);
            this.panelTiTle.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTiTle.Location = new System.Drawing.Point(0, 0);
            this.panelTiTle.Name = "panelTiTle";
            this.panelTiTle.Size = new System.Drawing.Size(276, 100);
            this.panelTiTle.TabIndex = 2;
            // 
            // LabellTiTle
            // 
            this.LabellTiTle.AutoSize = true;
            this.LabellTiTle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabellTiTle.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabellTiTle.Location = new System.Drawing.Point(134, 48);
            this.LabellTiTle.Name = "LabellTiTle";
            this.LabellTiTle.Size = new System.Drawing.Size(92, 20);
            this.LabellTiTle.TabIndex = 1;
            this.LabellTiTle.Text = "Trang Chủ";
            // 
            // IconCurrent
            // 
            this.IconCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.IconCurrent.ForeColor = System.Drawing.Color.Gainsboro;
            this.IconCurrent.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconCurrent.IconColor = System.Drawing.Color.Gainsboro;
            this.IconCurrent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCurrent.IconSize = 44;
            this.IconCurrent.Location = new System.Drawing.Point(72, 40);
            this.IconCurrent.Name = "IconCurrent";
            this.IconCurrent.Size = new System.Drawing.Size(50, 44);
            this.IconCurrent.TabIndex = 0;
            this.IconCurrent.TabStop = false;
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(222, 100);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(962, 571);
            this.panelContent.TabIndex = 5;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1184, 671);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_Menu);
            this.ForeColor = System.Drawing.Color.White;
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1200, 710);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
            this.panelTiTle.ResumeLayout(false);
            this.panelTiTle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private FontAwesome.Sharp.IconButton BTNHoSo;
        private FontAwesome.Sharp.IconButton BTNDangXuat;
        private FontAwesome.Sharp.IconButton BTNQuanLyNV;
        private FontAwesome.Sharp.IconButton BTNThongKe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logo;
        private FontAwesome.Sharp.IconButton BTNTrangChu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.Label Titel;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Panel panelTiTle;
        private System.Windows.Forms.Label LabellTiTle;
        private FontAwesome.Sharp.IconPictureBox IconCurrent;
        private System.Windows.Forms.Panel panelContent;
    }
}