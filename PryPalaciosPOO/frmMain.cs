using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryPalaciosPOO
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            ClassPersonaje objeto = new ClassPersonaje();
            objeto.nombre =  txtNombre.Text;
            objeto.fuerza = Convert.ToInt32(txtFuerza.Text);
            objeto.destreza = int.Parse(txtFuerza.Text);

            lblInfo.Text=objeto.nombre+"-"+
              objeto.fuerza+"-"+
              objeto.destreza + "\n";

        }
    }
}
