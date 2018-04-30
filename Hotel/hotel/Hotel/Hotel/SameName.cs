using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel
{
    public  partial class SameName : Form
    {
        public AddHouse ah;   //添加房间类型,
        public GroupAddHouseForm gh;
        int type;

        public  SameName(int type)
        {
            this.type = type;
            InitializeComponent();
        }
        
        private void lvSameName_DoubleClick(object sender, EventArgs e)
        {
            if (type == 0)
            {
                ah.txtCust.Text = lvSameName.SelectedItems[0].SubItems[0].Text;
                ah.txtName.Text = lvSameName.SelectedItems[0].SubItems[1].Text;
                if (lvSameName.SelectedItems[0].SubItems[2].Text == "男")
                {
                    ah.rdoMan.Checked = true;
                }
                else
                {
                    ah.rdoWaman.Checked = true;
                }
                ah.cboCertificate.Text = lvSameName.SelectedItems[0].SubItems[3].Text;
                ah.txtCertificateId.Text = lvSameName.SelectedItems[0].SubItems[4].Text;
                ah.txtAddress.Text = lvSameName.SelectedItems[0].SubItems[5].Text;
                ah.txtContactTel.Text = lvSameName.SelectedItems[0].SubItems[6].Text;

                this.Close();
                if(ah.txtCust.Text!="")
                {
                    ValidatePass vp = new ValidatePass(ah.txtCust.Text,0);
                    vp.ah = ah;
                    vp.Show();
                }
            }
            else
            {
                gh.txtCust.Text = lvSameName.SelectedItems[0].SubItems[0].Text;
                gh.txtName.Text = lvSameName.SelectedItems[0].SubItems[1].Text;
                if (lvSameName.SelectedItems[0].SubItems[2].Text == "男")
                {
                    gh.rdoMan.Checked = true;
                }
                else
                {
                    gh.rdoWaman.Checked = true;
                }
                gh.cboCertificate.Text = lvSameName.SelectedItems[0].SubItems[3].Text;
                gh.txtCertificateId.Text = lvSameName.SelectedItems[0].SubItems[4].Text;
                gh.txtAddress.Text = lvSameName.SelectedItems[0].SubItems[5].Text;
                gh.txtContactTel.Text = lvSameName.SelectedItems[0].SubItems[6].Text;

                if (gh.txtCust.Text != "")
                {
                    ValidatePass vp = new ValidatePass(gh.txtCust.Text,1);
                    vp.ga = gh;
                    vp.Show();
                }

                this.Close();

            }
                    
           
        }

        private void SameForm_Load(object sender, EventArgs e)
        {

        }
    }
}