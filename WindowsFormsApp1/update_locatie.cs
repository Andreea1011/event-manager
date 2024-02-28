using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class update_locatie : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public update_locatie()
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
                com.CommandText = "select count(*) from Locatie where ID_locatie = @ID_locatie";
                com.Parameters.AddWithValue("@ID_locatie", txtID_locatie.Text);

                int count = Convert.ToInt32(com.ExecuteScalar());
                int nr = 0;
                if (count == 0)
                {
                    MessageBox.Show("Nu exista nicio locatie cu acest ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtNume_locatie.Text != null)
                {
                    com.CommandText = "update Locatie set Nume_locatie = '" + txtNume_locatie.Text + "' where ID_locatie = '" + txtID_locatie.Text + "'";
                    nr++;
                }

                if (txtAdresa_locatie.Text != null)
                {
                    com.CommandText = "update Locatie set Adresa_locatie = '" + txtAdresa_locatie.Text + "' where ID_locatie = '" + txtID_locatie.Text + "'";
                }

                if (txtCapacitate_maxima.Text != null)
                {
                    com.CommandText = "update Locatie set Capacitate_maxima = '" + txtCapacitate_maxima.Text + "' where ID_locatie = '" + txtID_locatie.Text + "'";

                }

                if (nr != 0)
                {
                    com.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    this.Hide();
                }
                //com.CommandText = "insert into Clienti(ID_client,Nume_client,Prenume_client,Nr_tel) values('" + txtID_client.Text + "','" + txtNume_client.Text + "','" + txtPrenume_client.Text + "', '" + txtNr_tel.Text + "')";
                //com.ExecuteNonQuery();
                //MessageBox.Show("Datele au fost introduse cu succes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //con.Close();
                //this.Hide();
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

            // Optionally, clear the fields or hide the form here after insertion.
            this.Hide();
        }
    }
}
