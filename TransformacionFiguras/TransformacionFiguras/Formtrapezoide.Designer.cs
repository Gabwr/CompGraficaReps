namespace TransformacionFiguras
{
    partial class Formtrapezoide
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
            this.lblado = new System.Windows.Forms.Label();
            this.txtbaseMayor = new System.Windows.Forms.TextBox();
            this.picBoxTransformacion = new System.Windows.Forms.PictureBox();
            this.btnplus5 = new System.Windows.Forms.Button();
            this.btnminus5 = new System.Windows.Forms.Button();
            this.lbmostarTamanio = new System.Windows.Forms.Label();
            this.lbBaseMenor = new System.Windows.Forms.Label();
            this.txtbaseMenor = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lbAltura = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTransformacion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtperimetro
            // 
            this.txtperimetro.Location = new System.Drawing.Point(686, 645);
            this.txtperimetro.Name = "txtperimetro";
            this.txtperimetro.Size = new System.Drawing.Size(100, 22);
            this.txtperimetro.TabIndex = 35;
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(264, 645);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(100, 22);
            this.txtarea.TabIndex = 34;
            // 
            // lbperimetro
            // 
            this.lbperimetro.AutoSize = true;
            this.lbperimetro.Location = new System.Drawing.Point(597, 648);
            this.lbperimetro.Name = "lbperimetro";
            this.lbperimetro.Size = new System.Drawing.Size(68, 16);
            this.lbperimetro.TabIndex = 33;
            this.lbperimetro.Text = "Perimetro:";
            // 
            // lbarea
            // 
            this.lbarea.AutoSize = true;
            this.lbarea.Location = new System.Drawing.Point(190, 648);
            this.lbarea.Name = "lbarea";
            this.lbarea.Size = new System.Drawing.Size(39, 16);
            this.lbarea.TabIndex = 32;
            this.lbarea.Text = "Area:";
            // 
            // tBar
            // 
            this.tBar.Location = new System.Drawing.Point(164, 564);
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
            this.btnDibujar.Location = new System.Drawing.Point(568, 57);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(75, 23);
            this.btnDibujar.TabIndex = 30;
            this.btnDibujar.Text = "dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // lblado
            // 
            this.lblado.AutoSize = true;
            this.lblado.Location = new System.Drawing.Point(64, 18);
            this.lblado.Name = "lblado";
            this.lblado.Size = new System.Drawing.Size(126, 16);
            this.lblado.TabIndex = 29;
            this.lblado.Text = "Tamaño bae mayor";
            // 
            // txtbaseMayor
            // 
            this.txtbaseMayor.Location = new System.Drawing.Point(83, 47);
            this.txtbaseMayor.Name = "txtbaseMayor";
            this.txtbaseMayor.Size = new System.Drawing.Size(100, 22);
            this.txtbaseMayor.TabIndex = 28;
            // 
            // picBoxTransformacion
            // 
            this.picBoxTransformacion.Location = new System.Drawing.Point(38, 97);
            this.picBoxTransformacion.Name = "picBoxTransformacion";
            this.picBoxTransformacion.Size = new System.Drawing.Size(944, 461);
            this.picBoxTransformacion.TabIndex = 27;
            this.picBoxTransformacion.TabStop = false;
            // 
            // btnplus5
            // 
            this.btnplus5.Location = new System.Drawing.Point(846, 58);
            this.btnplus5.Name = "btnplus5";
            this.btnplus5.Size = new System.Drawing.Size(75, 23);
            this.btnplus5.TabIndex = 26;
            this.btnplus5.Text = "+5º";
            this.btnplus5.UseVisualStyleBackColor = true;
            this.btnplus5.Click += new System.EventHandler(this.btnplus5_Click);
            // 
            // btnminus5
            // 
            this.btnminus5.Location = new System.Drawing.Point(711, 58);
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
            this.lbmostarTamanio.Location = new System.Drawing.Point(782, 574);
            this.lbmostarTamanio.Name = "lbmostarTamanio";
            this.lbmostarTamanio.Size = new System.Drawing.Size(14, 16);
            this.lbmostarTamanio.TabIndex = 36;
            this.lbmostarTamanio.Text = "1";
            // 
            // lbBaseMenor
            // 
            this.lbBaseMenor.AutoSize = true;
            this.lbBaseMenor.Location = new System.Drawing.Point(230, 18);
            this.lbBaseMenor.Name = "lbBaseMenor";
            this.lbBaseMenor.Size = new System.Drawing.Size(140, 16);
            this.lbBaseMenor.TabIndex = 40;
            this.lbBaseMenor.Text = "Tamanio Base Menor:";
            // 
            // txtbaseMenor
            // 
            this.txtbaseMenor.Location = new System.Drawing.Point(264, 47);
            this.txtbaseMenor.Name = "txtbaseMenor";
            this.txtbaseMenor.Size = new System.Drawing.Size(100, 22);
            this.txtbaseMenor.TabIndex = 39;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(415, 47);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 22);
            this.txtAltura.TabIndex = 41;
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Location = new System.Drawing.Point(399, 18);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(101, 16);
            this.lbAltura.TabIndex = 42;
            this.lbAltura.Text = "Tamanio Altura:";
            // 
            // Formtrapezoide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 675);
            this.Controls.Add(this.lbAltura);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lbBaseMenor);
            this.Controls.Add(this.txtbaseMenor);
            this.Controls.Add(this.lbmostarTamanio);
            this.Controls.Add(this.txtperimetro);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.lbperimetro);
            this.Controls.Add(this.lbarea);
            this.Controls.Add(this.tBar);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.lblado);
            this.Controls.Add(this.txtbaseMayor);
            this.Controls.Add(this.picBoxTransformacion);
            this.Controls.Add(this.btnplus5);
            this.Controls.Add(this.btnminus5);
            this.Name = "Formtrapezoide";
            this.Text = "Formtrapezoide";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Formtrapezoide_KeyDown);
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
        private System.Windows.Forms.Label lblado;
        private System.Windows.Forms.TextBox txtbaseMayor;
        private System.Windows.Forms.PictureBox picBoxTransformacion;
        private System.Windows.Forms.Button btnplus5;
        private System.Windows.Forms.Button btnminus5;
        private System.Windows.Forms.Label lbmostarTamanio;
        private System.Windows.Forms.Label lbBaseMenor;
        private System.Windows.Forms.TextBox txtbaseMenor;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lbAltura;
    }
}