
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblMontoInicial = new System.Windows.Forms.Label();
            this.lblAporteMensual = new System.Windows.Forms.Label();
            this.lblTasaAnual = new System.Windows.Forms.Label();
            this.txtMontoInicial = new System.Windows.Forms.TextBox();
            this.txtAporteMensual = new System.Windows.Forms.TextBox();
            this.txtTasaAnual = new System.Windows.Forms.TextBox();
            this.txtNumMeses = new System.Windows.Forms.TextBox();
            this.lblNumMeses = new System.Windows.Forms.Label();
            this.btnLimpiarMeses = new System.Windows.Forms.Button();
            this.btnGenerarTabla = new System.Windows.Forms.Button();
            this.dgvAcumulado = new System.Windows.Forms.DataGridView();
            this.chrtAcumulado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcumulado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtAcumulado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMontoInicial
            // 
            this.lblMontoInicial.AutoSize = true;
            this.lblMontoInicial.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoInicial.Location = new System.Drawing.Point(97, 63);
            this.lblMontoInicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontoInicial.Name = "lblMontoInicial";
            this.lblMontoInicial.Size = new System.Drawing.Size(101, 17);
            this.lblMontoInicial.TabIndex = 0;
            this.lblMontoInicial.Text = "MontoInicial :";
            // 
            // lblAporteMensual
            // 
            this.lblAporteMensual.AutoSize = true;
            this.lblAporteMensual.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAporteMensual.Location = new System.Drawing.Point(97, 119);
            this.lblAporteMensual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAporteMensual.Name = "lblAporteMensual";
            this.lblAporteMensual.Size = new System.Drawing.Size(120, 17);
            this.lblAporteMensual.TabIndex = 1;
            this.lblAporteMensual.Text = "AporteMensual :";
            // 
            // lblTasaAnual
            // 
            this.lblTasaAnual.AutoSize = true;
            this.lblTasaAnual.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasaAnual.Location = new System.Drawing.Point(97, 180);
            this.lblTasaAnual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTasaAnual.Name = "lblTasaAnual";
            this.lblTasaAnual.Size = new System.Drawing.Size(85, 17);
            this.lblTasaAnual.TabIndex = 2;
            this.lblTasaAnual.Text = "TasaAnual :";
            // 
            // txtMontoInicial
            // 
            this.txtMontoInicial.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoInicial.Location = new System.Drawing.Point(200, 63);
            this.txtMontoInicial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMontoInicial.Name = "txtMontoInicial";
            this.txtMontoInicial.Size = new System.Drawing.Size(76, 24);
            this.txtMontoInicial.TabIndex = 3;
            // 
            // txtAporteMensual
            // 
            this.txtAporteMensual.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAporteMensual.Location = new System.Drawing.Point(211, 114);
            this.txtAporteMensual.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAporteMensual.Name = "txtAporteMensual";
            this.txtAporteMensual.Size = new System.Drawing.Size(76, 24);
            this.txtAporteMensual.TabIndex = 4;
            // 
            // txtTasaAnual
            // 
            this.txtTasaAnual.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTasaAnual.Location = new System.Drawing.Point(200, 176);
            this.txtTasaAnual.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTasaAnual.Name = "txtTasaAnual";
            this.txtTasaAnual.Size = new System.Drawing.Size(76, 24);
            this.txtTasaAnual.TabIndex = 5;
            // 
            // txtNumMeses
            // 
            this.txtNumMeses.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumMeses.Location = new System.Drawing.Point(200, 224);
            this.txtNumMeses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumMeses.Name = "txtNumMeses";
            this.txtNumMeses.Size = new System.Drawing.Size(76, 24);
            this.txtNumMeses.TabIndex = 6;
            // 
            // lblNumMeses
            // 
            this.lblNumMeses.AutoSize = true;
            this.lblNumMeses.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMeses.Location = new System.Drawing.Point(97, 224);
            this.lblNumMeses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumMeses.Name = "lblNumMeses";
            this.lblNumMeses.Size = new System.Drawing.Size(93, 17);
            this.lblNumMeses.TabIndex = 7;
            this.lblNumMeses.Text = "NumMeses :";
            // 
            // btnLimpiarMeses
            // 
            this.btnLimpiarMeses.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarMeses.Location = new System.Drawing.Point(478, 74);
            this.btnLimpiarMeses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiarMeses.Name = "btnLimpiarMeses";
            this.btnLimpiarMeses.Size = new System.Drawing.Size(64, 33);
            this.btnLimpiarMeses.TabIndex = 8;
            this.btnLimpiarMeses.Text = "Limpiar";
            this.btnLimpiarMeses.UseVisualStyleBackColor = true;
            this.btnLimpiarMeses.Click += new System.EventHandler(this.btnLimpiarMeses_Click);
            // 
            // btnGenerarTabla
            // 
            this.btnGenerarTabla.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarTabla.Location = new System.Drawing.Point(403, 74);
            this.btnGenerarTabla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerarTabla.Name = "btnGenerarTabla";
            this.btnGenerarTabla.Size = new System.Drawing.Size(66, 33);
            this.btnGenerarTabla.TabIndex = 9;
            this.btnGenerarTabla.Text = "Generar";
            this.btnGenerarTabla.UseVisualStyleBackColor = true;
            this.btnGenerarTabla.Click += new System.EventHandler(this.btnGenerarTabla_Click);
            // 
            // dgvAcumulado
            // 
            this.dgvAcumulado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcumulado.Location = new System.Drawing.Point(1, 268);
            this.dgvAcumulado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAcumulado.Name = "dgvAcumulado";
            this.dgvAcumulado.RowHeadersWidth = 51;
            this.dgvAcumulado.RowTemplate.Height = 24;
            this.dgvAcumulado.Size = new System.Drawing.Size(359, 88);
            this.dgvAcumulado.TabIndex = 10;
            // 
            // chrtAcumulado
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtAcumulado.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtAcumulado.Legends.Add(legend1);
            this.chrtAcumulado.Location = new System.Drawing.Point(366, 112);
            this.chrtAcumulado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chrtAcumulado.Name = "chrtAcumulado";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtAcumulado.Series.Add(series1);
            this.chrtAcumulado.Size = new System.Drawing.Size(225, 244);
            this.chrtAcumulado.TabIndex = 11;
            this.chrtAcumulado.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tabla de meses acumulados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chrtAcumulado);
            this.Controls.Add(this.dgvAcumulado);
            this.Controls.Add(this.btnGenerarTabla);
            this.Controls.Add(this.btnLimpiarMeses);
            this.Controls.Add(this.lblNumMeses);
            this.Controls.Add(this.txtNumMeses);
            this.Controls.Add(this.txtTasaAnual);
            this.Controls.Add(this.txtAporteMensual);
            this.Controls.Add(this.txtMontoInicial);
            this.Controls.Add(this.lblTasaAnual);
            this.Controls.Add(this.lblAporteMensual);
            this.Controls.Add(this.lblMontoInicial);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcumulado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtAcumulado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMontoInicial;
        private System.Windows.Forms.Label lblAporteMensual;
        private System.Windows.Forms.Label lblTasaAnual;
        private System.Windows.Forms.TextBox txtMontoInicial;
        private System.Windows.Forms.TextBox txtAporteMensual;
        private System.Windows.Forms.TextBox txtTasaAnual;
        private System.Windows.Forms.TextBox txtNumMeses;
        private System.Windows.Forms.Label lblNumMeses;
        private System.Windows.Forms.Button btnLimpiarMeses;
        private System.Windows.Forms.Button btnGenerarTabla;
        private System.Windows.Forms.DataGridView dgvAcumulado;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtAcumulado;
        private System.Windows.Forms.Label label1;
    }
}

