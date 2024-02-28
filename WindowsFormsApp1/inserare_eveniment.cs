using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class inserare_eveniment : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public inserare_eveniment()
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
                com.CommandText = "select count(*) from Evenimente where ID_eveniment = @ID_eveniment";
                com.Parameters.AddWithValue("@ID_eveniment", txtID_eveniment.Text);

                int count = Convert.ToInt32(com.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Deja exista un eveniment cu acest ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                com.CommandText = "insert into Evenimente(ID_eveniment,ID_locatie,ID_client,Nume_eveniment,Data_eveniment,Numar_invitati) values('" + txtID_eveniment.Text + "','" + txtID_locatie.Text + "','" + txtID_client.Text + "', '" + txtNume_eveniment.Text + "','" + txtData_eveniment.Text + "', '" + txtNumar_invitati.Text + "')";
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


            this.Hide();
        }
    }
}
