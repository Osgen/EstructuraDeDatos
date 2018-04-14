namespace Carrera
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
            this.bttnComenzar = new System.Windows.Forms.Button();
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.txtC2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(90, 154);
            this.txtRes.Multiline = true;
            this.txtRes.Name = "txtRes";
            this.txtRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRes.Size = new System.Drawing.Size(166, 223);
            this.txtRes.TabIndex = 0;
            // 
            // bttnComenzar
            // 
            this.bttnComenzar.Location = new System.Drawing.Point(134, 114);
            this.bttnComenzar.Name = "bttnComenzar";
            this.bttnComenzar.Size = new System.Drawing.Size(75, 23);
            this.bttnComenzar.TabIndex = 1;
            this.bttnComenzar.Text = "Comenzar";
            this.bttnComenzar.UseVisualStyleBackColor = true;
            this.bttnComenzar.Click += new System.EventHandler(this.bttnComenzar_Click);
            // 
            // txtC1
            // 
            this.txtC1.Location = new System.Drawing.Point(43, 75);
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(100, 20);
            this.txtC1.TabIndex = 2;
            // 
            // txtC2
            // 
            this.txtC2.Location = new System.Drawing.Point(190, 75);
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(100, 20);
            this.txtC2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 400);
            this.Controls.Add(this.txtC2);
            this.Controls.Add(this.txtC1);
            this.Controls.Add(this.bttnComenzar);
            this.Controls.Add(this.txtRes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Button bttnComenzar;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.TextBox txtC2;
    }
}

