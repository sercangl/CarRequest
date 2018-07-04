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
    public partial class ListPerson : Form
    {
        public ListPerson()
        {
            InitializeComponent();
        }

        static string connectionString = "Server=EPDI-4W68LX1\\SQLEXPRESS;Initial Catalog=CarRequest;Integrated Security=SSPI;";

        public void ListePerson()
        {
            SqlConnection con = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblPerson", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
