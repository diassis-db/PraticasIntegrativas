namespace Alpha
{
    partial class F_Produtos
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
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.lb_Id = new System.Windows.Forms.Label();
            this.lb_descricao = new System.Windows.Forms.Label();
            this.lb_preco = new System.Windows.Forms.Label();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.btn_novo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Id
            // 
            this.tb_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Id.Location = new System.Drawing.Point(23, 24);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.ReadOnly = true;
            this.tb_Id.Size = new System.Drawing.Size(78, 24);
            this.tb_Id.TabIndex = 6;
            this.tb_Id.TextChanged += new System.EventHandler(this.tb_Id_TextChanged);
            // 
            // tb_descricao
            // 
            this.tb_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_descricao.Location = new System.Drawing.Point(23, 76);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(354, 24);
            this.tb_descricao.TabIndex = 1;
            this.tb_descricao.TextChanged += new System.EventHandler(this.tb_descricao_TextChanged);
            // 
            // btn_gravar
            // 
            this.btn_gravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravar.ForeColor = System.Drawing.Color.White;
            this.btn_gravar.Location = new System.Drawing.Point(103, 181);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(83, 31);
            this.btn_gravar.TabIndex = 1;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = false;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_consulta
            // 
            this.btn_consulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulta.ForeColor = System.Drawing.Color.White;
            this.btn_consulta.Location = new System.Drawing.Point(192, 181);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(96, 31);
            this.btn_consulta.TabIndex = 3;
            this.btn_consulta.Text = "Consultar";
            this.btn_consulta.UseVisualStyleBackColor = false;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(294, 181);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(83, 31);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.ForeColor = System.Drawing.Color.White;
            this.btn_fechar.Location = new System.Drawing.Point(383, 181);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(83, 31);
            this.btn_fechar.TabIndex = 5;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // lb_Id
            // 
            this.lb_Id.AutoSize = true;
            this.lb_Id.Location = new System.Drawing.Point(20, 5);
            this.lb_Id.Name = "lb_Id";
            this.lb_Id.Size = new System.Drawing.Size(51, 16);
            this.lb_Id.TabIndex = 7;
            this.lb_Id.Text = "Código";
            // 
            // lb_descricao
            // 
            this.lb_descricao.AutoSize = true;
            this.lb_descricao.Location = new System.Drawing.Point(20, 57);
            this.lb_descricao.Name = "lb_descricao";
            this.lb_descricao.Size = new System.Drawing.Size(69, 16);
            this.lb_descricao.TabIndex = 8;
            this.lb_descricao.Text = "Descrição";
            // 
            // lb_preco
            // 
            this.lb_preco.AutoSize = true;
            this.lb_preco.Location = new System.Drawing.Point(20, 107);
            this.lb_preco.Name = "lb_preco";
            this.lb_preco.Size = new System.Drawing.Size(43, 16);
            this.lb_preco.TabIndex = 9;
            this.lb_preco.Text = "Preço";
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(23, 126);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(100, 22);
            this.tb_preco.TabIndex = 2;
            this.tb_preco.Leave += new System.EventHandler(this.tb_preco_Leave);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.ForeColor = System.Drawing.Color.White;
            this.btn_novo.Location = new System.Drawing.Point(17, 181);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(83, 31);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // F_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 251);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.lb_preco);
            this.Controls.Add(this.lb_descricao);
            this.Controls.Add(this.lb_Id);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.tb_Id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Produtos";
            this.Load += new System.EventHandler(this.F_Produtos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label lb_Id;
        private System.Windows.Forms.Label lb_descricao;
        private System.Windows.Forms.Label lb_preco;
        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.Button btn_novo;
    }
}