namespace ExpresionesAlgoritmicas
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.txtPreOrder = new System.Windows.Forms.TextBox();
            this.bttnPreOrder = new System.Windows.Forms.Button();
            this.txtPostOrder = new System.Windows.Forms.TextBox();
            this.bttnPostOrder = new System.Windows.Forms.Button();
            this.txtResultadoPre = new System.Windows.Forms.TextBox();
            this.txtResultadoPost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(31, 67);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(166, 20);
            this.txtValor.TabIndex = 0;
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.Location = new System.Drawing.Point(249, 64);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(75, 23);
            this.bttnAgregar.TabIndex = 1;
            this.bttnAgregar.Text = "Agregar";
            this.bttnAgregar.UseVisualStyleBackColor = true;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // txtPreOrder
            // 
            this.txtPreOrder.Location = new System.Drawing.Point(31, 125);
            this.txtPreOrder.Name = "txtPreOrder";
            this.txtPreOrder.Size = new System.Drawing.Size(166, 20);
            this.txtPreOrder.TabIndex = 2;
            // 
            // bttnPreOrder
            // 
            this.bttnPreOrder.Location = new System.Drawing.Point(249, 125);
            this.bttnPreOrder.Name = "bttnPreOrder";
            this.bttnPreOrder.Size = new System.Drawing.Size(75, 23);
            this.bttnPreOrder.TabIndex = 3;
            this.bttnPreOrder.Text = "PreOrder";
            this.bttnPreOrder.UseVisualStyleBackColor = true;
            this.bttnPreOrder.Click += new System.EventHandler(this.bttnPreOrder_Click);
            // 
            // txtPostOrder
            // 
            this.txtPostOrder.Location = new System.Drawing.Point(31, 222);
            this.txtPostOrder.Name = "txtPostOrder";
            this.txtPostOrder.Size = new System.Drawing.Size(166, 20);
            this.txtPostOrder.TabIndex = 4;
            // 
            // bttnPostOrder
            // 
            this.bttnPostOrder.Location = new System.Drawing.Point(249, 219);
            this.bttnPostOrder.Name = "bttnPostOrder";
            this.bttnPostOrder.Size = new System.Drawing.Size(75, 23);
            this.bttnPostOrder.TabIndex = 5;
            this.bttnPostOrder.Text = "PostOrder";
            this.bttnPostOrder.UseVisualStyleBackColor = true;
            this.bttnPostOrder.Click += new System.EventHandler(this.bttnPostOrder_Click);
            // 
            // txtResultadoPre
            // 
            this.txtResultadoPre.Location = new System.Drawing.Point(131, 151);
            this.txtResultadoPre.Name = "txtResultadoPre";
            this.txtResultadoPre.Size = new System.Drawing.Size(66, 20);
            this.txtResultadoPre.TabIndex = 6;
            // 
            // txtResultadoPost
            // 
            this.txtResultadoPost.Location = new System.Drawing.Point(131, 248);
            this.txtResultadoPost.Name = "txtResultadoPost";
            this.txtResultadoPost.Size = new System.Drawing.Size(66, 20);
            this.txtResultadoPost.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 333);
            this.Controls.Add(this.txtResultadoPost);
            this.Controls.Add(this.txtResultadoPre);
            this.Controls.Add(this.bttnPostOrder);
            this.Controls.Add(this.txtPostOrder);
            this.Controls.Add(this.bttnPreOrder);
            this.Controls.Add(this.txtPreOrder);
            this.Controls.Add(this.bttnAgregar);
            this.Controls.Add(this.txtValor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button bttnAgregar;
        private System.Windows.Forms.TextBox txtPreOrder;
        private System.Windows.Forms.Button bttnPreOrder;
        private System.Windows.Forms.TextBox txtPostOrder;
        private System.Windows.Forms.Button bttnPostOrder;
        private System.Windows.Forms.TextBox txtResultadoPre;
        private System.Windows.Forms.TextBox txtResultadoPost;
    }
}

