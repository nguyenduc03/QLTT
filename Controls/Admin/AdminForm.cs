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
using FontAwesome.Sharp;
using QLTT.Common.Class;

namespace QLTT.Controls.Admin
{
    public partial class AdminForm : Form
    {
        private IconButton CurrentBTN = new IconButton();
        private Form CurrentFormChildren ;
        public AdminForm()
        {
            InitializeComponent();
            OpenFormChildren(new TrangChu());
            ShowCurrentBTN(BTNTrangChu, ClassColor.color1);
        }


        private void  OpenFormChildren ( Form ChildrenForm)
        {
            if (CurrentFormChildren != null)
            {
                CurrentFormChildren.Close();
            }
            CurrentFormChildren = ChildrenForm;

            ChildrenForm.TopLevel = false;
            ChildrenForm.FormBorderStyle = FormBorderStyle.None;
            ChildrenForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(ChildrenForm);
            panelContent.Tag = ChildrenForm;
            ChildrenForm.BringToFront();
            ChildrenForm.Show();
            LabellTiTle.Text = ChildrenForm.Text;
        }
        public void ShowCurrentBTN(object senderBTN , Color colorInput)
        {
            if (senderBTN != null)
            {
                ResetBTN();
                CurrentBTN = (IconButton)senderBTN;
                CurrentBTN.TextAlign = ContentAlignment.MiddleLeft;
                CurrentBTN.TextImageRelation = TextImageRelation.TextBeforeImage;
                CurrentBTN.BackColor = Color.FromArgb(70, 252, 252, 252);
                CurrentBTN.IconColor = colorInput;


                /// icon current 
                IconCurrent.IconChar = CurrentBTN.IconChar;
                IconCurrent.IconColor = CurrentBTN.IconColor;

            }
        }
        public void ResetBTN ( )
        {
            if(CurrentBTN != null)
            {
                CurrentBTN.TextAlign = ContentAlignment.MiddleLeft;
                CurrentBTN.TextImageRelation = TextImageRelation.ImageBeforeText;
                CurrentBTN.BackColor = Color.FromArgb(47, 49, 49);
                CurrentBTN.IconColor = Color.Gainsboro;
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void BTNTrangChu_Click(object sender, EventArgs e)
        {
            OpenFormChildren(new TrangChu());
            ShowCurrentBTN(sender,ClassColor.color1);
        }

        private void BTNThongKe_Click(object sender, EventArgs e)
        {
            OpenFormChildren(new ThongKe());
         

            ShowCurrentBTN(sender,ClassColor.color2);

        }

        private void BTNQuanLyNV_Click(object sender, EventArgs e)
        {
            OpenFormChildren(new QuanLyNhanVien());
         

            ShowCurrentBTN(sender,ClassColor.color3);

        }

        private void BTNHoSo_Click(object sender, EventArgs e)
        {
            OpenFormChildren(new HoSoCaNhan());
         
            ShowCurrentBTN(sender,ClassColor.color4);


        }
    }
}
