
namespace CursoWindowsForms
{
    partial class Frm_ArquivoImagem_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_ArquivoImagem = new System.Windows.Forms.Label();
            this.Btn_Cor = new System.Windows.Forms.Button();
            this.Pic_ArquivoImagem = new System.Windows.Forms.PictureBox();
            this.Btn_Fonte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_ArquivoImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_ArquivoImagem
            // 
            this.Lbl_ArquivoImagem.AutoSize = true;
            this.Lbl_ArquivoImagem.Location = new System.Drawing.Point(17, 36);
            this.Lbl_ArquivoImagem.Name = "Lbl_ArquivoImagem";
            this.Lbl_ArquivoImagem.Size = new System.Drawing.Size(35, 13);
            this.Lbl_ArquivoImagem.TabIndex = 0;
            this.Lbl_ArquivoImagem.Text = "label1";
            // 
            // Btn_Cor
            // 
            this.Btn_Cor.Location = new System.Drawing.Point(20, 4);
            this.Btn_Cor.Name = "Btn_Cor";
            this.Btn_Cor.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cor.TabIndex = 1;
            this.Btn_Cor.Text = "Cor";
            this.Btn_Cor.UseVisualStyleBackColor = true;
            this.Btn_Cor.Click += new System.EventHandler(this.Btn_Cor_Click);
            // 
            // Pic_ArquivoImagem
            // 
            this.Pic_ArquivoImagem.Location = new System.Drawing.Point(20, 76);
            this.Pic_ArquivoImagem.Name = "Pic_ArquivoImagem";
            this.Pic_ArquivoImagem.Size = new System.Drawing.Size(209, 156);
            this.Pic_ArquivoImagem.TabIndex = 2;
            this.Pic_ArquivoImagem.TabStop = false;
            // 
            // Btn_Fonte
            // 
            this.Btn_Fonte.Location = new System.Drawing.Point(101, 4);
            this.Btn_Fonte.Name = "Btn_Fonte";
            this.Btn_Fonte.Size = new System.Drawing.Size(75, 23);
            this.Btn_Fonte.TabIndex = 3;
            this.Btn_Fonte.Text = "Fonte";
            this.Btn_Fonte.UseVisualStyleBackColor = true;
            this.Btn_Fonte.Click += new System.EventHandler(this.Btn_Fonte_Click);
            // 
            // Frm_ArquivoImagem_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Fonte);
            this.Controls.Add(this.Pic_ArquivoImagem);
            this.Controls.Add(this.Btn_Cor);
            this.Controls.Add(this.Lbl_ArquivoImagem);
            this.Name = "Frm_ArquivoImagem_UC";
            this.Size = new System.Drawing.Size(548, 290);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_ArquivoImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ArquivoImagem;
        private System.Windows.Forms.Button Btn_Cor;
        private System.Windows.Forms.PictureBox Pic_ArquivoImagem;
        private System.Windows.Forms.Button Btn_Fonte;
    }
}
