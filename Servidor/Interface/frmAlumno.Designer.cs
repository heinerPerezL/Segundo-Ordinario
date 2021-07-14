namespace Servidor.Interface
{
    partial class frmAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSApellido = new System.Windows.Forms.TextBox();
            this.txtPApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnRAlumno = new System.Windows.Forms.Button();
            this.btnSAlumno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Primer Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Segundo Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Contraseña";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(32, 57);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(242, 20);
            this.txtId.TabIndex = 7;
            // 
            // txtRol
            // 
            this.txtRol.Enabled = false;
            this.txtRol.Location = new System.Drawing.Point(32, 323);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(242, 20);
            this.txtRol.TabIndex = 8;
            this.txtRol.Text = "Estudiante";
            this.txtRol.TextChanged += new System.EventHandler(this.txtRol_TextChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(370, 119);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(242, 20);
            this.txtContraseña.TabIndex = 9;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(370, 57);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(242, 20);
            this.txtUsuario.TabIndex = 10;
            // 
            // txtSApellido
            // 
            this.txtSApellido.Location = new System.Drawing.Point(32, 267);
            this.txtSApellido.Name = "txtSApellido";
            this.txtSApellido.Size = new System.Drawing.Size(242, 20);
            this.txtSApellido.TabIndex = 11;
            // 
            // txtPApellido
            // 
            this.txtPApellido.Location = new System.Drawing.Point(32, 202);
            this.txtPApellido.Name = "txtPApellido";
            this.txtPApellido.Size = new System.Drawing.Size(242, 20);
            this.txtPApellido.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(32, 132);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(242, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // btnRAlumno
            // 
            this.btnRAlumno.Location = new System.Drawing.Point(332, 202);
            this.btnRAlumno.Name = "btnRAlumno";
            this.btnRAlumno.Size = new System.Drawing.Size(184, 62);
            this.btnRAlumno.TabIndex = 14;
            this.btnRAlumno.Text = "Registrar";
            this.btnRAlumno.UseVisualStyleBackColor = true;
            this.btnRAlumno.Click += new System.EventHandler(this.btnRAlumno_Click);
            // 
            // btnSAlumno
            // 
            this.btnSAlumno.Location = new System.Drawing.Point(450, 307);
            this.btnSAlumno.Name = "btnSAlumno";
            this.btnSAlumno.Size = new System.Drawing.Size(184, 62);
            this.btnSAlumno.TabIndex = 15;
            this.btnSAlumno.Text = "Salir";
            this.btnSAlumno.UseVisualStyleBackColor = true;
            this.btnSAlumno.Click += new System.EventHandler(this.btnSAlumno_Click);
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSAlumno);
            this.Controls.Add(this.btnRAlumno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPApellido);
            this.Controls.Add(this.txtSApellido);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAlumno";
            this.Text = "frmAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSApellido;
        private System.Windows.Forms.TextBox txtPApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnRAlumno;
        private System.Windows.Forms.Button btnSAlumno;
    }
}