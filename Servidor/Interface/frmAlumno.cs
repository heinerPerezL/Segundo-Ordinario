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
using Servidor.Clases;
using Servidor.Interface;

namespace Servidor.Interface
{
    public partial class frmAlumno : Form
    {
        Alumnobd opAlumno;
        public frmAlumno()
        {
            opAlumno =new Alumnobd();
            InitializeComponent();
        }

        private void btnRAlumno_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se a realizado el registro Alumno");
            opAlumno.insertar(llenarDatosAlumno());
            limpiar();

        }

       
        private Alumnocls llenarDatosAlumno() // se toman los datos del texbox y se asignan
        {
            Alumnocls opalumno = new Alumnocls();
            txtRol.Enabled = false;
            opalumno.Id_alumno = txtId.Text;
            opalumno.Dsc_nombre = txtNombre.Text;
            opalumno.Dsc_apellido1 = txtPApellido.Text;
            opalumno.Dsc_apellido2 = txtSApellido.Text;
            opalumno.Dsc_user_name = txtUsuario.Text;
            opalumno.Dsc_password = txtContraseña.Text;
            opalumno.Dsc_rol = "Estudiante";
            return opalumno;
        }

        private void btnSAlumno_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtPApellido.Text = "";
            txtSApellido.Text = "";
            txtRol.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void txtRol_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
