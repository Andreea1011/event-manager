using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class form_evenimente : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public form_evenimente()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-0OHL1Q8\SQLEXPRESS; Initial Catalog=Tema; Integrated Security=True";
        }

        private void form_evenimente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'temaDataSet.Evenimente' table. You can move, or remove it, as needed.
            this.evenimenteTableAdapter.Fill(this.temaDataSet.Evenimente);

        }
        public void UpdateGridView()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Evenimente", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Evenimente");
            dataGridView1.DataSource = ds.Tables["Evenimente"];
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            inserare_eveniment form15 = new inserare_eveniment();
            form15.ShowDialog();
            UpdateGridView();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            stergere_eveniment form16 = new stergere_eveniment();
            form16.ShowDialog();
            UpdateGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update_eveniment form17 = new update_eveniment();
            form17.ShowDialog();
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
            listBox1.Items.Clear();
            listBox1.Font = new Font("Courier New", 8);
            try
            {
                string query = "SELECT E.Nume_eveniment, COUNT(FE.ID_furnizor) AS NrFurnizori FROM Evenimente E JOIN Furnizori_Evenimente FE ON E.ID_eveniment = FE.ID_eveniment GROUP BY E.Nume_eveniment";

                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                string columns = "";
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    columns += reader.GetName(i).PadRight(25); 
                }
                listBox1.Items.Add(columns);


                while (reader.Read())
                {
                    string item = "";

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        item += reader[i].ToString().PadRight(25);
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

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Font = new Font("Courier New", 8);
            try
            {
                string query = "SELECT E.Nume_eveniment, SUM(F.Pret_serviciu) AS PretTotal FROM Evenimente E INNER JOIN Furnizori_Evenimente FE ON FE.ID_eveniment = E.ID_eveniment INNER JOIN Furnizori F ON F.ID_furnizor = FE.ID_furnizor GROUP BY E.Nume_eveniment ORDER BY SUM(F.Pret_serviciu) DESC";

                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                string columns = "";
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    columns += reader.GetName(i).PadRight(25);
                }
                listBox1.Items.Add(columns);


                while (reader.Read())
                {
                    string item = "";

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        item += reader[i].ToString().PadRight(25);
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
