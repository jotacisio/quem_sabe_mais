namespace QUEM_SABE_MAIS
{
    partial class Form5
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
            this.label3 = new System.Windows.Forms.Label();
            this.BT_novogame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(2, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 67);
            this.label3.TabIndex = 220;
            this.label3.Text = "\r\nObrigado por jogar o\r\n\r\n\r\n\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BT_novogame
            // 
            this.BT_novogame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_novogame.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_novogame.ForeColor = System.Drawing.Color.Black;
            this.BT_novogame.Location = new System.Drawing.Point(335, 128);
            this.BT_novogame.Name = "BT_novogame";
            this.BT_novogame.Size = new System.Drawing.Size(121, 33);
            this.BT_novogame.TabIndex = 221;
            this.BT_novogame.Text = "Sair";
            this.BT_novogame.UseVisualStyleBackColor = true;
            this.BT_novogame.Click += new System.EventHandler(this.BT_novogame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QUEM_SABE_MAIS.Properties.Resources.definition_mini;
            this.pictureBox1.Location = new System.Drawing.Point(242, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 82);
            this.pictureBox1.TabIndex = 222;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(468, 183);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BT_novogame);
            this.Controls.Add(this.label3);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado final";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_novogame;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}