namespace Exercicios
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNumeroUm = new System.Windows.Forms.TextBox();
            this.txbNumeroDois = new System.Windows.Forms.TextBox();
            this.txbNumeroTres = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNumeroMaior = new System.Windows.Forms.TextBox();
            this.txbNumeroMenor = new System.Windows.Forms.TextBox();
            this.btnProximo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira um número ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insira um número ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Insira um número ";
            // 
            // txbNumeroUm
            // 
            this.txbNumeroUm.Location = new System.Drawing.Point(159, 65);
            this.txbNumeroUm.Name = "txbNumeroUm";
            this.txbNumeroUm.Size = new System.Drawing.Size(100, 23);
            this.txbNumeroUm.TabIndex = 3;
            // 
            // txbNumeroDois
            // 
            this.txbNumeroDois.Location = new System.Drawing.Point(159, 107);
            this.txbNumeroDois.Name = "txbNumeroDois";
            this.txbNumeroDois.Size = new System.Drawing.Size(100, 23);
            this.txbNumeroDois.TabIndex = 4;
            // 
            // txbNumeroTres
            // 
            this.txbNumeroTres.Location = new System.Drawing.Point(159, 148);
            this.txbNumeroTres.Name = "txbNumeroTres";
            this.txbNumeroTres.Size = new System.Drawing.Size(100, 23);
            this.txbNumeroTres.TabIndex = 5;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImprimir.Location = new System.Drawing.Point(26, 196);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(127, 44);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Verificar";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(282, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Número maior";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(404, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Número menor";
            // 
            // txbNumeroMaior
            // 
            this.txbNumeroMaior.BackColor = System.Drawing.SystemColors.Menu;
            this.txbNumeroMaior.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbNumeroMaior.ForeColor = System.Drawing.Color.IndianRed;
            this.txbNumeroMaior.Location = new System.Drawing.Point(298, 101);
            this.txbNumeroMaior.Name = "txbNumeroMaior";
            this.txbNumeroMaior.Size = new System.Drawing.Size(69, 33);
            this.txbNumeroMaior.TabIndex = 9;
            this.txbNumeroMaior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbNumeroMenor
            // 
            this.txbNumeroMenor.BackColor = System.Drawing.SystemColors.Menu;
            this.txbNumeroMenor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbNumeroMenor.ForeColor = System.Drawing.Color.IndianRed;
            this.txbNumeroMenor.Location = new System.Drawing.Point(421, 101);
            this.txbNumeroMenor.Name = "txbNumeroMenor";
            this.txbNumeroMenor.Size = new System.Drawing.Size(75, 33);
            this.txbNumeroMenor.TabIndex = 10;
            this.txbNumeroMenor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbNumeroMenor.TextChanged += new System.EventHandler(this.txbNumeroMenor_TextChanged);
            // 
            // btnProximo
            // 
            this.btnProximo.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProximo.Location = new System.Drawing.Point(383, 196);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(127, 44);
            this.btnProximo.TabIndex = 11;
            this.btnProximo.Text = "→";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 261);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.txbNumeroMenor);
            this.Controls.Add(this.txbNumeroMaior);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txbNumeroTres);
            this.Controls.Add(this.txbNumeroDois);
            this.Controls.Add(this.txbNumeroUm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbNumeroUm;
        private TextBox txbNumeroDois;
        private TextBox txbNumeroTres;
        private Button btnImprimir;
        private Label label4;
        private Label label5;
        private TextBox txbNumeroMaior;
        private TextBox txbNumeroMenor;
        private Button btnProximo;
    }
}