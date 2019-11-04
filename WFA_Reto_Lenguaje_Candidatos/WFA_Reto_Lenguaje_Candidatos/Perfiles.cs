using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Reto_Lenguaje_Candidatos
{
    public partial class Perfiles : Form
    {
        public String Nombres ;

        public Perfiles()
        {
            InitializeComponent();
        }
        
        private void Btt_Senior_Click(object sender, EventArgs e)
        {
             Nombres = "Desarrollador Senior";
            this.Hide();
        }

        private void Btt_Director_Click(object sender, EventArgs e)
        {
             Nombres = "Director de Proyectos";
            this.Close();
        }

        private void Btt_Junior_Click(object sender, EventArgs e)
        {
             Nombres = "Desarrollador Junior";
            this.Close();
        }

    }
}
