using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class form_clienti : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public form_clienti()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-0OHL1Q8\SQLEXPRESS; Initial Catalog=Tema; Integrated Security=True";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void form_clienti_Load(object sender, EventArgs e)
        {
            this.clientiTableAdapter.Fill(this.temaDataSet.Clienti);
        }

        public void UpdateGridView()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Clienti", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Clienti");
            dataGridView1.DataSource = ds.Tables["Clienti"];
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            inserare_clienti form4 = new inserare_clienti();
            form4.ShowDialog();
            UpdateGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stergere_clienti form5 = new stergere_clienti();
            form5.ShowDialog();
            UpdateGridView();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            update_clienti form6 = new update_clienti();
            form6.ShowDialog();
            UpdateGridView();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Font = new Font("Courier New", 8);
            try
            {
                string query = "SELECT C.Nume_client, C.Prenume_client, COUNT(E.ID_client) AS NrEvenimente FROM Clienti C JOIN Evenimente E ON C.ID_client = E.ID_client GROUP  BY C.Nume_client, C.Prenume_client ORDER BY NrEvenimente DESC";

                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                string columns = "";
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    columns += reader.GetName(i).PadRight(20); // Append each column name, separated by space
                }
                listBox1.Items.Add(columns); // Add the column names as the first item


                while (reader.Read())
                {
                    string item = "";

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        item += reader[i].ToString().PadRight(20);
                    }

                    listBox1.Items.Add(item);
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ceva nu e bine " + ex.Message);
            }
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxVal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
