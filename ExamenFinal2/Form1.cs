using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinal2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Nacionalidad.Items.Clear();
            Nacionalidad.Items.Add("Nicaragua");
            Nacionalidad.Items.Add("Costa Rica");
            Nacionalidad.Items.Add("Estados Unidos");

            Universidad.Items.Clear();
            Universidad.Items.Add("Universidad Nacional de Ingeniería");
            Universidad.Items.Add("Universidad Centroamericana");
            Universidad.Items.Add("Universidad Nacional Autónoma");
            Universidad.Items.Add("Universidad Nacional Agraria");
            Universidad.Items.Add("Universidad Nacional Politécnica");

            Carrera.Items.Clear();
            Carrera.Items.Add("Ingeniería de Sistemas");
            Carrera.Items.Add("Ingeniería Industrial");
            Carrera.Items.Add("Ingeniería Civil");

            AñoCurso.Items.Clear();
            AñoCurso.Items.Add("Primero");
            AñoCurso.Items.Add("Segundo");
            AñoCurso.Items.Add("Tercero");
            AñoCurso.Items.Add("Cuarto");
            AñoCurso.Items.Add("Quinto");

            MascBut.Enabled = false;
            FemBut.Enabled = false;
            MostrarDatosPerfil.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MascBut_CheckedChanged(object sender, EventArgs e)
        {
            if(MascBut.Checked == true)
            {
                FemBut.Enabled = false;
            }
        }

        private void FemBut_CheckedChanged(object sender, EventArgs e)
        {
            if(FemBut.Checked == true)
            {
                MascBut.Enabled = false;
            }
        }

        private void MostrarDatosPerfil_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MostrarDatosPerfil.Checked == true)
            {
                //DialogResult dialogresult = MessageBox.Show(dateTimePicker1());
            }
            string nombre, apellidop, apellidom;
            nombre = Convert.ToString(Nombre.Text);
            apellidop = Convert.ToString(ApellidoP.Text);
            apellidom = Convert.ToString(ApellidoM.Text);
            
            if(MascBut.Checked == true)
            {
                MessageBox.Show($"Se registro correctamente a: " + nombre + " " + apellidop + " " + apellidom + ".\nEs de Sexo Masculino.");

            }
            else
            {
                if(FemBut.Checked == true)
                {
                    MessageBox.Show($"Se registro correctamente a: " + nombre + " " + apellidop + " " + apellidom + ".\nEs de Sexo Femenino.");
                }
                else
                {
                    MessageBox.Show($"Se registro correctamente a: " + nombre + " " + apellidop + " " + apellidom + ".\nNo se Identificó el Sexo");
                }
            }
            string nacionalidad;
            nacionalidad = Convert.ToString(Nacionalidad.Text);
            MessageBox.Show("Su nacionalidad es: "+nacionalidad);

            string fecha;
            fecha = Convert.ToString(dateTimePicker1.Text);
            if(MostrarDatosPerfil.Checked == true)
            {
                MessageBox.Show("La fecha de su nacimiento es: " + fecha+""+pictureBox1);
            }
            


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
