using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarRequest
{
    public partial class frmRentAdd : Form
    {


        Dictionary<string, string> _item = new Dictionary<string, string>();
        Dictionary<string, string> _itemcar = new Dictionary<string, string>();



        public void arabalistele()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=EPDI-4W68LX1\\SQLEXPRESS;Initial Catalog=CarRequest;Integrated Security=SSPI;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Marka,Model,ID,IsAvailable FROM tblCar";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            

           // if (IsAvailable=0)
          //  {
                while (dr.Read())
                {
                    _itemcar.Add(dr["ID"].ToString(), dr["Marka"].ToString());
                    comboBox14.Items.Add(dr["Marka"].ToString() + " " + dr["Model"].ToString());

                }
                conn.Close();
          //  }
         //   else (){
         //       return 0;
         //   }
        }

        


        public void personListele()
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=EPDI-4W68LX1\\SQLEXPRESS;Initial Catalog=CarRequest;Integrated Security=SSPI;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Name,ID,LastName FROM tblPerson";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
        
         
            while (dr.Read())
            {
                _item.Add(dr["ID"].ToString(), dr["Name"].ToString());
                comboBox2.Items.Add(dr["Name"].ToString() + " " + dr["LastName"].ToString());
                  // " " +dr["LastName"].ToString());

            }
            conn.Close();
        }

        public frmRentAdd()
        {
            InitializeComponent();
            personListele();
            arabalistele();
        }

        private void frm_fkPerson_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetScreen()
        {
            comboBox14.Text = string.Empty;
            comboBox2.Text = string.Empty;
            frm_fkCar.Text = string.Empty;
            frm_fkPerson.Text = string.Empty;
            frm_fkIncident.Text = string.Empty;
            frm_KM.Text = string.Empty;
            frmStart_time.Text = string.Empty;
            frmEnd_Time.Text = string.Empty;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DBActions.AddRent(int.Parse(frm_fkPerson.Text), Convert.ToDateTime(frmStart_time.Text), Convert.ToDateTime(frmEnd_Time.Text), int.Parse(frm_KM.Text), int.Parse(frm_fkCar.Text));
          
                ResetScreen();
                MessageBox.Show("TALEBİNİZ İLETİLMİŞTİR...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_fkIncident_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }


        

        private void frmCombobox(object sender, EventArgs e)
        {
           
        }


        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            foreach (var it in _item)
            {
                if (it.Value.Equals(comboBox2.Text.Split(' ')[0]));
                {
                    frm_fkPerson.Text = it.Key.ToString();
                }
            }

        }

        private void frmRentAdd_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
         private void frm_fkCar_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {



            foreach (var it in _itemcar)
            {



                if (it.Value.Equals(comboBox14.Text.Split(' ')[0]))
                {
                    frm_fkCar.Text = it.Key.ToString();
                }
            }
        }

        private void frm_fkIncident_TextChanged_1(object sender, EventArgs e)
        {
           
        }
    }

    


}
