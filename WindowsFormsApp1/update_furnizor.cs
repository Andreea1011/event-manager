using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   
    public partial class update_furnizor : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public update_furnizor()
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
                com.CommandText = "select count(*) from Furnizori where ID_furnizor = @ID_furnizor";
                com.Parameters.AddWithValue("@ID_furnizor", txtID_furnizor.Text);

                int count = Convert.ToInt32(com.ExecuteScalar());
                int nr = 0;
                if (count == 0)
                {
                    MessageBox.Show("Nu exista niciun furnizor cu acest ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtNume_furnizor.Text != null)
                {
                    com.CommandText = "update Furnizor set Nume_furnizor = '" + txtNume_furnizor.Text + "' where ID_furnizor = '" + txtID_furnizor.Text + "'";
                    nr++;
                }

                if (txtTip_serviciu.Text != null)
                {
                    com.CommandText = "update Furnizor set Tip_serviciu = '" + txtTip_serviciu.Text + "' where ID_furnizor = '" + txtID_furnizor.Text + "'";
                }

                if (txtPret_serviciu.Text != null)
                {
                    com.CommandText = "update Furnizori set Pret_serviciu = '" + txtPret_serviciu.Text + "' where ID_furnizor = '" + txtID_furnizor.Text + "'";

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
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            this.Hide();
        }
    }
}
