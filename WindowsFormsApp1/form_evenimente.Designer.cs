namespace WindowsFormsApp1
{
    partial class form_evenimente
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
            this.iDevenimentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDlocatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeevenimentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataevenimentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarinvitatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenimenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temaDataSet = new WindowsFormsApp1.TemaDataSet();
            this.evenimenteTableAdapter = new WindowsFormsApp1.TemaDataSetTableAdapters.EvenimenteTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenimenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(338, 210);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 33);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(181, 210);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(118, 33);
            this.btnStergere.TabIndex = 13;
            this.btnStergere.Text = "Sterge date";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(632, 377);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 45);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Catre celelalte tabele";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(24, 210);
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
            this.iDevenimentDataGridViewTextBoxColumn,
            this.iDlocatieDataGridViewTextBoxColumn,
            this.iDclientDataGridViewTextBoxColumn,
            this.numeevenimentDataGridViewTextBoxColumn,
            this.dataevenimentDataGridViewTextBoxColumn,
            this.numarinvitatiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.evenimenteBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 193);
            this.dataGridView1.TabIndex = 10;
            // 
            // iDevenimentDataGridViewTextBoxColumn
            // 
            this.iDevenimentDataGridViewTextBoxColumn.DataPropertyName = "ID_eveniment";
            this.iDevenimentDataGridViewTextBoxColumn.HeaderText = "ID_eveniment";
            this.iDevenimentDataGridViewTextBoxColumn.Name = "iDevenimentDataGridViewTextBoxColumn";
            // 
            // iDlocatieDataGridViewTextBoxColumn
            // 
            this.iDlocatieDataGridViewTextBoxColumn.DataPropertyName = "ID_locatie";
            this.iDlocatieDataGridViewTextBoxColumn.HeaderText = "ID_locatie";
            this.iDlocatieDataGridViewTextBoxColumn.Name = "iDlocatieDataGridViewTextBoxColumn";
            // 
            // iDclientDataGridViewTextBoxColumn
            // 
            this.iDclientDataGridViewTextBoxColumn.DataPropertyName = "ID_client";
            this.iDclientDataGridViewTextBoxColumn.HeaderText = "ID_client";
            this.iDclientDataGridViewTextBoxColumn.Name = "iDclientDataGridViewTextBoxColumn";
            // 
            // numeevenimentDataGridViewTextBoxColumn
            // 
            this.numeevenimentDataGridViewTextBoxColumn.DataPropertyName = "Nume_eveniment";
            this.numeevenimentDataGridViewTextBoxColumn.HeaderText = "Nume_eveniment";
            this.numeevenimentDataGridViewTextBoxColumn.Name = "numeevenimentDataGridViewTextBoxColumn";
            // 
            // dataevenimentDataGridViewTextBoxColumn
            // 
            this.dataevenimentDataGridViewTextBoxColumn.DataPropertyName = "Data_eveniment";
            this.dataevenimentDataGridViewTextBoxColumn.HeaderText = "Data_eveniment";
            this.dataevenimentDataGridViewTextBoxColumn.Name = "dataevenimentDataGridViewTextBoxColumn";
            // 
            // numarinvitatiDataGridViewTextBoxColumn
            // 
            this.numarinvitatiDataGridViewTextBoxColumn.DataPropertyName = "Numar_invitati";
            this.numarinvitatiDataGridViewTextBoxColumn.HeaderText = "Numar_invitati";
            this.numarinvitatiDataGridViewTextBoxColumn.Name = "numarinvitatiDataGridViewTextBoxColumn";
            // 
            // evenimenteBindingSource
            // 
            this.evenimenteBindingSource.DataMember = "Evenimente";
            this.evenimenteBindingSource.DataSource = this.temaDataSetBindingSource;
            // 
            // temaDataSetBindingSource
            // 
            this.temaDataSetBindingSource.DataSource = this.temaDataSet;
            this.temaDataSetBindingSource.Position = 0;
            // 
            // temaDataSet
            // 
            this.temaDataSet.DataSetName = "TemaDataSet";
            this.temaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evenimenteTableAdapter
            // 
            this.evenimenteTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 63);
            this.button1.TabIndex = 15;
            this.button1.Text = "Numarul de furnizori pentru fiecare eveniment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(248, 270);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(335, 134);
            this.listBox1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 63);
            this.button2.TabIndex = 19;
            this.button2.Text = "Costul total pentru fiecare eveniment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // form_evenimente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form_evenimente";
            this.Text = "form_evenimente";
            this.Load += new System.EventHandler(this.form_evenimente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenimenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaDataSet)).EndInit();
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
        private System.Windows.Forms.BindingSource evenimenteBindingSource;
        private TemaDataSetTableAdapters.EvenimenteTableAdapter evenimenteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDevenimentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDlocatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeevenimentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataevenimentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarinvitatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
    }
}