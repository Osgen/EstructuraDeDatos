namespace Rutas
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
            this.txtTabla = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.bttnBusName = new System.Windows.Forms.Button();
            this.txtBusName = new System.Windows.Forms.TextBox();
            this.bttnListar = new System.Windows.Forms.Button();
            this.bttnEliminarUltimo = new System.Windows.Forms.Button();
            this.bttnEliminarInicio = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.bttnInsertar = new System.Windows.Forms.Button();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoBase = new System.Windows.Forms.TextBox();
            this.bttnRuta = new System.Windows.Forms.Button();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.txtHoraFin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTabla
            // 
            this.txtTabla.Location = new System.Drawing.Point(12, 160);
            this.txtTabla.Multiline = true;
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(504, 235);
            this.txtTabla.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(65, 77);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(100, 20);
            this.txtMinutos.TabIndex = 2;
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.Location = new System.Drawing.Point(195, 50);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(75, 23);
            this.bttnAgregar.TabIndex = 3;
            this.bttnAgregar.Text = "Agregar";
            this.bttnAgregar.UseVisualStyleBackColor = true;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // bttnBusName
            // 
            this.bttnBusName.Location = new System.Drawing.Point(573, 12);
            this.bttnBusName.Name = "bttnBusName";
            this.bttnBusName.Size = new System.Drawing.Size(75, 23);
            this.bttnBusName.TabIndex = 4;
            this.bttnBusName.Text = "Buscar";
            this.bttnBusName.UseVisualStyleBackColor = true;
            this.bttnBusName.Click += new System.EventHandler(this.bttnBusName_Click);
            // 
            // txtBusName
            // 
            this.txtBusName.Location = new System.Drawing.Point(451, 30);
            this.txtBusName.Name = "txtBusName";
            this.txtBusName.Size = new System.Drawing.Size(100, 20);
            this.txtBusName.TabIndex = 5;
            // 
            // bttnListar
            // 
            this.bttnListar.Location = new System.Drawing.Point(573, 360);
            this.bttnListar.Name = "bttnListar";
            this.bttnListar.Size = new System.Drawing.Size(75, 23);
            this.bttnListar.TabIndex = 6;
            this.bttnListar.Text = "Listar";
            this.bttnListar.UseVisualStyleBackColor = true;
            this.bttnListar.Click += new System.EventHandler(this.bttnListar_Click);
            // 
            // bttnEliminarUltimo
            // 
            this.bttnEliminarUltimo.Location = new System.Drawing.Point(564, 254);
            this.bttnEliminarUltimo.Name = "bttnEliminarUltimo";
            this.bttnEliminarUltimo.Size = new System.Drawing.Size(106, 23);
            this.bttnEliminarUltimo.TabIndex = 7;
            this.bttnEliminarUltimo.Text = "EliminarUltimo";
            this.bttnEliminarUltimo.UseVisualStyleBackColor = true;
            this.bttnEliminarUltimo.Click += new System.EventHandler(this.bttnEliminarUltimo_Click);
            // 
            // bttnEliminarInicio
            // 
            this.bttnEliminarInicio.Location = new System.Drawing.Point(564, 225);
            this.bttnEliminarInicio.Name = "bttnEliminarInicio";
            this.bttnEliminarInicio.Size = new System.Drawing.Size(106, 23);
            this.bttnEliminarInicio.TabIndex = 8;
            this.bttnEliminarInicio.Text = "EliminarInicio";
            this.bttnEliminarInicio.UseVisualStyleBackColor = true;
            this.bttnEliminarInicio.Click += new System.EventHandler(this.bttnEliminarInicio_Click);
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.Location = new System.Drawing.Point(573, 54);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(75, 23);
            this.bttnEliminar.TabIndex = 9;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.UseVisualStyleBackColor = true;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // bttnInsertar
            // 
            this.bttnInsertar.Location = new System.Drawing.Point(195, 92);
            this.bttnInsertar.Name = "bttnInsertar";
            this.bttnInsertar.Size = new System.Drawing.Size(75, 23);
            this.bttnInsertar.TabIndex = 10;
            this.bttnInsertar.Text = "Insertar";
            this.bttnInsertar.UseVisualStyleBackColor = true;
            this.bttnInsertar.Click += new System.EventHandler(this.bttnInsertar_Click);
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(276, 94);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(57, 20);
            this.txtPos.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Minutos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Posicion";
            // 
            // txtNoBase
            // 
            this.txtNoBase.Location = new System.Drawing.Point(483, 94);
            this.txtNoBase.Name = "txtNoBase";
            this.txtNoBase.Size = new System.Drawing.Size(96, 20);
            this.txtNoBase.TabIndex = 15;
            // 
            // bttnRuta
            // 
            this.bttnRuta.Location = new System.Drawing.Point(595, 131);
            this.bttnRuta.Name = "bttnRuta";
            this.bttnRuta.Size = new System.Drawing.Size(75, 23);
            this.bttnRuta.TabIndex = 16;
            this.bttnRuta.Text = "Ruta";
            this.bttnRuta.UseVisualStyleBackColor = true;
            this.bttnRuta.Click += new System.EventHandler(this.bttnRuta_Click);
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(522, 131);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(57, 20);
            this.txtHoraInicio.TabIndex = 17;
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.Location = new System.Drawing.Point(522, 168);
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.Size = new System.Drawing.Size(57, 20);
            this.txtHoraFin.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 424);
            this.Controls.Add(this.txtHoraFin);
            this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.bttnRuta);
            this.Controls.Add(this.txtNoBase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.bttnInsertar);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.bttnEliminarInicio);
            this.Controls.Add(this.bttnEliminarUltimo);
            this.Controls.Add(this.bttnListar);
            this.Controls.Add(this.txtBusName);
            this.Controls.Add(this.bttnBusName);
            this.Controls.Add(this.bttnAgregar);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtTabla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTabla;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.Button bttnAgregar;
        private System.Windows.Forms.Button bttnBusName;
        private System.Windows.Forms.TextBox txtBusName;
        private System.Windows.Forms.Button bttnListar;
        private System.Windows.Forms.Button bttnEliminarUltimo;
        private System.Windows.Forms.Button bttnEliminarInicio;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.Button bttnInsertar;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoBase;
        private System.Windows.Forms.Button bttnRuta;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.TextBox txtHoraFin;
    }
}

