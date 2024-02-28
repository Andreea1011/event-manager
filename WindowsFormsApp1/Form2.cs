using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        // butoanele care duc catre fiecare tabela
        private void btnClienti_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_clienti form3 = new form_clienti();
            form3.Show();
        }

        private void btnLocatie_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_locatie form7 = new form_locatie();
            form7.Show();
        }

        private void btnFurnizori_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_furnizori form10 = new form_furnizori();
            form10.Show();
        }

        private void btnEvenimente_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_evenimente form14 = new form_evenimente();
            form14.Show();
        }

        private void btnAngajati_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_angajati form18 = new form_angajati();
            form18.Show();
        }

        private void btnDepartamente_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_departamente form22 = new form_departamente();
            form22.Show();
        }

        private void btnFurnizoriEvenimente_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_f_e form26 = new form_f_e();
            form26.Show();
        }

        private void btnAngajatiEvenimente_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_a_e form30 = new form_a_e();
            form30.Show();
        }
    }
}
