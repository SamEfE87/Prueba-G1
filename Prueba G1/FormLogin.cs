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
    public partial class FormLogin : Form
    {
        ToolTip mensaje = new ToolTip();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = buttonLogin;
            // Llenar el ComboBox con los usuarios
            comboBoxUsuario.Items.Add("Vendedor1");
            comboBoxUsuario.Items.Add("Vendedor2");
            comboBoxUsuario.Items.Add("ADMIN");

            // Por defecto, ocultar contraseña
            labelPassword.Visible = false;
            textBoxPassword.Visible = false;
            btnMostrar.Visible = false; 
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si es ADMIN, mostrar campo de contraseña
            if (comboBoxUsuario.SelectedItem.ToString() == "ADMIN")
            {
                labelPassword.Visible = true;
                textBoxPassword.Visible = true;
                btnMostrar.Visible = true;  
            }
            else
            {
                labelPassword.Visible = false;
                textBoxPassword.Visible = false;
                btnMostrar.Visible = false; 
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear(); // Limpia errores anteriores

            if (string.IsNullOrWhiteSpace(comboBoxUsuario.Text))
            {
                errorProvider1.SetError(comboBoxUsuario, "Seleccione un usuario");
                return;
            }

            if (comboBoxUsuario.Text == "ADMIN" && string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                errorProvider1.SetError(textBoxPassword, "Ingrese la contraseña");
                return;
            }


            string usuario = comboBoxUsuario.Text;
            string contraseña = textBoxPassword.Text;

            if (usuario == "")
            {
                mensaje.Show("Seleccione un usuario", comboBoxUsuario, 0, -40, 2000);
                return;
            }

            // Validación
            if (usuario == "ADMIN")
            {
                if (contraseña != "1234")
                {
                    mensaje.Show("Contraseña incorrecta", textBoxPassword, 0, -40, 2000);
                    return;
                }
            }

            // Si pasa validación
            mensaje.Show("Sesión iniciada con éxito", buttonLogin, 0, -40, 2000);

            // Mostrar mensaje adicional
            MessageBox.Show("Bienvenido " + usuario + "!", "Inicio de sesión");

            // Abrir el siguiente formulario
            FormMenu siguiente = new FormMenu();
            siguiente.Show();
            this.Hide();
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
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

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
        }
    }
    
}
