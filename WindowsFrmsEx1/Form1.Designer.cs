namespace WindowsFrmsEx1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRenda = new System.Windows.Forms.TextBox();
            this.grbGastos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEnergia = new System.Windows.Forms.TextBox();
            this.txtAgua = new System.Windows.Forms.TextBox();
            this.txtTV = new System.Windows.Forms.TextBox();
            this.txtAlimentacao = new System.Windows.Forms.TextBox();
            this.txtOutros = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGastos = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.grbGastos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renda Familiar:";
            // 
            // txtRenda
            // 
            this.txtRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenda.Location = new System.Drawing.Point(150, 22);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(376, 26);
            this.txtRenda.TabIndex = 1;
            this.txtRenda.TextChanged += new System.EventHandler(this.txtRenda_TextChanged);
            // 
            // grbGastos
            // 
            this.grbGastos.Controls.Add(this.txtOutros);
            this.grbGastos.Controls.Add(this.txtAlimentacao);
            this.grbGastos.Controls.Add(this.txtTV);
            this.grbGastos.Controls.Add(this.txtAgua);
            this.grbGastos.Controls.Add(this.txtEnergia);
            this.grbGastos.Controls.Add(this.label6);
            this.grbGastos.Controls.Add(this.label5);
            this.grbGastos.Controls.Add(this.label4);
            this.grbGastos.Controls.Add(this.label3);
            this.grbGastos.Controls.Add(this.label2);
            this.grbGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGastos.Location = new System.Drawing.Point(28, 80);
            this.grbGastos.Name = "grbGastos";
            this.grbGastos.Size = new System.Drawing.Size(498, 287);
            this.grbGastos.TabIndex = 2;
            this.grbGastos.TabStop = false;
            this.grbGastos.Text = "Gastos:";
            this.grbGastos.Enter += new System.EventHandler(this.grbGastos_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Energia Elétrica:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Água:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "TV / Fone / Internet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Alimentação:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Outros Gastos:";
            // 
            // txtEnergia
            // 
            this.txtEnergia.Location = new System.Drawing.Point(152, 42);
            this.txtEnergia.Name = "txtEnergia";
            this.txtEnergia.Size = new System.Drawing.Size(326, 22);
            this.txtEnergia.TabIndex = 5;
            // 
            // txtAgua
            // 
            this.txtAgua.Location = new System.Drawing.Point(152, 89);
            this.txtAgua.Name = "txtAgua";
            this.txtAgua.Size = new System.Drawing.Size(326, 22);
            this.txtAgua.TabIndex = 6;
            // 
            // txtTV
            // 
            this.txtTV.Location = new System.Drawing.Point(152, 136);
            this.txtTV.Name = "txtTV";
            this.txtTV.Size = new System.Drawing.Size(326, 22);
            this.txtTV.TabIndex = 7;
            // 
            // txtAlimentacao
            // 
            this.txtAlimentacao.Location = new System.Drawing.Point(152, 183);
            this.txtAlimentacao.Name = "txtAlimentacao";
            this.txtAlimentacao.Size = new System.Drawing.Size(326, 22);
            this.txtAlimentacao.TabIndex = 8;
            // 
            // txtOutros
            // 
            this.txtOutros.Location = new System.Drawing.Point(152, 235);
            this.txtOutros.Name = "txtOutros";
            this.txtOutros.Size = new System.Drawing.Size(326, 22);
            this.txtOutros.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(52, 412);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(102, 54);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(230, 412);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(102, 54);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Novo Calculo";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(404, 412);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(102, 54);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 533);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total de Gastos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 592);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Saldo:";
            // 
            // lblGastos
            // 
            this.lblGastos.AutoSize = true;
            this.lblGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastos.Location = new System.Drawing.Point(226, 533);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(0, 20);
            this.lblGastos.TabIndex = 8;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(226, 592);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(0, 20);
            this.lblSaldo.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 679);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblGastos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grbGastos);
            this.Controls.Add(this.txtRenda);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.grbGastos.ResumeLayout(false);
            this.grbGastos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRenda;
        private System.Windows.Forms.GroupBox grbGastos;
        private System.Windows.Forms.TextBox txtOutros;
        private System.Windows.Forms.TextBox txtAlimentacao;
        private System.Windows.Forms.TextBox txtTV;
        private System.Windows.Forms.TextBox txtAgua;
        private System.Windows.Forms.TextBox txtEnergia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblGastos;
        private System.Windows.Forms.Label lblSaldo;
    }
}

