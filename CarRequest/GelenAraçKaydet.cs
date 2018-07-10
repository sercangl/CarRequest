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



         //   SqlCommand komut = "UPDATE tblRent SET EndDate=@now Where @PersonID=ID"
            

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
            
            SqlConnection baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            string güncelleme = "UPDATE tblRent    SET  fkIncidents=@fkIncident  WHERE ID=@rentID";

            SqlCommand komut = new SqlCommand(güncelleme, baglanti);

            komut.Parameters.AddWithValue("@fkIncident", textBox3.Text);

            komut.Parameters.AddWithValue("@rentID", textBox2.Text);
            komut.ExecuteNonQuery();
            ResetScreen();

            // komut.ExecuteNonQuery();

                MessageBox.Show("BAŞARIYLA KAYDEDİLDİ....");

            // ResetScreen();
            baglanti.Close();








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
            textBox3.Text = string.Empty;

        }




        private void GelenAraçKaydet_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {



            ResetScreen();
            }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DBActions.AddAccident(frmdescription.Text, repairCheck.Checked, Convert.ToDateTime(repairTime.Text));

           
            SqlConnection baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            string arama = "SELECT  ID FROM  tblIncident WHERE  Description = @description";

            SqlCommand komut = new SqlCommand(arama, baglanti);
            
            komut.Parameters.AddWithValue("@description", frmdescription.Text);
            // komut.ExecuteNonQuery();

            SqlDataReader dr = komut.ExecuteReader();


            if (dr.Read())
            {
                textBox3.Text = dr["ID"].ToString();

            }
            else
                MessageBox.Show("Arama TAMAMLANAMADI...");

           // ResetScreen();
            baglanti.Close();


            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
