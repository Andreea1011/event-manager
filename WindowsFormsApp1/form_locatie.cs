using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class form_locatie : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public form_locatie()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-0OHL1Q8\SQLEXPRESS; Initial Catalog=Tema; Integrated Security=True";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void form_locatie_Load(object sender, EventArgs e)
        {
            this.locatieTableAdapter.Fill(this.temaDataSet.Locatie);
        }
        public void UpdateGridView()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Locatie", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Locatie");
            dataGridView1.DataSource = ds.Tables["Locatie"];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            inserare_locatie form7 = new inserare_locatie();
            form7.ShowDialog();
            UpdateGridView();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            stergere_locatie form8 = new stergere_locatie();
            form8.ShowDialog();
            UpdateGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update_locatie form9 = new update_locatie();
            form9.ShowDialog();
            UpdateGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Font = new Font("Courier New", 8);
            try
            {
                string query = "SELECT L.Nume_locatie, COUNT(E.ID_eveniment) AS NrEvenimente, AVG(E.Numar_invitati) AS MedieInvitati FROM Locatie L JOIN Evenimente E ON L.ID_locatie = E.ID_locatie GROUP BY L.Nume_locatie";

                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                string columns = "";
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    columns += reader.GetName(i).PadRight(20); 
                }
                listBox1.Items.Add(columns); 

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

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Font = new Font("Courier New", 8);
            try
            {
                string query = "SELECT Nume_client, Prenume_client FROM Clienti WHERE ID_client IN (SELECT E.ID_client FROM Evenimente E JOIN Locatie L ON E.ID_locatie = L.ID_locatie WHERE L.Nume_locatie = '" + txtBoxVal.Text + "')";

                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                string columns = "";
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    columns += reader.GetName(i).PadRight(20);
                }
                listBox1.Items.Add(columns);


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

