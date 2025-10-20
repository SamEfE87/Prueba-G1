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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void AbrirFueraDeServicio(object sender, EventArgs e)
        {
            Form formulario = new FormFS(); 
            formulario.Show();
            this.Close();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                
                foreach (ToolStripMenuItem subItem in item.DropDownItems)
                {
                    subItem.Click += AbrirFueraDeServicio;
                }
            }
        }

        private void buttonCerrarS_Click_1(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show(
       "¿Quieres cerrar la sesión?",
       "Confirmar cierre de sesión",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
   );

            if (respuesta == DialogResult.Yes)
            {
               
                FormLogin login = new FormLogin();
                login.Show();
                this.Close(); 
            }
        }
        

        private void buttonSalir_Click_1(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show(
       "¿Está seguro de cerrar el sistema?",
       "Confirmar salida",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Warning
   );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void propiedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formulario = new FormInter();
            formulario.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
