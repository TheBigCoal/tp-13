using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu.cs
{
    public partial class Registro : Form
    {
        Login ventanaLogin;
        Menu ventanamenu;
        public Registro()
        {
            InitializeComponent();
            ventanaLogin = new Login();

            
        }
        public void referenciarventanamenu(Menu ventanamenu)
        {
            this.ventanamenu = ventanamenu;
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ventanamenu.Visible = true;
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnombre.Text != "")
                {
                    if (txtcontra.Text != "")
                    {
                        if (txtcontra.Text == txtconfirma.Text)
                        {
                            string username = txtnombre.Text;
                            string password = txtconfirma.Text;
                            MessageBox.Show("Registro de sesión exitoso", "Registro completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtnombre.Text = "";
                            txtcontra.Text = "";
                            txtconfirma.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Por favor confirme la contraseña", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtconfirma.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese la contraseña", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese el nombre de usuario", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ventanaLogin.referenciarventanaRegistro(this);
            ventanaLogin.Visible = true;
        }
    }
}
