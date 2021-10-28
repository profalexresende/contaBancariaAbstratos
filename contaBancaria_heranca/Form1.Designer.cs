
namespace contaBancaria_heranca
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cmbTipoConta = new System.Windows.Forms.ComboBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnConsultarSaldo = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnAtualizaSaldo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor da Transação:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(53, 32);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(121, 20);
            this.txtValor.TabIndex = 1;
            // 
            // cmbTipoConta
            // 
            this.cmbTipoConta.FormattingEnabled = true;
            this.cmbTipoConta.Items.AddRange(new object[] {
            "Conta Corrente",
            "Poupança"});
            this.cmbTipoConta.Location = new System.Drawing.Point(53, 78);
            this.cmbTipoConta.Name = "cmbTipoConta";
            this.cmbTipoConta.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoConta.TabIndex = 2;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(53, 158);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(121, 23);
            this.btnDepositar.TabIndex = 3;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnConsultarSaldo
            // 
            this.btnConsultarSaldo.Location = new System.Drawing.Point(53, 216);
            this.btnConsultarSaldo.Name = "btnConsultarSaldo";
            this.btnConsultarSaldo.Size = new System.Drawing.Size(121, 23);
            this.btnConsultarSaldo.TabIndex = 4;
            this.btnConsultarSaldo.Text = "Consultar Saldo";
            this.btnConsultarSaldo.UseVisualStyleBackColor = true;
            this.btnConsultarSaldo.Click += new System.EventHandler(this.btnConsultarSaldo_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(53, 187);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(121, 23);
            this.btnSacar.TabIndex = 5;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnAtualizaSaldo
            // 
            this.btnAtualizaSaldo.Location = new System.Drawing.Point(53, 245);
            this.btnAtualizaSaldo.Name = "btnAtualizaSaldo";
            this.btnAtualizaSaldo.Size = new System.Drawing.Size(121, 23);
            this.btnAtualizaSaldo.TabIndex = 6;
            this.btnAtualizaSaldo.Text = "Atualizar Saldo";
            this.btnAtualizaSaldo.UseVisualStyleBackColor = true;
            this.btnAtualizaSaldo.Click += new System.EventHandler(this.btnAtualizaSaldo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 276);
            this.Controls.Add(this.btnAtualizaSaldo);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnConsultarSaldo);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.cmbTipoConta);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Banco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cmbTipoConta;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnConsultarSaldo;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnAtualizaSaldo;
    }
}

