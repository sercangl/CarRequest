namespace CarRequest
{
    partial class FrmCarAdd
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
            this.marka = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Plaka = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lastKM = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chckavailable = new System.Windows.Forms.CheckBox();
            this.rentStart = new System.Windows.Forms.DateTimePicker();
            this.rentEnd = new System.Windows.Forms.DateTimePicker();
            this.fkPerson = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // marka
            // 
            this.marka.Location = new System.Drawing.Point(201, 87);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(172, 20);
            this.marka.TabIndex = 3;
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(199, 127);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(174, 20);
            this.model.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Marka";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rent Start Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rent End Time";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Plaka";
            // 
            // Plaka
            // 
            this.Plaka.Location = new System.Drawing.Point(199, 251);
            this.Plaka.Name = "Plaka";
            this.Plaka.Size = new System.Drawing.Size(174, 20);
            this.Plaka.TabIndex = 12;
            this.Plaka.TextChanged += new System.EventHandler(this.Plaka_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Last KM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Is Available ?";
            // 
            // lastKM
            // 
            this.lastKM.Location = new System.Drawing.Point(199, 287);
            this.lastKM.Name = "lastKM";
            this.lastKM.Size = new System.Drawing.Size(174, 20);
            this.lastKM.TabIndex = 15;
            this.lastKM.TextChanged += new System.EventHandler(this.LastKM_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(200, 348);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(239, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chckavailable
            // 
            this.chckavailable.AutoSize = true;
            this.chckavailable.Location = new System.Drawing.Point(201, 313);
            this.chckavailable.Name = "chckavailable";
            this.chckavailable.Size = new System.Drawing.Size(15, 14);
            this.chckavailable.TabIndex = 18;
            this.chckavailable.UseVisualStyleBackColor = true;
            // 
            // rentStart
            // 
            this.rentStart.Location = new System.Drawing.Point(199, 172);
            this.rentStart.Name = "rentStart";
            this.rentStart.Size = new System.Drawing.Size(174, 20);
            this.rentStart.TabIndex = 19;
            this.rentStart.ValueChanged += new System.EventHandler(this.rentStart_ValueChanged);
            // 
            // rentEnd
            // 
            this.rentEnd.Location = new System.Drawing.Point(199, 215);
            this.rentEnd.Name = "rentEnd";
            this.rentEnd.Size = new System.Drawing.Size(174, 20);
            this.rentEnd.TabIndex = 20;
            // 
            // fkPerson
            // 
            this.fkPerson.Enabled = false;
            this.fkPerson.Location = new System.Drawing.Point(201, 43);
            this.fkPerson.Name = "fkPerson";
            this.fkPerson.Size = new System.Drawing.Size(172, 20);
            this.fkPerson.TabIndex = 21;
            this.fkPerson.TextChanged += new System.EventHandler(this.fkPerson_TextChanged_1);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(201, 16);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(172, 21);
            this.comboBox3.TabIndex = 22;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // FrmCarAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 402);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.fkPerson);
            this.Controls.Add(this.rentEnd);
            this.Controls.Add(this.rentStart);
            this.Controls.Add(this.chckavailable);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lastKM);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Plaka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.model);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.label1);
            this.Name = "FrmCarAdd";
            this.Text = "frmCarAdd";
            this.Load += new System.EventHandler(this.FrmCarAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox marka;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Plaka;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lastKM;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chckavailable;
        private System.Windows.Forms.DateTimePicker rentStart;
        private System.Windows.Forms.DateTimePicker rentEnd;
        private System.Windows.Forms.TextBox fkPerson;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}