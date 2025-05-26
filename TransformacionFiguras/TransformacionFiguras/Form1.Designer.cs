namespace TransformacionFiguras
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
            this.components = new System.ComponentModel.Container();
            this.btnminus5 = new System.Windows.Forms.Button();
            this.btnplus5 = new System.Windows.Forms.Button();
            this.picBoxTransformacion = new System.Windows.Forms.PictureBox();
            this.txtlado = new System.Windows.Forms.TextBox();
            this.lblado = new System.Windows.Forms.Label();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tBar = new System.Windows.Forms.TrackBar();
            this.lbmostarTamanio = new System.Windows.Forms.Label();
            this.lbarea = new System.Windows.Forms.Label();
            this.lbperimetro = new System.Windows.Forms.Label();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.txtperimetro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTransformacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnminus5
            // 
            this.btnminus5.Location = new System.Drawing.Point(505, 39);
            this.btnminus5.Name = "btnminus5";
            this.btnminus5.Size = new System.Drawing.Size(75, 23);
            this.btnminus5.TabIndex = 0;
            this.btnminus5.Text = "-5º";
            this.btnminus5.UseVisualStyleBackColor = true;
            this.btnminus5.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnplus5
            // 
            this.btnplus5.Location = new System.Drawing.Point(655, 39);
            this.btnplus5.Name = "btnplus5";
            this.btnplus5.Size = new System.Drawing.Size(75, 23);
            this.btnplus5.TabIndex = 1;
            this.btnplus5.Text = "+5º";
            this.btnplus5.UseVisualStyleBackColor = true;
            this.btnplus5.Click += new System.EventHandler(this.btnplus5_Click);
            // 
            // picBoxTransformacion
            // 
            this.picBoxTransformacion.Location = new System.Drawing.Point(35, 95);
            this.picBoxTransformacion.Name = "picBoxTransformacion";
            this.picBoxTransformacion.Size = new System.Drawing.Size(857, 423);
            this.picBoxTransformacion.TabIndex = 2;
            this.picBoxTransformacion.TabStop = false;
            // 
            // txtlado
            // 
            this.txtlado.Location = new System.Drawing.Point(98, 39);
            this.txtlado.Name = "txtlado";
            this.txtlado.Size = new System.Drawing.Size(100, 22);
            this.txtlado.TabIndex = 4;
            // 
            // lblado
            // 
            this.lblado.AutoSize = true;
            this.lblado.Location = new System.Drawing.Point(69, 13);
            this.lblado.Name = "lblado";
            this.lblado.Size = new System.Drawing.Size(129, 16);
            this.lblado.TabIndex = 6;
            this.lblado.Text = "Tamaño inicial Lado";
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(302, 39);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(75, 23);
            this.btnDibujar.TabIndex = 7;
            this.btnDibujar.Text = "dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // tBar
            // 
            this.tBar.Location = new System.Drawing.Point(98, 524);
            this.tBar.Maximum = 150;
            this.tBar.Minimum = 1;
            this.tBar.Name = "tBar";
            this.tBar.Size = new System.Drawing.Size(594, 56);
            this.tBar.TabIndex = 8;
            this.tBar.Value = 1;
            this.tBar.Scroll += new System.EventHandler(this.tBar_Scroll);
            // 
            // lbmostarTamanio
            // 
            this.lbmostarTamanio.AutoSize = true;
            this.lbmostarTamanio.Location = new System.Drawing.Point(726, 542);
            this.lbmostarTamanio.Name = "lbmostarTamanio";
            this.lbmostarTamanio.Size = new System.Drawing.Size(14, 16);
            this.lbmostarTamanio.TabIndex = 9;
            this.lbmostarTamanio.Text = "1";
            // 
            // lbarea
            // 
            this.lbarea.AutoSize = true;
            this.lbarea.Location = new System.Drawing.Point(120, 629);
            this.lbarea.Name = "lbarea";
            this.lbarea.Size = new System.Drawing.Size(39, 16);
            this.lbarea.TabIndex = 10;
            this.lbarea.Text = "Area:";
            // 
            // lbperimetro
            // 
            this.lbperimetro.AutoSize = true;
            this.lbperimetro.Location = new System.Drawing.Point(527, 629);
            this.lbperimetro.Name = "lbperimetro";
            this.lbperimetro.Size = new System.Drawing.Size(68, 16);
            this.lbperimetro.TabIndex = 11;
            this.lbperimetro.Text = "Perimetro:";
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(194, 626);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(100, 22);
            this.txtarea.TabIndex = 12;
            // 
            // txtperimetro
            // 
            this.txtperimetro.Location = new System.Drawing.Point(616, 626);
            this.txtperimetro.Name = "txtperimetro";
            this.txtperimetro.Size = new System.Drawing.Size(100, 22);
            this.txtperimetro.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 701);
            this.Controls.Add(this.txtperimetro);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.lbperimetro);
            this.Controls.Add(this.lbarea);
            this.Controls.Add(this.lbmostarTamanio);
            this.Controls.Add(this.tBar);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.lblado);
            this.Controls.Add(this.txtlado);
            this.Controls.Add(this.picBoxTransformacion);
            this.Controls.Add(this.btnplus5);
            this.Controls.Add(this.btnminus5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTransformacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnminus5;
        private System.Windows.Forms.Button btnplus5;
        private System.Windows.Forms.PictureBox picBoxTransformacion;
        private System.Windows.Forms.TextBox txtlado;
        private System.Windows.Forms.Label lblado;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TrackBar tBar;
        private System.Windows.Forms.Label lbmostarTamanio;
        private System.Windows.Forms.Label lbarea;
        private System.Windows.Forms.Label lbperimetro;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.TextBox txtperimetro;
    }
}

