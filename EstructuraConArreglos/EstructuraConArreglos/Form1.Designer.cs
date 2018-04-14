namespace EstructuraConArreglos
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.bttnInsertar = new System.Windows.Forms.Button();
            this.bttnListar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInsertar = new System.Windows.Forms.TextBox();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(83, 44);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(129, 20);
            this.txtID.TabIndex = 0;
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.Location = new System.Drawing.Point(354, 41);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(75, 23);
            this.bttnAgregar.TabIndex = 1;
            this.bttnAgregar.Text = "Agregar";
            this.bttnAgregar.UseVisualStyleBackColor = true;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 88);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(83, 139);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(129, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(83, 186);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(129, 20);
            this.txtCosto.TabIndex = 4;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(449, 84);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(84, 20);
            this.txtBuscar.TabIndex = 5;
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(24, 248);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(495, 143);
            this.txtLista.TabIndex = 6;
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.Location = new System.Drawing.Point(354, 81);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(75, 23);
            this.bttnBuscar.TabIndex = 7;
            this.bttnBuscar.Text = "Buscar";
            this.bttnBuscar.UseVisualStyleBackColor = true;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.Location = new System.Drawing.Point(354, 119);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(75, 23);
            this.bttnEliminar.TabIndex = 8;
            this.bttnEliminar.Text = "Elimiinar";
            this.bttnEliminar.UseVisualStyleBackColor = true;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // bttnInsertar
            // 
            this.bttnInsertar.Location = new System.Drawing.Point(354, 158);
            this.bttnInsertar.Name = "bttnInsertar";
            this.bttnInsertar.Size = new System.Drawing.Size(75, 23);
            this.bttnInsertar.TabIndex = 9;
            this.bttnInsertar.Text = "Insertar";
            this.bttnInsertar.UseVisualStyleBackColor = true;
            this.bttnInsertar.Click += new System.EventHandler(this.bttnInsertar_Click);
            // 
            // bttnListar
            // 
            this.bttnListar.Location = new System.Drawing.Point(354, 193);
            this.bttnListar.Name = "bttnListar";
            this.bttnListar.Size = new System.Drawing.Size(75, 23);
            this.bttnListar.TabIndex = 10;
            this.bttnListar.Text = "Listar";
            this.bttnListar.UseVisualStyleBackColor = true;
            this.bttnListar.Click += new System.EventHandler(this.bttnListar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Costo:";
            // 
            // txtInsertar
            // 
            this.txtInsertar.Location = new System.Drawing.Point(449, 161);
            this.txtInsertar.Name = "txtInsertar";
            this.txtInsertar.Size = new System.Drawing.Size(84, 20);
            this.txtInsertar.TabIndex = 16;
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(449, 122);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(84, 20);
            this.txtEliminar.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 403);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.txtInsertar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnListar);
            this.Controls.Add(this.bttnInsertar);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.bttnBuscar);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.bttnAgregar);
            this.Controls.Add(this.txtID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button bttnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Button bttnBuscar;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.Button bttnInsertar;
        private System.Windows.Forms.Button bttnListar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInsertar;
        private System.Windows.Forms.TextBox txtEliminar;
    }
}

