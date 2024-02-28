namespace WindowsFormsApp1
{
    partial class form_a_e
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
            this.temaDataSet = new WindowsFormsApp1.TemaDataSet();
            this.temaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temaDataSet2 = new WindowsFormsApp1.TemaDataSet2();
            this.angajatiEvenimenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.angajati_EvenimenteTableAdapter = new WindowsFormsApp1.TemaDataSet2TableAdapters.Angajati_EvenimenteTableAdapter();
            this.iDangajatievenimenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDangajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDevenimentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiEvenimenteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(358, 315);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 33);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(201, 315);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(118, 33);
            this.btnStergere.TabIndex = 8;
            this.btnStergere.Text = "Sterge date";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(612, 393);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 45);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Catre celelalte tabele";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(44, 315);
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
            this.iDangajatievenimenteDataGridViewTextBoxColumn,
            this.iDangajatDataGridViewTextBoxColumn,
            this.iDevenimentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.angajatiEvenimenteBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 263);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // temaDataSet
            // 
            this.temaDataSet.DataSetName = "TemaDataSet";
            this.temaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // temaDataSetBindingSource
            // 
            this.temaDataSetBindingSource.DataSource = this.temaDataSet;
            this.temaDataSetBindingSource.Position = 0;
            // 
            // temaDataSet2
            // 
            this.temaDataSet2.DataSetName = "TemaDataSet2";
            this.temaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // angajatiEvenimenteBindingSource
            // 
            this.angajatiEvenimenteBindingSource.DataMember = "Angajati_Evenimente";
            this.angajatiEvenimenteBindingSource.DataSource = this.temaDataSet2;
            // 
            // angajati_EvenimenteTableAdapter
            // 
            this.angajati_EvenimenteTableAdapter.ClearBeforeFill = true;
            // 
            // iDangajatievenimenteDataGridViewTextBoxColumn
            // 
            this.iDangajatievenimenteDataGridViewTextBoxColumn.DataPropertyName = "ID_angajati_evenimente";
            this.iDangajatievenimenteDataGridViewTextBoxColumn.HeaderText = "ID_angajati_evenimente";
            this.iDangajatievenimenteDataGridViewTextBoxColumn.Name = "iDangajatievenimenteDataGridViewTextBoxColumn";
            // 
            // iDangajatDataGridViewTextBoxColumn
            // 
            this.iDangajatDataGridViewTextBoxColumn.DataPropertyName = "ID_angajat";
            this.iDangajatDataGridViewTextBoxColumn.HeaderText = "ID_angajat";
            this.iDangajatDataGridViewTextBoxColumn.Name = "iDangajatDataGridViewTextBoxColumn";
            // 
            // iDevenimentDataGridViewTextBoxColumn
            // 
            this.iDevenimentDataGridViewTextBoxColumn.DataPropertyName = "ID_eveniment";
            this.iDevenimentDataGridViewTextBoxColumn.HeaderText = "ID_eveniment";
            this.iDevenimentDataGridViewTextBoxColumn.Name = "iDevenimentDataGridViewTextBoxColumn";
            // 
            // form_a_e
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form_a_e";
            this.Text = "form_a_e";
            this.Load += new System.EventHandler(this.form_a_e_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiEvenimenteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource temaDataSetBindingSource;
        private TemaDataSet temaDataSet;
        private TemaDataSet2 temaDataSet2;
        private System.Windows.Forms.BindingSource angajatiEvenimenteBindingSource;
        private TemaDataSet2TableAdapters.Angajati_EvenimenteTableAdapter angajati_EvenimenteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDangajatievenimenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDangajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDevenimentDataGridViewTextBoxColumn;
    }
}