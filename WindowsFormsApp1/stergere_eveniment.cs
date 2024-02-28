using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class stergere_eveniment : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public stergere_eveniment()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-0OHL1Q8\SQLEXPRESS; Initial Catalog=Tema; Integrated Security=True";
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.Connection = con;

                //verific daca exista acel ID in baza de date pentru a fi sterse datele despre acel eveniment
                com.CommandText = "select count(*) from Evenimente where ID_eveniment = @ID_eveniment";
                com.Parameters.AddWithValue("@ID_eveniment", txtID_eveniment.Text);

                int count = Convert.ToInt32(com.ExecuteScalar());
                if (count == 0)
                {
                    MessageBox.Show("Nu exista un eveniment cu acest ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                com.CommandText = "delete from Eveniment where ID_eveniment = '" + txtID_eveniment.Text + "'";
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
