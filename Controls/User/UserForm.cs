using QLTT.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTT.Controls.User
{
    public partial class UserForm : Form
    {

        private Form CurrentChildForm;
        public UserForm()
        {
            InitializeComponent();
            OpenChildForm(new TrangChu());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }
        private  void OpenChildForm (Form ChildForm)
        {
            if (CurrentChildForm !=null)
            {
                CurrentChildForm.Close();
            }
            CurrentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            paneContent.Controls.Add(ChildForm);
            paneContent.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            LabellTiTle.Text = ChildForm.Text;
        }

        private void BTNTrangChu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TrangChu());
        }

        private void BTNLapHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LapHoaDon());

        }

        private void BTNSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SanPham());

        }

        private void BTNHoSo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HoSoCaNhan());

        }
    }
}
