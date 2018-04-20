namespace GraficosTortuga
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
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.bttnAvanzar = new System.Windows.Forms.Button();
            this.bttnPB = new System.Windows.Forms.Button();
            this.bttnPA = new System.Windows.Forms.Button();
            this.bttnGirarD = new System.Windows.Forms.Button();
            this.bttnGirarI = new System.Windows.Forms.Button();
            this.bttnEmpezar = new System.Windows.Forms.Button();
            this.txtAvanzar = new System.Windows.Forms.TextBox();
            this.bttnMostrar = new System.Windows.Forms.Button();
            this.lblFlecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(43, 112);
            this.txtPiso.Multiline = true;
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(497, 523);
            this.txtPiso.TabIndex = 0;
            // 
            // bttnAvanzar
            // 
            this.bttnAvanzar.Location = new System.Drawing.Point(181, 39);
            this.bttnAvanzar.Name = "bttnAvanzar";
            this.bttnAvanzar.Size = new System.Drawing.Size(75, 23);
            this.bttnAvanzar.TabIndex = 1;
            this.bttnAvanzar.Text = "Avanzar";
            this.bttnAvanzar.UseVisualStyleBackColor = true;
            this.bttnAvanzar.Click += new System.EventHandler(this.bttnAvanzar_Click);
            // 
            // bttnPB
            // 
            this.bttnPB.Location = new System.Drawing.Point(283, 39);
            this.bttnPB.Name = "bttnPB";
            this.bttnPB.Size = new System.Drawing.Size(75, 23);
            this.bttnPB.TabIndex = 2;
            this.bttnPB.Text = "Bajar Pluma";
            this.bttnPB.UseVisualStyleBackColor = true;
            this.bttnPB.Click += new System.EventHandler(this.bttnPB_Click);
            // 
            // bttnPA
            // 
            this.bttnPA.Location = new System.Drawing.Point(283, 77);
            this.bttnPA.Name = "bttnPA";
            this.bttnPA.Size = new System.Drawing.Size(75, 23);
            this.bttnPA.TabIndex = 3;
            this.bttnPA.Text = "Subir Pluma";
            this.bttnPA.UseVisualStyleBackColor = true;
            this.bttnPA.Click += new System.EventHandler(this.bttnPA_Click);
            // 
            // bttnGirarD
            // 
            this.bttnGirarD.Location = new System.Drawing.Point(378, 39);
            this.bttnGirarD.Name = "bttnGirarD";
            this.bttnGirarD.Size = new System.Drawing.Size(95, 23);
            this.bttnGirarD.TabIndex = 4;
            this.bttnGirarD.Text = "Girar derecha";
            this.bttnGirarD.UseVisualStyleBackColor = true;
            this.bttnGirarD.Click += new System.EventHandler(this.bttnGirarD_Click);
            // 
            // bttnGirarI
            // 
            this.bttnGirarI.Location = new System.Drawing.Point(378, 77);
            this.bttnGirarI.Name = "bttnGirarI";
            this.bttnGirarI.Size = new System.Drawing.Size(95, 23);
            this.bttnGirarI.TabIndex = 5;
            this.bttnGirarI.Text = "Girar izquierda";
            this.bttnGirarI.UseVisualStyleBackColor = true;
            this.bttnGirarI.Click += new System.EventHandler(this.bttnGirarI_Click);
            // 
            // bttnEmpezar
            // 
            this.bttnEmpezar.Location = new System.Drawing.Point(181, 77);
            this.bttnEmpezar.Name = "bttnEmpezar";
            this.bttnEmpezar.Size = new System.Drawing.Size(75, 23);
            this.bttnEmpezar.TabIndex = 6;
            this.bttnEmpezar.Text = "Empezar";
            this.bttnEmpezar.UseVisualStyleBackColor = true;
            this.bttnEmpezar.Click += new System.EventHandler(this.bttnEmpezar_Click);
            // 
            // txtAvanzar
            // 
            this.txtAvanzar.Location = new System.Drawing.Point(108, 42);
            this.txtAvanzar.Name = "txtAvanzar";
            this.txtAvanzar.Size = new System.Drawing.Size(67, 20);
            this.txtAvanzar.TabIndex = 7;
            // 
            // bttnMostrar
            // 
            this.bttnMostrar.Location = new System.Drawing.Point(108, 77);
            this.bttnMostrar.Name = "bttnMostrar";
            this.bttnMostrar.Size = new System.Drawing.Size(67, 23);
            this.bttnMostrar.TabIndex = 8;
            this.bttnMostrar.Text = "Mostrar";
            this.bttnMostrar.UseVisualStyleBackColor = true;
            this.bttnMostrar.Click += new System.EventHandler(this.bttnMostrar_Click);
            // 
            // lblFlecha
            // 
            this.lblFlecha.AutoSize = true;
            this.lblFlecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlecha.Location = new System.Drawing.Point(513, 61);
            this.lblFlecha.Name = "lblFlecha";
            this.lblFlecha.Size = new System.Drawing.Size(0, 39);
            this.lblFlecha.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 654);
            this.Controls.Add(this.lblFlecha);
            this.Controls.Add(this.bttnMostrar);
            this.Controls.Add(this.txtAvanzar);
            this.Controls.Add(this.bttnEmpezar);
            this.Controls.Add(this.bttnGirarI);
            this.Controls.Add(this.bttnGirarD);
            this.Controls.Add(this.bttnPA);
            this.Controls.Add(this.bttnPB);
            this.Controls.Add(this.bttnAvanzar);
            this.Controls.Add(this.txtPiso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Button bttnAvanzar;
        private System.Windows.Forms.Button bttnPB;
        private System.Windows.Forms.Button bttnPA;
        private System.Windows.Forms.Button bttnGirarD;
        private System.Windows.Forms.Button bttnGirarI;
        private System.Windows.Forms.Button bttnEmpezar;
        private System.Windows.Forms.TextBox txtAvanzar;
        private System.Windows.Forms.Button bttnMostrar;
        private System.Windows.Forms.Label lblFlecha;
    }
}

