namespace Alpha
{
    partial class Cad_cliente
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
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.btn_foto = new System.Windows.Forms.Button();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_celular = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtb_cep = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.cb_uf = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_foto
            // 
            this.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_foto.Location = new System.Drawing.Point(439, 12);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(126, 142);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foto.TabIndex = 0;
            this.pb_foto.TabStop = false;
            // 
            // btn_foto
            // 
            this.btn_foto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_foto.Location = new System.Drawing.Point(462, 167);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.Size = new System.Drawing.Size(82, 35);
            this.btn_foto.TabIndex = 8;
            this.btn_foto.Text = "Foto";
            this.btn_foto.UseVisualStyleBackColor = false;
            this.btn_foto.Click += new System.EventHandler(this.btn_foto_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.Location = new System.Drawing.Point(12, 61);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(353, 23);
            this.tb_nome.TabIndex = 1;
            this.tb_nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // mtb_celular
            // 
            this.mtb_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_celular.Location = new System.Drawing.Point(15, 117);
            this.mtb_celular.Mask = "(99) 99999-9999";
            this.mtb_celular.Name = "mtb_celular";
            this.mtb_celular.Size = new System.Drawing.Size(114, 23);
            this.mtb_celular.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Celular:";
            // 
            // tb_endereco
            // 
            this.tb_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_endereco.Location = new System.Drawing.Point(12, 175);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(353, 23);
            this.tb_endereco.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Endereço:";
            // 
            // mtb_cep
            // 
            this.mtb_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_cep.Location = new System.Drawing.Point(12, 237);
            this.mtb_cep.Mask = "99.999-999";
            this.mtb_cep.Name = "mtb_cep";
            this.mtb_cep.Size = new System.Drawing.Size(99, 23);
            this.mtb_cep.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cep:";
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_cpf.Location = new System.Drawing.Point(177, 118);
            this.mtb_cpf.Mask = "999.999.999-99";
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(133, 23);
            this.mtb_cpf.TabIndex = 3;
            this.mtb_cpf.Enter += new System.EventHandler(this.mtb_cpf_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "CPF:";
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.Location = new System.Drawing.Point(12, 276);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(87, 35);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravar.Location = new System.Drawing.Point(218, 276);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(83, 35);
            this.btn_gravar.TabIndex = 10;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = false;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_consulta
            // 
            this.btn_consulta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulta.Location = new System.Drawing.Point(105, 276);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(107, 35);
            this.btn_consulta.TabIndex = 9;
            this.btn_consulta.Text = "Consultar";
            this.btn_consulta.UseVisualStyleBackColor = false;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(309, 276);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(87, 35);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Red;
            this.btn_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.ForeColor = System.Drawing.Color.White;
            this.btn_fechar.Location = new System.Drawing.Point(404, 276);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(87, 35);
            this.btn_fechar.TabIndex = 12;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // cb_uf
            // 
            this.cb_uf.FormattingEnabled = true;
            this.cb_uf.Location = new System.Drawing.Point(142, 236);
            this.cb_uf.Name = "cb_uf";
            this.cb_uf.Size = new System.Drawing.Size(55, 24);
            this.cb_uf.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "UF:";
            // 
            // tb_cidade
            // 
            this.tb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cidade.Location = new System.Drawing.Point(203, 236);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(162, 23);
            this.tb_cidade.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Cidade:";
            // 
            // tb_codigo
            // 
            this.tb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigo.Location = new System.Drawing.Point(15, 12);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.ReadOnly = true;
            this.tb_codigo.Size = new System.Drawing.Size(84, 23);
            this.tb_codigo.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Código";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Images(*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF";
            // 
            // Cad_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 332);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_cidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_uf);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtb_cpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtb_cep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtb_celular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.btn_foto);
            this.Controls.Add(this.pb_foto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Cad_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Clientes";
            this.Load += new System.EventHandler(this.Cad_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.Button btn_foto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox tb_codigo;
        public System.Windows.Forms.TextBox tb_nome;
        public System.Windows.Forms.MaskedTextBox mtb_celular;
        public System.Windows.Forms.MaskedTextBox mtb_cpf;
        public System.Windows.Forms.MaskedTextBox mtb_cep;
        public System.Windows.Forms.ComboBox cb_uf;
        public System.Windows.Forms.TextBox tb_cidade;
        public System.Windows.Forms.TextBox tb_endereco;
    }
}