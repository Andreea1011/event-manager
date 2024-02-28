namespace WindowsFormsApp1
{
    partial class stergere_f_e
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
            this.btnStergere = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID_furnizori_evenimente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStergere
            // 
            this.btnStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.Location = new System.Drawing.Point(316, 304);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(128, 51);
            this.btnStergere.TabIndex = 8;
            this.btnStergere.Text = "Sterge";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(228, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Introdu ID-ul care trebuie sters";
            // 
            // txtID_furnizori_evenimente
            // 
            this.txtID_furnizori_evenimente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_furnizori_evenimente.Location = new System.Drawing.Point(421, 173);
            this.txtID_furnizori_evenimente.Name = "txtID_furnizori_evenimente";
            this.txtID_furnizori_evenimente.Size = new System.Drawing.Size(199, 31);
            this.txtID_furnizori_evenimente.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID_furnizori_evenimente";
            // 
            // stergere_f_e
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID_furnizori_evenimente);
            this.Controls.Add(this.label1);
            this.Name = "stergere_f_e";
            this.Text = "stergere_f_e";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID_furnizori_evenimente;
        private System.Windows.Forms.Label label1;
    }
}