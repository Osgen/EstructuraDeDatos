namespace LiebreYTortuga
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
            this.bttnCarrera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(12, 39);
            this.txtRes.Multiline = true;
            this.txtRes.Name = "txtRes";
            this.txtRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRes.Size = new System.Drawing.Size(178, 257);
            this.txtRes.TabIndex = 0;
            // 
            // bttnCarrera
            // 
            this.bttnCarrera.Location = new System.Drawing.Point(221, 62);
            this.bttnCarrera.Name = "bttnCarrera";
            this.bttnCarrera.Size = new System.Drawing.Size(96, 45);
            this.bttnCarrera.TabIndex = 1;
            this.bttnCarrera.Text = "Carrera";
            this.bttnCarrera.UseVisualStyleBackColor = true;
            this.bttnCarrera.Click += new System.EventHandler(this.bttnCarrera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 308);
            this.Controls.Add(this.bttnCarrera);
            this.Controls.Add(this.txtRes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Button bttnCarrera;
    }
}

