using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    public partial class inserare_clienti : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public inserare_clienti()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-0OHL1Q8\SQLEXPRESS; Initial Catalog=Tema; Integrated Security=True";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.Connection = con;

                //verific daca exista deja acel ID in baza de date
                com.CommandText = "select count(*) from Clienti where ID_client = @ID_client";
                com.Parameters.AddWithValue("@ID_client", txtID_client.Text);

                int count = Convert.ToInt32(com.ExecuteScalar());
                if(count > 0)
                    {
                        MessageBox.Show("Deja exista un client cu acest ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                com.CommandText = "insert into Clienti(ID_client,Nume_client,Prenume_client,Nr_tel) values('" + txtID_client.Text + "','" + txtNume_client.Text + "','" + txtPrenume_client.Text + "', '" + txtNr_tel.Text + "')";
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

        private void txtID_client_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
