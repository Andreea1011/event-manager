namespace WindowsFormsApp1
{
    partial class form_locatie
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
            this.components = new System.ComponentModel.Container();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDlocatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numelocatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresalocatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacitatemaximaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locatieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temaDataSet = new WindowsFormsApp1.TemaDataSet();
            this.locatieTableAdapter = new WindowsFormsApp1.TemaDataSetTableAdapters.LocatieTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxVal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(339, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 33);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(182, 168);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(118, 33);
            this.btnStergere.TabIndex = 8;
            this.btnStergere.Text = "Sterge date";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(646, 384);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 45);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Catre celelalte tabele";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(25, 168);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(118, 33);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insereaza date";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDlocatieDataGridViewTextBoxColumn,
            this.numelocatieDataGridViewTextBoxColumn,
            this.adresalocatieDataGridViewTextBoxColumn,
            this.capacitatemaximaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.locatieBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 137);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDlocatieDataGridViewTextBoxColumn
            // 
            this.iDlocatieDataGridViewTextBoxColumn.DataPropertyName = "ID_locatie";
            this.iDlocatieDataGridViewTextBoxColumn.HeaderText = "ID_locatie";
            this.iDlocatieDataGridViewTextBoxColumn.Name = "iDlocatieDataGridViewTextBoxColumn";
            // 
            // numelocatieDataGridViewTextBoxColumn
            // 
            this.numelocatieDataGridViewTextBoxColumn.DataPropertyName = "Nume_locatie";
            this.numelocatieDataGridViewTextBoxColumn.HeaderText = "Nume_locatie";
            this.numelocatieDataGridViewTextBoxColumn.Name = "numelocatieDataGridViewTextBoxColumn";
            // 
            // adresalocatieDataGridViewTextBoxColumn
            // 
            this.adresalocatieDataGridViewTextBoxColumn.DataPropertyName = "Adresa_locatie";
            this.adresalocatieDataGridViewTextBoxColumn.HeaderText = "Adresa_locatie";
            this.adresalocatieDataGridViewTextBoxColumn.Name = "adresalocatieDataGridViewTextBoxColumn";
            // 
            // capacitatemaximaDataGridViewTextBoxColumn
            // 
            this.capacitatemaximaDataGridViewTextBoxColumn.DataPropertyName = "Capacitate_maxima";
            this.capacitatemaximaDataGridViewTextBoxColumn.HeaderText = "Capacitate_maxima";
            this.capacitatemaximaDataGridViewTextBoxColumn.Name = "capacitatemaximaDataGridViewTextBoxColumn";
            // 
            // locatieBindingSource
            // 
            this.locatieBindingSource.DataMember = "Locatie";
            this.locatieBindingSource.DataSource = this.temaDataSet;
            // 
            // temaDataSet
            // 
            this.temaDataSet.DataSetName = "TemaDataSet";
            this.temaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locatieTableAdapter
            // 
            this.locatieTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 51);
            this.button1.TabIndex = 12;
            this.button1.Text = "Numarul de evenimente la fiecare locatie si media numarului de invitati";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(227, 235);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(401, 134);
            this.listBox1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "introduceti numele locatiei";
            // 
            // txtBoxVal
            // 
            this.txtBoxVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtBoxVal.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtBoxVal.Location = new System.Drawing.Point(25, 389);
            this.txtBoxVal.Name = "txtBoxVal";
            this.txtBoxVal.Size = new System.Drawing.Size(189, 20);
            this.txtBoxVal.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 51);
            this.button2.TabIndex = 22;
            this.button2.Text = "Clientii care au evenimente in locatia data de utilizator";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // form_locatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxVal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form_locatie";
            this.Text = "form_locatie";
            this.Load += new System.EventHandler(this.form_locatie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TemaDataSet temaDataSet;
        private System.Windows.Forms.BindingSource locatieBindingSource;
        private TemaDataSetTableAdapters.LocatieTableAdapter locatieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDlocatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numelocatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresalocatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacitatemaximaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxVal;
        private System.Windows.Forms.Button button2;
    }
}