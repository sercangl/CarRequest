namespace CarRequest
{
    partial class frmRentAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.frm_fkPerson = new System.Windows.Forms.TextBox();
            this.frm_KM = new System.Windows.Forms.TextBox();
            this.frm_fkCar = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.frmStart_time = new System.Windows.Forms.DateTimePicker();
            this.frmEnd_Time = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.frm_fkIncident = new System.Windows.Forms.TextBox();
            this.fkIncıdent = new System.Windows.Forms.Label();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Person Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "KM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "fk_Car";
            // 
            // frm_fkPerson
            // 
            this.frm_fkPerson.Enabled = false;
            this.frm_fkPerson.Location = new System.Drawing.Point(142, 70);
            this.frm_fkPerson.Name = "frm_fkPerson";
            this.frm_fkPerson.Size = new System.Drawing.Size(170, 20);
            this.frm_fkPerson.TabIndex = 6;
            this.frm_fkPerson.TextChanged += new System.EventHandler(this.frm_fkPerson_TextChanged);
            // 
            // frm_KM
            // 
            this.frm_KM.Location = new System.Drawing.Point(142, 187);
            this.frm_KM.Name = "frm_KM";
            this.frm_KM.Size = new System.Drawing.Size(170, 20);
            this.frm_KM.TabIndex = 9;
            // 
            // frm_fkCar
            // 
            this.frm_fkCar.Enabled = false;
            this.frm_fkCar.Location = new System.Drawing.Point(142, 151);
            this.frm_fkCar.Name = "frm_fkCar";
            this.frm_fkCar.Size = new System.Drawing.Size(170, 20);
            this.frm_fkCar.TabIndex = 11;
            this.frm_fkCar.TextChanged += new System.EventHandler(this.frm_fkCar_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(142, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(239, 53);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmStart_time
            // 
            this.frmStart_time.Location = new System.Drawing.Point(142, 297);
            this.frmStart_time.Name = "frmStart_time";
            this.frmStart_time.Size = new System.Drawing.Size(200, 20);
            this.frmStart_time.TabIndex = 19;
            // 
            // frmEnd_Time
            // 
            this.frmEnd_Time.Location = new System.Drawing.Point(142, 346);
            this.frmEnd_Time.Name = "frmEnd_Time";
            this.frmEnd_Time.Size = new System.Drawing.Size(200, 20);
            this.frmEnd_Time.TabIndex = 20;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(141, 30);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // frm_fkIncident
            // 
            this.frm_fkIncident.Enabled = false;
            this.frm_fkIncident.Location = new System.Drawing.Point(142, 237);
            this.frm_fkIncident.Name = "frm_fkIncident";
            this.frm_fkIncident.Size = new System.Drawing.Size(170, 20);
            this.frm_fkIncident.TabIndex = 22;
            this.frm_fkIncident.TextChanged += new System.EventHandler(this.frm_fkIncident_TextChanged_1);
            // 
            // fkIncıdent
            // 
            this.fkIncıdent.AutoSize = true;
            this.fkIncıdent.Location = new System.Drawing.Point(12, 244);
            this.fkIncıdent.Name = "fkIncıdent";
            this.fkIncıdent.Size = new System.Drawing.Size(64, 13);
            this.fkIncıdent.TabIndex = 23;
            this.fkIncıdent.Text = "FK_Incıdent";
            // 
            // comboBox14
            // 
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Location = new System.Drawing.Point(142, 113);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(166, 21);
            this.comboBox14.TabIndex = 24;
            this.comboBox14.SelectedIndexChanged += new System.EventHandler(this.comboBox14_SelectedIndexChanged);
            // 
            // frmRentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(389, 480);
            this.Controls.Add(this.comboBox14);
            this.Controls.Add(this.fkIncıdent);
            this.Controls.Add(this.frm_fkIncident);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.frmEnd_Time);
            this.Controls.Add(this.frmStart_time);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.frm_fkCar);
            this.Controls.Add(this.frm_KM);
            this.Controls.Add(this.frm_fkPerson);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRentAdd";
            this.Text = "frmRentAdd";
            this.Load += new System.EventHandler(this.frmRentAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox frm_fkPerson;
        private System.Windows.Forms.TextBox frm_KM;
        private System.Windows.Forms.TextBox frm_fkCar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker frmStart_time;
        private System.Windows.Forms.DateTimePicker frmEnd_Time;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox frm_fkIncident;
        private System.Windows.Forms.Label fkIncıdent;
        private System.Windows.Forms.ComboBox comboBox14;
    }
}