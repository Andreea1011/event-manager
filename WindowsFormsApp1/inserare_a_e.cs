using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class inserare_a_e : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public inserare_a_e()
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
                com.CommandText = "select count(*) from Angajati_Evenimente where ID_angajati_evenimente = @ID_angajati_evenimente";
                com.Parameters.AddWithValue("@ID_angajati_evenimente", txtID_angajati_evenimente.Text);

                int count = Convert.ToInt32(com.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Deja exista date cu acest ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                com.CommandText = "insert into Angajati_Evenimente(ID_angajati_evenimente,ID_eveniment,ID_angajat) values('" + txtID_angajati_evenimente.Text + "','" + txtID_eveniment.Text + "','" + txtID_angajat.Text + "')";
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
