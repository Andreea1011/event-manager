using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class form_a_e : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public form_a_e()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-0OHL1Q8\SQLEXPRESS; Initial Catalog=Tema; Integrated Security=True";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void form_a_e_Load(object sender, EventArgs e)
        {
            this.angajati_EvenimenteTableAdapter.Fill(this.temaDataSet2.Angajati_Evenimente);
        }

        public void UpdateGridView()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Angajati_Evenimente", con); // vizualizarea datelor din tabela
            DataSet ds = new DataSet();
            da.Fill(ds, "Angajati_Evenimente");
            dataGridView1.DataSource = ds.Tables["Angajati_Evenimente"];
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            inserare_a_e form31 = new inserare_a_e();
            form31.ShowDialog();
            UpdateGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            stergere_a_e form32 = new stergere_a_e();
            form32.ShowDialog();
            UpdateGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update_a_e form33 = new update_a_e();
            form33.ShowDialog();
            UpdateGridView();
        }
    }
}
