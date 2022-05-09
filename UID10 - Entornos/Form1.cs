using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UID10___Entornos
{
    public partial class Form1 : Form
    {
        List<Socios> socios;
        public Form1()
        {
            InitializeComponent();
        }

        private void guardar_socio(object sender, EventArgs e)
        {
            if(socios == null || socios.Count == 0)
            {
                socios = new List<Socios>();
                socios.Add(new Socios(tNombre.Text, tApellidos.Text, tTelefono.Text));
            }
            else
            {
                socios.Add(new Socios(tNombre.Text, tApellidos.Text, tTelefono.Text));
            }

            string[] socioss = new string[socios.Count];
            for (int i = 0; i < socios.Count; i++)
            {
                socioss[i] = socios[i].Nombre + " " + socios[i].Apellidos + " | " + socios[i].Telefono;
            }
            tListaSocios.Lines = socioss;
        }

        private void tListaSocios_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
