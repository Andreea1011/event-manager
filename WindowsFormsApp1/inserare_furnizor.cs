using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class inserare_furnizor : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public inserare_furnizor()
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
                com.CommandText = "select count(*) from Furnizori where ID_furnizor = @ID_furnizor";
                com.Parameters.AddWithValue("@ID_furnizor", txtID_furnizor.Text);

                int count = Convert.ToInt32(com.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Deja exista un furnizor cu acest ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                com.CommandText = "insert into Furnizori(ID_furnizor,Nume_furnizor,Tip_serviciu,Pret_serviciu) values('" + txtID_furnizor.Text + "','" + txtNume_furnizor.Text + "','" + txtTip_serviciu.Text + "', '" + txtPret_serviciu.Text + "')";
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
    }
}
