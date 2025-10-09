using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_G1
{
    public partial class FormFS : Form
    {
        public FormFS()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formulario = new FormMenu();
            formulario.Show();
        }

        private void FormFS_Load(object sender, EventArgs e)
        {
          
        }
    }
}
