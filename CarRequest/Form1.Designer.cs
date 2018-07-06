namespace CarRequest
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddCar = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.kişileriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arabalarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.miTalep = new System.Windows.Forms.ToolStripMenuItem();
            this.kazaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerADMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miRecordIncoming = new System.Windows.Forms.ToolStripMenuItem();
            this.miTalepApprove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.işlemlerToolStripMenuItem1,
            this.işlemlerADMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1061, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddCar,
            this.miAddPerson,
            this.kişileriListeleToolStripMenuItem,
            this.arabalarıListeleToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.işlemlerToolStripMenuItem.Text = "Master";
            this.işlemlerToolStripMenuItem.Click += new System.EventHandler(this.işlemlerToolStripMenuItem_Click);
            // 
            // miAddCar
            // 
            this.miAddCar.Name = "miAddCar";
            this.miAddCar.Size = new System.Drawing.Size(180, 22);
            this.miAddCar.Text = "Araba Ekle";
            this.miAddCar.Click += new System.EventHandler(this.miAddCar_Click_1);
            // 
            // miAddPerson
            // 
            this.miAddPerson.Name = "miAddPerson";
            this.miAddPerson.Size = new System.Drawing.Size(180, 22);
            this.miAddPerson.Text = "Kişi Ekle";
            this.miAddPerson.Click += new System.EventHandler(this.miAddPerson_Click);
            // 
            // kişileriListeleToolStripMenuItem
            // 
            this.kişileriListeleToolStripMenuItem.Name = "kişileriListeleToolStripMenuItem";
            this.kişileriListeleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kişileriListeleToolStripMenuItem.Text = "Kişileri Listele";
            this.kişileriListeleToolStripMenuItem.Click += new System.EventHandler(this.kişileriListeleToolStripMenuItem_Click);
            // 
            // arabalarıListeleToolStripMenuItem
            // 
            this.arabalarıListeleToolStripMenuItem.Name = "arabalarıListeleToolStripMenuItem";
            this.arabalarıListeleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arabalarıListeleToolStripMenuItem.Text = "Arabaları Listele";
            this.arabalarıListeleToolStripMenuItem.Click += new System.EventHandler(this.arabalarıListeleToolStripMenuItem_Click);
            // 
            // işlemlerToolStripMenuItem1
            // 
            this.işlemlerToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTalep,
            this.kazaEkleToolStripMenuItem});
            this.işlemlerToolStripMenuItem1.Name = "işlemlerToolStripMenuItem1";
            this.işlemlerToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem1.Text = "İşlemler";
            this.işlemlerToolStripMenuItem1.Click += new System.EventHandler(this.işlemlerToolStripMenuItem1_Click);
            // 
            // miTalep
            // 
            this.miTalep.Name = "miTalep";
            this.miTalep.Size = new System.Drawing.Size(180, 22);
            this.miTalep.Text = "Talep Et";
            this.miTalep.Click += new System.EventHandler(this.miTalep_Click);
            // 
            // kazaEkleToolStripMenuItem
            // 
            this.kazaEkleToolStripMenuItem.Name = "kazaEkleToolStripMenuItem";
            this.kazaEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kazaEkleToolStripMenuItem.Text = "Kaza Ekle";
            this.kazaEkleToolStripMenuItem.Click += new System.EventHandler(this.kazaEkleToolStripMenuItem_Click);
            // 
            // işlemlerADMToolStripMenuItem
            // 
            this.işlemlerADMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRecordIncoming,
            this.miTalepApprove});
            this.işlemlerADMToolStripMenuItem.Name = "işlemlerADMToolStripMenuItem";
            this.işlemlerADMToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.işlemlerADMToolStripMenuItem.Text = "İşlemler-ADM";
            // 
            // miRecordIncoming
            // 
            this.miRecordIncoming.Name = "miRecordIncoming";
            this.miRecordIncoming.Size = new System.Drawing.Size(170, 22);
            this.miRecordIncoming.Text = "Gelen Araç Kaydet";
            this.miRecordIncoming.Click += new System.EventHandler(this.miRecordIncoming_Click);
            // 
            // miTalepApprove
            // 
            this.miTalepApprove.Name = "miTalepApprove";
            this.miTalepApprove.Size = new System.Drawing.Size(170, 22);
            this.miTalepApprove.Text = "Talep Onayla";
            this.miTalepApprove.Click += new System.EventHandler(this.miTalepApprove_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 641);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miAddCar;
        private System.Windows.Forms.ToolStripMenuItem miAddPerson;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miTalep;
        private System.Windows.Forms.ToolStripMenuItem işlemlerADMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miRecordIncoming;
        private System.Windows.Forms.ToolStripMenuItem miTalepApprove;
        private System.Windows.Forms.ToolStripMenuItem kazaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kişileriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arabalarıListeleToolStripMenuItem;
    }
}

