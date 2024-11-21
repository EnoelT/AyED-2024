using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) >= 19)
            {
                if (comboBox1.Text == "100,001 - 200,000" || comboBox1.Text == "Más de 200,000")
                {
                    MessageBox.Show("la beca ha sido aceptada");
                }
                else
                {
                    MessageBox.Show("la beca ha sido rechazada\n ingresos invalidos");
                }
            }
            else
            {
                MessageBox.Show("la beca ha sido rechazada\n edad invalida");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}