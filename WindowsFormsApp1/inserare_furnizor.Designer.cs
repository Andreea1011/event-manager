namespace WindowsFormsApp1
{
    partial class inserare_furnizor
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
            this.txtPret_serviciu = new System.Windows.Forms.TextBox();
            this.txtTip_serviciu = new System.Windows.Forms.TextBox();
            this.txtNume_furnizor = new System.Windows.Forms.TextBox();
            this.txtID_furnizor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_locatie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.Location = new System.Drawing.Point(362, 346);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(128, 51);
            this.btnAdaugare.TabIndex = 20;
            this.btnAdaugare.Text = "Adauga";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // txtPret_serviciu
            // 
            this.txtPret_serviciu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPret_serviciu.Location = new System.Drawing.Point(404, 244);
            this.txtPret_serviciu.Name = "txtPret_serviciu";
            this.txtPret_serviciu.Size = new System.Drawing.Size(199, 31);
            this.txtPret_serviciu.TabIndex = 16;
            // 
            // txtTip_serviciu
            // 
            this.txtTip_serviciu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTip_serviciu.Location = new System.Drawing.Point(404, 180);
            this.txtTip_serviciu.Name = "txtTip_serviciu";
            this.txtTip_serviciu.Size = new System.Drawing.Size(199, 31);
            this.txtTip_serviciu.TabIndex = 17;
            // 
            // txtNume_furnizor
            // 
            this.txtNume_furnizor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume_furnizor.Location = new System.Drawing.Point(404, 116);
            this.txtNume_furnizor.Name = "txtNume_furnizor";
            this.txtNume_furnizor.Size = new System.Drawing.Size(199, 31);
            this.txtNume_furnizor.TabIndex = 18;
            // 
            // txtID_furnizor
            // 
            this.txtID_furnizor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_furnizor.Location = new System.Drawing.Point(404, 54);
            this.txtID_furnizor.Name = "txtID_furnizor";
            this.txtID_furnizor.Size = new System.Drawing.Size(199, 31);
            this.txtID_furnizor.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pret_serviciu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tip_serviciu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nume_furnizor";
            // 
            // ID_locatie
            // 
            this.ID_locatie.AutoSize = true;
            this.ID_locatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_locatie.Location = new System.Drawing.Point(254, 57);
            this.ID_locatie.Name = "ID_locatie";
            this.ID_locatie.Size = new System.Drawing.Size(116, 25);
            this.ID_locatie.TabIndex = 15;
            this.ID_locatie.Text = "ID_furnizor";
            // 
            // inserare_furnizor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.txtPret_serviciu);
            this.Controls.Add(this.txtTip_serviciu);
            this.Controls.Add(this.txtNume_furnizor);
            this.Controls.Add(this.txtID_furnizor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID_locatie);
            this.Name = "inserare_furnizor";
            this.Text = "inserare_furnizor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.TextBox txtPret_serviciu;
        private System.Windows.Forms.TextBox txtTip_serviciu;
        private System.Windows.Forms.TextBox txtNume_furnizor;
        private System.Windows.Forms.TextBox txtID_furnizor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ID_locatie;
    }
}