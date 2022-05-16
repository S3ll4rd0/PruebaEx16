using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaEx16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            lblForm1.Text = "Has introducido en el Text Box:\n" + textBoxForm1.Text;
        }
    }
}
