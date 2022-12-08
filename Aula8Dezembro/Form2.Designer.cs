namespace Aula8Dezembro
{
    partial class Form2
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
            this.inputTexto = new System.Windows.Forms.TextBox();
            this.tela = new System.Windows.Forms.TextBox();
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTexto
            // 
            this.inputTexto.Location = new System.Drawing.Point(12, 12);
            this.inputTexto.Multiline = true;
            this.inputTexto.Name = "inputTexto";
            this.inputTexto.Size = new System.Drawing.Size(173, 31);
            this.inputTexto.TabIndex = 0;
            this.inputTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // tela
            // 
            this.tela.Location = new System.Drawing.Point(12, 60);
            this.tela.Multiline = true;
            this.tela.Name = "tela";
            this.tela.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tela.Size = new System.Drawing.Size(382, 365);
            this.tela.TabIndex = 1;
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Location = new System.Drawing.Point(417, 12);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(102, 54);
            this.botaoLimpar.TabIndex = 2;
            this.botaoLimpar.Text = "LIMPAR";
            this.botaoLimpar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 450);
            this.Controls.Add(this.botaoLimpar);
            this.Controls.Add(this.tela);
            this.Controls.Add(this.inputTexto);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTexto;
        private System.Windows.Forms.TextBox tela;
        private System.Windows.Forms.Button botaoLimpar;
    }
}