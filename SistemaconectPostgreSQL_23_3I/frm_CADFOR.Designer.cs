namespace SistemaconectPostgreSQL_23_3I
{
    partial class frm_CADFOR
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
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Telefonef = new System.Windows.Forms.TextBox();
            this.txt_NomeFantasia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_RS = new System.Windows.Forms.TextBox();
            this.txt_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_representante = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(274, 346);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(70, 39);
            this.btn_Excluir.TabIndex = 27;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(198, 346);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(70, 39);
            this.btn_Alterar.TabIndex = 26;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(122, 346);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(70, 39);
            this.btn_Consultar.TabIndex = 25;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Location = new System.Drawing.Point(46, 346);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(70, 39);
            this.btn_Inserir.TabIndex = 24;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(143, 203);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(158, 20);
            this.txt_Email.TabIndex = 23;
            // 
            // txt_Telefonef
            // 
            this.txt_Telefonef.Location = new System.Drawing.Point(143, 154);
            this.txt_Telefonef.Name = "txt_Telefonef";
            this.txt_Telefonef.Size = new System.Drawing.Size(113, 20);
            this.txt_Telefonef.TabIndex = 22;
            // 
            // txt_NomeFantasia
            // 
            this.txt_NomeFantasia.Location = new System.Drawing.Point(143, 99);
            this.txt_NomeFantasia.Name = "txt_NomeFantasia";
            this.txt_NomeFantasia.Size = new System.Drawing.Size(158, 20);
            this.txt_NomeFantasia.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Razão social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome Fantasia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "CNPJ";
            // 
            // txt_RS
            // 
            this.txt_RS.Location = new System.Drawing.Point(143, 246);
            this.txt_RS.Name = "txt_RS";
            this.txt_RS.Size = new System.Drawing.Size(144, 20);
            this.txt_RS.TabIndex = 28;
            // 
            // txt_CNPJ
            // 
            this.txt_CNPJ.Location = new System.Drawing.Point(143, 55);
            this.txt_CNPJ.Mask = " 00. 000. 000/0000-00";
            this.txt_CNPJ.Name = "txt_CNPJ";
            this.txt_CNPJ.Size = new System.Drawing.Size(126, 20);
            this.txt_CNPJ.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "data";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(144, 312);
            this.txt_date.Mask = "00/00/0000";
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(73, 20);
            this.txt_date.TabIndex = 31;
            this.txt_date.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Representante";
            // 
            // txt_representante
            // 
            this.txt_representante.Location = new System.Drawing.Point(143, 284);
            this.txt_representante.Name = "txt_representante";
            this.txt_representante.Size = new System.Drawing.Size(144, 20);
            this.txt_representante.TabIndex = 33;
            // 
            // frm_CADFOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 397);
            this.Controls.Add(this.txt_representante);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_CNPJ);
            this.Controls.Add(this.txt_RS);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Telefonef);
            this.Controls.Add(this.txt_NomeFantasia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_CADFOR";
            this.Text = "cadastro de fornecedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Telefonef;
        private System.Windows.Forms.TextBox txt_NomeFantasia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_RS;
        private System.Windows.Forms.MaskedTextBox txt_CNPJ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txt_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_representante;
    }
}