namespace WindowsFormsApp1
{
    partial class Form2
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
            this.btnClienti = new System.Windows.Forms.Button();
            this.btnLocatie = new System.Windows.Forms.Button();
            this.btnFurnizori = new System.Windows.Forms.Button();
            this.btnEvenimente = new System.Windows.Forms.Button();
            this.btnAngajati = new System.Windows.Forms.Button();
            this.btnDepartamente = new System.Windows.Forms.Button();
            this.btnFurnizoriEvenimente = new System.Windows.Forms.Button();
            this.btnAngajatiEvenimente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(301, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alege o tabela";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnClienti
            // 
            this.btnClienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienti.Location = new System.Drawing.Point(92, 134);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Size = new System.Drawing.Size(147, 52);
            this.btnClienti.TabIndex = 1;
            this.btnClienti.Text = "Clienti";
            this.btnClienti.UseVisualStyleBackColor = true;
            this.btnClienti.Click += new System.EventHandler(this.btnClienti_Click);
            // 
            // btnLocatie
            // 
            this.btnLocatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocatie.Location = new System.Drawing.Point(314, 134);
            this.btnLocatie.Name = "btnLocatie";
            this.btnLocatie.Size = new System.Drawing.Size(147, 52);
            this.btnLocatie.TabIndex = 1;
            this.btnLocatie.Text = "Locatie";
            this.btnLocatie.UseVisualStyleBackColor = true;
            this.btnLocatie.Click += new System.EventHandler(this.btnLocatie_Click);
            // 
            // btnFurnizori
            // 
            this.btnFurnizori.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFurnizori.Location = new System.Drawing.Point(528, 134);
            this.btnFurnizori.Name = "btnFurnizori";
            this.btnFurnizori.Size = new System.Drawing.Size(147, 52);
            this.btnFurnizori.TabIndex = 1;
            this.btnFurnizori.Text = "Furnizori";
            this.btnFurnizori.UseVisualStyleBackColor = true;
            this.btnFurnizori.Click += new System.EventHandler(this.btnFurnizori_Click);
            // 
            // btnEvenimente
            // 
            this.btnEvenimente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvenimente.Location = new System.Drawing.Point(92, 233);
            this.btnEvenimente.Name = "btnEvenimente";
            this.btnEvenimente.Size = new System.Drawing.Size(147, 52);
            this.btnEvenimente.TabIndex = 1;
            this.btnEvenimente.Text = "Evenimente";
            this.btnEvenimente.UseVisualStyleBackColor = true;
            this.btnEvenimente.Click += new System.EventHandler(this.btnEvenimente_Click);
            // 
            // btnAngajati
            // 
            this.btnAngajati.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAngajati.Location = new System.Drawing.Point(314, 232);
            this.btnAngajati.Name = "btnAngajati";
            this.btnAngajati.Size = new System.Drawing.Size(147, 52);
            this.btnAngajati.TabIndex = 1;
            this.btnAngajati.Text = "Angajati";
            this.btnAngajati.UseVisualStyleBackColor = true;
            this.btnAngajati.Click += new System.EventHandler(this.btnAngajati_Click);
            // 
            // btnDepartamente
            // 
            this.btnDepartamente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartamente.Location = new System.Drawing.Point(528, 233);
            this.btnDepartamente.Name = "btnDepartamente";
            this.btnDepartamente.Size = new System.Drawing.Size(147, 52);
            this.btnDepartamente.TabIndex = 1;
            this.btnDepartamente.Text = "Departamente";
            this.btnDepartamente.UseVisualStyleBackColor = true;
            this.btnDepartamente.Click += new System.EventHandler(this.btnDepartamente_Click);
            // 
            // btnFurnizoriEvenimente
            // 
            this.btnFurnizoriEvenimente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFurnizoriEvenimente.Location = new System.Drawing.Point(142, 326);
            this.btnFurnizoriEvenimente.Name = "btnFurnizoriEvenimente";
            this.btnFurnizoriEvenimente.Size = new System.Drawing.Size(204, 52);
            this.btnFurnizoriEvenimente.TabIndex = 1;
            this.btnFurnizoriEvenimente.Text = "Furnizori_Evenimente";
            this.btnFurnizoriEvenimente.UseVisualStyleBackColor = true;
            this.btnFurnizoriEvenimente.Click += new System.EventHandler(this.btnFurnizoriEvenimente_Click);
            // 
            // btnAngajatiEvenimente
            // 
            this.btnAngajatiEvenimente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAngajatiEvenimente.Location = new System.Drawing.Point(424, 326);
            this.btnAngajatiEvenimente.Name = "btnAngajatiEvenimente";
            this.btnAngajatiEvenimente.Size = new System.Drawing.Size(204, 52);
            this.btnAngajatiEvenimente.TabIndex = 1;
            this.btnAngajatiEvenimente.Text = "Angajati_Evenimente";
            this.btnAngajatiEvenimente.UseVisualStyleBackColor = true;
            this.btnAngajatiEvenimente.Click += new System.EventHandler(this.btnAngajatiEvenimente_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFurnizori);
            this.Controls.Add(this.btnDepartamente);
            this.Controls.Add(this.btnAngajatiEvenimente);
            this.Controls.Add(this.btnFurnizoriEvenimente);
            this.Controls.Add(this.btnAngajati);
            this.Controls.Add(this.btnLocatie);
            this.Controls.Add(this.btnEvenimente);
            this.Controls.Add(this.btnClienti);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClienti;
        private System.Windows.Forms.Button btnLocatie;
        private System.Windows.Forms.Button btnFurnizori;
        private System.Windows.Forms.Button btnEvenimente;
        private System.Windows.Forms.Button btnAngajati;
        private System.Windows.Forms.Button btnDepartamente;
        private System.Windows.Forms.Button btnFurnizoriEvenimente;
        private System.Windows.Forms.Button btnAngajatiEvenimente;
    }
}