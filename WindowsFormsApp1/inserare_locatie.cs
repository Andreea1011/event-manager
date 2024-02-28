using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class inserare_locatie : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public inserare_locatie()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-0OHL1Q8\SQLEXPRESS; Initial Catalog=Tema; Integrated Security=True";
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.Connection = con;

                //verific daca exista deja acel ID in baza de date
                com.CommandText = "select count(*) from Locatie where ID_locatie = @ID_locatie";
                com.Parameters.AddWithValue("@ID_locatie", txtID_locatie.Text);

                int count = Convert.ToInt32(com.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Deja exista o locatie cu acest ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                com.CommandText = "insert into Locatie(ID_Locatie,Nume_locatie,Adresa_locatie,Capacitate_maxima) values('" + txtID_locatie.Text + "','" + txtNume_locatie.Text + "','" + txtAdresa_locatie.Text + "', '" + txtCapacitate_maxima.Text + "')";
                com.ExecuteNonQuery();
                MessageBox.Show("Datele au fost introduse cu succes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            // Optionally, clear the fields or hide the form here after insertion.
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCapacitate_maxima_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdresa_locatie_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNume_locatie_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_locatie_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
