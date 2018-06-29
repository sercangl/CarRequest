using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRequest
{
    public partial class frmPersonAdd : Form
    {
        public frmPersonAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DBActions.AddPerson(txtName.Text, txtLastname.Text, int.Parse(txtPersID.Text), chkIsadmin.Checked);
                ResetScreen();
                MessageBox.Show("KİŞİ SİSTEME BAŞARIYLA EKLENMİŞİR...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ResetScreen()
        {
            txtName.Text = string.Empty;
            txtLastname.Text = string.Empty;
            txtPersID.Text = string.Empty;
            chkIsadmin.Checked = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
