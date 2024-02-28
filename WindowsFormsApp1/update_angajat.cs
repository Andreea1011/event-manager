using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class update_angajat : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public update_angajat()
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

                //verific daca exista un angajat cu acel ID in baza de date
                com.CommandText = "select count(*) from Angajati where ID_angajat = @ID_angajat";
                com.Parameters.AddWithValue("@ID_angajat", txtID_angajat.Text);

                int count = Convert.ToInt32(com.ExecuteScalar());
                int nr = 0;
                if (count == 0)
                {
                    MessageBox.Show("Nu exista niciun angajat cu acest ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtID_departament.Text != null)
                {
                    com.CommandText = "update Angajati set ID_departament = '" + txtID_departament.Text + "' where ID_angajat = '" + txtID_angajat.Text + "'";
                    nr++;
                }

                if (txtID_supervizor.Text != null)
                {
                    com.CommandText = "update Angajati set ID_supervizor= '" + txtID_supervizor.Text + "' where ID_angajat = '" + txtID_angajat.Text + "'";
                }

                if (txtNume_angajat.Text != null)
                {
                    com.CommandText = "update Angajati set Nume_angajat= '" + txtNume_angajat.Text + "' where ID_angajat = '" + txtID_angajat.Text + "'";

                }

                if (txtPrenume_angajat.Text != null)
                {
                    com.CommandText = "update Angajati set Prenume_angajat= '" + txtPrenume_angajat.Text + "' where ID_angajat = '" + txtID_angajat.Text + "'";

                }

                if (txtFunctie.Text != null)
                {
                    com.CommandText = "update Angajati set Functie= '" + txtFunctie.Text + "' where ID_angajat = '" + txtID_angajat.Text + "'";

                }

                if (txtSalariu.Text != null)
                {
                    com.CommandText = "update Angajati set Salariu= '" + txtSalariu.Text + "' where ID_angajat = '" + txtID_angajat.Text + "'";

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
