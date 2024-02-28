using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class update_eveniment : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public update_eveniment()
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

                //verific daca exista un eveniment cu acel ID in baza de date
                com.CommandText = "select count(*) from Evenimente where ID_eveniment = @ID_eveniment";
                com.Parameters.AddWithValue("@ID_eveniment", txtID_eveniment.Text);

                int count = Convert.ToInt32(com.ExecuteScalar());
                int nr = 0;
                if (count == 0)
                {
                    MessageBox.Show("Nu exista niciun eveniment cu acest ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtID_locatie.Text != null)
                {
                    com.CommandText = "update Eveniment set ID_locatie = '" + txtID_locatie.Text + "' where ID_eveniment = '" + txtID_eveniment.Text + "'";
                    nr++;
                }

                if (txtID_client.Text != null)
                {
                    com.CommandText = "update Eveniment set ID_client= '" + txtID_client.Text + "' where ID_eveniment = '" + txtID_eveniment.Text + "'";
                }

                if (txtNume_eveniment.Text != null)
                {
                    com.CommandText = "update Eveniment set Nume_eveniment= '" + txtNume_eveniment.Text + "' where ID_eveniment = '" + txtID_eveniment.Text + "'";

                }

                if (txtData_eveniment.Text != null)
                {
                    com.CommandText = "update Eveniment set Data_eveniment= '" + txtData_eveniment.Text + "' where ID_eveniment = '" + txtID_eveniment.Text + "'";

                }

                if (txtNumar_invitati.Text != null)
                {
                    com.CommandText = "update Eveniment set Numar_invitati= '" + txtNumar_invitati.Text + "' where ID_eveniment = '" + txtID_eveniment.Text + "'";

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
