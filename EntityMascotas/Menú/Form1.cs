using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menú
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRecetas_Click(object sender, EventArgs e)
        {
            Form2 Re = new Form2();
            Re.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnimales_Click(object sender, EventArgs e)
        {
            Form3 An = new Form3();
            An.Show();
        }
    }
}
