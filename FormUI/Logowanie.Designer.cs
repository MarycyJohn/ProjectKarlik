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
            this.guzik_exit_login = new System.Windows.Forms.Button();
            this.okienko_login = new System.Windows.Forms.TextBox();
            this.okienko_haslo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // guzik_login
            // 
            this.guzik_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guzik_login.Location = new System.Drawing.Point(77, 101);
            this.guzik_login.Name = "guzik_login";
            this.guzik_login.Size = new System.Drawing.Size(75, 35);
            this.guzik_login.TabIndex = 2;
            this.guzik_login.Text = "Login";
            this.guzik_login.UseVisualStyleBackColor = true;
            this.guzik_login.Click += new System.EventHandler(this.guzik_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "HASŁO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // guzik_exit_login
            // 
            this.guzik_exit_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guzik_exit_login.Location = new System.Drawing.Point(158, 101);
            this.guzik_exit_login.Name = "guzik_exit_login";
            this.guzik_exit_login.Size = new System.Drawing.Size(75, 35);
            this.guzik_exit_login.TabIndex = 3;
            this.guzik_exit_login.Text = "Wyjście";
            this.guzik_exit_login.UseVisualStyleBackColor = true;
            this.guzik_exit_login.Click += new System.EventHandler(this.guzik_exit_login_Click);
            // 
            // okienko_login
            // 
            this.okienko_login.Location = new System.Drawing.Point(77, 27);
            this.okienko_login.Name = "okienko_login";
            this.okienko_login.Size = new System.Drawing.Size(186, 20);
            this.okienko_login.TabIndex = 0;
            this.okienko_login.TextChanged += new System.EventHandler(this.okno_login_TextChanged);
            this.okienko_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tab);
            // 
            // okienko_haslo
            // 
            this.okienko_haslo.Location = new System.Drawing.Point(78, 62);
            this.okienko_haslo.Name = "okienko_haslo";
            this.okienko_haslo.Size = new System.Drawing.Size(186, 20);
            this.okienko_haslo.TabIndex = 1;
            this.okienko_haslo.TextChanged += new System.EventHandler(this.okno_login_TextChanged);
            this.okienko_haslo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tab);
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 154);
            this.Controls.Add(this.okienko_haslo);
            this.Controls.Add(this.okienko_login);
            this.Controls.Add(this.guzik_exit_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guzik_login);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Logowanie";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guzik_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button guzik_exit_login;
        private System.Windows.Forms.TextBox okienko_login;
        private System.Windows.Forms.TextBox okienko_haslo;
    }
}