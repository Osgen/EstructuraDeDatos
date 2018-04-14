namespace MatrizPrac
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
            this.txtMatriz = new System.Windows.Forms.TextBox();
            this.bttnLlenar = new System.Windows.Forms.Button();
            this.bttnMostrar = new System.Windows.Forms.Button();
            this.bttnLlenarColumna = new System.Windows.Forms.Button();
            this.bttnLlenarInverso = new System.Windows.Forms.Button();
            this.bttnDP = new System.Windows.Forms.Button();
            this.bttnMostrarDs = new System.Windows.Forms.Button();
            this.bttnAbajoDP = new System.Windows.Forms.Button();
            this.bttnAbajoDS = new System.Windows.Forms.Button();
            this.bttnGiroDP = new System.Windows.Forms.Button();
            this.bttnGiroDS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMatriz
            // 
            this.txtMatriz.Location = new System.Drawing.Point(12, 86);
            this.txtMatriz.Multiline = true;
            this.txtMatriz.Name = "txtMatriz";
            this.txtMatriz.Size = new System.Drawing.Size(274, 188);
            this.txtMatriz.TabIndex = 0;
            // 
            // bttnLlenar
            // 
            this.bttnLlenar.Location = new System.Drawing.Point(335, 86);
            this.bttnLlenar.Name = "bttnLlenar";
            this.bttnLlenar.Size = new System.Drawing.Size(75, 23);
            this.bttnLlenar.TabIndex = 1;
            this.bttnLlenar.Text = "LLenar";
            this.bttnLlenar.UseVisualStyleBackColor = true;
            this.bttnLlenar.Click += new System.EventHandler(this.bttnLlenar_Click);
            // 
            // bttnMostrar
            // 
            this.bttnMostrar.Location = new System.Drawing.Point(335, 216);
            this.bttnMostrar.Name = "bttnMostrar";
            this.bttnMostrar.Size = new System.Drawing.Size(75, 23);
            this.bttnMostrar.TabIndex = 2;
            this.bttnMostrar.Text = "Mostrar";
            this.bttnMostrar.UseVisualStyleBackColor = true;
            this.bttnMostrar.Click += new System.EventHandler(this.bttnMostrar_Click);
            // 
            // bttnLlenarColumna
            // 
            this.bttnLlenarColumna.Location = new System.Drawing.Point(304, 123);
            this.bttnLlenarColumna.Name = "bttnLlenarColumna";
            this.bttnLlenarColumna.Size = new System.Drawing.Size(106, 23);
            this.bttnLlenarColumna.TabIndex = 3;
            this.bttnLlenarColumna.Text = "LLenar Columna";
            this.bttnLlenarColumna.UseVisualStyleBackColor = true;
            this.bttnLlenarColumna.Click += new System.EventHandler(this.bttnLlenarColumna_Click);
            // 
            // bttnLlenarInverso
            // 
            this.bttnLlenarInverso.Location = new System.Drawing.Point(304, 152);
            this.bttnLlenarInverso.Name = "bttnLlenarInverso";
            this.bttnLlenarInverso.Size = new System.Drawing.Size(106, 23);
            this.bttnLlenarInverso.TabIndex = 4;
            this.bttnLlenarInverso.Text = "LLenar Inverso";
            this.bttnLlenarInverso.UseVisualStyleBackColor = true;
            this.bttnLlenarInverso.Click += new System.EventHandler(this.bttnLlenarInverso_Click);
            // 
            // bttnDP
            // 
            this.bttnDP.Location = new System.Drawing.Point(304, 251);
            this.bttnDP.Name = "bttnDP";
            this.bttnDP.Size = new System.Drawing.Size(106, 23);
            this.bttnDP.TabIndex = 5;
            this.bttnDP.Text = "Mostrar DP";
            this.bttnDP.UseVisualStyleBackColor = true;
            this.bttnDP.Click += new System.EventHandler(this.bttnDP_Click);
            // 
            // bttnMostrarDs
            // 
            this.bttnMostrarDs.Location = new System.Drawing.Point(304, 280);
            this.bttnMostrarDs.Name = "bttnMostrarDs";
            this.bttnMostrarDs.Size = new System.Drawing.Size(106, 23);
            this.bttnMostrarDs.TabIndex = 6;
            this.bttnMostrarDs.Text = "Mostrar DS";
            this.bttnMostrarDs.UseVisualStyleBackColor = true;
            this.bttnMostrarDs.Click += new System.EventHandler(this.bttnMostrarDs_Click);
            // 
            // bttnAbajoDP
            // 
            this.bttnAbajoDP.Location = new System.Drawing.Point(304, 309);
            this.bttnAbajoDP.Name = "bttnAbajoDP";
            this.bttnAbajoDP.Size = new System.Drawing.Size(106, 23);
            this.bttnAbajoDP.TabIndex = 7;
            this.bttnAbajoDP.Text = "Mostrar Abajo DP";
            this.bttnAbajoDP.UseVisualStyleBackColor = true;
            this.bttnAbajoDP.Click += new System.EventHandler(this.bttnAbajoDP_Click);
            // 
            // bttnAbajoDS
            // 
            this.bttnAbajoDS.Location = new System.Drawing.Point(304, 338);
            this.bttnAbajoDS.Name = "bttnAbajoDS";
            this.bttnAbajoDS.Size = new System.Drawing.Size(106, 23);
            this.bttnAbajoDS.TabIndex = 8;
            this.bttnAbajoDS.Text = "Mostrar Abajo DS";
            this.bttnAbajoDS.UseVisualStyleBackColor = true;
            this.bttnAbajoDS.Click += new System.EventHandler(this.bttnAbajoDS_Click);
            // 
            // bttnGiroDP
            // 
            this.bttnGiroDP.Location = new System.Drawing.Point(74, 280);
            this.bttnGiroDP.Name = "bttnGiroDP";
            this.bttnGiroDP.Size = new System.Drawing.Size(106, 23);
            this.bttnGiroDP.TabIndex = 9;
            this.bttnGiroDP.Text = "Giro DP";
            this.bttnGiroDP.UseVisualStyleBackColor = true;
            this.bttnGiroDP.Click += new System.EventHandler(this.bttnGiroDP_Click);
            // 
            // bttnGiroDS
            // 
            this.bttnGiroDS.Location = new System.Drawing.Point(74, 309);
            this.bttnGiroDS.Name = "bttnGiroDS";
            this.bttnGiroDS.Size = new System.Drawing.Size(106, 23);
            this.bttnGiroDS.TabIndex = 10;
            this.bttnGiroDS.Text = "Giro DS";
            this.bttnGiroDS.UseVisualStyleBackColor = true;
            this.bttnGiroDS.Click += new System.EventHandler(this.bttnGiroDS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 367);
            this.Controls.Add(this.bttnGiroDS);
            this.Controls.Add(this.bttnGiroDP);
            this.Controls.Add(this.bttnAbajoDS);
            this.Controls.Add(this.bttnAbajoDP);
            this.Controls.Add(this.bttnMostrarDs);
            this.Controls.Add(this.bttnDP);
            this.Controls.Add(this.bttnLlenarInverso);
            this.Controls.Add(this.bttnLlenarColumna);
            this.Controls.Add(this.bttnMostrar);
            this.Controls.Add(this.bttnLlenar);
            this.Controls.Add(this.txtMatriz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatriz;
        private System.Windows.Forms.Button bttnLlenar;
        private System.Windows.Forms.Button bttnMostrar;
        private System.Windows.Forms.Button bttnLlenarColumna;
        private System.Windows.Forms.Button bttnLlenarInverso;
        private System.Windows.Forms.Button bttnDP;
        private System.Windows.Forms.Button bttnMostrarDs;
        private System.Windows.Forms.Button bttnAbajoDP;
        private System.Windows.Forms.Button bttnAbajoDS;
        private System.Windows.Forms.Button bttnGiroDP;
        private System.Windows.Forms.Button bttnGiroDS;
    }
}

