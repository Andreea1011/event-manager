namespace WindowsFormsApp1
{
    partial class update_eveniment
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtNume_eveniment = new System.Windows.Forms.TextBox();
            this.txtID_client = new System.Windows.Forms.TextBox();
            this.txtID_locatie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID_eveniment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtData_eveniment = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumar_invitati = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(339, 382);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 51);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Modifica";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtNume_eveniment
            // 
            this.txtNume_eveniment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume_eveniment.Location = new System.Drawing.Point(368, 243);
            this.txtNume_eveniment.Name = "txtNume_eveniment";
            this.txtNume_eveniment.Size = new System.Drawing.Size(199, 31);
            this.txtNume_eveniment.TabIndex = 33;
            // 
            // txtID_client
            // 
            this.txtID_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_client.Location = new System.Drawing.Point(368, 194);
            this.txtID_client.Name = "txtID_client";
            this.txtID_client.Size = new System.Drawing.Size(199, 31);
            this.txtID_client.TabIndex = 34;
            // 
            // txtID_locatie
            // 
            this.txtID_locatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_locatie.Location = new System.Drawing.Point(368, 148);
            this.txtID_locatie.Name = "txtID_locatie";
            this.txtID_locatie.Size = new System.Drawing.Size(199, 31);
            this.txtID_locatie.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nume_eveniment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "ID_client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(204, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "ID_locatie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(182, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Introdu datele care trebuie modificate";
            // 
            // txtID_eveniment
            // 
            this.txtID_eveniment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_eveniment.Location = new System.Drawing.Point(368, 62);
            this.txtID_eveniment.Name = "txtID_eveniment";
            this.txtID_eveniment.Size = new System.Drawing.Size(199, 31);
            this.txtID_eveniment.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID_eveniment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(105, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(632, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Introdu ID-ul evenimentului al carui date trebuie modificate";
            // 
            // txtData_eveniment
            // 
            this.txtData_eveniment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData_eveniment.Location = new System.Drawing.Point(368, 289);
            this.txtData_eveniment.Name = "txtData_eveniment";
            this.txtData_eveniment.Size = new System.Drawing.Size(199, 31);
            this.txtData_eveniment.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(161, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "Data_eveniment";
            // 
            // txtNumar_invitati
            // 
            this.txtNumar_invitati.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumar_invitati.Location = new System.Drawing.Point(368, 336);
            this.txtNumar_invitati.Name = "txtNumar_invitati";
            this.txtNumar_invitati.Size = new System.Drawing.Size(199, 31);
            this.txtNumar_invitati.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(161, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 25);
            this.label8.TabIndex = 39;
            this.label8.Text = "Numar_invitati";
            // 
            // update_eveniment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumar_invitati);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtData_eveniment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNume_eveniment);
            this.Controls.Add(this.txtID_client);
            this.Controls.Add(this.txtID_locatie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID_eveniment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "update_eveniment";
            this.Text = "update_eveniment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtNume_eveniment;
        private System.Windows.Forms.TextBox txtID_client;
        private System.Windows.Forms.TextBox txtID_locatie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID_eveniment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtData_eveniment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumar_invitati;
        private System.Windows.Forms.Label label8;
    }
}