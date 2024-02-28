using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class update_departamente : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public update_departamente()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-0OHL1Q8\SQLEXPRESS; Initial Catalog=Tema; Integrated Security=True";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.Connection = con;

                //verific daca exista un departament cu acel ID in baza de date
                com.CommandText = "select count(*) from Departamente where ID_departament = @ID_departament";
                com.Parameters.AddWithValue("@ID_departament", txtID_departament.Text);

                int count = Convert.ToInt32(com.ExecuteScalar());
                int nr = 0;
                if (count == 0)
                {
                    MessageBox.Show("Nu exista niciun departament cu acest ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtID_manager.Text != null)
                {
                    com.CommandText = "update Departamente set ID_manager = '" + txtID_manager.Text + "' where ID_departament = '" + txtID_departament.Text + "'";
                    nr++;
                }

                if (txtNume_departament.Text != null)
                {
                    com.CommandText = "update Departamente set Nume_departament = '" + txtNume_departament.Text + "' where ID_departament = '" + txtID_departament.Text + "'";
                }

                if (nr != 0)
                {
                    com.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    this.Hide();
                }
            }

            catch (Exception ex)
            {
                // Show a general error message or log the exception.
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure that the connection is closed even if an exception occurs.
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            this.Hide();
        }
    }
}
