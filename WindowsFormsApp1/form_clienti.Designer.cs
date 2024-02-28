namespace WindowsFormsApp1
{
    partial class form_clienti
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
            this.clientiDataSet = new WindowsFormsApp1.ClientiDataSet();
            this.clientiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrtelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temaDataSet = new WindowsFormsApp1.TemaDataSet();
            this.clientiTableAdapter = new WindowsFormsApp1.TemaDataSetTableAdapters.ClientiTableAdapter();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // clientiDataSet
            // 
            this.clientiDataSet.DataSetName = "ClientiDataSet";
            this.clientiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientiDataSetBindingSource
            // 
            this.clientiDataSetBindingSource.DataSource = this.clientiDataSet;
            this.clientiDataSetBindingSource.Position = 0;
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
            this.iDclientDataGridViewTextBoxColumn,
            this.numeclientDataGridViewTextBoxColumn,
            this.prenumeclientDataGridViewTextBoxColumn,
            this.nrtelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 181);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // iDclientDataGridViewTextBoxColumn
            // 
            this.iDclientDataGridViewTextBoxColumn.DataPropertyName = "ID_client";
            this.iDclientDataGridViewTextBoxColumn.HeaderText = "ID_client";
            this.iDclientDataGridViewTextBoxColumn.Name = "iDclientDataGridViewTextBoxColumn";
            // 
            // numeclientDataGridViewTextBoxColumn
            // 
            this.numeclientDataGridViewTextBoxColumn.DataPropertyName = "Nume_client";
            this.numeclientDataGridViewTextBoxColumn.HeaderText = "Nume_client";
            this.numeclientDataGridViewTextBoxColumn.Name = "numeclientDataGridViewTextBoxColumn";
            // 
            // prenumeclientDataGridViewTextBoxColumn
            // 
            this.prenumeclientDataGridViewTextBoxColumn.DataPropertyName = "Prenume_client";
            this.prenumeclientDataGridViewTextBoxColumn.HeaderText = "Prenume_client";
            this.prenumeclientDataGridViewTextBoxColumn.Name = "prenumeclientDataGridViewTextBoxColumn";
            // 
            // nrtelDataGridViewTextBoxColumn
            // 
            this.nrtelDataGridViewTextBoxColumn.DataPropertyName = "Nr_tel";
            this.nrtelDataGridViewTextBoxColumn.HeaderText = "Nr_tel";
            this.nrtelDataGridViewTextBoxColumn.Name = "nrtelDataGridViewTextBoxColumn";
            // 
            // clientiBindingSource
            // 
            this.clientiBindingSource.DataMember = "Clienti";
            this.clientiBindingSource.DataSource = this.temaDataSet;
            // 
            // temaDataSet
            // 
            this.temaDataSet.DataSetName = "TemaDataSet";
            this.temaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientiTableAdapter
            // 
            this.clientiTableAdapter.ClearBeforeFill = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(39, 201);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(118, 33);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insereaza date";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(648, 393);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 45);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Catre celelalte tabele";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(196, 201);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(118, 33);
            this.btnStergere.TabIndex = 3;
            this.btnStergere.Text = "Sterge date";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(353, 201);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 33);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 51);
            this.button1.TabIndex = 11;
            this.button1.Text = "Numarul de evenimente al fiecarui client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(228, 252);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(412, 134);
            this.listBox1.TabIndex = 18;
            // 
            // form_clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form_clienti";
            this.Text = "form_clienti";
            this.Load += new System.EventHandler(this.form_clienti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource clientiDataSetBindingSource;
        private ClientiDataSet clientiDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TemaDataSet temaDataSet;
        private System.Windows.Forms.BindingSource clientiBindingSource;
        private TemaDataSetTableAdapters.ClientiTableAdapter clientiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrtelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}