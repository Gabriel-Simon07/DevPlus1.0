
namespace DevPlus
{
    partial class telaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaMenu));
            this.btnTela_cadastrar = new System.Windows.Forms.Button();
            this.btnTela_gestao = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTela_cadastrar
            // 
            this.btnTela_cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnTela_cadastrar.FlatAppearance.BorderSize = 5;
            this.btnTela_cadastrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTela_cadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTela_cadastrar.Location = new System.Drawing.Point(181, 301);
            this.btnTela_cadastrar.Name = "btnTela_cadastrar";
            this.btnTela_cadastrar.Size = new System.Drawing.Size(171, 103);
            this.btnTela_cadastrar.TabIndex = 0;
            this.btnTela_cadastrar.Text = "Cadastrar";
            this.btnTela_cadastrar.UseVisualStyleBackColor = true;
            this.btnTela_cadastrar.Click += new System.EventHandler(this.btnTela_cadastrar_Click);
            // 
            // btnTela_gestao
            // 
            this.btnTela_gestao.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnTela_gestao.FlatAppearance.BorderSize = 5;
            this.btnTela_gestao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTela_gestao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTela_gestao.Location = new System.Drawing.Point(441, 301);
            this.btnTela_gestao.Name = "btnTela_gestao";
            this.btnTela_gestao.Size = new System.Drawing.Size(171, 103);
            this.btnTela_gestao.TabIndex = 3;
            this.btnTela_gestao.Text = "Gestão do evento";
            this.btnTela_gestao.UseVisualStyleBackColor = true;
            this.btnTela_gestao.Click += new System.EventHandler(this.btnTela_gestao_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // telaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTela_gestao);
            this.Controls.Add(this.btnTela_cadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "telaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTela_cadastrar;
        private System.Windows.Forms.Button btnTela_gestao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

