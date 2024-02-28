using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class form_furnizori : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public form_furnizori()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-0OHL1Q8\SQLEXPRESS; Initial Catalog=Tema; Integrated Security=True";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void form_furnizori_Load(object sender, EventArgs e)
        {
            this.furnizoriTableAdapter.Fill(this.temaDataSet.Furnizori);
        }

        public void UpdateGridView()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Furnizori", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Furnizori");
            dataGridView1.DataSource = ds.Tables["Furnizori"];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void form_furnizori_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'temaDataSet1.Furnizori' table. You can move, or remove it, as needed.
            this.furnizoriTableAdapter1.Fill(this.temaDataSet1.Furnizori);

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            inserare_furnizor form11 = new inserare_furnizor();
            form11.ShowDialog();
            UpdateGridView();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            stergere_furnizor form12 = new stergere_furnizor();
            form12.ShowDialog();
            UpdateGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update_furnizor form13 = new update_furnizor();
            form13.ShowDialog();
            UpdateGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Font = new Font("Courier New", 8);
            try
            {
                string query = "SELECT F.Nume_furnizor, COUNT(FE.ID_eveniment) AS NrEvenimente FROM Furnizori F INNER JOIN Furnizori_Evenimente FE ON F.ID_furnizor = FE.ID_furnizor GROUP BY F.Nume_furnizor HAVING COUNT(FE.ID_eveniment) = (SELECT MAX(NrEvenimente) FROM (SELECT COUNT(ID_eveniment) AS NrEvenimente FROM Furnizori_Evenimente GROUP BY ID_furnizor)AS NrEven)";

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
    }
}
