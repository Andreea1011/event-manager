namespace WindowsFormsApp1
{
    partial class form_departamente
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
            this.iDdepartamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDmanagerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numedepartamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temaDataSet = new WindowsFormsApp1.TemaDataSet();
            this.departamenteTableAdapter = new WindowsFormsApp1.TemaDataSetTableAdapters.DepartamenteTableAdapter();
            this.Dep_interogare1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxVal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(347, 177);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 33);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(190, 177);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(118, 33);
            this.btnStergere.TabIndex = 8;
            this.btnStergere.Text = "Sterge date";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(645, 393);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 45);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Catre celelalte tabele";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(33, 177);
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
            this.iDdepartamentDataGridViewTextBoxColumn,
            this.iDmanagerDataGridViewTextBoxColumn,
            this.numedepartamentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.departamenteBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 156);
            this.dataGridView1.TabIndex = 5;
            // 
            // iDdepartamentDataGridViewTextBoxColumn
            // 
            this.iDdepartamentDataGridViewTextBoxColumn.DataPropertyName = "ID_departament";
            this.iDdepartamentDataGridViewTextBoxColumn.HeaderText = "ID_departament";
            this.iDdepartamentDataGridViewTextBoxColumn.Name = "iDdepartamentDataGridViewTextBoxColumn";
            // 
            // iDmanagerDataGridViewTextBoxColumn
            // 
            this.iDmanagerDataGridViewTextBoxColumn.DataPropertyName = "ID_manager";
            this.iDmanagerDataGridViewTextBoxColumn.HeaderText = "ID_manager";
            this.iDmanagerDataGridViewTextBoxColumn.Name = "iDmanagerDataGridViewTextBoxColumn";
            // 
            // numedepartamentDataGridViewTextBoxColumn
            // 
            this.numedepartamentDataGridViewTextBoxColumn.DataPropertyName = "Nume_departament";
            this.numedepartamentDataGridViewTextBoxColumn.HeaderText = "Nume_departament";
            this.numedepartamentDataGridViewTextBoxColumn.Name = "numedepartamentDataGridViewTextBoxColumn";
            // 
            // departamenteBindingSource
            // 
            this.departamenteBindingSource.DataMember = "Departamente";
            this.departamenteBindingSource.DataSource = this.temaDataSet;
            // 
            // temaDataSet
            // 
            this.temaDataSet.DataSetName = "TemaDataSet";
            this.temaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamenteTableAdapter
            // 
            this.departamenteTableAdapter.ClearBeforeFill = true;
            // 
            // Dep_interogare1
            // 
            this.Dep_interogare1.Location = new System.Drawing.Point(33, 246);
            this.Dep_interogare1.Name = "Dep_interogare1";
            this.Dep_interogare1.Size = new System.Drawing.Size(234, 60);
            this.Dep_interogare1.TabIndex = 10;
            this.Dep_interogare1.Text = "Departamente pentru care media salariilor angajatilor e mai mare decat media sala" +
    "riului pe intreaga companie";
            this.Dep_interogare1.UseVisualStyleBackColor = true;
            this.Dep_interogare1.Click += new System.EventHandler(this.Dep_interogare1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(290, 246);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(335, 134);
            this.listBox1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 60);
            this.button1.TabIndex = 12;
            this.button1.Text = "Numarul de angajati dintr-un departament dat de utilizator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxVal
            // 
            this.txtBoxVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtBoxVal.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtBoxVal.Location = new System.Drawing.Point(62, 406);
            this.txtBoxVal.Name = "txtBoxVal";
            this.txtBoxVal.Size = new System.Drawing.Size(189, 20);
            this.txtBoxVal.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "introduceti numele departamentului";
            // 
            // form_departamente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxVal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Dep_interogare1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form_departamente";
            this.Text = "form_departamente";
            this.Load += new System.EventHandler(this.form_departamente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamenteBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource departamenteBindingSource;
        private TemaDataSetTableAdapters.DepartamenteTableAdapter departamenteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDdepartamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDmanagerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numedepartamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Dep_interogare1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxVal;
        private System.Windows.Forms.Label label1;
    }
}