using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servidor.BD;
using Servidor.Interface;
using Servidor.Clases;

namespace Servidor.Interface
{
    
    public partial class frmCurso : Form
    {
        Cursobd opcurso;
        public frmCurso()
        {
            opcurso = new Cursobd();
            InitializeComponent();
        }

        private void btnRCurso_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro de Curso Realizado");
            opcurso.insertar(llenarDatosCurso());
            limpiar();
        }

        private Cursocls llenarDatosCurso() // se toman los datos del texbox y se asignan
        {
            Cursocls opcurso = new Cursocls();

            opcurso.Id_curso = txtnumCurs.Text;
            opcurso.Dsc_curso = txtnuNomCur.Text;
            opcurso.Dsc_Grado = txtNivel.Text;
            opcurso.Dsc_Horas = txtHoras.Text;
            return opcurso;
        }

        private void limpiar()
        {
            txtnumCurs.Text = "";
            txtnuNomCur.Text = "";
            txtNivel.Text = "";
            txtHoras.Text = "";
            
        }

        private void btnSCurso_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
