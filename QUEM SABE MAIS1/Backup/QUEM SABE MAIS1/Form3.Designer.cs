namespace QUEM_SABE_MAIS
{
    partial class Form3
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
            this.LB_pergunta = new System.Windows.Forms.Label();
            this.RBA = new System.Windows.Forms.RadioButton();
            this.RBD = new System.Windows.Forms.RadioButton();
            this.RBC = new System.Windows.Forms.RadioButton();
            this.RBB = new System.Windows.Forms.RadioButton();
            this.BT_confirm = new System.Windows.Forms.Button();
            this.LB_categoria = new System.Windows.Forms.Label();
            this.PB_perguntas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_perguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_pergunta
            // 
            this.LB_pergunta.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_pergunta.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LB_pergunta.Location = new System.Drawing.Point(18, 122);
            this.LB_pergunta.Name = "LB_pergunta";
            this.LB_pergunta.Size = new System.Drawing.Size(583, 70);
            this.LB_pergunta.TabIndex = 206;
            this.LB_pergunta.Text = "Qual a definião de C# ?\r\n\r\n";
            this.LB_pergunta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RBA
            // 
            this.RBA.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBA.Location = new System.Drawing.Point(22, 195);
            this.RBA.Name = "RBA";
            this.RBA.Size = new System.Drawing.Size(384, 23);
            this.RBA.TabIndex = 207;
            this.RBA.Text = "Dó sustendido";
            this.RBA.UseVisualStyleBackColor = true;
            // 
            // RBD
            // 
            this.RBD.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBD.Location = new System.Drawing.Point(22, 282);
            this.RBD.Name = "RBD";
            this.RBD.Size = new System.Drawing.Size(384, 23);
            this.RBD.TabIndex = 208;
            this.RBD.Text = "Dó sustendido";
            this.RBD.UseVisualStyleBackColor = true;
            // 
            // RBC
            // 
            this.RBC.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBC.Location = new System.Drawing.Point(22, 253);
            this.RBC.Name = "RBC";
            this.RBC.Size = new System.Drawing.Size(384, 23);
            this.RBC.TabIndex = 209;
            this.RBC.Text = "Dó sustendido";
            this.RBC.UseVisualStyleBackColor = true;
            // 
            // RBB
            // 
            this.RBB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBB.Location = new System.Drawing.Point(22, 224);
            this.RBB.Name = "RBB";
            this.RBB.Size = new System.Drawing.Size(384, 23);
            this.RBB.TabIndex = 210;
            this.RBB.Text = "Dó sustendido";
            this.RBB.UseVisualStyleBackColor = true;
            // 
            // BT_confirm
            // 
            this.BT_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_confirm.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_confirm.ForeColor = System.Drawing.Color.Black;
            this.BT_confirm.Location = new System.Drawing.Point(474, 255);
            this.BT_confirm.Name = "BT_confirm";
            this.BT_confirm.Size = new System.Drawing.Size(121, 50);
            this.BT_confirm.TabIndex = 211;
            this.BT_confirm.Text = "Confirmar";
            this.BT_confirm.UseVisualStyleBackColor = true;
            this.BT_confirm.Click += new System.EventHandler(this.BT_confirm_Click);
            // 
            // LB_categoria
            // 
            this.LB_categoria.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_categoria.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LB_categoria.Location = new System.Drawing.Point(18, 97);
            this.LB_categoria.Name = "LB_categoria";
            this.LB_categoria.Size = new System.Drawing.Size(233, 25);
            this.LB_categoria.TabIndex = 213;
            this.LB_categoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PB_perguntas
            // 
            this.PB_perguntas.Image = global::QUEM_SABE_MAIS.Properties.Resources.definition_mini;
            this.PB_perguntas.Location = new System.Drawing.Point(22, 12);
            this.PB_perguntas.Name = "PB_perguntas";
            this.PB_perguntas.Size = new System.Drawing.Size(214, 82);
            this.PB_perguntas.TabIndex = 204;
            this.PB_perguntas.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(612, 316);
            this.Controls.Add(this.LB_categoria);
            this.Controls.Add(this.BT_confirm);
            this.Controls.Add(this.RBB);
            this.Controls.Add(this.RBC);
            this.Controls.Add(this.RBD);
            this.Controls.Add(this.RBA);
            this.Controls.Add(this.LB_pergunta);
            this.Controls.Add(this.PB_perguntas);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta";
            ((System.ComponentModel.ISupportInitialize)(this.PB_perguntas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_perguntas;
        private System.Windows.Forms.Label LB_pergunta;
        private System.Windows.Forms.RadioButton RBA;
        private System.Windows.Forms.RadioButton RBD;
        private System.Windows.Forms.RadioButton RBC;
        private System.Windows.Forms.RadioButton RBB;
        private System.Windows.Forms.Button BT_confirm;
        private System.Windows.Forms.Label LB_categoria;

    }
}