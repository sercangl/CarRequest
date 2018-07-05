using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRequest
{
    public partial class frmIncıdentAdd : Form
    {

    //    static string connectionString = "Server=EPDI-4W68LX1\\SQLEXPRESS;Initial Catalog=CarRequest;Integrated Security=SSPI;";
        Dictionary<string, string> _itemOther = new Dictionary<string, string>();


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

        private void frmIncıdentAdd_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }





    }

}
