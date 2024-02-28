using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class form_angajati : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public form_angajati()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-0OHL1Q8\SQLEXPRESS; Initial Catalog=Tema; Integrated Security=True";
        }

        private void form_angajati_Load(object sender, EventArgs e)
        {
            this.angajatiTableAdapter.Fill(this.temaDataSet.Angajati);

        }
        public void UpdateGridView()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Angajati", con); // vizualizarea datelor din tabela
            DataSet ds = new DataSet();
            da.Fill(ds, "Angajati");
            dataGridView1.DataSource = ds.Tables["Angajati"];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            inserare_angajat form19 = new inserare_angajat();
            form19.ShowDialog();
            UpdateGridView();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            stergere_angajat form20 = new stergere_angajat();
            form20.ShowDialog();
            UpdateGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update_angajat form21 = new update_angajat();
            form21.ShowDialog();
            UpdateGridView();
        }

        private void Ang_even_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Font = new Font("Courier New", 8);
            try
            {
                string query = "SELECT A.ID_angajat, A.Nume_angajat, AE.ID_eveniment FROM Angajati A, Angajati_Evenimente AE WHERE A.ID_angajat = AE.ID_angajat AND AE.ID_eveniment IN (SELECT AE2.ID_eveniment FROM Departamente D, Angajati_Evenimente AE2, Angajati A2 WHERE D.ID_manager = A2.ID_angajat AND A2.ID_departament = D.ID_departament AND D.ID_manager = AE2.ID_angajat) GROUP BY A.ID_angajat, A.Nume_angajat, AE.ID_eveniment";

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

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Font = new Font("Courier New", 8);
            try
            {
                string query = "SELECT A.Nume_angajat, A.Prenume_angajat FROM Angajati A WHERE A.ID_angajat NOT IN (SELECT DISTINCT A2.ID_angajat FROM Angajati A2, Angajati_Evenimente AE WHERE A2.ID_angajat = AE.ID_angajat)";

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
