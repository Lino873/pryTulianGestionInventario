namespace pryTulianGestionInventario
{
    partial class frminicio
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frminicio));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Ventas2 = new System.Windows.Forms.TabControl();
            this.tbpinicio = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxcategoria = new System.Windows.Forms.ComboBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbpventas = new System.Windows.Forms.TabPage();
            this.gbxventas2 = new System.Windows.Forms.GroupBox();
            this.dgventas = new System.Windows.Forms.DataGridView();
            this.gbxarticulo = new System.Windows.Forms.GroupBox();
            this.btnbuscarventas = new System.Windows.Forms.Button();
            this.txtarticulo = new System.Windows.Forms.TextBox();
            this.lblarticulo = new System.Windows.Forms.Label();
            this.tabreporte = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chtreporte = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Ventas2.SuspendLayout();
            this.tbpinicio.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbpventas.SuspendLayout();
            this.gbxventas2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgventas)).BeginInit();
            this.gbxarticulo.SuspendLayout();
            this.tabreporte.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtreporte)).BeginInit();
            this.SuspendLayout();
            // 
            // Ventas2
            // 
            this.Ventas2.Controls.Add(this.tbpinicio);
            this.Ventas2.Controls.Add(this.tbpventas);
            this.Ventas2.Controls.Add(this.tabreporte);
            this.Ventas2.Location = new System.Drawing.Point(29, 25);
            this.Ventas2.Name = "Ventas2";
            this.Ventas2.SelectedIndex = 0;
            this.Ventas2.Size = new System.Drawing.Size(650, 390);
            this.Ventas2.TabIndex = 15;
            // 
            // tbpinicio
            // 
            this.tbpinicio.BackColor = System.Drawing.Color.DarkCyan;
            this.tbpinicio.Controls.Add(this.groupBox1);
            this.tbpinicio.Controls.Add(this.label3);
            this.tbpinicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbpinicio.Location = new System.Drawing.Point(4, 22);
            this.tbpinicio.Name = "tbpinicio";
            this.tbpinicio.Padding = new System.Windows.Forms.Padding(3);
            this.tbpinicio.Size = new System.Drawing.Size(642, 364);
            this.tbpinicio.TabIndex = 0;
            this.tbpinicio.Text = "Inicio";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.txtstock);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btnmodificar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxcategoria);
            this.groupBox1.Controls.Add(this.txtprecio);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, -15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 395);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Descripcìon:";
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(134, 341);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(95, 35);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(31, 248);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(385, 72);
            this.txtdescripcion.TabIndex = 5;
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(417, 183);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(78, 26);
            this.txtstock.TabIndex = 3;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(362, 341);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(95, 35);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(249, 341);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(95, 35);
            this.btnmodificar.TabIndex = 2;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stock:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Categorìa:";
            // 
            // cbxcategoria
            // 
            this.cbxcategoria.FormattingEnabled = true;
            this.cbxcategoria.Location = new System.Drawing.Point(128, 90);
            this.cbxcategoria.Name = "cbxcategoria";
            this.cbxcategoria.Size = new System.Drawing.Size(166, 28);
            this.cbxcategoria.TabIndex = 6;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(417, 109);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(74, 26);
            this.txtprecio.TabIndex = 4;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(127, 146);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(166, 26);
            this.txtnombre.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Còdigo:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(127, 36);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(79, 26);
            this.txtcodigo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descripcìon:";
            // 
            // tbpventas
            // 
            this.tbpventas.BackColor = System.Drawing.Color.DarkCyan;
            this.tbpventas.Controls.Add(this.gbxventas2);
            this.tbpventas.Location = new System.Drawing.Point(4, 22);
            this.tbpventas.Name = "tbpventas";
            this.tbpventas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpventas.Size = new System.Drawing.Size(642, 364);
            this.tbpventas.TabIndex = 1;
            this.tbpventas.Text = "Ventas2";
            // 
            // gbxventas2
            // 
            this.gbxventas2.Controls.Add(this.dgventas);
            this.gbxventas2.Controls.Add(this.gbxarticulo);
            this.gbxventas2.Location = new System.Drawing.Point(6, 6);
            this.gbxventas2.Name = "gbxventas2";
            this.gbxventas2.Size = new System.Drawing.Size(630, 352);
            this.gbxventas2.TabIndex = 6;
            this.gbxventas2.TabStop = false;
            this.gbxventas2.Enter += new System.EventHandler(this.gbxventas2_Enter);
            // 
            // dgventas
            // 
            this.dgventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgventas.Location = new System.Drawing.Point(62, 69);
            this.dgventas.Name = "dgventas";
            this.dgventas.Size = new System.Drawing.Size(488, 227);
            this.dgventas.TabIndex = 16;
            // 
            // gbxarticulo
            // 
            this.gbxarticulo.Controls.Add(this.btnbuscarventas);
            this.gbxarticulo.Controls.Add(this.txtarticulo);
            this.gbxarticulo.Controls.Add(this.lblarticulo);
            this.gbxarticulo.Location = new System.Drawing.Point(129, 6);
            this.gbxarticulo.Name = "gbxarticulo";
            this.gbxarticulo.Size = new System.Drawing.Size(376, 57);
            this.gbxarticulo.TabIndex = 15;
            this.gbxarticulo.TabStop = false;
            // 
            // btnbuscarventas
            // 
            this.btnbuscarventas.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnbuscarventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarventas.Location = new System.Drawing.Point(253, 13);
            this.btnbuscarventas.Name = "btnbuscarventas";
            this.btnbuscarventas.Size = new System.Drawing.Size(117, 32);
            this.btnbuscarventas.TabIndex = 15;
            this.btnbuscarventas.Text = "Buscar";
            this.btnbuscarventas.UseVisualStyleBackColor = false;
            this.btnbuscarventas.Click += new System.EventHandler(this.btnbuscarventas_Click);
            // 
            // txtarticulo
            // 
            this.txtarticulo.Location = new System.Drawing.Point(98, 19);
            this.txtarticulo.Name = "txtarticulo";
            this.txtarticulo.Size = new System.Drawing.Size(138, 20);
            this.txtarticulo.TabIndex = 1;
            // 
            // lblarticulo
            // 
            this.lblarticulo.AutoSize = true;
            this.lblarticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblarticulo.Location = new System.Drawing.Point(23, 17);
            this.lblarticulo.Name = "lblarticulo";
            this.lblarticulo.Size = new System.Drawing.Size(78, 24);
            this.lblarticulo.TabIndex = 0;
            this.lblarticulo.Text = "Artículo:";
            // 
            // tabreporte
            // 
            this.tabreporte.Controls.Add(this.groupBox3);
            this.tabreporte.Location = new System.Drawing.Point(4, 22);
            this.tabreporte.Name = "tabreporte";
            this.tabreporte.Padding = new System.Windows.Forms.Padding(3);
            this.tabreporte.Size = new System.Drawing.Size(642, 364);
            this.tabreporte.TabIndex = 2;
            this.tabreporte.Text = "Reporte";
            this.tabreporte.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox3.Controls.Add(this.chtreporte);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(630, 352);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // chtreporte
            // 
            chartArea1.Name = "ChartArea1";
            this.chtreporte.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtreporte.Legends.Add(legend1);
            this.chtreporte.Location = new System.Drawing.Point(90, 64);
            this.chtreporte.Name = "chtreporte";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtreporte.Series.Add(series1);
            this.chtreporte.Size = new System.Drawing.Size(438, 270);
            this.chtreporte.TabIndex = 13;
            this.chtreporte.Text = "chart1";
            // 
            // frminicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.Ventas2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frminicio";
            this.Text = "Gestìon de inventario";
            this.Load += new System.EventHandler(this.frminicio_Load);
            this.Ventas2.ResumeLayout(false);
            this.tbpinicio.ResumeLayout(false);
            this.tbpinicio.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbpventas.ResumeLayout(false);
            this.gbxventas2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgventas)).EndInit();
            this.gbxarticulo.ResumeLayout(false);
            this.gbxarticulo.PerformLayout();
            this.tabreporte.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtreporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl Ventas2;
        private System.Windows.Forms.TabPage tbpinicio;
        private System.Windows.Forms.TabPage tbpventas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxcategoria;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxventas2;
        private System.Windows.Forms.Label lblarticulo;
        private System.Windows.Forms.GroupBox gbxarticulo;
        private System.Windows.Forms.TextBox txtarticulo;
        private System.Windows.Forms.Button btnbuscarventas;
        private System.Windows.Forms.TabPage tabreporte;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgventas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtreporte;
    }
}