namespace Criptografia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnome = new System.Windows.Forms.Label();
            this.lbln = new System.Windows.Forms.Label();
            this.btncrip = new System.Windows.Forms.Button();
            this.txbn = new System.Windows.Forms.TextBox();
            this.txtcrip = new System.Windows.Forms.TextBox();
            this.txtdcrip = new System.Windows.Forms.TextBox();
            this.lblcrip = new System.Windows.Forms.Label();
            this.lbldcrip = new System.Windows.Forms.Label();
            this.btndcrip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(288, 140);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(0, 13);
            this.lblnome.TabIndex = 0;
            // 
            // lbln
            // 
            this.lbln.AutoSize = true;
            this.lbln.Location = new System.Drawing.Point(100, 37);
            this.lbln.Name = "lbln";
            this.lbln.Size = new System.Drawing.Size(44, 13);
            this.lbln.TabIndex = 1;
            this.lbln.Text = "Entrada";
            // 
            // btncrip
            // 
            this.btncrip.Location = new System.Drawing.Point(89, 110);
            this.btncrip.Name = "btncrip";
            this.btncrip.Size = new System.Drawing.Size(75, 23);
            this.btncrip.TabIndex = 2;
            this.btncrip.Text = "Criptografar";
            this.btncrip.UseVisualStyleBackColor = true;
            this.btncrip.Click += new System.EventHandler(this.btncrip_Click);
            // 
            // txbn
            // 
            this.txbn.Location = new System.Drawing.Point(42, 72);
            this.txbn.Name = "txbn";
            this.txbn.Size = new System.Drawing.Size(162, 20);
            this.txbn.TabIndex = 3;
            // 
            // txtcrip
            // 
            this.txtcrip.Location = new System.Drawing.Point(1, 308);
            this.txtcrip.Name = "txtcrip";
            this.txtcrip.Size = new System.Drawing.Size(798, 20);
            this.txtcrip.TabIndex = 4;
            // 
            // txtdcrip
            // 
            this.txtdcrip.Location = new System.Drawing.Point(565, 72);
            this.txtdcrip.Name = "txtdcrip";
            this.txtdcrip.Size = new System.Drawing.Size(162, 20);
            this.txtdcrip.TabIndex = 5;
            // 
            // lblcrip
            // 
            this.lblcrip.AutoSize = true;
            this.lblcrip.Location = new System.Drawing.Point(75, 269);
            this.lblcrip.Name = "lblcrip";
            this.lblcrip.Size = new System.Drawing.Size(106, 13);
            this.lblcrip.TabIndex = 6;
            this.lblcrip.Text = "Código Criptografado";
            // 
            // lbldcrip
            // 
            this.lbldcrip.AutoSize = true;
            this.lbldcrip.Location = new System.Drawing.Point(584, 37);
            this.lbldcrip.Name = "lbldcrip";
            this.lbldcrip.Size = new System.Drawing.Size(124, 13);
            this.lbldcrip.TabIndex = 7;
            this.lbldcrip.Text = "Código Descriptografado";
            // 
            // btndcrip
            // 
            this.btndcrip.Location = new System.Drawing.Point(78, 363);
            this.btndcrip.Name = "btndcrip";
            this.btndcrip.Size = new System.Drawing.Size(92, 23);
            this.btndcrip.TabIndex = 8;
            this.btndcrip.Text = "Descriptografar";
            this.btndcrip.UseVisualStyleBackColor = true;
            this.btndcrip.Click += new System.EventHandler(this.btndcrip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndcrip);
            this.Controls.Add(this.lbldcrip);
            this.Controls.Add(this.lblcrip);
            this.Controls.Add(this.txtdcrip);
            this.Controls.Add(this.txtcrip);
            this.Controls.Add(this.txbn);
            this.Controls.Add(this.btncrip);
            this.Controls.Add(this.lbln);
            this.Controls.Add(this.lblnome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lbln;
        private System.Windows.Forms.Button btncrip;
        private System.Windows.Forms.TextBox txbn;
        private System.Windows.Forms.TextBox txtcrip;
        private System.Windows.Forms.TextBox txtdcrip;
        private System.Windows.Forms.Label lblcrip;
        private System.Windows.Forms.Label lbldcrip;
        private System.Windows.Forms.Button btndcrip;
    }
}

