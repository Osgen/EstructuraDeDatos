namespace Simulador_Dados
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
            this.txtRes = new System.Windows.Forms.TextBox();
            this.bttnTirar = new System.Windows.Forms.Button();
            this.bttn2Dados = new System.Windows.Forms.Button();
            this.bttn2D = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(12, 37);
            this.txtRes.Multiline = true;
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(177, 163);
            this.txtRes.TabIndex = 0;
            // 
            // bttnTirar
            // 
            this.bttnTirar.Location = new System.Drawing.Point(212, 51);
            this.bttnTirar.Name = "bttnTirar";
            this.bttnTirar.Size = new System.Drawing.Size(102, 36);
            this.bttnTirar.TabIndex = 1;
            this.bttnTirar.Text = "Tirar 100 veces";
            this.bttnTirar.UseVisualStyleBackColor = true;
            this.bttnTirar.Click += new System.EventHandler(this.bttnTirar_Click);
            // 
            // bttn2Dados
            // 
            this.bttn2Dados.Location = new System.Drawing.Point(212, 111);
            this.bttn2Dados.Name = "bttn2Dados";
            this.bttn2Dados.Size = new System.Drawing.Size(102, 46);
            this.bttn2Dados.TabIndex = 2;
            this.bttn2Dados.Text = "Tirar 2 caras 100 veces";
            this.bttn2Dados.UseVisualStyleBackColor = true;
            this.bttn2Dados.Click += new System.EventHandler(this.bttn2Dados_Click);
            // 
            // bttn2D
            // 
            this.bttn2D.Location = new System.Drawing.Point(212, 163);
            this.bttn2D.Name = "bttn2D";
            this.bttn2D.Size = new System.Drawing.Size(102, 46);
            this.bttn2D.TabIndex = 3;
            this.bttn2D.Text = "2 dados";
            this.bttn2D.UseVisualStyleBackColor = true;
            this.bttn2D.Click += new System.EventHandler(this.bttn2D_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 228);
            this.Controls.Add(this.bttn2D);
            this.Controls.Add(this.bttn2Dados);
            this.Controls.Add(this.bttnTirar);
            this.Controls.Add(this.txtRes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Button bttnTirar;
        private System.Windows.Forms.Button bttn2Dados;
        private System.Windows.Forms.Button bttn2D;
    }
}

