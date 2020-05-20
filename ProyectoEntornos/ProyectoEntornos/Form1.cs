using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEntornos
{
    public partial class bVeigar : Form
    {
        public bVeigar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tListaSocios.Text += tNombre.Text + tApellidos.Text + tTelefono.Text + "\n";
        }
    }
}
