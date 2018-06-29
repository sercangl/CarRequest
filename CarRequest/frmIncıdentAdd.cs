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
    public partial class frmIncıdentAdd : Form
    {
        public frmIncıdentAdd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void accidentId_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void resetScreen()
        {
           
            frmdescription.Text = string.Empty;
            repairCheck.Checked = false;
            repairTime.Text = string.Empty;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DBActions.AddAccident(frmdescription.Text , repairCheck.Checked,Convert.ToDateTime(repairTime.Text));
                resetScreen();
                MessageBox.Show("GEÇMİŞ OLSUN");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
