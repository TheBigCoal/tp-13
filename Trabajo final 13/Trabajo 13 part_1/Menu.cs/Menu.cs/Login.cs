using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Menu.cs
{
    public partial class Login : Form
    {
        Registro ventanaRegistro;
        //string userlogin;
        //string passlogin;
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        public Login()
        {
            InitializeComponent();
            connection.ConnectionString = @"Data Source=DESKTOP-SAC7IAI;Initial Catalog=trabajo_12;Integrated Security=True";
        }

        public void referenciarventanaRegistro(Registro ventanaRegistro)
        {
            this.ventanaRegistro = ventanaRegistro;
        }

        private void btn_volver1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ventanaRegistro.Visible = true;
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnombre.Text != "")
                {
                    if (txtcontra.Text != "")
                    {
                        command.Connection = connection;
                        connection.Open();
                        command.CommandText = "SELECT * FROM Registro WHERE nombre_usuario = @txtnombre_usuario";
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("txtnombre_usuario", txtnombre.Text);

                        SqlDataReader reader = command.ExecuteReader();

                        if(reader.Read())
                        {
                            string username = reader.GetString(1);
                            string password = reader.GetString(2);
                            if (txtcontra.Text == password)
                            {
                            MessageBox.Show("Bienvenido a la aplicación", "Registro completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                             else
                            {
                             MessageBox.Show("La contraseña ingresada es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show("El nombre de usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese el nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            command.Dispose();
            connection.Close();
        }
    }
}
