using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-0OHL1Q8\SQLEXPRESS; Initial Catalog=Tema; Integrated Security=True";

            //con.ConnectionString = @"Data Source = DESKTOP - 0OHL1Q8\SQLEXPRESS; Initial Catalog = Tema; Integrated Security = True";
        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(@"username"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = @"username";
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("password"))
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "password";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Date_Login";
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (txtUsername.Text.Equals(dr["username"].ToString()) && txtPassword.Text.Equals(dr["password"].ToString()))
                {
                    MessageBox.Show("Logare cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Nume sau parola gresita", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
