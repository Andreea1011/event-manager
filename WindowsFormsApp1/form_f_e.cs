using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class form_f_e : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public form_f_e()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-0OHL1Q8\SQLEXPRESS; Initial Catalog=Tema; Integrated Security=True";
        }

        private void form_f_e_Load(object sender, EventArgs e)
        {
            this.furnizori_EvenimenteTableAdapter.Fill(this.temaDataSet.Furnizori_Evenimente);

        }
        public void UpdateGridView()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Furnizori_Evenimente", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Furnizori_Evenimente");
            dataGridView1.DataSource = ds.Tables["Furnizori_Evenimente"];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            inserare_f_e form27 = new inserare_f_e();
            form27.ShowDialog();
            UpdateGridView();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            stergere_f_e form28 = new stergere_f_e();
            form28.ShowDialog();
            UpdateGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update_f_e form29 = new update_f_e();
            form29.ShowDialog();
            UpdateGridView();
        }
    }
}
