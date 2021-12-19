using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleDatabaseWalkthrought
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.reserva' Puede moverla o quitarla según sea necesario.
            this.reservaTableAdapter.Fill(this.database1DataSet.reserva);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reservaTableAdapter.agregar(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, numericUpDown1.Value, numericUpDown2.Value);
            this.reservaTableAdapter.Fill(this.database1DataSet.reserva);
        }
    }
}
