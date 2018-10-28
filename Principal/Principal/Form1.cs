using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Inicializacion de Objetos de las clases
        Leer_archivo leer_archivo = new Leer_archivo();
        Lexico lx = new Lexico();


        private void btn_archivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ventana_archivos = new OpenFileDialog();
            ventana_archivos.ShowDialog();
            lbl_archivo_seleccionado.Text = ventana_archivos.FileName;

            foreach (string l in leer_archivo.Read_file(lbl_archivo_seleccionado.Text))
            {
                txt_archivo.Text += l + " \n";
            }

            foreach (string l in lx.Lexico_metodo(lbl_archivo_seleccionado.Text))
            {
                txt_lexico.Text += lx.Lexico_metodo(lbl_archivo_seleccionado.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
