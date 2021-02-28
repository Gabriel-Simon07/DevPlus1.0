
namespace DevPlus.Views
{
    partial class telaGestão
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
            this.btnCancelar_cadast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSala_nome = new System.Windows.Forms.TextBox();
            this.txtNome_LotacaoCafe = new System.Windows.Forms.TextBox();
            this.btnCadastrar_cadastro = new System.Windows.Forms.Button();
            this.btnCadastrar_LotacaoCafe = new System.Windows.Forms.Button();
            this.numbSala = new System.Windows.Forms.NumericUpDown();
            this.numbLotacaoCafe = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numbSala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbLotacaoCafe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar_cadast
            // 
            this.btnCancelar_cadast.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar_cadast.Location = new System.Drawing.Point(288, 362);
            this.btnCancelar_cadast.Name = "btnCancelar_cadast";
            this.btnCancelar_cadast.Size = new System.Drawing.Size(186, 76);
            this.btnCancelar_cadast.TabIndex = 10;
            this.btnCancelar_cadast.Text = "Voltar para tela inicial";
            this.btnCancelar_cadast.UseVisualStyleBackColor = true;
            this.btnCancelar_cadast.Click += new System.EventHandler(this.btnCancelar_cadast_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(288, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastramento ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(97, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome da sala:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(362, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do lugar de intervalo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(354, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lotação do lugar de intervalo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(84, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lotação da Sala:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSala_nome
            // 
            this.txtSala_nome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSala_nome.Location = new System.Drawing.Point(222, 126);
            this.txtSala_nome.Name = "txtSala_nome";
            this.txtSala_nome.Size = new System.Drawing.Size(100, 29);
            this.txtSala_nome.TabIndex = 5;
            this.txtSala_nome.TextChanged += new System.EventHandler(this.txtCadastro_nome_TextChanged);
            // 
            // txtNome_LotacaoCafe
            // 
            this.txtNome_LotacaoCafe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome_LotacaoCafe.Location = new System.Drawing.Point(568, 123);
            this.txtNome_LotacaoCafe.Name = "txtNome_LotacaoCafe";
            this.txtNome_LotacaoCafe.Size = new System.Drawing.Size(100, 29);
            this.txtNome_LotacaoCafe.TabIndex = 6;
            // 
            // btnCadastrar_cadastro
            // 
            this.btnCadastrar_cadastro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar_cadastro.Location = new System.Drawing.Point(132, 270);
            this.btnCadastrar_cadastro.Name = "btnCadastrar_cadastro";
            this.btnCadastrar_cadastro.Size = new System.Drawing.Size(152, 54);
            this.btnCadastrar_cadastro.TabIndex = 9;
            this.btnCadastrar_cadastro.Text = "Cadastrar Sala";
            this.btnCadastrar_cadastro.UseVisualStyleBackColor = true;
            this.btnCadastrar_cadastro.Click += new System.EventHandler(this.btnCadastrar_cadastro_Click);
            // 
            // btnCadastrar_LotacaoCafe
            // 
            this.btnCadastrar_LotacaoCafe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar_LotacaoCafe.Location = new System.Drawing.Point(503, 270);
            this.btnCadastrar_LotacaoCafe.Name = "btnCadastrar_LotacaoCafe";
            this.btnCadastrar_LotacaoCafe.Size = new System.Drawing.Size(152, 54);
            this.btnCadastrar_LotacaoCafe.TabIndex = 11;
            this.btnCadastrar_LotacaoCafe.Text = "Cadastrar lugar do intervalo";
            this.btnCadastrar_LotacaoCafe.UseVisualStyleBackColor = true;
            this.btnCadastrar_LotacaoCafe.Click += new System.EventHandler(this.btnCadastrar_LotacaoCafe_Click);
            // 
            // numbSala
            // 
            this.numbSala.Location = new System.Drawing.Point(222, 216);
            this.numbSala.Name = "numbSala";
            this.numbSala.Size = new System.Drawing.Size(100, 23);
            this.numbSala.TabIndex = 12;
            this.numbSala.ValueChanged += new System.EventHandler(this.numbSala_ValueChanged);
            // 
            // numbLotacaoCafe
            // 
            this.numbLotacaoCafe.Location = new System.Drawing.Point(568, 214);
            this.numbLotacaoCafe.Name = "numbLotacaoCafe";
            this.numbLotacaoCafe.Size = new System.Drawing.Size(100, 23);
            this.numbLotacaoCafe.TabIndex = 13;
            // 
            // telaGestão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.numbLotacaoCafe);
            this.Controls.Add(this.numbSala);
            this.Controls.Add(this.btnCadastrar_LotacaoCafe);
            this.Controls.Add(this.btnCancelar_cadast);
            this.Controls.Add(this.btnCadastrar_cadastro);
            this.Controls.Add(this.txtNome_LotacaoCafe);
            this.Controls.Add(this.txtSala_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "telaGestão";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaAdministrativo";
            this.Load += new System.EventHandler(this.telaAdministrativo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numbSala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbLotacaoCafe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSala_nome;
        private System.Windows.Forms.TextBox txtNome_LotacaoCafe;
        private System.Windows.Forms.Button btnCadastrar_cadastro;
        private System.Windows.Forms.Button btnCancelar_cadast;
        private System.Windows.Forms.Button btnCadastrar_LotacaoCafe;
        private System.Windows.Forms.NumericUpDown numbSala;
        private System.Windows.Forms.NumericUpDown numbLotacaoCafe;
    }
}