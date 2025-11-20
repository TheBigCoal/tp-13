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
    public partial class Menu : Form
    {
        Registro ventanaregistro;
        public Menu()
        {
            InitializeComponent();
            ventanaregistro = new Registro();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ventanaregistro.referenciarventanamenu(this);
            ventanaregistro.Visible = true;
        }
    }
}
