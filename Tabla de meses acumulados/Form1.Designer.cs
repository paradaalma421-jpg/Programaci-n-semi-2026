
namespace Tabla_de_meses_acumulados
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbNavegacion = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrimeroAlumno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoAlumno = new System.Windows.Forms.TextBox();
            this.lblCodicgoAlumno = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            this.lblDirrecionAlumno = new System.Windows.Forms.Label();
            this.txtDirrecionAlumno = new System.Windows.Forms.TextBox();
            this.txtTelefonoAlmno = new System.Windows.Forms.TextBox();
            this.lblTelefonoAlumno = new System.Windows.Forms.Label();
            this.lblEmilAlumno = new System.Windows.Forms.Label();
            this.txtEmailAlumno = new System.Windows.Forms.TextBox();
            this.btnAnteriorAlumno = new System.Windows.Forms.Button();
            this.btnSiguienteAlumno = new System.Windows.Forms.Button();
            this.btnUltimoAluno = new System.Windows.Forms.Button();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.lblRegistroAlumno = new System.Windows.Forms.Label();
            this.grbNavegacion.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbNavegacion
            // 
            this.grbNavegacion.Controls.Add(this.lblRegistroAlumno);
            this.grbNavegacion.Controls.Add(this.btnUltimoAluno);
            this.grbNavegacion.Controls.Add(this.btnSiguienteAlumno);
            this.grbNavegacion.Controls.Add(this.btnAnteriorAlumno);
            this.grbNavegacion.Controls.Add(this.btnPrimeroAlumno);
            this.grbNavegacion.Location = new System.Drawing.Point(12, 250);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Size = new System.Drawing.Size(347, 104);
            this.grbNavegacion.TabIndex = 1;
            this.grbNavegacion.TabStop = false;
            this.grbNavegacion.Text = "Navegacion";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnModificarAlumno);
            this.groupBox3.Controls.Add(this.btnAgregarAlumno);
            this.groupBox3.Location = new System.Drawing.Point(365, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 104);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edicion ";
            // 
            // btnPrimeroAlumno
            // 
            this.btnPrimeroAlumno.Location = new System.Drawing.Point(-6, 19);
            this.btnPrimeroAlumno.Name = "btnPrimeroAlumno";
            this.btnPrimeroAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnPrimeroAlumno.TabIndex = 0;
            this.btnPrimeroAlumno.Text = "|<";
            this.btnPrimeroAlumno.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCodigoAlumno
            // 
            this.txtCodigoAlumno.Location = new System.Drawing.Point(62, 19);
            this.txtCodigoAlumno.Name = "txtCodigoAlumno";
            this.txtCodigoAlumno.Size = new System.Drawing.Size(179, 20);
            this.txtCodigoAlumno.TabIndex = 1;
            // 
            // lblCodicgoAlumno
            // 
            this.lblCodicgoAlumno.AutoSize = true;
            this.lblCodicgoAlumno.Location = new System.Drawing.Point(12, 26);
            this.lblCodicgoAlumno.Name = "lblCodicgoAlumno";
            this.lblCodicgoAlumno.Size = new System.Drawing.Size(49, 13);
            this.lblCodicgoAlumno.TabIndex = 2;
            this.lblCodicgoAlumno.Text = "CODIGO";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(62, 56);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(292, 20);
            this.txtNombreAlumno.TabIndex = 3;
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.txtEmailAlumno);
            this.grbDatos.Controls.Add(this.lblEmilAlumno);
            this.grbDatos.Controls.Add(this.lblTelefonoAlumno);
            this.grbDatos.Controls.Add(this.txtTelefonoAlmno);
            this.grbDatos.Controls.Add(this.txtDirrecionAlumno);
            this.grbDatos.Controls.Add(this.lblDirrecionAlumno);
            this.grbDatos.Controls.Add(this.lblCodigoAlumno);
            this.grbDatos.Controls.Add(this.txtNombreAlumno);
            this.grbDatos.Controls.Add(this.lblCodicgoAlumno);
            this.grbDatos.Controls.Add(this.txtCodigoAlumno);
            this.grbDatos.Controls.Add(this.label1);
            this.grbDatos.Location = new System.Drawing.Point(12, 12);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(560, 219);
            this.grbDatos.TabIndex = 0;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "DATOS ";
            this.grbDatos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Location = new System.Drawing.Point(12, 63);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(54, 13);
            this.lblCodigoAlumno.TabIndex = 4;
            this.lblCodigoAlumno.Text = "NOMBRE";
            // 
            // lblDirrecionAlumno
            // 
            this.lblDirrecionAlumno.AutoSize = true;
            this.lblDirrecionAlumno.Location = new System.Drawing.Point(12, 94);
            this.lblDirrecionAlumno.Name = "lblDirrecionAlumno";
            this.lblDirrecionAlumno.Size = new System.Drawing.Size(67, 13);
            this.lblDirrecionAlumno.TabIndex = 5;
            this.lblDirrecionAlumno.Text = "DIRRECION";
            // 
            // txtDirrecionAlumno
            // 
            this.txtDirrecionAlumno.Location = new System.Drawing.Point(75, 94);
            this.txtDirrecionAlumno.Name = "txtDirrecionAlumno";
            this.txtDirrecionAlumno.Size = new System.Drawing.Size(292, 20);
            this.txtDirrecionAlumno.TabIndex = 6;
            // 
            // txtTelefonoAlmno
            // 
            this.txtTelefonoAlmno.Location = new System.Drawing.Point(87, 121);
            this.txtTelefonoAlmno.Name = "txtTelefonoAlmno";
            this.txtTelefonoAlmno.Size = new System.Drawing.Size(292, 20);
            this.txtTelefonoAlmno.TabIndex = 7;
            // 
            // lblTelefonoAlumno
            // 
            this.lblTelefonoAlumno.AutoSize = true;
            this.lblTelefonoAlumno.Location = new System.Drawing.Point(17, 128);
            this.lblTelefonoAlumno.Name = "lblTelefonoAlumno";
            this.lblTelefonoAlumno.Size = new System.Drawing.Size(64, 13);
            this.lblTelefonoAlumno.TabIndex = 8;
            this.lblTelefonoAlumno.Text = "TELEFONO";
            // 
            // lblEmilAlumno
            // 
            this.lblEmilAlumno.AutoSize = true;
            this.lblEmilAlumno.Location = new System.Drawing.Point(27, 164);
            this.lblEmilAlumno.Name = "lblEmilAlumno";
            this.lblEmilAlumno.Size = new System.Drawing.Size(39, 13);
            this.lblEmilAlumno.TabIndex = 9;
            this.lblEmilAlumno.Text = "EMAIL";
            // 
            // txtEmailAlumno
            // 
            this.txtEmailAlumno.Location = new System.Drawing.Point(87, 161);
            this.txtEmailAlumno.Name = "txtEmailAlumno";
            this.txtEmailAlumno.Size = new System.Drawing.Size(179, 20);
            this.txtEmailAlumno.TabIndex = 10;
            // 
            // btnAnteriorAlumno
            // 
            this.btnAnteriorAlumno.Location = new System.Drawing.Point(62, 19);
            this.btnAnteriorAlumno.Name = "btnAnteriorAlumno";
            this.btnAnteriorAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnAnteriorAlumno.TabIndex = 1;
            this.btnAnteriorAlumno.TabStop = false;
            this.btnAnteriorAlumno.Text = "<";
            this.btnAnteriorAlumno.UseVisualStyleBackColor = true;
            this.btnAnteriorAlumno.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSiguienteAlumno
            // 
            this.btnSiguienteAlumno.Location = new System.Drawing.Point(200, 24);
            this.btnSiguienteAlumno.Name = "btnSiguienteAlumno";
            this.btnSiguienteAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnSiguienteAlumno.TabIndex = 2;
            this.btnSiguienteAlumno.Text = ">|";
            this.btnSiguienteAlumno.UseVisualStyleBackColor = true;
            // 
            // btnUltimoAluno
            // 
            this.btnUltimoAluno.Location = new System.Drawing.Point(272, 24);
            this.btnUltimoAluno.Name = "btnUltimoAluno";
            this.btnUltimoAluno.Size = new System.Drawing.Size(75, 23);
            this.btnUltimoAluno.TabIndex = 3;
            this.btnUltimoAluno.TabStop = false;
            this.btnUltimoAluno.Text = ">";
            this.btnUltimoAluno.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Location = new System.Drawing.Point(6, 19);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarAlumno.TabIndex = 2;
            this.btnAgregarAlumno.TabStop = false;
            this.btnAgregarAlumno.Text = "AGREGAR";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Location = new System.Drawing.Point(87, 19);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(113, 23);
            this.btnModificarAlumno.TabIndex = 3;
            this.btnModificarAlumno.TabStop = false;
            this.btnModificarAlumno.Text = "MODIFICAR";
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            // 
            // lblRegistroAlumno
            // 
            this.lblRegistroAlumno.AutoSize = true;
            this.lblRegistroAlumno.Location = new System.Drawing.Point(143, 24);
            this.lblRegistroAlumno.Name = "lblRegistroAlumno";
            this.lblRegistroAlumno.Size = new System.Drawing.Size(36, 13);
            this.lblRegistroAlumno.TabIndex = 10;
            this.lblRegistroAlumno.Text = "x de n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grbNavegacion);
            this.Controls.Add(this.grbDatos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "registro de alumnos ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbNavegacion.ResumeLayout(false);
            this.grbNavegacion.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbNavegacion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPrimeroAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoAlumno;
        private System.Windows.Forms.Label lblCodicgoAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.TextBox txtTelefonoAlmno;
        private System.Windows.Forms.TextBox txtDirrecionAlumno;
        private System.Windows.Forms.Label lblDirrecionAlumno;
        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.Label lblTelefonoAlumno;
        private System.Windows.Forms.TextBox txtEmailAlumno;
        private System.Windows.Forms.Label lblEmilAlumno;
        private System.Windows.Forms.Button btnAnteriorAlumno;
        private System.Windows.Forms.Label lblRegistroAlumno;
        private System.Windows.Forms.Button btnUltimoAluno;
        private System.Windows.Forms.Button btnSiguienteAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Button btnAgregarAlumno;
    }
}

