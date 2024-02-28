using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class form_departamente : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public form_departamente()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-0OHL1Q8\SQLEXPRESS; Initial Catalog=Tema; Integrated Security=True";
        }

        private void form_departamente_Load(object sender, EventArgs e)
        {
            this.departamenteTableAdapter.Fill(this.temaDataSet.Departamente);

        }
        public void UpdateGridView()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Departamente", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Departamente");
            dataGridView1.DataSource = ds.Tables["Departamente"];
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            inserare_departamente form23 = new inserare_departamente();
            form23.ShowDialog();
            UpdateGridView();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            stergere_departamente form24 = new stergere_departamente();
            form24.ShowDialog();
            UpdateGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update_departamente form25 = new update_departamente();
            form25.ShowDialog();
            UpdateGridView();
        }

        private void Dep_interogare1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Font = new Font("Courier New", 8);
            try
            {
                string query = "SELECT D.Nume_departament, AVG(A.Salariu) AS MedieSalariu FROM Departamente D, Angajati A WHERE A.ID_departament = D.ID_departament GROUP BY D.ID_departament, D.Nume_departament HAVING AVG(A.Salariu) > (SELECT AVG(Salariu) FROM Angajati)";

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

                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        item += reader[i].ToString().PadRight(20);
                    }

                    listBox1.Items.Add(item);
                }
                reader.Close();
                con.Close();
            }
            catch(Exception ex)
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
                string query = "SELECT D.Nume_departament, COUNT(A.ID_angajat) AS Numar_Angajati FROM Departamente D JOIN Angajati A ON D.ID_departament = A.ID_departament WHERE D.Nume_departament = '" + txtBoxVal.Text + "' GROUP BY D.Nume_departament";

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
