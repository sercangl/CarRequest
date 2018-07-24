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

        // kolaylık olması bakımından tanımlanmış global değişkenler
        static string connectionString = "Server=EPDI-4W68LX1\\SQLEXPRESS;Initial Catalog=CarRequest;Integrated Security=SSPI;";
        Dictionary<string, string> _item = new Dictionary<string, string>();
        Dictionary<string, string> _itemcar = new Dictionary<string, string>();
        Dictionary<string, string> _itemOther = new Dictionary<string, string>();
        Dictionary<string, string> _itemcarr = new Dictionary<string, string>();
        SqlCommand cmd = new SqlCommand();

        // Formumuzun çalıştığı ana fonksiyonumuz
        public TalepOnayla()
        {
            InitializeComponent();
            personListeleme();
            arabalistele();



        }

        


        // talep etme formunda kullanılan arama yapan fonksiyon
        //public void talepEtArama()
        //{

        //    SqlConnection baglanti = new SqlConnection(connectionString);
        //    baglanti.Open();
        //    string arama = "SELECT  * FROM  tblRent WHERE fkPerson=@personID and KM IS NULL and fkCar IS NULL";
        //    SqlCommand komut = new SqlCommand(arama, baglanti);
        //    komut.Parameters.AddWithValue("@personID", textBox2.Text);
        //    komut.ExecuteNonQuery();

        //    SqlDataReader dr = komut.ExecuteReader();


        //    if (dr.Read())
        //    {

        //        dateTimePicker1.Text = dr["StartDate"].ToString();
        //        dateTimePicker2.Text = dr["EndDate"].ToString();
        //        textBox5.Text = dr["ID"].ToString();

        //        // Application.DoEvents();
        //        //  comboBox1.Items.Remove(comboBox1.SelectedItem);
        //    }
        //    else
        //        MessageBox.Show("Arama TAMAMLANAMADI...");


        //    baglanti.Close();

        //}
        
       
            
            
        // talep etme formunda kullanılan arama yapan fonksiyon
        public void talepEtArama()
        {
            DataTable dt = DBActions.talepEtArama(int.Parse(textBox2.Text));


            dateTimePicker1.Text = dt.Rows[0]["StartDate"].ToString();
            dateTimePicker2.Text = dt.Rows[0]["EndDate"].ToString();
            textBox5.Text = dt.Rows[0]["ID"].ToString();

        }

        // talep etme formunda kullanılan kaydetmeye yarayan fonksiyon
        public void  talepEtKaydet()
        {
           DBActions.talepEtKaydet(Convert.ToDateTime(dateTimePicker1.Text),Convert.ToDateTime(dateTimePicker2.Text),int.Parse(kiloMetre.Text),int.Parse(textBox1.Text),int.Parse(textBox5.Text));
            // DataTable dt = 

            //dateTimePicker1.Text = dt.Rows[0]["StartDate"].ToString();
            //dateTimePicker2.Text = dt.Rows[0]["EndDate"].ToString();
            //kiloMetre.Text = dt.Rows[0]["Km"].ToString();
            //textBox1.Text = dt.Rows[0]["fkCar"].ToString();
            //textBox5.Text = dt.Rows[0]["uniqueID"].ToString();


        }

        // talep etme kısmında araba vermeyi sağlayan fonksiyon

        public void talepEtAraba()
        {
            DBActions.talepEtAraba(int.Parse(textBox1.Text));

            // textBox1.Text = dt.Rows[0]["carID"].ToString();
            

        }




        //  Arama butonunun çalıştığı fonksiyon
        private void button1_Click_1(object sender, EventArgs e)
        {
            talepEtArama();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        // Person isimlerinin gözüktüğü ve seçilmenin yapıldığı ComboBox
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



        public void talepEtArabaListele()
        {

        }



        // Combobox ın gözüken arabaların veritabanından çekilmesini sağlayan fonksiyon
        public void arabalistele()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=EPDI-4W68LX1\\SQLEXPRESS;Initial Catalog=CarRequest;Integrated Security=SSPI;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Marka,Model,ID,IsAvailable,Plaka FROM tblCar WHERE  IsAvailable=1 ";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();

            //   cmd.Parameters.AddWithValue("@CarID", textBox1.Text);


            while (dr.Read())
            {
                _itemcar.Add(dr["ID"].ToString(), dr["Model"].ToString());
                //              _itemcarr.Add(dr["ID"].ToString(), dr["Model"].ToString());
                //if (Convert.ToBoolean(_itemcar["IsAvailable"] == "0"))
                comboBox2.Items.Add(dr["Model"].ToString() + " - (" + dr["Marka"].ToString() + ") ---------" + dr["Plaka"].ToString());
            }

            conn.Close();

        }
       
        
        
        // Formlarda girilen bilgileri veritabanında güncelliyor.
        private void button1_Click(object sender, EventArgs e)
        {

            talepEtAraba();
            talepEtKaydet();
                
                ResetScreen();
                MessageBox.Show("TALEBİ ONAYLADINIZ ..!");
                this.Refresh();
            
          
        }
       
        
        
        
        
        
        // Form kaydedildikten sonra formların içinin boşaltılmasını sağlıyor
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
        // arabaların içinde gözüktüğü combobox  arabalisteleme fonksiyonunu kullanıyor
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

        private void comboBox1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.Refresh();
            foreach (var it in _itemOther)
            {

                if (it.Value.Equals(comboBox1.Text.Split(' ')[0]))
                {
                    this.Refresh();
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
        // Combo box üzerindeki isimleri getiren textbox'a atan fonksiyon

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


                }


            }

            conn.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



