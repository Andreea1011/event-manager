namespace WindowsFormsApp1
{
    partial class inserare_f_e
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
            this.txtID_furnizor = new System.Windows.Forms.TextBox();
            this.txtID_eveniment = new System.Windows.Forms.TextBox();
            this.txtID_furnizori_evenimente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // txtID_furnizor
            // 
            this.txtID_furnizor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_furnizor.Location = new System.Drawing.Point(383, 180);
            this.txtID_furnizor.Name = "txtID_furnizor";
            this.txtID_furnizor.Size = new System.Drawing.Size(199, 31);
            this.txtID_furnizor.TabIndex = 8;
            // 
            // txtID_eveniment
            // 
            this.txtID_eveniment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_eveniment.Location = new System.Drawing.Point(383, 116);
            this.txtID_eveniment.Name = "txtID_eveniment";
            this.txtID_eveniment.Size = new System.Drawing.Size(199, 31);
            this.txtID_eveniment.TabIndex = 9;
            // 
            // txtID_furnizori_evenimente
            // 
            this.txtID_furnizori_evenimente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_furnizori_evenimente.Location = new System.Drawing.Point(383, 54);
            this.txtID_furnizori_evenimente.Name = "txtID_furnizori_evenimente";
            this.txtID_furnizori_evenimente.Size = new System.Drawing.Size(199, 31);
            this.txtID_furnizori_evenimente.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID_furnizor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID_eveniment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID_furnizori_evenimente";
            // 
            // inserare_f_e
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.txtID_furnizor);
            this.Controls.Add(this.txtID_eveniment);
            this.Controls.Add(this.txtID_furnizori_evenimente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "inserare_f_e";
            this.Text = "inserare_f_e";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.TextBox txtID_furnizor;
        private System.Windows.Forms.TextBox txtID_eveniment;
        private System.Windows.Forms.TextBox txtID_furnizori_evenimente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}