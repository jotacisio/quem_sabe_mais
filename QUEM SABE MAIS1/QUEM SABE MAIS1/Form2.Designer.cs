namespace QUEM_SABE_MAIS
{
    partial class Form2
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
            this.LB_nick = new System.Windows.Forms.Label();
            this.LB_nickprincipal = new System.Windows.Forms.Label();
            this.BT_jogar = new System.Windows.Forms.Button();
            this.PB_Form2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Form2)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_nick
            // 
            this.LB_nick.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_nick.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LB_nick.Location = new System.Drawing.Point(261, 12);
            this.LB_nick.Name = "LB_nick";
            this.LB_nick.Size = new System.Drawing.Size(293, 82);
            this.LB_nick.TabIndex = 199;
            this.LB_nick.Text = "Bem vindo, \r\n{NICK}.";
            // 
            // LB_nickprincipal
            // 
            this.LB_nickprincipal.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_nickprincipal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LB_nickprincipal.Location = new System.Drawing.Point(261, 54);
            this.LB_nickprincipal.Name = "LB_nickprincipal";
            this.LB_nickprincipal.Size = new System.Drawing.Size(293, 40);
            this.LB_nickprincipal.TabIndex = 223;
            this.LB_nickprincipal.Text = "{NICK}";
            // 
            // BT_jogar
            // 
            this.BT_jogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_jogar.Font = new System.Drawing.Font("Consolas", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_jogar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.BT_jogar.Location = new System.Drawing.Point(60, 132);
            this.BT_jogar.Name = "BT_jogar";
            this.BT_jogar.Size = new System.Drawing.Size(365, 139);
            this.BT_jogar.TabIndex = 224;
            this.BT_jogar.Text = "Jogar";
            this.BT_jogar.UseVisualStyleBackColor = true;
            this.BT_jogar.Click += new System.EventHandler(this.BT_jogar_Click_1);
            // 
            // PB_Form2
            // 
            this.PB_Form2.Image = global::QUEM_SABE_MAIS.Properties.Resources.definition_mini;
            this.PB_Form2.Location = new System.Drawing.Point(41, 12);
            this.PB_Form2.Name = "PB_Form2";
            this.PB_Form2.Size = new System.Drawing.Size(214, 82);
            this.PB_Form2.TabIndex = 191;
            this.PB_Form2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(487, 307);
            this.Controls.Add(this.BT_jogar);
            this.Controls.Add(this.LB_nickprincipal);
            this.Controls.Add(this.LB_nick);
            this.Controls.Add(this.PB_Form2);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quem sabe mais - Iniciar";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Form2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Form2;
        public System.Windows.Forms.Label LB_nick;
        public System.Windows.Forms.Label LB_nickprincipal;
        public System.Windows.Forms.Button BT_jogar;
    }
}