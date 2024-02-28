namespace WindowsFormsApp1
{
    partial class form_angajati
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
            this.iDangajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDdepartamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDsupervizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeangajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeangajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angajatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temaDataSet = new WindowsFormsApp1.TemaDataSet();
            this.angajatiTableAdapter = new WindowsFormsApp1.TemaDataSetTableAdapters.AngajatiTableAdapter();
            this.Ang_even = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(312, 225);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 33);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(165, 225);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(118, 33);
            this.btnStergere.TabIndex = 13;
            this.btnStergere.Text = "Sterge date";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(657, 393);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 45);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Catre celelalte tabele";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 225);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(118, 33);
            this.btnInsert.TabIndex = 11;
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
            this.iDangajatDataGridViewTextBoxColumn,
            this.iDdepartamentDataGridViewTextBoxColumn,
            this.iDsupervizorDataGridViewTextBoxColumn,
            this.numeangajatDataGridViewTextBoxColumn,
            this.prenumeangajatDataGridViewTextBoxColumn,
            this.functieDataGridViewTextBoxColumn,
            this.salariuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.angajatiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 202);
            this.dataGridView1.TabIndex = 10;
            // 
            // iDangajatDataGridViewTextBoxColumn
            // 
            this.iDangajatDataGridViewTextBoxColumn.DataPropertyName = "ID_angajat";
            this.iDangajatDataGridViewTextBoxColumn.HeaderText = "ID_angajat";
            this.iDangajatDataGridViewTextBoxColumn.Name = "iDangajatDataGridViewTextBoxColumn";
            // 
            // iDdepartamentDataGridViewTextBoxColumn
            // 
            this.iDdepartamentDataGridViewTextBoxColumn.DataPropertyName = "ID_departament";
            this.iDdepartamentDataGridViewTextBoxColumn.HeaderText = "ID_departament";
            this.iDdepartamentDataGridViewTextBoxColumn.Name = "iDdepartamentDataGridViewTextBoxColumn";
            // 
            // iDsupervizorDataGridViewTextBoxColumn
            // 
            this.iDsupervizorDataGridViewTextBoxColumn.DataPropertyName = "ID_supervizor";
            this.iDsupervizorDataGridViewTextBoxColumn.HeaderText = "ID_supervizor";
            this.iDsupervizorDataGridViewTextBoxColumn.Name = "iDsupervizorDataGridViewTextBoxColumn";
            // 
            // numeangajatDataGridViewTextBoxColumn
            // 
            this.numeangajatDataGridViewTextBoxColumn.DataPropertyName = "Nume_angajat";
            this.numeangajatDataGridViewTextBoxColumn.HeaderText = "Nume_angajat";
            this.numeangajatDataGridViewTextBoxColumn.Name = "numeangajatDataGridViewTextBoxColumn";
            // 
            // prenumeangajatDataGridViewTextBoxColumn
            // 
            this.prenumeangajatDataGridViewTextBoxColumn.DataPropertyName = "Prenume_angajat";
            this.prenumeangajatDataGridViewTextBoxColumn.HeaderText = "Prenume_angajat";
            this.prenumeangajatDataGridViewTextBoxColumn.Name = "prenumeangajatDataGridViewTextBoxColumn";
            // 
            // functieDataGridViewTextBoxColumn
            // 
            this.functieDataGridViewTextBoxColumn.DataPropertyName = "Functie";
            this.functieDataGridViewTextBoxColumn.HeaderText = "Functie";
            this.functieDataGridViewTextBoxColumn.Name = "functieDataGridViewTextBoxColumn";
            // 
            // salariuDataGridViewTextBoxColumn
            // 
            this.salariuDataGridViewTextBoxColumn.DataPropertyName = "Salariu";
            this.salariuDataGridViewTextBoxColumn.HeaderText = "Salariu";
            this.salariuDataGridViewTextBoxColumn.Name = "salariuDataGridViewTextBoxColumn";
            // 
            // angajatiBindingSource
            // 
            this.angajatiBindingSource.DataMember = "Angajati";
            this.angajatiBindingSource.DataSource = this.temaDataSet;
            // 
            // temaDataSet
            // 
            this.temaDataSet.DataSetName = "TemaDataSet";
            this.temaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // angajatiTableAdapter
            // 
            this.angajatiTableAdapter.ClearBeforeFill = true;
            // 
            // Ang_even
            // 
            this.Ang_even.Location = new System.Drawing.Point(12, 287);
            this.Ang_even.Name = "Ang_even";
            this.Ang_even.Size = new System.Drawing.Size(218, 50);
            this.Ang_even.TabIndex = 15;
            this.Ang_even.Text = "Angajatii care lucreaza la cel putin un eveniment la care lucreaza si managerul d" +
    "epartamentului din care fac parte";
            this.Ang_even.UseVisualStyleBackColor = true;
            this.Ang_even.Click += new System.EventHandler(this.Ang_even_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(249, 287);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(389, 134);
            this.listBox1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 50);
            this.button1.TabIndex = 17;
            this.button1.Text = "Angajatii care nu lucreaza la niciun eveniment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_angajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Ang_even);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form_angajati";
            this.Text = "form_angajati";
            this.Load += new System.EventHandler(this.form_angajati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TemaDataSet temaDataSet;
        private System.Windows.Forms.BindingSource angajatiBindingSource;
        private TemaDataSetTableAdapters.AngajatiTableAdapter angajatiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDangajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDdepartamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDsupervizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeangajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeangajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn functieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Ang_even;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}