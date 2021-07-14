namespace Servidor.Interface
{
    partial class frmCurso
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
            this.txtnumCurs = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.txtnuNomCur = new System.Windows.Forms.TextBox();
            this.btnRCurso = new System.Windows.Forms.Button();
            this.btnSCurso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nivel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad Horas";
            // 
            // txtnumCurs
            // 
            this.txtnumCurs.Location = new System.Drawing.Point(40, 53);
            this.txtnumCurs.Name = "txtnumCurs";
            this.txtnumCurs.Size = new System.Drawing.Size(248, 20);
            this.txtnumCurs.TabIndex = 4;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(40, 268);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(248, 20);
            this.txtHoras.TabIndex = 5;
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(40, 200);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(248, 20);
            this.txtNivel.TabIndex = 6;
            // 
            // txtnuNomCur
            // 
            this.txtnuNomCur.Location = new System.Drawing.Point(40, 132);
            this.txtnuNomCur.Name = "txtnuNomCur";
            this.txtnuNomCur.Size = new System.Drawing.Size(248, 20);
            this.txtnuNomCur.TabIndex = 7;
            // 
            // btnRCurso
            // 
            this.btnRCurso.Location = new System.Drawing.Point(445, 53);
            this.btnRCurso.Name = "btnRCurso";
            this.btnRCurso.Size = new System.Drawing.Size(196, 79);
            this.btnRCurso.TabIndex = 8;
            this.btnRCurso.Text = "Registar";
            this.btnRCurso.UseVisualStyleBackColor = true;
            this.btnRCurso.Click += new System.EventHandler(this.btnRCurso_Click);
            // 
            // btnSCurso
            // 
            this.btnSCurso.Location = new System.Drawing.Point(445, 197);
            this.btnSCurso.Name = "btnSCurso";
            this.btnSCurso.Size = new System.Drawing.Size(196, 56);
            this.btnSCurso.TabIndex = 9;
            this.btnSCurso.Text = "Salir";
            this.btnSCurso.UseVisualStyleBackColor = true;
            this.btnSCurso.Click += new System.EventHandler(this.btnSCurso_Click);
            // 
            // frmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSCurso);
            this.Controls.Add(this.btnRCurso);
            this.Controls.Add(this.txtnuNomCur);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtnumCurs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCurso";
            this.Text = "frmCurso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnumCurs;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.TextBox txtnuNomCur;
        private System.Windows.Forms.Button btnRCurso;
        private System.Windows.Forms.Button btnSCurso;
    }
}