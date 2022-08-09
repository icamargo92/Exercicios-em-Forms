namespace Exercicios
{
    partial class Form3
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbFim = new System.Windows.Forms.TextBox();
            this.txbInicio = new System.Windows.Forms.TextBox();
            this.ltbSequencia = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImprimir.Location = new System.Drawing.Point(125, 163);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(127, 44);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.Text = "Verificar";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProximo.Location = new System.Drawing.Point(125, 224);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(127, 44);
            this.btnProximo.TabIndex = 13;
            this.btnProximo.Text = "→";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Insira o início da sequência";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Insira o fim da sequência";
            // 
            // txbFim
            // 
            this.txbFim.Location = new System.Drawing.Point(33, 110);
            this.txbFim.Name = "txbFim";
            this.txbFim.Size = new System.Drawing.Size(100, 23);
            this.txbFim.TabIndex = 16;
            this.txbFim.TextChanged += new System.EventHandler(this.txbNumeroUm_TextChanged);
            // 
            // txbInicio
            // 
            this.txbInicio.Location = new System.Drawing.Point(33, 33);
            this.txbInicio.Name = "txbInicio";
            this.txbInicio.Size = new System.Drawing.Size(100, 23);
            this.txbInicio.TabIndex = 17;
            // 
            // ltbSequencia
            // 
            this.ltbSequencia.FormattingEnabled = true;
            this.ltbSequencia.ItemHeight = 15;
            this.ltbSequencia.Location = new System.Drawing.Point(294, 12);
            this.ltbSequencia.Name = "ltbSequencia";
            this.ltbSequencia.Size = new System.Drawing.Size(89, 214);
            this.ltbSequencia.TabIndex = 18;
            this.ltbSequencia.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 309);
            this.Controls.Add(this.ltbSequencia);
            this.Controls.Add(this.txbInicio);
            this.Controls.Add(this.txbFim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnImprimir);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnImprimir;
        private Button btnProximo;
        private Label label1;
        private Label label2;
        private TextBox txbFim;
        private TextBox txbInicio;
        private ListBox ltbSequencia;
    }
}