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
using System.Data.SqlClient;



namespace Servidor.Interface
{
    public partial class frmNotas : Form
    {
        CursosAlumnobd opcnx;
  

        public frmNotas()
        {
            opcnx = new CursosAlumnobd();
            
            InitializeComponent();
            LlenarDatosAlumno();
            LlenarDatosCurso();
            

        }

        private void btnSalirNotas_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRnotas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro de Notas listo");
            RegistroCxA();
            limpiar();

        }

       private void LlenarDatosAlumno()
        {
            cbxAlmuno.DataSource = Alumnobd.llenarCbxAlumno();
            cbxAlmuno.DisplayMember = "Id_alumno";
            cbxAlmuno.ValueMember = "Id_alumno";
        }

        private void LlenarDatosCurso()
        {
            cbxCurso.DataSource = Cursobd.llenarCbxCurso();
            cbxCurso.DisplayMember = "Dsc_curso";
            cbxCurso.ValueMember = "Id_curso";
        }

        private void RegistroCxA()
        {
            Conexionbd datos = new Conexionbd();
            String Id_curso = cbxCurso.Text;
            String Id_alumno = cbxAlmuno.Text;
            String NotaOrdinario1 = txtNo1.Text;
            String NotaOrdinario2 = txtNo2.Text;
            String NotaProyecto = txtProy.Text;
            datos.ingresoBD("INSERT INTO CursosAlumno(Id_curso,Id_alumno,NotaOrdinario1,NotaOrdinario2,NotaProyecto)VALUES('" + Id_curso + "','" + Id_alumno + "','" + NotaOrdinario1 + "','" + NotaOrdinario2 + "', '" + NotaProyecto + "')");

            MessageBox.Show("Datos Ingresados");

        }
        private void limpiar()
        {
            cbxAlmuno.Text = "";
            cbxCurso.Text = "";
            txtNo1.Text = "";
            txtProy.Text = "";

        }



        private void btnConsNotas_Click(object sender, EventArgs e)
        {
            dgCxA.DataSource = opcnx.MostrarCxA().Tables[0];
        }

        

        
    }
}
