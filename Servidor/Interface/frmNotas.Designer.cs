namespace Servidor.Interface
{
    partial class frmNotas
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
            this.txtNo1 = new System.Windows.Forms.TextBox();
            this.txtNo2 = new System.Windows.Forms.TextBox();
            this.txtProy = new System.Windows.Forms.TextBox();
            this.dgCxA = new System.Windows.Forms.DataGridView();
            this.btnRnotas = new System.Windows.Forms.Button();
            this.btnSalirNotas = new System.Windows.Forms.Button();
            this.btnConsNotas = new System.Windows.Forms.Button();
            this.cbxAlmuno = new System.Windows.Forms.ComboBox();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgCxA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota Ordinario 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Notas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nota Proyecto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nota Ordinario 2";
            // 
            // txtNo1
            // 
            this.txtNo1.Location = new System.Drawing.Point(54, 147);
            this.txtNo1.Name = "txtNo1";
            this.txtNo1.Size = new System.Drawing.Size(117, 20);
            this.txtNo1.TabIndex = 11;
            // 
            // txtNo2
            // 
            this.txtNo2.Location = new System.Drawing.Point(209, 147);
            this.txtNo2.Name = "txtNo2";
            this.txtNo2.Size = new System.Drawing.Size(119, 20);
            this.txtNo2.TabIndex = 12;
            // 
            // txtProy
            // 
            this.txtProy.Location = new System.Drawing.Point(351, 147);
            this.txtProy.Name = "txtProy";
            this.txtProy.Size = new System.Drawing.Size(139, 20);
            this.txtProy.TabIndex = 15;
            // 
            // dgCxA
            // 
            this.dgCxA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCxA.Location = new System.Drawing.Point(54, 252);
            this.dgCxA.Name = "dgCxA";
            this.dgCxA.Size = new System.Drawing.Size(544, 186);
            this.dgCxA.TabIndex = 16;
            // 
            // btnRnotas
            // 
            this.btnRnotas.Location = new System.Drawing.Point(614, 69);
            this.btnRnotas.Name = "btnRnotas";
            this.btnRnotas.Size = new System.Drawing.Size(138, 41);
            this.btnRnotas.TabIndex = 17;
            this.btnRnotas.Text = "Registrar";
            this.btnRnotas.UseVisualStyleBackColor = true;
            this.btnRnotas.Click += new System.EventHandler(this.btnRnotas_Click);
            // 
            // btnSalirNotas
            // 
            this.btnSalirNotas.Location = new System.Drawing.Point(614, 332);
            this.btnSalirNotas.Name = "btnSalirNotas";
            this.btnSalirNotas.Size = new System.Drawing.Size(138, 41);
            this.btnSalirNotas.TabIndex = 18;
            this.btnSalirNotas.Text = "Salir";
            this.btnSalirNotas.UseVisualStyleBackColor = true;
            this.btnSalirNotas.Click += new System.EventHandler(this.btnSalirNotas_Click);
            // 
            // btnConsNotas
            // 
            this.btnConsNotas.Location = new System.Drawing.Point(614, 147);
            this.btnConsNotas.Name = "btnConsNotas";
            this.btnConsNotas.Size = new System.Drawing.Size(138, 41);
            this.btnConsNotas.TabIndex = 19;
            this.btnConsNotas.Text = "Consultar Notas";
            this.btnConsNotas.UseVisualStyleBackColor = true;
            this.btnConsNotas.Click += new System.EventHandler(this.btnConsNotas_Click);
            // 
            // cbxAlmuno
            // 
            this.cbxAlmuno.FormattingEnabled = true;
            this.cbxAlmuno.Location = new System.Drawing.Point(54, 69);
            this.cbxAlmuno.Name = "cbxAlmuno";
            this.cbxAlmuno.Size = new System.Drawing.Size(211, 21);
            this.cbxAlmuno.TabIndex = 20;
            // 
            // cbxCurso
            // 
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Location = new System.Drawing.Point(327, 69);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(190, 21);
            this.cbxCurso.TabIndex = 21;
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxCurso);
            this.Controls.Add(this.cbxAlmuno);
            this.Controls.Add(this.btnConsNotas);
            this.Controls.Add(this.btnSalirNotas);
            this.Controls.Add(this.btnRnotas);
            this.Controls.Add(this.dgCxA);
            this.Controls.Add(this.txtProy);
            this.Controls.Add(this.txtNo2);
            this.Controls.Add(this.txtNo1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNotas";
            this.Text = "frmNotas";
            ((System.ComponentModel.ISupportInitialize)(this.dgCxA)).EndInit();
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
        private System.Windows.Forms.TextBox txtNo1;
        private System.Windows.Forms.TextBox txtNo2;
        private System.Windows.Forms.TextBox txtProy;
        private System.Windows.Forms.DataGridView dgCxA;
        private System.Windows.Forms.Button btnRnotas;
        private System.Windows.Forms.Button btnSalirNotas;
        private System.Windows.Forms.Button btnConsNotas;
        private System.Windows.Forms.ComboBox cbxAlmuno;
        private System.Windows.Forms.ComboBox cbxCurso;
    }
}