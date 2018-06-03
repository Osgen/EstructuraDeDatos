namespace AtencionProcesos
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
            this.txtSimulacion = new System.Windows.Forms.TextBox();
            this.bttnSimular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSimulacion
            // 
            this.txtSimulacion.Location = new System.Drawing.Point(29, 42);
            this.txtSimulacion.Multiline = true;
            this.txtSimulacion.Name = "txtSimulacion";
            this.txtSimulacion.Size = new System.Drawing.Size(239, 121);
            this.txtSimulacion.TabIndex = 0;
            // 
            // bttnSimular
            // 
            this.bttnSimular.Location = new System.Drawing.Point(311, 59);
            this.bttnSimular.Name = "bttnSimular";
            this.bttnSimular.Size = new System.Drawing.Size(75, 23);
            this.bttnSimular.TabIndex = 1;
            this.bttnSimular.Text = "Simular";
            this.bttnSimular.UseVisualStyleBackColor = true;
            this.bttnSimular.Click += new System.EventHandler(this.bttnSimular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 187);
            this.Controls.Add(this.bttnSimular);
            this.Controls.Add(this.txtSimulacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSimulacion;
        private System.Windows.Forms.Button bttnSimular;
    }
}

