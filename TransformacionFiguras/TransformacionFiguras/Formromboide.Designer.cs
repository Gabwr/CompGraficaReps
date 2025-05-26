namespace TransformacionFiguras
{
    partial class Formromboide
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
            this.txtperimetro = new System.Windows.Forms.TextBox();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.lbperimetro = new System.Windows.Forms.Label();
            this.lbarea = new System.Windows.Forms.Label();
            this.tBar = new System.Windows.Forms.TrackBar();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.lbaltura = new System.Windows.Forms.Label();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.picBoxTransformacion = new System.Windows.Forms.PictureBox();
            this.btnplus5 = new System.Windows.Forms.Button();
            this.btnminus5 = new System.Windows.Forms.Button();
            this.lbmostarTamanio = new System.Windows.Forms.Label();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.lbBase = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTransformacion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtperimetro
            // 
            this.txtperimetro.Location = new System.Drawing.Point(663, 640);
            this.txtperimetro.Name = "txtperimetro";
            this.txtperimetro.Size = new System.Drawing.Size(100, 22);
            this.txtperimetro.TabIndex = 35;
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(241, 640);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(100, 22);
            this.txtarea.TabIndex = 34;
            // 
            // lbperimetro
            // 
            this.lbperimetro.AutoSize = true;
            this.lbperimetro.Location = new System.Drawing.Point(574, 643);
            this.lbperimetro.Name = "lbperimetro";
            this.lbperimetro.Size = new System.Drawing.Size(68, 16);
            this.lbperimetro.TabIndex = 33;
            this.lbperimetro.Text = "Perimetro:";
            // 
            // lbarea
            // 
            this.lbarea.AutoSize = true;
            this.lbarea.Location = new System.Drawing.Point(167, 643);
            this.lbarea.Name = "lbarea";
            this.lbarea.Size = new System.Drawing.Size(39, 16);
            this.lbarea.TabIndex = 32;
            this.lbarea.Text = "Area:";
            // 
            // tBar
            // 
            this.tBar.Location = new System.Drawing.Point(145, 538);
            this.tBar.Maximum = 150;
            this.tBar.Minimum = 1;
            this.tBar.Name = "tBar";
            this.tBar.Size = new System.Drawing.Size(594, 56);
            this.tBar.TabIndex = 31;
            this.tBar.Value = 1;
            this.tBar.Scroll += new System.EventHandler(this.tBar_Scroll);
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(513, 42);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(75, 23);
            this.btnDibujar.TabIndex = 30;
            this.btnDibujar.Text = "dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // lbaltura
            // 
            this.lbaltura.AutoSize = true;
            this.lbaltura.Location = new System.Drawing.Point(116, 27);
            this.lbaltura.Name = "lbaltura";
            this.lbaltura.Size = new System.Drawing.Size(98, 16);
            this.lbaltura.TabIndex = 29;
            this.lbaltura.Text = "Tamaño Altura:";
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(145, 53);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 22);
            this.txtaltura.TabIndex = 28;
            // 
            // picBoxTransformacion
            // 
            this.picBoxTransformacion.Location = new System.Drawing.Point(82, 109);
            this.picBoxTransformacion.Name = "picBoxTransformacion";
            this.picBoxTransformacion.Size = new System.Drawing.Size(857, 423);
            this.picBoxTransformacion.TabIndex = 27;
            this.picBoxTransformacion.TabStop = false;
            // 
            // btnplus5
            // 
            this.btnplus5.Location = new System.Drawing.Point(813, 53);
            this.btnplus5.Name = "btnplus5";
            this.btnplus5.Size = new System.Drawing.Size(75, 23);
            this.btnplus5.TabIndex = 26;
            this.btnplus5.Text = "+5º";
            this.btnplus5.UseVisualStyleBackColor = true;
            this.btnplus5.Click += new System.EventHandler(this.btnplus5_Click);
            // 
            // btnminus5
            // 
            this.btnminus5.Location = new System.Drawing.Point(663, 52);
            this.btnminus5.Name = "btnminus5";
            this.btnminus5.Size = new System.Drawing.Size(75, 23);
            this.btnminus5.TabIndex = 25;
            this.btnminus5.Text = "-5º";
            this.btnminus5.UseVisualStyleBackColor = true;
            this.btnminus5.Click += new System.EventHandler(this.btnminus5_Click);
            // 
            // lbmostarTamanio
            // 
            this.lbmostarTamanio.AutoSize = true;
            this.lbmostarTamanio.Location = new System.Drawing.Point(763, 538);
            this.lbmostarTamanio.Name = "lbmostarTamanio";
            this.lbmostarTamanio.Size = new System.Drawing.Size(14, 16);
            this.lbmostarTamanio.TabIndex = 36;
            this.lbmostarTamanio.Text = "1";
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(327, 52);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(100, 22);
            this.txtbase.TabIndex = 37;
            // 
            // lbBase
            // 
            this.lbBase.AutoSize = true;
            this.lbBase.Location = new System.Drawing.Point(298, 27);
            this.lbBase.Name = "lbBase";
            this.lbBase.Size = new System.Drawing.Size(99, 16);
            this.lbBase.TabIndex = 38;
            this.lbBase.Text = "Tamanio Base:";
            // 
            // Formromboide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 688);
            this.Controls.Add(this.lbBase);
            this.Controls.Add(this.txtbase);
            this.Controls.Add(this.lbmostarTamanio);
            this.Controls.Add(this.txtperimetro);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.lbperimetro);
            this.Controls.Add(this.lbarea);
            this.Controls.Add(this.tBar);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.lbaltura);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.picBoxTransformacion);
            this.Controls.Add(this.btnplus5);
            this.Controls.Add(this.btnminus5);
            this.Name = "Formromboide";
            this.Text = "Formromboide";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Formromboide_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTransformacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtperimetro;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.Label lbperimetro;
        private System.Windows.Forms.Label lbarea;
        private System.Windows.Forms.TrackBar tBar;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Label lbaltura;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.PictureBox picBoxTransformacion;
        private System.Windows.Forms.Button btnplus5;
        private System.Windows.Forms.Button btnminus5;
        private System.Windows.Forms.Label lbmostarTamanio;
        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.Label lbBase;
    }
}