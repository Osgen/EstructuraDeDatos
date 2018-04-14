namespace PracticaBits
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bttnProcesar = new System.Windows.Forms.Button();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.imgSensor1 = new System.Windows.Forms.ImageList(this.components);
            this.pbSensor1 = new System.Windows.Forms.PictureBox();
            this.pbSensor2 = new System.Windows.Forms.PictureBox();
            this.imgSensor2 = new System.Windows.Forms.ImageList(this.components);
            this.imgEstanque = new System.Windows.Forms.ImageList(this.components);
            this.pbEstanque = new System.Windows.Forms.PictureBox();
            this.imgDireccion = new System.Windows.Forms.ImageList(this.components);
            this.pbDireccion = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFechaLectura = new System.Windows.Forms.Label();
            this.bttnAjustarFecha = new System.Windows.Forms.Button();
            this.txtAjustarFecha = new System.Windows.Forms.TextBox();
            this.txtAjustar = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSensor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSensor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstanque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDireccion)).BeginInit();
            this.Date.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnProcesar
            // 
            this.bttnProcesar.Location = new System.Drawing.Point(226, 65);
            this.bttnProcesar.Name = "bttnProcesar";
            this.bttnProcesar.Size = new System.Drawing.Size(75, 23);
            this.bttnProcesar.TabIndex = 0;
            this.bttnProcesar.Text = "Procesar";
            this.bttnProcesar.UseVisualStyleBackColor = true;
            this.bttnProcesar.Click += new System.EventHandler(this.bttnProcesar_Click);
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(105, 68);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtEntrada.TabIndex = 1;
            // 
            // imgSensor1
            // 
            this.imgSensor1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgSensor1.ImageStream")));
            this.imgSensor1.TransparentColor = System.Drawing.Color.Transparent;
            this.imgSensor1.Images.SetKeyName(0, "on.png");
            this.imgSensor1.Images.SetKeyName(1, "off.png");
            // 
            // pbSensor1
            // 
            this.pbSensor1.Location = new System.Drawing.Point(32, 136);
            this.pbSensor1.Name = "pbSensor1";
            this.pbSensor1.Size = new System.Drawing.Size(152, 156);
            this.pbSensor1.TabIndex = 2;
            this.pbSensor1.TabStop = false;
            // 
            // pbSensor2
            // 
            this.pbSensor2.Location = new System.Drawing.Point(190, 136);
            this.pbSensor2.Name = "pbSensor2";
            this.pbSensor2.Size = new System.Drawing.Size(152, 156);
            this.pbSensor2.TabIndex = 3;
            this.pbSensor2.TabStop = false;
            // 
            // imgSensor2
            // 
            this.imgSensor2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgSensor2.ImageStream")));
            this.imgSensor2.TransparentColor = System.Drawing.Color.Transparent;
            this.imgSensor2.Images.SetKeyName(0, "on.png");
            this.imgSensor2.Images.SetKeyName(1, "off.png");
            // 
            // imgEstanque
            // 
            this.imgEstanque.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgEstanque.ImageStream")));
            this.imgEstanque.TransparentColor = System.Drawing.Color.Transparent;
            this.imgEstanque.Images.SetKeyName(0, "vacio.png");
            this.imgEstanque.Images.SetKeyName(1, "medio.png");
            this.imgEstanque.Images.SetKeyName(2, "lleno.png");
            this.imgEstanque.Images.SetKeyName(3, "llenando.png");
            // 
            // pbEstanque
            // 
            this.pbEstanque.Location = new System.Drawing.Point(348, 136);
            this.pbEstanque.Name = "pbEstanque";
            this.pbEstanque.Size = new System.Drawing.Size(152, 200);
            this.pbEstanque.TabIndex = 4;
            this.pbEstanque.TabStop = false;
            // 
            // imgDireccion
            // 
            this.imgDireccion.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgDireccion.ImageStream")));
            this.imgDireccion.TransparentColor = System.Drawing.Color.Transparent;
            this.imgDireccion.Images.SetKeyName(0, "1.png");
            this.imgDireccion.Images.SetKeyName(1, "2.png");
            this.imgDireccion.Images.SetKeyName(2, "3.png");
            this.imgDireccion.Images.SetKeyName(3, "4.png");
            this.imgDireccion.Images.SetKeyName(4, "5.png");
            this.imgDireccion.Images.SetKeyName(5, "6.png");
            this.imgDireccion.Images.SetKeyName(6, "7.png");
            this.imgDireccion.Images.SetKeyName(7, "8.png");
            // 
            // pbDireccion
            // 
            this.pbDireccion.Location = new System.Drawing.Point(502, 136);
            this.pbDireccion.Name = "pbDireccion";
            this.pbDireccion.Size = new System.Drawing.Size(167, 129);
            this.pbDireccion.TabIndex = 5;
            this.pbDireccion.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(59, 313);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(79, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha Lectura:";
            // 
            // lblFechaLectura
            // 
            this.lblFechaLectura.AutoSize = true;
            this.lblFechaLectura.Location = new System.Drawing.Point(144, 313);
            this.lblFechaLectura.Name = "lblFechaLectura";
            this.lblFechaLectura.Size = new System.Drawing.Size(0, 13);
            this.lblFechaLectura.TabIndex = 7;
            // 
            // bttnAjustarFecha
            // 
            this.bttnAjustarFecha.Location = new System.Drawing.Point(106, 65);
            this.bttnAjustarFecha.Name = "bttnAjustarFecha";
            this.bttnAjustarFecha.Size = new System.Drawing.Size(100, 23);
            this.bttnAjustarFecha.TabIndex = 9;
            this.bttnAjustarFecha.Text = "Ajustar Fecha";
            this.bttnAjustarFecha.UseVisualStyleBackColor = true;
            this.bttnAjustarFecha.Click += new System.EventHandler(this.bttnAjustarFecha_Click);
            // 
            // txtAjustarFecha
            // 
            this.txtAjustarFecha.Location = new System.Drawing.Point(106, 109);
            this.txtAjustarFecha.Name = "txtAjustarFecha";
            this.txtAjustarFecha.Size = new System.Drawing.Size(100, 20);
            this.txtAjustarFecha.TabIndex = 10;
            // 
            // txtAjustar
            // 
            this.txtAjustar.Location = new System.Drawing.Point(106, 39);
            this.txtAjustar.Name = "txtAjustar";
            this.txtAjustar.Size = new System.Drawing.Size(100, 20);
            this.txtAjustar.TabIndex = 11;
            // 
            // Date
            // 
            this.Date.Controls.Add(this.label1);
            this.Date.Controls.Add(this.txtAjustar);
            this.Date.Controls.Add(this.bttnAjustarFecha);
            this.Date.Controls.Add(this.txtAjustarFecha);
            this.Date.Location = new System.Drawing.Point(-1, 366);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(709, 217);
            this.Date.TabIndex = 12;
            this.Date.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Entrada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sensor 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sensor 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Estanque";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(554, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Direccion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(708, 543);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.lblFechaLectura);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.pbDireccion);
            this.Controls.Add(this.pbEstanque);
            this.Controls.Add(this.pbSensor2);
            this.Controls.Add(this.pbSensor1);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.bttnProcesar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbSensor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSensor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstanque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDireccion)).EndInit();
            this.Date.ResumeLayout(false);
            this.Date.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnProcesar;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.ImageList imgSensor1;
        private System.Windows.Forms.PictureBox pbSensor1;
        private System.Windows.Forms.PictureBox pbSensor2;
        private System.Windows.Forms.ImageList imgSensor2;
        private System.Windows.Forms.ImageList imgEstanque;
        private System.Windows.Forms.PictureBox pbEstanque;
        private System.Windows.Forms.ImageList imgDireccion;
        private System.Windows.Forms.PictureBox pbDireccion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFechaLectura;
        private System.Windows.Forms.Button bttnAjustarFecha;
        private System.Windows.Forms.TextBox txtAjustarFecha;
        private System.Windows.Forms.TextBox txtAjustar;
        private System.Windows.Forms.GroupBox Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

