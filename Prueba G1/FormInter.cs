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
    public partial class FormInter : Form
    {
        public FormInter()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
            Form formulario = new FormMenu();
            formulario.Show();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();  
            Form formulario = new FormConsulta();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show(
        "¿Quieres cerrar la sesión?",
        "Confirmar cierre de sesión",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (respuesta == DialogResult.Yes)
            {
                // Volver al formulario de Login
                FormLogin login = new FormLogin();
                login.Show();
                this.Close(); // o this.Hide(), según prefieras
            }
        }

        private void button4_Click(object sender, EventArgs e)
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
    }
}
