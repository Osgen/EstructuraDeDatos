namespace Elavador
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
            this.txtElevador = new System.Windows.Forms.TextBox();
            this.bttnP1 = new System.Windows.Forms.Button();
            this.bttnP2 = new System.Windows.Forms.Button();
            this.bttnP4 = new System.Windows.Forms.Button();
            this.bttnP3 = new System.Windows.Forms.Button();
            this.bttnP5 = new System.Windows.Forms.Button();
            this.bttnP6 = new System.Windows.Forms.Button();
            this.bttnCerrar = new System.Windows.Forms.Button();
            this.bttnAbrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtElevador
            // 
            this.txtElevador.Location = new System.Drawing.Point(43, 88);
            this.txtElevador.Multiline = true;
            this.txtElevador.Name = "txtElevador";
            this.txtElevador.Size = new System.Drawing.Size(100, 74);
            this.txtElevador.TabIndex = 0;
            // 
            // bttnP1
            // 
            this.bttnP1.Location = new System.Drawing.Point(182, 189);
            this.bttnP1.Name = "bttnP1";
            this.bttnP1.Size = new System.Drawing.Size(40, 23);
            this.bttnP1.TabIndex = 1;
            this.bttnP1.Text = "1";
            this.bttnP1.UseVisualStyleBackColor = true;
            this.bttnP1.Click += new System.EventHandler(this.bttnP1_Click);
            // 
            // bttnP2
            // 
            this.bttnP2.Location = new System.Drawing.Point(182, 160);
            this.bttnP2.Name = "bttnP2";
            this.bttnP2.Size = new System.Drawing.Size(40, 23);
            this.bttnP2.TabIndex = 2;
            this.bttnP2.Text = "2";
            this.bttnP2.UseVisualStyleBackColor = true;
            this.bttnP2.Click += new System.EventHandler(this.bttnP1_Click);
            // 
            // bttnP4
            // 
            this.bttnP4.Location = new System.Drawing.Point(182, 100);
            this.bttnP4.Name = "bttnP4";
            this.bttnP4.Size = new System.Drawing.Size(40, 23);
            this.bttnP4.TabIndex = 4;
            this.bttnP4.Text = "4";
            this.bttnP4.UseVisualStyleBackColor = true;
            this.bttnP4.Click += new System.EventHandler(this.bttnP1_Click);
            // 
            // bttnP3
            // 
            this.bttnP3.Location = new System.Drawing.Point(182, 129);
            this.bttnP3.Name = "bttnP3";
            this.bttnP3.Size = new System.Drawing.Size(40, 23);
            this.bttnP3.TabIndex = 3;
            this.bttnP3.Text = "3";
            this.bttnP3.UseVisualStyleBackColor = true;
            this.bttnP3.Click += new System.EventHandler(this.bttnP1_Click);
            // 
            // bttnP5
            // 
            this.bttnP5.Location = new System.Drawing.Point(182, 71);
            this.bttnP5.Name = "bttnP5";
            this.bttnP5.Size = new System.Drawing.Size(40, 23);
            this.bttnP5.TabIndex = 5;
            this.bttnP5.Text = "5";
            this.bttnP5.UseVisualStyleBackColor = true;
            this.bttnP5.Click += new System.EventHandler(this.bttnP1_Click);
            // 
            // bttnP6
            // 
            this.bttnP6.Location = new System.Drawing.Point(182, 42);
            this.bttnP6.Name = "bttnP6";
            this.bttnP6.Size = new System.Drawing.Size(40, 23);
            this.bttnP6.TabIndex = 6;
            this.bttnP6.Text = "6";
            this.bttnP6.UseVisualStyleBackColor = true;
            this.bttnP6.Click += new System.EventHandler(this.bttnP1_Click);
            // 
            // bttnCerrar
            // 
            this.bttnCerrar.Location = new System.Drawing.Point(12, 221);
            this.bttnCerrar.Name = "bttnCerrar";
            this.bttnCerrar.Size = new System.Drawing.Size(75, 23);
            this.bttnCerrar.TabIndex = 7;
            this.bttnCerrar.Text = "Cerrar";
            this.bttnCerrar.UseVisualStyleBackColor = true;
            this.bttnCerrar.Click += new System.EventHandler(this.bttnCerrar_Click);
            // 
            // bttnAbrir
            // 
            this.bttnAbrir.Location = new System.Drawing.Point(103, 221);
            this.bttnAbrir.Name = "bttnAbrir";
            this.bttnAbrir.Size = new System.Drawing.Size(75, 23);
            this.bttnAbrir.TabIndex = 8;
            this.bttnAbrir.Text = "Abrir";
            this.bttnAbrir.UseVisualStyleBackColor = true;
            this.bttnAbrir.Click += new System.EventHandler(this.bttnAbrir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 300);
            this.Controls.Add(this.bttnAbrir);
            this.Controls.Add(this.bttnCerrar);
            this.Controls.Add(this.bttnP6);
            this.Controls.Add(this.bttnP5);
            this.Controls.Add(this.bttnP3);
            this.Controls.Add(this.bttnP4);
            this.Controls.Add(this.bttnP2);
            this.Controls.Add(this.bttnP1);
            this.Controls.Add(this.txtElevador);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtElevador;
        private System.Windows.Forms.Button bttnP1;
        private System.Windows.Forms.Button bttnP2;
        private System.Windows.Forms.Button bttnP4;
        private System.Windows.Forms.Button bttnP3;
        private System.Windows.Forms.Button bttnP5;
        private System.Windows.Forms.Button bttnP6;
        private System.Windows.Forms.Button bttnCerrar;
        private System.Windows.Forms.Button bttnAbrir;
    }
}

