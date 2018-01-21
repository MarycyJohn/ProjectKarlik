namespace FormUI
{
    partial class Logowanie
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
            this.label1 = new System.Windows.Forms.Label();
            this.guzik_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.okno_login = new System.Windows.Forms.ListBox();
            this.okno_haslo = new System.Windows.Forms.ListBox();
            this.guzik_exit_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // guzik_login
            // 
            this.guzik_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guzik_login.Location = new System.Drawing.Point(89, 98);
            this.guzik_login.Name = "guzik_login";
            this.guzik_login.Size = new System.Drawing.Size(75, 23);
            this.guzik_login.TabIndex = 1;
            this.guzik_login.Text = "Login";
            this.guzik_login.UseVisualStyleBackColor = true;
            this.guzik_login.Click += new System.EventHandler(this.guzik_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "HASŁO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // okno_login
            // 
            this.okno_login.FormattingEnabled = true;
            this.okno_login.Location = new System.Drawing.Point(89, 31);
            this.okno_login.Name = "okno_login";
            this.okno_login.Size = new System.Drawing.Size(168, 17);
            this.okno_login.TabIndex = 3;
            // 
            // okno_haslo
            // 
            this.okno_haslo.FormattingEnabled = true;
            this.okno_haslo.Location = new System.Drawing.Point(89, 66);
            this.okno_haslo.Name = "okno_haslo";
            this.okno_haslo.Size = new System.Drawing.Size(168, 17);
            this.okno_haslo.TabIndex = 4;
            // 
            // guzik_exit_login
            // 
            this.guzik_exit_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guzik_exit_login.Location = new System.Drawing.Point(170, 98);
            this.guzik_exit_login.Name = "guzik_exit_login";
            this.guzik_exit_login.Size = new System.Drawing.Size(75, 23);
            this.guzik_exit_login.TabIndex = 5;
            this.guzik_exit_login.Text = "Wyjście";
            this.guzik_exit_login.UseVisualStyleBackColor = true;
            this.guzik_exit_login.Click += new System.EventHandler(this.guzik_exit_login_Click);
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 149);
            this.Controls.Add(this.guzik_exit_login);
            this.Controls.Add(this.okno_haslo);
            this.Controls.Add(this.okno_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guzik_login);
            this.Controls.Add(this.label1);
            this.Name = "Logowanie";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guzik_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox okno_login;
        private System.Windows.Forms.ListBox okno_haslo;
        private System.Windows.Forms.Button guzik_exit_login;
    }
}