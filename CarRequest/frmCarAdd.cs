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
    public partial class FrmCarAdd : Form
    {
        Dictionary<string, string> _item = new Dictionary<string, string>();

        public FrmCarAdd()
        {
            InitializeComponent();
            personelListele();
           

        }

        // veri tabanındaki insanların isimlerini listeleyen fonksiyon
        public void personelListele()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=EPDI-4W68LX1\\SQLEXPRESS;Initial Catalog=CarRequest;Integrated Security=SSPI;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Name,ID,Lastname FROM tblPerson";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                
                _item.Add(dr["ID"].ToString(), dr["Name"].ToString());
                comboBox3.Items.Add(dr["Name"].ToString() + " " + dr["LastName"].ToString());
            
            }
            conn.Close();
        }




    
        private void label2_Click(object sender, EventArgs e)
        {


        }
        
        // Form kayıt edildikten sonra textboxların içinin boşaltılmasını sağlayan fonksiyon
        private void ResetScreen()
        {
            comboBox3.Text = string.Empty;
            fkPerson.Text = string.Empty;
            marka.Text = string.Empty;
            model.Text = string.Empty;
            rentStart.Text = string.Empty;
            rentEnd.Text = string.Empty;
            Plaka.Text = string.Empty;
            lastKM.Text = string.Empty;
            chckavailable.Checked = false;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rentStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LastKM_TextChanged(object sender, EventArgs e)
        {

        }

        private void Plaka_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCarAdd_Load(object sender, EventArgs e)
        {

        }
        // Kayıt butonunun tıklandığında içinde yapılacakların belirlendiği fonksiyon
        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {

                DBActions.AddCar(int.Parse(fkPerson.Text), marka.Text, model.Text, Convert.ToDateTime(rentStart.Text), Convert.ToDateTime(rentEnd.Text), Plaka.Text, int.Parse(lastKM.Text), chckavailable.Checked);
                ResetScreen();
                MessageBox.Show("ARAÇ BAŞARIYLA SİSTEME EKLENDİ...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void fkPerson_TextChanged(object sender, EventArgs e)
        {

        }

        private void fkPerson_TextChanged_1(object sender, EventArgs e)
        {

        }


        // kişi listeleyen combobox

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (var it in _item)
            {
               
                if (it.Value.Equals(comboBox3.Text.Split(' ')[0]))
                {
                    fkPerson.Text = it.Key.ToString();
                                    }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
