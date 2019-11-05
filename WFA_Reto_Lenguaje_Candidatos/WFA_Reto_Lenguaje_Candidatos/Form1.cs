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
    public partial class Form1 : Form
    {
        Controladores Controladores = new Controladores();
        int Ncedula = 0;
        Dictionary<int, double> Notas = new Dictionary<int, double>();
        Perfiles Perfiles = new Perfiles();

        public Form1()
        {
            InitializeComponent();
        }

        private void Btt_Volver_Click(object sender, EventArgs e)
        {
            Controladores.VaciarTextBox(this);
            GbCalificaciones.Enabled = false;
            GbCandidato.Enabled = false;
            GbPorcentaje.Enabled = true;
            for (int i = DGV_NotaFinales.Rows.Count-1; i >=0; i--)
            {
                DGV_NotaFinales.Rows.RemoveAt(i);
            }
            Controladores.index = 1;
            Notas.Clear();
            Controladores.valorporcentual.Clear();
            Controladores.Ordenado.Clear();
            Perfiles.ShowDialog();
            this.Text = Perfiles.Nombres;
        }

        private void Btt_Agregar_Click(object sender, EventArgs e)
        {
            var controls = Controladores.TodosLosTextBoxs(this.GbPorcentaje);
            int Suma = 0;
            foreach (Control Txt in controls)
            {
                if (Txt.Text == "")
                {
                    Txt.BackColor = Color.FromArgb(255, 63, 63);
                    MessageBox.Show("Todos los campos resaltados son obligatorios", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Controladores.index = 1;
                }
                else
                {
                    Controladores.AddPorcentajes(Txt.Text);
                    Suma += int.Parse(Txt.Text);
                    Txt.BackColor = Color.White;
                }
            }
            if (Suma == 100)
            {
                GbPorcentaje.Enabled = false;
                GbCalificaciones.Enabled = true;
                GbCandidato.Enabled = true;
            }
            else
            {
                MessageBox.Show("La suma de los valores debe ser 100% \nLos valores ingresados no son correctos \nPor favor ingreselos nuevamente", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Controladores.index = 1;
            }
        }
        
        private void Btt_Agregar3_Click(object sender, EventArgs e)
        {
            Controladores.Controlador = true;
            if (TxtBoxCedula.Text == "")
            {
                TxtBoxCedula.BackColor = Color.FromArgb(255, 63, 63);
                MessageBox.Show("Todos los campos resaltados son obligatorios", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Controladores.Controlador = false;
            }
            else
            {
                Ncedula = int.Parse(TxtBoxCedula.Text);
                TxtBoxCedula.BackColor = Color.White;
            }
            Controladores.ObtenerCalificaciones(this.GbCalificaciones);
            if (Controladores.Controlador == false) { }
            else
            {
                if (Notas.ContainsKey(Ncedula))
                {
                    Notas[Ncedula] = Controladores.SumaNotas;
                    for (int i = DGV_NotaFinales.Rows.Count - 1; i >= 0; i--)
                    {
                        DGV_NotaFinales.Rows.RemoveAt(i);
                    }
                    foreach (var item in Notas)
                    {
                        DGV_NotaFinales.Rows.Add(item.Key, item.Value);
                    }
                }
                else
                {
                    Notas.Add(Ncedula, Controladores.SumaNotas);
                    DGV_NotaFinales.Rows.Add(Ncedula, Controladores.SumaNotas);
                }
                Controladores.VaciarTextBox(this.GbCalificaciones);
                Controladores.VaciarTextBox(this.GbCandidato);
            }
            Controladores.SumaNotas = 0;
            Controladores.indexs = 1;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controladores.SoloNumeros(this);
            GbCalificaciones.Enabled = false;
            GbCandidato.Enabled = false;
            Perfiles.ShowDialog();
            this.Text = Perfiles.Nombres ;
        }

        private void Btt_Ordenar_Click(object sender, EventArgs e)
        {
            for (int i = DGV_NotaFinales.Rows.Count - 1; i >= 0; i--)
            {
                DGV_NotaFinales.Rows.RemoveAt(i);
            }
            Controladores.OrderInsertion(Notas);
            foreach (var item in Controladores.Ordenado)
            {
                DGV_NotaFinales.Rows.Add(item.Key,item.Value);
            }

        }
    }
}
