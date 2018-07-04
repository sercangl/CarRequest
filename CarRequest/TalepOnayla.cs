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


        static string connectionString = "Server=EPDI-4W68LX1\\SQLEXPRESS;Initial Catalog=CarRequest;Integrated Security=SSPI;";


        Dictionary<string, string> _item = new Dictionary<string, string>();
        Dictionary<string, string> _itemcar = new Dictionary<string, string>();
        Dictionary<string, string> _itemOther = new Dictionary<string, string>();
        SqlCommand cmd = new SqlCommand();
        public TalepOnayla()
        {
            InitializeComponent();
            personListeleme();
            arabalistele();
            


        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            string arama = "SELECT DISTINCT * FROM  tblrent WHERE fkPerson=@personID and KM IS NULL or fkCar IS NULL";
            SqlCommand komut = new SqlCommand(arama, baglanti);
            komut.Parameters.AddWithValue("@personID", textBox2.Text);
            
         
            SqlDataReader dr = komut.ExecuteReader();
            

            if (dr.Read())
            {
                dateTimePicker1.Text = dr["StartDate"].ToString();
                dateTimePicker2.Text = dr["EndDate"].ToString();
                textBox5.Text = dr["ID"].ToString();

                
            }
            else
                MessageBox.Show("Arama TAMAMLANAMADI...");
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (var it in _itemOther)
            {
                if (it.Value.Equals(comboBox1.Text.Split(' ')[0]))
                {
                    textBox2.Text = it.Key.ToString();
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
            
            cmd.Parameters.AddWithValue("@CarID", textBox1.Text);


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
            try
            {

                SqlConnection baglanti = new SqlConnection(connectionString);
                baglanti.Open();
                string talepGüncelle = "UPDATE tblRent SET KM=@Km,fkCar=@fkCar,StartDate=@StartDate,EndDate=@EndDate WHERE  ID=@uniqueID";
                SqlCommand komut = new SqlCommand(talepGüncelle, baglanti);
               // SqlDataReader dr = komut.ExecuteReader();

          
                // if (dr.Read())
                //   {
               
                string Kmm = kiloMetre.Text;
                string fkkCar = textBox1.Text;
                string uniqueeID = textBox5.Text;


                komut.Parameters.AddWithValue("@StartDate", Convert.ToDateTime(dateTimePicker1.Text));
                    komut.Parameters.AddWithValue("@EndDate", Convert.ToDateTime(dateTimePicker2.Text));
                    komut.Parameters.AddWithValue("@Km", Kmm);
                    komut.Parameters.AddWithValue("@fkCar", fkkCar);
                    komut.Parameters.AddWithValue("@uniqueID", uniqueeID);
                    komut.ExecuteNonQuery();


                    // cmd = new SqlCommand("INSERT INTO tblPerson (Name,Lastname,PersID,IsAdmin) VALUES (@name,@lastname,@persid,@isadmin)", con);

                    ResetScreen();
                    MessageBox.Show("TALEBİ ONAYLADINIZ ..!");
                    baglanti.Close();
            //    }
            //    else
                //    MessageBox.Show("Talep ONAYLANMADI");
               baglanti.Close();


                //int.Parse(frm_KM.Text), int.Parse(frm_fkCar.Text)
               










            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetScreen()
        {
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox1.Text = string.Empty;
            kiloMetre.Text = string.Empty;

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
            // var sdk = new SqlParameter("@KM", kiloMetre.Text.ToString());
            //  cmd.Parameters.Add(sdk);
            cmd.Parameters.AddWithValue("@KM", kiloMetre.Text);
        }

        private void comboBox1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            foreach (var it in _itemOther)
            {

                if (it.Value.Equals(comboBox1.Text.Split(' ')[0]))
                {
                    textBox2.Text = it.Key.ToString();
                }
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public static void AddRentt(int fkPerson, DateTime StartDate, DateTime EndDate)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;


            try
            {
                //,KM,fkCar    ,@KM,@fkCar
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("INSERT INTO tblRent (fkPerson,StartDate,EndDate) VALUES (@fkPerson,@StartDate,@EndDate)", con);
                cmd.Parameters.AddWithValue("@fkPerson", fkPerson);
                cmd.Parameters.AddWithValue("@StartDate", StartDate);
                cmd.Parameters.AddWithValue("@EndDate", EndDate);
                //  cmd.Parameters.AddWithValue("@KM", KM);
                //  cmd.Parameters.AddWithValue("@fkCar", fkCar);

                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();

                cmd.ExecuteNonQuery();

            }

            catch (Exception)
            {
                throw;
            }
            finally
            {
                try
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        con.Dispose();
                    }
                }
                catch (Exception)
                {


                }

            }


        }


        public void personListeleme()
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=EPDI-4W68LX1\\SQLEXPRESS;Initial Catalog=CarRequest;Integrated Security=SSPI;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT DISTINCT Y.Name,Y.ID,Y.LastName,K.StartDate,K.EndDate,K.ID FROM tblRent K, tblPerson Y WHERE  K.fkPerson = Y.ID and K.KM IS NULL ";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;


            var sdf = new SqlParameter("@PersonID", textBox2.Text.ToString());

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

                   // cmd.CommandText = "SELECT ID,StartDate,EndDate FROM tblRent WHERE  ID = PersonID";
                    

                    
                    //textBox5.Text = dr["ID"].ToString();
                    //textBox3.Text = dr["StartDate"].ToString();
                    //textBox4.Text = dr["EndDate"].ToString();
                }


                //Seçilen kişinin StartDate ve EndDate ini çekmeye yarayan part...




            }

            conn.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

      
    }
}



//public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
//{




//    foreach (var it in _itemOther)
//    {
//      //  ((ComboBox)sender).SelectedValue = textBox1;


//        if (it.Value.Equals(comboBox1.Text.Split(' ')[0]))
//        {
//            txtBox1.Text = it.Key.ToString();
//        }
//    }


//}




//public void personListeleme()
//{

//    SqlConnection conn = new SqlConnection();
//    conn.ConnectionString = "Server=EPDI-4W68LX1\\SQLEXPRESS;Initial Catalog=CarRequest;Integrated Security=SSPI;";
//    SqlCommand cmd = new SqlCommand();
//    cmd.CommandText = "SELECT DISTINCT * FROM tblRent K, tblPerson Y WHERE  K.fkPerson = Y.ID and K.KM IS NULL  ";
//    cmd.Connection = conn;
//    cmd.CommandType = CommandType.Text;
//    SqlDataReader dr;
//    dr = cmd.ExecuteReader();

//    // PersonID parametresi için
//    // var sdf = new SqlParameter("@PersonID", textBox2.Text.ToString());
//    // cmd.Parameters.Add(sdf);

//    //cmd.Parameters.AddWithValue("@PersonID", textBox2.Text);


//    conn.Open();

//    cmd.Parameters.AddWithValue("@PersonID", textBox2.Text);
//    cmd.CommandText = "Select From Where ";
//    while (dr.Read())
//    {

//        if (!_itemOther.ContainsKey(dr["ID"].ToString()))
//        {
//            _itemOther.Add(dr["ID"].ToString(), dr["Name"].ToString());
//            comboBox1.Items.Add(dr["Name"].ToString() + " " + dr["LastName"].ToString());


//        }

//    }
//    conn.Close();
//}