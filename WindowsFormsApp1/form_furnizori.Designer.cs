namespace WindowsFormsApp1
{
    partial class form_furnizori
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
            this.iDfurnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numefurnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipserviciuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretserviciuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.temaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temaDataSet1 = new WindowsFormsApp1.TemaDataSet();
            this.furnizoriTableAdapter1 = new WindowsFormsApp1.TemaDataSetTableAdapters.FurnizoriTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(351, 247);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 33);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(194, 247);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(118, 33);
            this.btnStergere.TabIndex = 8;
            this.btnStergere.Text = "Sterge date";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(657, 393);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 45);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Catre celelalte tabele";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(37, 247);
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
            this.iDfurnizorDataGridViewTextBoxColumn,
            this.numefurnizorDataGridViewTextBoxColumn,
            this.tipserviciuDataGridViewTextBoxColumn,
            this.pretserviciuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 221);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDfurnizorDataGridViewTextBoxColumn
            // 
            this.iDfurnizorDataGridViewTextBoxColumn.DataPropertyName = "ID_furnizor";
            this.iDfurnizorDataGridViewTextBoxColumn.HeaderText = "ID_furnizor";
            this.iDfurnizorDataGridViewTextBoxColumn.Name = "iDfurnizorDataGridViewTextBoxColumn";
            // 
            // numefurnizorDataGridViewTextBoxColumn
            // 
            this.numefurnizorDataGridViewTextBoxColumn.DataPropertyName = "Nume_furnizor";
            this.numefurnizorDataGridViewTextBoxColumn.HeaderText = "Nume_furnizor";
            this.numefurnizorDataGridViewTextBoxColumn.Name = "numefurnizorDataGridViewTextBoxColumn";
            // 
            // tipserviciuDataGridViewTextBoxColumn
            // 
            this.tipserviciuDataGridViewTextBoxColumn.DataPropertyName = "Tip_serviciu";
            this.tipserviciuDataGridViewTextBoxColumn.HeaderText = "Tip_serviciu";
            this.tipserviciuDataGridViewTextBoxColumn.Name = "tipserviciuDataGridViewTextBoxColumn";
            // 
            // pretserviciuDataGridViewTextBoxColumn
            // 
            this.pretserviciuDataGridViewTextBoxColumn.DataPropertyName = "Pret_serviciu";
            this.pretserviciuDataGridViewTextBoxColumn.HeaderText = "Pret_serviciu";
            this.pretserviciuDataGridViewTextBoxColumn.Name = "pretserviciuDataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Furnizori";
            this.bindingSource1.DataSource = this.temaDataSet1BindingSource;
            // 
            // temaDataSet1BindingSource
            // 
            this.temaDataSet1BindingSource.DataSource = this.temaDataSet1;
            this.temaDataSet1BindingSource.Position = 0;
            // 
            // temaDataSet1
            // 
            this.temaDataSet1.DataSetName = "TemaDataSet";
            this.temaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // furnizoriTableAdapter1
            // 
            this.furnizoriTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 63);
            this.button1.TabIndex = 10;
            this.button1.Text = "Furnizorii care lucreaza la cele mai multe evenimente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(264, 304);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(266, 134);
            this.listBox1.TabIndex = 17;
            // 
            // form_furnizori
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
            this.Name = "form_furnizori";
            this.Text = "form_furnizori";
            this.Load += new System.EventHandler(this.form_furnizori_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TemaDataSet temaDataSet;
        private System.Windows.Forms.BindingSource furnizoriBindingSource;
        private TemaDataSetTableAdapters.FurnizoriTableAdapter furnizoriTableAdapter;
        private System.Windows.Forms.BindingSource temaDataSet1BindingSource;
        private TemaDataSet temaDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private TemaDataSetTableAdapters.FurnizoriTableAdapter furnizoriTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDfurnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numefurnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipserviciuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretserviciuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}