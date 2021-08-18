
namespace QLTT.Controls
{
    partial class HoSoCaNhan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.HinhNV = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelMatKhau = new System.Windows.Forms.Label();
            this.DateNV = new System.Windows.Forms.DateTimePicker();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.TBEmailNV = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelEmail = new System.Windows.Forms.Label();
            this.TBSDTNV = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labelSDT = new System.Windows.Forms.Label();
            this.TBTenNV = new System.Windows.Forms.TextBox();
            this.labelTênNV = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BTNLuu = new FontAwesome.Sharp.IconButton();
            this.BTNHuy = new FontAwesome.Sharp.IconButton();
            this.BTNReset = new FontAwesome.Sharp.IconButton();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HinhNV)).BeginInit();
            this.panelChucNang.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Silver;
            this.panelTitle.Controls.Add(this.textBox2);
            this.panelTitle.Controls.Add(this.HinhNV);
            this.panelTitle.Controls.Add(this.textBox1);
            this.panelTitle.Controls.Add(this.panel3);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(800, 150);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.Location = new System.Drawing.Point(521, 84);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 27);
            this.textBox2.TabIndex = 4;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "MÃ NV";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HinhNV
            // 
            this.HinhNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HinhNV.Image = global::QLTT.Properties.Resources._1111;
            this.HinhNV.Location = new System.Drawing.Point(95, 9);
            this.HinhNV.Name = "HinhNV";
            this.HinhNV.Size = new System.Drawing.Size(146, 135);
            this.HinhNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HinhNV.TabIndex = 0;
            this.HinhNV.TabStop = false;
            this.HinhNV.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(283, 84);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Nguyễn Đức Trí";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(366, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 2);
            this.panel3.TabIndex = 3;
            // 
            // panelChucNang
            // 
            this.panelChucNang.Controls.Add(this.panel4);
            this.panelChucNang.Controls.Add(this.panel7);
            this.panelChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChucNang.Location = new System.Drawing.Point(0, 150);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panelChucNang.Size = new System.Drawing.Size(800, 300);
            this.panelChucNang.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel4.Controls.Add(this.labelMatKhau);
            this.panel4.Controls.Add(this.DateNV);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.textBoxMatKhau);
            this.panel4.Controls.Add(this.labelNgaySinh);
            this.panel4.Controls.Add(this.TBEmailNV);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.labelEmail);
            this.panel4.Controls.Add(this.TBSDTNV);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.labelSDT);
            this.panel4.Controls.Add(this.TBTenNV);
            this.panel4.Controls.Add(this.labelTênNV);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(20, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(760, 223);
            this.panel4.TabIndex = 0;
            // 
            // labelMatKhau
            // 
            this.labelMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMatKhau.AutoSize = true;
            this.labelMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatKhau.ForeColor = System.Drawing.Color.White;
            this.labelMatKhau.Location = new System.Drawing.Point(32, 180);
            this.labelMatKhau.Name = "labelMatKhau";
            this.labelMatKhau.Size = new System.Drawing.Size(94, 18);
            this.labelMatKhau.TabIndex = 35;
            this.labelMatKhau.Text = "Mật Khẩu : ";
            // 
            // DateNV
            // 
            this.DateNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateNV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateNV.Location = new System.Drawing.Point(558, 22);
            this.DateNV.Name = "DateNV";
            this.DateNV.Size = new System.Drawing.Size(146, 20);
            this.DateNV.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(58, 202);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 2);
            this.panel9.TabIndex = 34;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(481, 128);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 2);
            this.panel5.TabIndex = 31;
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.textBoxMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMatKhau.ForeColor = System.Drawing.Color.White;
            this.textBoxMatKhau.Location = new System.Drawing.Point(128, 182);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(109, 17);
            this.textBoxMatKhau.TabIndex = 5;
            this.textBoxMatKhau.Text = "0835866056";
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgaySinh.ForeColor = System.Drawing.Color.White;
            this.labelNgaySinh.Location = new System.Drawing.Point(455, 22);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(99, 18);
            this.labelNgaySinh.TabIndex = 27;
            this.labelNgaySinh.Text = "Ngày Sinh : ";
            // 
            // TBEmailNV
            // 
            this.TBEmailNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBEmailNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.TBEmailNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBEmailNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBEmailNV.ForeColor = System.Drawing.Color.White;
            this.TBEmailNV.Location = new System.Drawing.Point(526, 106);
            this.TBEmailNV.Multiline = true;
            this.TBEmailNV.Name = "TBEmailNV";
            this.TBEmailNV.Size = new System.Drawing.Size(231, 20);
            this.TBEmailNV.TabIndex = 4;
            this.TBEmailNV.Text = "nguyenductri030702@gmail.com";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(58, 127);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 2);
            this.panel6.TabIndex = 32;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(455, 107);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(65, 18);
            this.labelEmail.TabIndex = 28;
            this.labelEmail.Text = "Email : ";
            // 
            // TBSDTNV
            // 
            this.TBSDTNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBSDTNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.TBSDTNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBSDTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBSDTNV.ForeColor = System.Drawing.Color.White;
            this.TBSDTNV.Location = new System.Drawing.Point(158, 106);
            this.TBSDTNV.Name = "TBSDTNV";
            this.TBSDTNV.Size = new System.Drawing.Size(109, 17);
            this.TBSDTNV.TabIndex = 3;
            this.TBSDTNV.Text = "0835866056";
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(58, 43);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 2);
            this.panel8.TabIndex = 33;
            // 
            // labelSDT
            // 
            this.labelSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSDT.AutoSize = true;
            this.labelSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSDT.ForeColor = System.Drawing.Color.White;
            this.labelSDT.Location = new System.Drawing.Point(32, 107);
            this.labelSDT.Name = "labelSDT";
            this.labelSDT.Size = new System.Drawing.Size(130, 18);
            this.labelSDT.TabIndex = 29;
            this.labelSDT.Text = "Số Điện Thoại : ";
            // 
            // TBTenNV
            // 
            this.TBTenNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBTenNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.TBTenNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTenNV.ForeColor = System.Drawing.Color.White;
            this.TBTenNV.Location = new System.Drawing.Point(158, 20);
            this.TBTenNV.Multiline = true;
            this.TBTenNV.Name = "TBTenNV";
            this.TBTenNV.Size = new System.Drawing.Size(200, 20);
            this.TBTenNV.TabIndex = 1;
            this.TBTenNV.Text = "Nguyễn đức trí";
            // 
            // labelTênNV
            // 
            this.labelTênNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTênNV.AutoSize = true;
            this.labelTênNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTênNV.ForeColor = System.Drawing.Color.White;
            this.labelTênNV.Location = new System.Drawing.Point(28, 22);
            this.labelTênNV.Name = "labelTênNV";
            this.labelTênNV.Size = new System.Drawing.Size(132, 18);
            this.labelTênNV.TabIndex = 30;
            this.labelTênNV.Text = "Tên Nhân Viên : ";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel7.Controls.Add(this.BTNLuu);
            this.panel7.Controls.Add(this.BTNHuy);
            this.panel7.Controls.Add(this.BTNReset);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(20, 233);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(760, 57);
            this.panel7.TabIndex = 16;
            // 
            // BTNLuu
            // 
            this.BTNLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTNLuu.FlatAppearance.BorderSize = 0;
            this.BTNLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLuu.ForeColor = System.Drawing.Color.White;
            this.BTNLuu.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BTNLuu.IconColor = System.Drawing.Color.White;
            this.BTNLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNLuu.IconSize = 40;
            this.BTNLuu.Location = new System.Drawing.Point(358, 10);
            this.BTNLuu.Name = "BTNLuu";
            this.BTNLuu.Size = new System.Drawing.Size(100, 35);
            this.BTNLuu.TabIndex = 7;
            this.BTNLuu.Text = "Lưu";
            this.BTNLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNLuu.UseVisualStyleBackColor = true;
            // 
            // BTNHuy
            // 
            this.BTNHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTNHuy.FlatAppearance.BorderSize = 0;
            this.BTNHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNHuy.ForeColor = System.Drawing.Color.White;
            this.BTNHuy.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BTNHuy.IconColor = System.Drawing.Color.White;
            this.BTNHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNHuy.IconSize = 40;
            this.BTNHuy.Location = new System.Drawing.Point(595, 10);
            this.BTNHuy.Name = "BTNHuy";
            this.BTNHuy.Size = new System.Drawing.Size(100, 35);
            this.BTNHuy.TabIndex = 8;
            this.BTNHuy.Text = "Hủy";
            this.BTNHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNHuy.UseVisualStyleBackColor = true;
            // 
            // BTNReset
            // 
            this.BTNReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTNReset.FlatAppearance.BorderSize = 0;
            this.BTNReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNReset.ForeColor = System.Drawing.Color.White;
            this.BTNReset.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.BTNReset.IconColor = System.Drawing.Color.White;
            this.BTNReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNReset.IconSize = 40;
            this.BTNReset.Location = new System.Drawing.Point(104, 10);
            this.BTNReset.Name = "BTNReset";
            this.BTNReset.Size = new System.Drawing.Size(100, 35);
            this.BTNReset.TabIndex = 6;
            this.BTNReset.Text = "Reset";
            this.BTNReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNReset.UseVisualStyleBackColor = true;
            // 
            // HoSoCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelChucNang);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panel1);
            this.Name = "HoSoCaNhan";
            this.ShowIcon = false;
            this.Text = "Hồ Sơ Cá Nhân";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HinhNV)).EndInit();
            this.panelChucNang.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox HinhNV;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton BTNLuu;
        private FontAwesome.Sharp.IconButton BTNHuy;
        private FontAwesome.Sharp.IconButton BTNReset;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelMatKhau;
        private System.Windows.Forms.DateTimePicker DateNV;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.TextBox TBEmailNV;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox TBSDTNV;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label labelSDT;
        private System.Windows.Forms.TextBox TBTenNV;
        private System.Windows.Forms.Label labelTênNV;
    }
}