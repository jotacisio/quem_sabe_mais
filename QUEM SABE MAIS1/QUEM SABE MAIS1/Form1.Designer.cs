namespace QUEM_SABE_MAIS
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ENTRAR = new System.Windows.Forms.TabPage();
            this.TB_nomeP1 = new System.Windows.Forms.TextBox();
            this.BT_jogar = new System.Windows.Forms.Button();
            this.LB_nomeP1 = new System.Windows.Forms.Label();
            this.INSTRUÇÕES = new System.Windows.Forms.TabPage();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.CRÉDITOS = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PB_Principal = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.ENTRAR.SuspendLayout();
            this.INSTRUÇÕES.SuspendLayout();
            this.CRÉDITOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Principal)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.ENTRAR);
            this.tabControl1.Controls.Add(this.INSTRUÇÕES);
            this.tabControl1.Controls.Add(this.CRÉDITOS);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(90, 221);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(27, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(494, 197);
            this.tabControl1.TabIndex = 37;
            // 
            // ENTRAR
            // 
            this.ENTRAR.AllowDrop = true;
            this.ENTRAR.BackColor = System.Drawing.Color.Transparent;
            this.ENTRAR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ENTRAR.Controls.Add(this.TB_nomeP1);
            this.ENTRAR.Controls.Add(this.BT_jogar);
            this.ENTRAR.Controls.Add(this.LB_nomeP1);
            this.ENTRAR.ForeColor = System.Drawing.Color.Transparent;
            this.ENTRAR.Location = new System.Drawing.Point(4, 38);
            this.ENTRAR.Name = "ENTRAR";
            this.ENTRAR.Padding = new System.Windows.Forms.Padding(3);
            this.ENTRAR.Size = new System.Drawing.Size(486, 155);
            this.ENTRAR.TabIndex = 0;
            this.ENTRAR.Text = "ENTRAR";
            this.ENTRAR.UseVisualStyleBackColor = true;
            // 
            // TB_nomeP1
            // 
            this.TB_nomeP1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TB_nomeP1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TB_nomeP1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_nomeP1.ForeColor = System.Drawing.Color.Black;
            this.TB_nomeP1.Location = new System.Drawing.Point(141, 50);
            this.TB_nomeP1.Name = "TB_nomeP1";
            this.TB_nomeP1.Size = new System.Drawing.Size(221, 28);
            this.TB_nomeP1.TabIndex = 35;
            // 
            // BT_jogar
            // 
            this.BT_jogar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BT_jogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_jogar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BT_jogar.FlatAppearance.BorderSize = 3;
            this.BT_jogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BT_jogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BT_jogar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BT_jogar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_jogar.ForeColor = System.Drawing.Color.Transparent;
            this.BT_jogar.Location = new System.Drawing.Point(270, 84);
            this.BT_jogar.Name = "BT_jogar";
            this.BT_jogar.Size = new System.Drawing.Size(92, 43);
            this.BT_jogar.TabIndex = 34;
            this.BT_jogar.Text = "Jogar";
            this.BT_jogar.UseVisualStyleBackColor = false;
            this.BT_jogar.Click += new System.EventHandler(this.BT_jogar_Click_1);
            // 
            // LB_nomeP1
            // 
            this.LB_nomeP1.BackColor = System.Drawing.Color.Transparent;
            this.LB_nomeP1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LB_nomeP1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_nomeP1.ForeColor = System.Drawing.Color.Black;
            this.LB_nomeP1.Location = new System.Drawing.Point(6, 55);
            this.LB_nomeP1.Name = "LB_nomeP1";
            this.LB_nomeP1.Size = new System.Drawing.Size(129, 21);
            this.LB_nomeP1.TabIndex = 33;
            this.LB_nomeP1.Text = "INSIRA SEU NICK";
            this.LB_nomeP1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // INSTRUÇÕES
            // 
            this.INSTRUÇÕES.AllowDrop = true;
            this.INSTRUÇÕES.Controls.Add(this.listBox3);
            this.INSTRUÇÕES.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSTRUÇÕES.ForeColor = System.Drawing.Color.DimGray;
            this.INSTRUÇÕES.Location = new System.Drawing.Point(4, 38);
            this.INSTRUÇÕES.Name = "INSTRUÇÕES";
            this.INSTRUÇÕES.Padding = new System.Windows.Forms.Padding(3);
            this.INSTRUÇÕES.Size = new System.Drawing.Size(486, 155);
            this.INSTRUÇÕES.TabIndex = 1;
            this.INSTRUÇÕES.Text = "INSTRUÇÕES";
            this.INSTRUÇÕES.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.SystemColors.Control;
            this.listBox3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Items.AddRange(new object[] {
            "INSTRUÇÕES:",
            "",
            "- Cada jogador deve definir um nome de usuário (nick) para poder",
            " iniciar um jogo.",
            "",
            "-Após definido um nome de usuário, click em  jogar e logo após",
            "será apresentada cinco categorias para o usuário, selecione a ",
            "primeira pergunta de uma categoria.",
            "",
            "- Na tela seguinte, sera apresentado a pergunta se você acertar ",
            "acumula pontos.",
            "",
            "- As perguntas são objetivas, contendo quatro respostas,",
            " mas apenas uma é verdadeira.",
            "",
            "Isso é tudo. Bom jogo!"});
            this.listBox3.Location = new System.Drawing.Point(0, 0);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(486, 160);
            this.listBox3.TabIndex = 38;
            // 
            // CRÉDITOS
            // 
            this.CRÉDITOS.AllowDrop = true;
            this.CRÉDITOS.Controls.Add(this.listBox1);
            this.CRÉDITOS.Location = new System.Drawing.Point(4, 38);
            this.CRÉDITOS.Name = "CRÉDITOS";
            this.CRÉDITOS.Padding = new System.Windows.Forms.Padding(3);
            this.CRÉDITOS.Size = new System.Drawing.Size(486, 155);
            this.CRÉDITOS.TabIndex = 2;
            this.CRÉDITOS.Text = "CRÉDITOS";
            this.CRÉDITOS.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Items.AddRange(new object[] {
            "CRÉDITOS:",
            "",
            "Plaforma:",
            " - Microsoft Visual",
            "",
            "Programação:",
            " - Jotacísio Araújo de Oliveira",
            " - Lucas Matheus Leandro de Carvalho",
            " - Emanuel Campos",
            "",
            "Design:",
            " - dSantos - web art!",
            "",
            "Versão:",
            "1.0"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(486, 158);
            this.listBox1.TabIndex = 5;
            // 
            // PB_Principal
            // 
            this.PB_Principal.Image = global::QUEM_SABE_MAIS.Properties.Resources.definition;
            this.PB_Principal.InitialImage = global::QUEM_SABE_MAIS.Properties.Resources.definition;
            this.PB_Principal.Location = new System.Drawing.Point(85, 12);
            this.PB_Principal.Name = "PB_Principal";
            this.PB_Principal.Size = new System.Drawing.Size(440, 190);
            this.PB_Principal.TabIndex = 36;
            this.PB_Principal.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(610, 421);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.PB_Principal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quem vai jogar";
            this.tabControl1.ResumeLayout(false);
            this.ENTRAR.ResumeLayout(false);
            this.ENTRAR.PerformLayout();
            this.INSTRUÇÕES.ResumeLayout(false);
            this.CRÉDITOS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Principal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox PB_Principal;
        private System.Windows.Forms.TabPage ENTRAR;
        private System.Windows.Forms.TextBox TB_nomeP1;
        private System.Windows.Forms.Button BT_jogar;
        private System.Windows.Forms.Label LB_nomeP1;
        private System.Windows.Forms.TabPage INSTRUÇÕES;
        private System.Windows.Forms.TabPage CRÉDITOS;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox3;
    }
}

