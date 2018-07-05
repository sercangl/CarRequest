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
    public partial class GelenAraçKaydet : Form
    {


        static string connectionString = "Server=EPDI-4W68LX1\\SQLEXPRESS;Initial Catalog=CarRequest;Integrated Security=SSPI;";
        Dictionary<string, string> _item = new Dictionary<string, string>();
        Dictionary<string, string> _itemcar = new Dictionary<string, string>();
        Dictionary<string, string> _itemOther = new Dictionary<string, string>();
        Dictionary<string, string> _itemcarr = new Dictionary<string, string>();
        SqlCommand cmd = new SqlCommand();


        public GelenAraçKaydet()
        {
            InitializeComponent();
            personListeleme();
        }


        public void personListeleme()
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=EPDI-4W68LX1\\SQLEXPRESS;Initial Catalog=CarRequest;Integrated Security=SSPI;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT DISTINCT Y.Name,Y.ID,Y.LastName,K.StartDate,K.EndDate,K.ID FROM tblRent K, tblPerson Y WHERE  K.fkPerson = Y.ID and K.fkIncidents IS NULL ";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@PersonID", textBox1.Text.ToString());

            

            SqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                // _itemOther.Add(dr["ID"].ToString(), dr["Name"].ToString());

                if (!_itemOther.ContainsKey(dr["ID"].ToString()))
                {
                    _itemOther.Add(dr["ID"].ToString(), dr["Name"].ToString());
                    comboBox1.Items.Add(dr["Name"].ToString() + " " + dr["LastName"].ToString());


                }


            }

            conn.Close();
        }



        private void frmdescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void repairTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void repairCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var it in _itemOther)
            {

                if (it.Value.Equals(comboBox1.Text.Split(' ')[0]))
                {
                    this.Refresh();
                    textBox1.Text = it.Key.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) { 


            SqlConnection baglanti = new SqlConnection(connectionString);
        baglanti.Open();
            string arama = "SELECT  * FROM  tblRent WHERE fkPerson=@personID and fkIncidents IS NULL";
        SqlCommand komut = new SqlCommand(arama, baglanti);
        komut.Parameters.AddWithValue("@personID", textBox1.Text);
            komut.ExecuteNonQuery();

            SqlDataReader dr = komut.ExecuteReader();
            

            if (dr.Read())
            {
                textBox2.Text = dr["ID"].ToString();

            }
            else
                MessageBox.Show("Arama TAMAMLANAMADI...");

            
            baglanti.Close();
        


        }

        private void ResetScreen()
        {
            comboBox1.Text = string.Empty;
            
            textBox2.Text = string.Empty;
            textBox1.Text = string.Empty;
            frmdescription.Text = string.Empty;
            repairTime.Text = string.Empty;
            repairCheck.Text = string.Empty;
        }




        private void GelenAraçKaydet_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            }

          
        
    }
}
