namespace CelularCTIDesktop
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.btnBuscaPreco = new System.Windows.Forms.Button();
            this.lstCelular = new System.Windows.Forms.ListBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.btnBuscaModelo = new System.Windows.Forms.Button();
            this.btnBuscaFornecedor = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(208, 107);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 22);
            this.textBox1.TabIndex = 0;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(116, 54);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(43, 16);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(116, 107);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(53, 16);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // btnBuscaPreco
            // 
            this.btnBuscaPreco.Location = new System.Drawing.Point(558, 48);
            this.btnBuscaPreco.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscaPreco.Name = "btnBuscaPreco";
            this.btnBuscaPreco.Size = new System.Drawing.Size(100, 28);
            this.btnBuscaPreco.TabIndex = 4;
            this.btnBuscaPreco.Text = ">";
            this.btnBuscaPreco.UseVisualStyleBackColor = true;
            // 
            // lstCelular
            // 
            this.lstCelular.FormattingEnabled = true;
            this.lstCelular.ItemHeight = 16;
            this.lstCelular.Location = new System.Drawing.Point(119, 250);
            this.lstCelular.Name = "lstCelular";
            this.lstCelular.Size = new System.Drawing.Size(662, 228);
            this.lstCelular.TabIndex = 5;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(116, 164);
            this.lblFornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(77, 16);
            this.lblFornecedor.TabIndex = 6;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // numMin
            // 
            this.numMin.DecimalPlaces = 2;
            this.numMin.Location = new System.Drawing.Point(208, 54);
            this.numMin.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(120, 22);
            this.numMin.TabIndex = 7;
            // 
            // numMax
            // 
            this.numMax.DecimalPlaces = 2;
            this.numMax.Location = new System.Drawing.Point(381, 54);
            this.numMax.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(120, 22);
            this.numMax.TabIndex = 8;
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(207, 161);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(294, 24);
            this.cmbFabricante.TabIndex = 9;
            // 
            // btnBuscaModelo
            // 
            this.btnBuscaModelo.Location = new System.Drawing.Point(558, 107);
            this.btnBuscaModelo.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscaModelo.Name = "btnBuscaModelo";
            this.btnBuscaModelo.Size = new System.Drawing.Size(100, 28);
            this.btnBuscaModelo.TabIndex = 10;
            this.btnBuscaModelo.Text = ">";
            this.btnBuscaModelo.UseVisualStyleBackColor = true;
            // 
            // btnBuscaFornecedor
            // 
            this.btnBuscaFornecedor.Location = new System.Drawing.Point(558, 161);
            this.btnBuscaFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscaFornecedor.Name = "btnBuscaFornecedor";
            this.btnBuscaFornecedor.Size = new System.Drawing.Size(100, 28);
            this.btnBuscaFornecedor.TabIndex = 11;
            this.btnBuscaFornecedor.Text = ">";
            this.btnBuscaFornecedor.UseVisualStyleBackColor = true;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(243, 518);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(4);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(100, 28);
            this.btnComprar.TabIndex = 12;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(412, 518);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 28);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(558, 518);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 28);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 662);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnBuscaFornecedor);
            this.Controls.Add(this.btnBuscaModelo);
            this.Controls.Add(this.cmbFabricante);
            this.Controls.Add(this.numMax);
            this.Controls.Add(this.numMin);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lstCelular);
            this.Controls.Add(this.btnBuscaPreco);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Button btnBuscaPreco;
        private System.Windows.Forms.ListBox lstCelular;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.Button btnBuscaModelo;
        private System.Windows.Forms.Button btnBuscaFornecedor;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
    }
}

