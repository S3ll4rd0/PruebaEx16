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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            lblForm2Título.Text = "¿De La Vila i plores, cabra fotuda?";
            lblForm2Texto.Text = "Interpel·lar algú de la Vila Joiosa amb aquesta pregunta \n" +
                                 "és una petita ofensa: una ofensa còmplice, venial; \n" +
                                 "a penes una temptativa d'ofensa, si es vol. Però una ofensa.";
        }
    }
}
