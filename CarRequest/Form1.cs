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
    public partial class mainForm : Form
    {


        frmPersonAdd frmP;
        FrmCarAdd frmC;
        frmIncıdentAdd frmA;
        frmRentAdd frmR;
        ListCar lstC;
        ListPerson lstP;



        public mainForm()
        {
            InitializeComponent();
        }



        private void miAddPerson_Click(object sender, EventArgs e)
        {
            if (frmP == null)
            {
                frmP = new frmPersonAdd();
                frmP.MdiParent = this;
                frmP.Show();
                frmP.FormClosed += FrmP_FormClosed;
            }
            else
            {
                return;
            }


        }





        private void miAddCar_Click(object sender, EventArgs e)
        {
           

        }

        private void frmC_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmC.Dispose();
            frmC = null;
        }

        private void frmA_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmA.Dispose();
            frmA = null;
        }
        public void FrmP_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmP.Dispose();
            frmP = null;
        }

        public void FrmR_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmR.Dispose();
            frmR = null;
        }


        private void miAddCar_Click_1(object sender, EventArgs e)
        {
            if (frmC == null)
            {
                frmC = new FrmCarAdd();
                frmC.MdiParent = this;
                frmC.Show();
                frmC.FormClosed += frmC_FormClosed;
            }
            else
            {
                return;
            }
        }

        private void kazaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmA == null)
            {
                frmA = new frmIncıdentAdd();
                    
                frmA.MdiParent = this;
                frmA.Show();
                frmA.FormClosed += frmA_FormClosed;
            }
            else
            {
                return;
            }

        }

        
        private void işlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void miTalep_Click(object sender, EventArgs e)
        {
            if (frmR    == null)
            {
                frmR = new frmRentAdd();
                frmR.MdiParent = this;
                frmR.Show();
                frmR.FormClosed += FrmR_FormClosed;
            }
            else
            {
                return;
            }
        }

        private void işlemlerToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void kişileriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstP == null)
            {
                lstP = new ListPerson();

                lstP.MdiParent = this;
                lstP.Show();
                lstP.ListePerson();
                lstP.FormClosed += lstP_FormClosed;
            }
            else
            {
                return;
            }

        }

        private void lstP_FormClosed(object sender, FormClosedEventArgs e)
        {
            lstP.Dispose();
         
        }

        private void lstC_FormClosed(object sender, FormClosedEventArgs e)
        {
            lstC.Dispose();
            
        }

        private void arabalarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (lstC == null)
            {
                lstC = new ListCar();

                lstC.MdiParent = this;
                lstC.Show();
                lstC.FormClosed += lstC_FormClosed;
            }
            else
            {
                return;
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
