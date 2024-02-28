using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class update_clienti : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public update_clienti()
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

                //verific daca exista un client cu acel ID in baza de date
                com.CommandText = "select count(*) from Clienti where ID_client = @ID_client";
                com.Parameters.AddWithValue("@ID_client", txtID_client.Text);

                int count = Convert.ToInt32(com.ExecuteScalar());
                int nr = 0;
                if (count == 0)
                {
                    MessageBox.Show("Nu exista niciun client cu acest ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(txtNume_client.Text != null)
                {
                    com.CommandText = "update Clienti set Nume_client = '" + txtNume_client.Text + "' where ID_client = '" + txtID_client.Text + "'";
                    nr++;
                }

                if(txtPrenume_client.Text != null)
                {
                    com.CommandText = "update Clienti set Prenume_client = '" + txtPrenume_client.Text + "' where ID_client = '" + txtID_client.Text + "'";
                }

                if(txtNr_tel.Text != null)
                {
                    com.CommandText = "update Clienti set Nr_tel = '" + txtNr_tel.Text + "' where ID_client = '" + txtID_client.Text + "'";

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
