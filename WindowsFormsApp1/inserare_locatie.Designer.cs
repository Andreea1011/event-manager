namespace WindowsFormsApp1
{
    partial class inserare_locatie
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
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.txtCapacitate_maxima = new System.Windows.Forms.TextBox();
            this.txtAdresa_locatie = new System.Windows.Forms.TextBox();
            this.txtNume_locatie = new System.Windows.Forms.TextBox();
            this.txtID_locatie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_locatie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.Location = new System.Drawing.Point(341, 346);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(128, 51);
            this.btnAdaugare.TabIndex = 11;
            this.btnAdaugare.Text = "Adauga";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // txtCapacitate_maxima
            // 
            this.txtCapacitate_maxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacitate_maxima.Location = new System.Drawing.Point(383, 244);
            this.txtCapacitate_maxima.Name = "txtCapacitate_maxima";
            this.txtCapacitate_maxima.Size = new System.Drawing.Size(199, 31);
            this.txtCapacitate_maxima.TabIndex = 7;
            this.txtCapacitate_maxima.TextChanged += new System.EventHandler(this.txtCapacitate_maxima_TextChanged);
            // 
            // txtAdresa_locatie
            // 
            this.txtAdresa_locatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresa_locatie.Location = new System.Drawing.Point(383, 180);
            this.txtAdresa_locatie.Name = "txtAdresa_locatie";
            this.txtAdresa_locatie.Size = new System.Drawing.Size(199, 31);
            this.txtAdresa_locatie.TabIndex = 8;
            this.txtAdresa_locatie.TextChanged += new System.EventHandler(this.txtAdresa_locatie_TextChanged);
            // 
            // txtNume_locatie
            // 
            this.txtNume_locatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume_locatie.Location = new System.Drawing.Point(383, 116);
            this.txtNume_locatie.Name = "txtNume_locatie";
            this.txtNume_locatie.Size = new System.Drawing.Size(199, 31);
            this.txtNume_locatie.TabIndex = 9;
            this.txtNume_locatie.TextChanged += new System.EventHandler(this.txtNume_locatie_TextChanged);
            // 
            // txtID_locatie
            // 
            this.txtID_locatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_locatie.Location = new System.Drawing.Point(383, 54);
            this.txtID_locatie.Name = "txtID_locatie";
            this.txtID_locatie.Size = new System.Drawing.Size(199, 31);
            this.txtID_locatie.TabIndex = 10;
            this.txtID_locatie.TextChanged += new System.EventHandler(this.txtID_locatie_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacitate_maxima";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adresa_locatie";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nume_locatie";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ID_locatie
            // 
            this.ID_locatie.AutoSize = true;
            this.ID_locatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_locatie.Location = new System.Drawing.Point(233, 57);
            this.ID_locatie.Name = "ID_locatie";
            this.ID_locatie.Size = new System.Drawing.Size(107, 25);
            this.ID_locatie.TabIndex = 6;
            this.ID_locatie.Text = "ID_locatie";
            this.ID_locatie.Click += new System.EventHandler(this.label1_Click);
            // 
            // inserare_locatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.txtCapacitate_maxima);
            this.Controls.Add(this.txtAdresa_locatie);
            this.Controls.Add(this.txtNume_locatie);
            this.Controls.Add(this.txtID_locatie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID_locatie);
            this.Name = "inserare_locatie";
            this.Text = "inserare_locatie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.TextBox txtCapacitate_maxima;
        private System.Windows.Forms.TextBox txtAdresa_locatie;
        private System.Windows.Forms.TextBox txtNume_locatie;
        private System.Windows.Forms.TextBox txtID_locatie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ID_locatie;
    }
}