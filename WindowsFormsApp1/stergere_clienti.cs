using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class stergere_clienti : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();

        public stergere_clienti()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-0OHL1Q8\SQLEXPRESS; Initial Catalog=Tema; Integrated Security=True";
        }

        private void txtID_client_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.Connection = con;

                //verific daca exista acel ID in baza de date pentru a fi sterse datele despre acel client
                com.CommandText = "select count(*) from Clienti where ID_client = @ID_client";
                com.Parameters.AddWithValue("@ID_client", txtID_client.Text);

                int count = Convert.ToInt32(com.ExecuteScalar());
                if (count == 0)
                {
                    MessageBox.Show("Nu exista un client cu acest ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                com.CommandText = "delete from Clienti where ID_client = '" + txtID_client.Text + "'";
                com.ExecuteNonQuery();
                MessageBox.Show("Datele au fost sterse cu succes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                this.Hide();
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
