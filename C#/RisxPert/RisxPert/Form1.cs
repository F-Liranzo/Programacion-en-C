using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RisxPert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        // Formulario para las diferentes pestañas //

       
        private void abrirformulairo<MiForm>()where MiForm : Form, new()   //creando metodo //
        {
            Form Formulario;   // creando variable formulario //
            Formulario = panelformulario.Controls.OfType<MiForm>().FirstOrDefault(); // va a buscar el formulario si existe y lo va a poner // 

            if (Formulario == null ) // si existe va a poner los soguientes parametros //
            {
                Formulario = new MiForm();
                Formulario.TopLevel = false;
                Formulario.FormBorderStyle = FormBorderStyle.None;
                Formulario.Dock = DockStyle.Fill;
                panelformulario.Controls.Add(Formulario);
                panelformulario.Tag = Formulario;
                Formulario.Show();
                Formulario.BringToFront();
            }
            else
            {
                Formulario.BringToFront();
            }
        }
        // creamos un nuevo formulario , con el mismo tamaño de la pestaña y llamamamos el metodo //
        private void Fase1_Click(object sender, EventArgs e)
        {
            abrirformulairo<Fase1>();
        }

        private void Fase2_Click(object sender, EventArgs e)
        {
            abrirformulairo<Fase2>();
        }

        private void Fase3_Click(object sender, EventArgs e)
        {
            abrirformulairo<Fase3>();
        }

        private void Fase4_Click(object sender, EventArgs e)
        {
            abrirformulairo<Fase4>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelformulario_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
