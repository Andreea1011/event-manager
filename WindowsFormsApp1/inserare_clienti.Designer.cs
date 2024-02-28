namespace WindowsFormsApp1
{
    partial class inserare_clienti
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
            this.txtID_client = new System.Windows.Forms.TextBox();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNume_client = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrenume_client = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNr_tel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID_client";
            // 
            // txtID_client
            // 
            this.txtID_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_client.Location = new System.Drawing.Point(378, 42);
            this.txtID_client.Name = "txtID_client";
            this.txtID_client.Size = new System.Drawing.Size(199, 31);
            this.txtID_client.TabIndex = 1;
            this.txtID_client.TextChanged += new System.EventHandler(this.txtID_client_TextChanged);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.Location = new System.Drawing.Point(336, 334);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(128, 51);
            this.btnAdaugare.TabIndex = 2;
            this.btnAdaugare.Text = "Adauga";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nume_client";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNume_client
            // 
            this.txtNume_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume_client.Location = new System.Drawing.Point(378, 104);
            this.txtNume_client.Name = "txtNume_client";
            this.txtNume_client.Size = new System.Drawing.Size(199, 31);
            this.txtNume_client.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prenume_client";
            // 
            // txtPrenume_client
            // 
            this.txtPrenume_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenume_client.Location = new System.Drawing.Point(378, 168);
            this.txtPrenume_client.Name = "txtPrenume_client";
            this.txtPrenume_client.Size = new System.Drawing.Size(199, 31);
            this.txtPrenume_client.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nr_tel";
            // 
            // txtNr_tel
            // 
            this.txtNr_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNr_tel.Location = new System.Drawing.Point(378, 232);
            this.txtNr_tel.Name = "txtNr_tel";
            this.txtNr_tel.Size = new System.Drawing.Size(199, 31);
            this.txtNr_tel.TabIndex = 1;
            // 
            // inserare_clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.txtNr_tel);
            this.Controls.Add(this.txtPrenume_client);
            this.Controls.Add(this.txtNume_client);
            this.Controls.Add(this.txtID_client);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "inserare_clienti";
            this.Text = "inserare_clienti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID_client;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNume_client;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrenume_client;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNr_tel;
    }
}