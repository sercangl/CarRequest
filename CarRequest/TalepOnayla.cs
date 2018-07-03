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
    public partial class TalepOnayla : Form
        
    {
        Dictionary<string, string> _item = new Dictionary<string, string>();
        Dictionary<string, string> _itemcar = new Dictionary<string, string>();
        Dictionary<string, string> _itemOther = new Dictionary<string, string>();

        public TalepOnayla()
        {
            InitializeComponent();
            personListeleme();
            arabalistele();
           
            
        }

        public void personListeleme()
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=EPDI-4W68LX1\\SQLEXPRESS;Initial Catalog=CarRequest;Integrated Security=SSPI;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT DISTINCT Y.Name,Y.ID,Y.LastName,K.StartDate,K.EndDate FROM tblRent K, tblPerson Y WHERE  K.fkPerson = Y.ID and K.KM IS NULL ";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;


            var sdf = new SqlParameter("@PersonID",txtBox1.Text.ToString());

            cmd.Parameters.Add(sdf);

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

                    cmd.CommandText = "SELECT ID,StartDate,EndDate FROM tblRent WHERE  ID = PersonID";
                    textBox5.Text = dr["ID"].ToString();
                    textBox3.Text = dr["StartDate"].ToString();
                    textBox4.Text = dr["EndDate"].ToString();
                }


                    //Seçilen kişinin StartDate ve EndDate ini çekmeye yarayan part...

                    

                
            }
           
            conn.Close();
        }


       


        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




            foreach (var it in _itemOther)
            {
              //  ((ComboBox)sender).SelectedValue = textBox1;


                if (it.Value.Equals(comboBox1.Text.Split(' ')[0]))
                {
                    txtBox1.Text = it.Key.ToString();
                }
            }


        }

        

        public void arabalistele()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=EPDI-4W68LX1\\SQLEXPRESS;Initial Catalog=CarRequest;Integrated Security=SSPI;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Marka,Model,ID,IsAvailable FROM tblCar WHERE  IsAvailable=1 ";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();



            while (dr.Read())
            {
                _itemcar.Add(dr["ID"].ToString(), dr["Marka"].ToString());
                //if (Convert.ToBoolean(_itemcar["IsAvailable"] == "0"))
                comboBox2.Items.Add(dr["Marka"].ToString() + " " + dr["Model"].ToString());
            }

            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var it in _itemcar)
            {

                if (it.Value.Equals(comboBox2.Text.Split(' ')[0]))
                {
                    textBox1.Text = it.Key.ToString();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TalepOnayla_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
