
namespace DevPlus.Views
{
    partial class telaCadastro
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.cmbSalaNome = new System.Windows.Forms.ComboBox();
            this.cmbLotacaoCafeNome = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbLotacaoLotacaoCafe = new System.Windows.Forms.ComboBox();
            this.cmblotacaoDaSala = new System.Windows.Forms.ComboBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.btnConsultar_consulta = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConsultaDados = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(195, 410);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(147, 97);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(357, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tela de Cadastro";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(606, 410);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 97);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSobrenome.Location = new System.Drawing.Point(606, 72);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(146, 29);
            this.txtSobrenome.TabIndex = 4;
            // 
            // cmbSalaNome
            // 
            this.cmbSalaNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSalaNome.FormattingEnabled = true;
            this.cmbSalaNome.Location = new System.Drawing.Point(234, 130);
            this.cmbSalaNome.Name = "cmbSalaNome";
            this.cmbSalaNome.Size = new System.Drawing.Size(146, 29);
            this.cmbSalaNome.TabIndex = 5;
            this.cmbSalaNome.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbLotacaoCafeNome
            // 
            this.cmbLotacaoCafeNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbLotacaoCafeNome.FormattingEnabled = true;
            this.cmbLotacaoCafeNome.Location = new System.Drawing.Point(234, 174);
            this.cmbLotacaoCafeNome.Name = "cmbLotacaoCafeNome";
            this.cmbLotacaoCafeNome.Size = new System.Drawing.Size(146, 29);
            this.cmbLotacaoCafeNome.TabIndex = 6;
            this.cmbLotacaoCafeNome.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(234, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(146, 29);
            this.txtNome.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome do lugar do intervalo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(120, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome da sala:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(172, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(506, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sobrenome:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(481, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lotação da sala:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(386, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Lotação do lugar de intervalo:";
            // 
            // cmbLotacaoLotacaoCafe
            // 
            this.cmbLotacaoLotacaoCafe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbLotacaoLotacaoCafe.FormattingEnabled = true;
            this.cmbLotacaoLotacaoCafe.Location = new System.Drawing.Point(607, 174);
            this.cmbLotacaoLotacaoCafe.Name = "cmbLotacaoLotacaoCafe";
            this.cmbLotacaoLotacaoCafe.Size = new System.Drawing.Size(146, 29);
            this.cmbLotacaoLotacaoCafe.TabIndex = 16;
            // 
            // cmblotacaoDaSala
            // 
            this.cmblotacaoDaSala.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmblotacaoDaSala.FormattingEnabled = true;
            this.cmblotacaoDaSala.Location = new System.Drawing.Point(606, 127);
            this.cmblotacaoDaSala.Name = "cmblotacaoDaSala";
            this.cmblotacaoDaSala.Size = new System.Drawing.Size(146, 29);
            this.cmblotacaoDaSala.TabIndex = 17;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(278, 228);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.RowTemplate.Height = 25;
            this.dgvConsulta.Size = new System.Drawing.Size(570, 170);
            this.dgvConsulta.TabIndex = 18;
            // 
            // btnConsultar_consulta
            // 
            this.btnConsultar_consulta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar_consulta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConsultar_consulta.Location = new System.Drawing.Point(111, 312);
            this.btnConsultar_consulta.Name = "btnConsultar_consulta";
            this.btnConsultar_consulta.Size = new System.Drawing.Size(105, 38);
            this.btnConsultar_consulta.TabIndex = 19;
            this.btnConsultar_consulta.Text = "Consultar";
            this.btnConsultar_consulta.UseVisualStyleBackColor = true;
            this.btnConsultar_consulta.Click += new System.EventHandler(this.btnConsultar_consulta_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(15, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Consultar:";
            // 
            // txtConsultaDados
            // 
            this.txtConsultaDados.Location = new System.Drawing.Point(98, 283);
            this.txtConsultaDados.Name = "txtConsultaDados";
            this.txtConsultaDados.Size = new System.Drawing.Size(133, 23);
            this.txtConsultaDados.TabIndex = 20;
            // 
            // telaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(924, 519);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtConsultaDados);
            this.Controls.Add(this.btnConsultar_consulta);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.cmblotacaoDaSala);
            this.Controls.Add(this.cmbLotacaoLotacaoCafe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cmbLotacaoCafeNome);
            this.Controls.Add(this.cmbSalaNome);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "telaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaCadastro";
            this.Load += new System.EventHandler(this.telaCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.ComboBox cmbSalaNome;
        private System.Windows.Forms.ComboBox cmbLotacaoCafeNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbLotacaoLotacaoCafe;
        private System.Windows.Forms.ComboBox cmblotacaoDaSala;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnConsultar_consulta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConsultaDados;
    }
}