using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SatzDesPythagoras
{
    public partial class SatzDesPythagorasForm : Form
    {
        public SatzDesPythagorasForm()
        {
            InitializeComponent();
        }

        private void berechnenButton_Click(object sender, EventArgs e)
        {
            // Deklaration der Variablen
            double a, b, c;

            // Lesen der Seitenlšnge der Katheten
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            // Berechnung der Seitenlšnge der Hypotenuse
            c = Math.Pow(a * a + b * b, 0.5);
            // c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            // Ausgabe der Seitenlšnge der Hypotenuse
            label4.Text = c.ToString();
        }
    }
}