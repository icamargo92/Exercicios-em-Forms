namespace Exercicios
{
    partial class Form4
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
            this.ltbSequencia1 = new System.Windows.Forms.ListBox();
            this.txbInicio = new System.Windows.Forms.TextBox();
            this.txbFim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.ltbSequencia2 = new System.Windows.Forms.ListBox();
            this.ltbSequencia3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ltbSequencia1
            // 
            this.ltbSequencia1.FormattingEnabled = true;
            this.ltbSequencia1.ItemHeight = 15;
            this.ltbSequencia1.Location = new System.Drawing.Point(277, 35);
            this.ltbSequencia1.Name = "ltbSequencia1";
            this.ltbSequencia1.Size = new System.Drawing.Size(85, 214);
            this.ltbSequencia1.TabIndex = 25;
            // 
            // txbInicio
            // 
            this.txbInicio.Location = new System.Drawing.Point(16, 56);
            this.txbInicio.Name = "txbInicio";
            this.txbInicio.Size = new System.Drawing.Size(100, 23);
            this.txbInicio.TabIndex = 24;
            // 
            // txbFim
            // 
            this.txbFim.Location = new System.Drawing.Point(16, 133);
            this.txbFim.Name = "txbFim";
            this.txbFim.Size = new System.Drawing.Size(100, 23);
            this.txbFim.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Insira o fim da sequência";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Insira o início da sequência";
            // 
            // btnProximo
            // 
            this.btnProximo.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProximo.Location = new System.Drawing.Point(108, 247);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(127, 44);
            this.btnProximo.TabIndex = 20;
            this.btnProximo.Text = "→";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImprimir.Location = new System.Drawing.Point(108, 186);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(127, 44);
            this.btnImprimir.TabIndex = 19;
            this.btnImprimir.Text = "Verificar";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // ltbSequencia2
            // 
            this.ltbSequencia2.FormattingEnabled = true;
            this.ltbSequencia2.ItemHeight = 15;
            this.ltbSequencia2.Location = new System.Drawing.Point(380, 35);
            this.ltbSequencia2.Name = "ltbSequencia2";
            this.ltbSequencia2.Size = new System.Drawing.Size(85, 214);
            this.ltbSequencia2.TabIndex = 26;
            // 
            // ltbSequencia3
            // 
            this.ltbSequencia3.FormattingEnabled = true;
            this.ltbSequencia3.ItemHeight = 15;
            this.ltbSequencia3.Location = new System.Drawing.Point(482, 35);
            this.ltbSequencia3.Name = "ltbSequencia3";
            this.ltbSequencia3.Size = new System.Drawing.Size(85, 214);
            this.ltbSequencia3.TabIndex = 27;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(583, 306);
            this.Controls.Add(this.ltbSequencia3);
            this.Controls.Add(this.ltbSequencia2);
            this.Controls.Add(this.ltbSequencia1);
            this.Controls.Add(this.txbInicio);
            this.Controls.Add(this.txbFim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnImprimir);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ltbSequencia1;
        private TextBox txbInicio;
        private TextBox txbFim;
        private Label label2;
        private Label label1;
        private Button btnProximo;
        private Button btnImprimir;
        private ListBox ltbSequencia2;
        private ListBox ltbSequencia3;
    }
}