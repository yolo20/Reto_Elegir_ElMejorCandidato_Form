using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WFA_Reto_Lenguaje_Candidatos
{
    class Controladores : Form
    {
        public Dictionary<int, double> valorporcentual = new Dictionary<int, double>();
        public Dictionary<int, double> Ordenado = new Dictionary<int, double>();
        public int index = 1;
        public int indexs = 1;
        public double SumaNotas = 0;
        public bool Controlador = true; 

        public void AddPorcentajes(string Txt)
        {
            double Porcentajes = 0;
            Porcentajes = double.Parse(Txt);
            if (valorporcentual.ContainsKey(index))
            {
                valorporcentual[index] = Porcentajes;
            }
            else
            {
                valorporcentual.Add(index, Porcentajes);
            }
            index += 1;

        }

        //public void CalcularNota(string Nota)
        //{
        //    int Calificacion = int.Parse(Nota);
        //    if (Calificacion <= 10)
        //    {
        //        double CalculoNotas = ((70 * valorporcentual[indexs] / 100) * Calificacion) / 10;
        //        SumaNotas += CalculoNotas;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Ingrese nuevamente la calificación con valor: " + Calificacion, "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        indexs = 0;
        //        Controlador = false;
        //    }
        //    indexs += 1;

        //}


        public static void SoloNumeros(Control control)
        {
            var controls = TodosLosTextBoxs(control);
            foreach (var textBox in controls)
            {
                textBox.KeyPress += delegate (object o, KeyPressEventArgs e)
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                    {
                        e.Handled = true;
                    }
                };
            }
        }
        public static IEnumerable<Control> TodosLosTextBoxs(Control control)
        {
            var controls = control.Controls.Cast<Control>();
            var especificar = controls as IList<Control> ?? controls.ToList();
            return especificar.SelectMany(TodosLosTextBoxs).Concat(especificar).Where(c => c.GetType() == typeof(TextBox));
        }

        public static void VaciarTextBox(Control vaciar)
        {
            var controls = TodosLosTextBoxs(vaciar);
            foreach (Control contenedor in controls)
            {
                contenedor.Text = string.Empty;
            }

        }

        public void ObtenerCalificaciones(Control Texto)
        {
            var controls = TodosLosTextBoxs(Texto);
            foreach (Control Txt in controls)
            {
                if (Txt.Text == "")
                {
                    Txt.BackColor = Color.FromArgb(255, 63, 63);
                    MessageBox.Show("Todos los campos resaltados son obligatorios", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Controlador = false;
                }
                else
                {
                    int Calificacion = int.Parse(Txt.Text);
                    if (Calificacion <= 10)
                    {
                        double CalculoNotas = ((70 * valorporcentual[indexs] / 100) * Calificacion) / 10;
                        SumaNotas += CalculoNotas;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese nuevamente la calificación con valor: " + Calificacion, "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        indexs = 0;
                        Controlador = false;
                    }
                    indexs += 1;
                    Txt.BackColor = Color.White;
                }
            }

        }

        public void OrderInsertion (Dictionary<int,double> Notascandidatos)
        {
            double[] myArray = Notascandidatos.Values.ToArray();
            //Ordenamiento con Insertion
            for (int k = 1; k <= myArray.Length - 1; k++) // k=1 ya que se asume que la posición 0 está ordenada
            {
                double temp = myArray[k];
                int j = k - 1;
                while (j >= 0 && temp > myArray[j])
                {
                    myArray[j + 1] = myArray[j];
                    j = j - 1;
                }
                myArray[j + 1] = temp;
            }

            Ordenado.Clear();
            for (int i = 0; i < myArray.Length; i++)
            {
                int candidato = Notascandidatos.FirstOrDefault(x => x.Value == myArray[i]).Key;
                Ordenado.Add(candidato, Notascandidatos[candidato]);
                
            }
            
        }


    }
}
