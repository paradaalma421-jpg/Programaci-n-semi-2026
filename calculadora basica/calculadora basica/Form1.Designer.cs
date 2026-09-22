
namespace calculadora_basica
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
            this.lbllblDirrecionAlumno = new System.Windows.Forms.Label();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.grbNavegacion = new System.Windows.Forms.GroupBox();
            this.grbEdicion = new System.Windows.Forms.GroupBox();
            this.lblCodigoAalumno = new System.Windows.Forms.Label();
            this.btnCodigo = new System.Windows.Forms.Button();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.btnNombre = new System.Windows.Forms.Button();
            this.btnDireccion = new System.Windows.Forms.Button();
            this.lblDirrecionAlumno = new System.Windows.Forms.Label();
            this.lblTelefonoAlumno = new System.Windows.Forms.Label();
            this.btnTelefono = new System.Windows.Forms.Button();
            this.lblEmailAlumno = new System.Windows.Forms.Label();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnPrimerAlumno = new System.Windows.Forms.Button();
            this.btnAnteriorAlumno = new System.Windows.Forms.Button();
            this.btnUltimoAlumno = new System.Windows.Forms.Button();
            this.btnSiguienteAlumno = new System.Windows.Forms.Button();
            this.btnAgregarAlumo = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.lblRegristroalmno = new System.Windows.Forms.Label();
            this.grbDatos.SuspendLayout();
            this.grbNavegacion.SuspendLayout();
            this.grbEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbllblDirrecionAlumno
            // 
            this.lbllblDirrecionAlumno.AutoSize = true;
            this.lbllblDirrecionAlumno.Location = new System.Drawing.Point(400, 177);
            this.lbllblDirrecionAlumno.Name = "lbllblDirrecionAlumno";
            this.lbllblDirrecionAlumno.Size = new System.Drawing.Size(12, 13);
            this.lbllblDirrecionAlumno.TabIndex = 12;
            this.lbllblDirrecionAlumno.Text = "z";
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.btnEmail);
            this.grbDatos.Controls.Add(this.lblEmailAlumno);
            this.grbDatos.Controls.Add(this.btnTelefono);
            this.grbDatos.Controls.Add(this.lblTelefonoAlumno);
            this.grbDatos.Controls.Add(this.lblDirrecionAlumno);
            this.grbDatos.Controls.Add(this.btnDireccion);
            this.grbDatos.Controls.Add(this.btnNombre);
            this.grbDatos.Controls.Add(this.lblNombreAlumno);
            this.grbDatos.Controls.Add(this.btnCodigo);
            this.grbDatos.Controls.Add(this.lblCodigoAalumno);
            this.grbDatos.Location = new System.Drawing.Point(12, 12);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(526, 251);
            this.grbDatos.TabIndex = 13;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "DATOS";
            // 
            // grbNavegacion
            // 
            this.grbNavegacion.Controls.Add(this.lblRegristroalmno);
            this.grbNavegacion.Controls.Add(this.btnSiguienteAlumno);
            this.grbNavegacion.Controls.Add(this.btnUltimoAlumno);
            this.grbNavegacion.Controls.Add(this.btnAnteriorAlumno);
            this.grbNavegacion.Controls.Add(this.btnPrimerAlumno);
            this.grbNavegacion.Location = new System.Drawing.Point(12, 269);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Size = new System.Drawing.Size(261, 100);
            this.grbNavegacion.TabIndex = 14;
            this.grbNavegacion.TabStop = false;
            this.grbNavegacion.Text = "NAVEGACION";
            // 
            // grbEdicion
            // 
            this.grbEdicion.Controls.Add(this.btnModificarAlumno);
            this.grbEdicion.Controls.Add(this.btnAgregarAlumo);
            this.grbEdicion.Location = new System.Drawing.Point(279, 269);
            this.grbEdicion.Name = "grbEdicion";
            this.grbEdicion.Size = new System.Drawing.Size(235, 100);
            this.grbEdicion.TabIndex = 15;
            this.grbEdicion.TabStop = false;
            this.grbEdicion.Text = "EDICION";
            // 
            // lblCodigoAalumno
            // 
            this.lblCodigoAalumno.AutoSize = true;
            this.lblCodigoAalumno.Location = new System.Drawing.Point(16, 24);
            this.lblCodigoAalumno.Name = "lblCodigoAalumno";
            this.lblCodigoAalumno.Size = new System.Drawing.Size(49, 13);
            this.lblCodigoAalumno.TabIndex = 0;
            this.lblCodigoAalumno.Text = "CODIGO";
            // 
            // btnCodigo
            // 
            this.btnCodigo.Location = new System.Drawing.Point(71, 19);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(158, 23);
            this.btnCodigo.TabIndex = 1;
            this.btnCodigo.UseVisualStyleBackColor = true;
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Location = new System.Drawing.Point(16, 55);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(54, 13);
            this.lblNombreAlumno.TabIndex = 2;
            this.lblNombreAlumno.Text = "NOMBRE";
            // 
            // btnNombre
            // 
            this.btnNombre.Location = new System.Drawing.Point(71, 50);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(158, 23);
            this.btnNombre.TabIndex = 3;
            this.btnNombre.UseVisualStyleBackColor = true;
            // 
            // btnDireccion
            // 
            this.btnDireccion.Location = new System.Drawing.Point(88, 84);
            this.btnDireccion.Name = "btnDireccion";
            this.btnDireccion.Size = new System.Drawing.Size(176, 23);
            this.btnDireccion.TabIndex = 4;
            this.btnDireccion.UseVisualStyleBackColor = true;
            // 
            // lblDirrecionAlumno
            // 
            this.lblDirrecionAlumno.AutoSize = true;
            this.lblDirrecionAlumno.Location = new System.Drawing.Point(16, 89);
            this.lblDirrecionAlumno.Name = "lblDirrecionAlumno";
            this.lblDirrecionAlumno.Size = new System.Drawing.Size(66, 13);
            this.lblDirrecionAlumno.TabIndex = 5;
            this.lblDirrecionAlumno.Text = "DIRECCION";
            // 
            // lblTelefonoAlumno
            // 
            this.lblTelefonoAlumno.AutoSize = true;
            this.lblTelefonoAlumno.Location = new System.Drawing.Point(16, 115);
            this.lblTelefonoAlumno.Name = "lblTelefonoAlumno";
            this.lblTelefonoAlumno.Size = new System.Drawing.Size(64, 13);
            this.lblTelefonoAlumno.TabIndex = 6;
            this.lblTelefonoAlumno.Text = "TELEFONO";
            // 
            // btnTelefono
            // 
            this.btnTelefono.Location = new System.Drawing.Point(85, 110);
            this.btnTelefono.Name = "btnTelefono";
            this.btnTelefono.Size = new System.Drawing.Size(176, 23);
            this.btnTelefono.TabIndex = 7;
            this.btnTelefono.UseVisualStyleBackColor = true;
            // 
            // lblEmailAlumno
            // 
            this.lblEmailAlumno.AutoSize = true;
            this.lblEmailAlumno.Location = new System.Drawing.Point(16, 145);
            this.lblEmailAlumno.Name = "lblEmailAlumno";
            this.lblEmailAlumno.Size = new System.Drawing.Size(39, 13);
            this.lblEmailAlumno.TabIndex = 8;
            this.lblEmailAlumno.Text = "EMAIL";
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(85, 135);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(176, 23);
            this.btnEmail.TabIndex = 9;
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // btnPrimerAlumno
            // 
            this.btnPrimerAlumno.Location = new System.Drawing.Point(0, 19);
            this.btnPrimerAlumno.Name = "btnPrimerAlumno";
            this.btnPrimerAlumno.Size = new System.Drawing.Size(55, 23);
            this.btnPrimerAlumno.TabIndex = 0;
            this.btnPrimerAlumno.Text = "|<";
            this.btnPrimerAlumno.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorAlumno
            // 
            this.btnAnteriorAlumno.Location = new System.Drawing.Point(52, 19);
            this.btnAnteriorAlumno.Name = "btnAnteriorAlumno";
            this.btnAnteriorAlumno.Size = new System.Drawing.Size(55, 23);
            this.btnAnteriorAlumno.TabIndex = 1;
            this.btnAnteriorAlumno.Text = "<";
            this.btnAnteriorAlumno.UseVisualStyleBackColor = true;
            // 
            // btnUltimoAlumno
            // 
            this.btnUltimoAlumno.Location = new System.Drawing.Point(138, 21);
            this.btnUltimoAlumno.Name = "btnUltimoAlumno";
            this.btnUltimoAlumno.Size = new System.Drawing.Size(55, 23);
            this.btnUltimoAlumno.TabIndex = 2;
            this.btnUltimoAlumno.Text = ">";
            this.btnUltimoAlumno.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteAlumno
            // 
            this.btnSiguienteAlumno.Location = new System.Drawing.Point(183, 23);
            this.btnSiguienteAlumno.Name = "btnSiguienteAlumno";
            this.btnSiguienteAlumno.Size = new System.Drawing.Size(55, 19);
            this.btnSiguienteAlumno.TabIndex = 3;
            this.btnSiguienteAlumno.Text = ">|";
            this.btnSiguienteAlumno.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAlumo
            // 
            this.btnAgregarAlumo.Location = new System.Drawing.Point(6, 21);
            this.btnAgregarAlumo.Name = "btnAgregarAlumo";
            this.btnAgregarAlumo.Size = new System.Drawing.Size(81, 23);
            this.btnAgregarAlumo.TabIndex = 3;
            this.btnAgregarAlumo.Text = "AGREGAR";
            this.btnAgregarAlumo.UseVisualStyleBackColor = true;
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Location = new System.Drawing.Point(93, 23);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(81, 23);
            this.btnModificarAlumno.TabIndex = 4;
            this.btnModificarAlumno.Text = "MODIFICAR";
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            // 
            // lblRegristroalmno
            // 
            this.lblRegristroalmno.AutoSize = true;
            this.lblRegristroalmno.Location = new System.Drawing.Point(113, 26);
            this.lblRegristroalmno.Name = "lblRegristroalmno";
            this.lblRegristroalmno.Size = new System.Drawing.Size(36, 13);
            this.lblRegristroalmno.TabIndex = 4;
            this.lblRegristroalmno.Text = "x de n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 366);
            this.Controls.Add(this.grbNavegacion);
            this.Controls.Add(this.grbEdicion);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.lbllblDirrecionAlumno);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "administracion de alumnos";
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.grbNavegacion.ResumeLayout(false);
            this.grbNavegacion.PerformLayout();
            this.grbEdicion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllblDirrecionAlumno;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Label lblEmailAlumno;
        private System.Windows.Forms.Button btnTelefono;
        private System.Windows.Forms.Label lblTelefonoAlumno;
        private System.Windows.Forms.Label lblDirrecionAlumno;
        private System.Windows.Forms.Button btnDireccion;
        private System.Windows.Forms.Button btnNombre;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.Button btnCodigo;
        private System.Windows.Forms.Label lblCodigoAalumno;
        private System.Windows.Forms.GroupBox grbNavegacion;
        private System.Windows.Forms.GroupBox grbEdicion;
        private System.Windows.Forms.Button btnPrimerAlumno;
        private System.Windows.Forms.Button btnSiguienteAlumno;
        private System.Windows.Forms.Button btnUltimoAlumno;
        private System.Windows.Forms.Button btnAnteriorAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Button btnAgregarAlumo;
        private System.Windows.Forms.Label lblRegristroalmno;
    }
}

