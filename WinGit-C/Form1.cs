using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGit_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bVerMensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MENSAJE DESDE EL PRIMER BOTON DE MENSAJES");
        }
    }
}
