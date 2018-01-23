namespace FormUI
{
    partial class Dashboard
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
            this.okno_wynik = new System.Windows.Forms.ListBox();
            this.okno_szukaj = new System.Windows.Forms.TextBox();
            this.Wprowadz_marke = new System.Windows.Forms.Label();
            this.Guzik_szukaj = new System.Windows.Forms.Button();
            this.nazwa_marka = new System.Windows.Forms.Label();
            this.okno_marka = new System.Windows.Forms.TextBox();
            this.nazwa_rok = new System.Windows.Forms.Label();
            this.okno_rok = new System.Windows.Forms.TextBox();
            this.nazwa_kolor = new System.Windows.Forms.Label();
            this.okno_kolor = new System.Windows.Forms.TextBox();
            this.nazwa_naped = new System.Windows.Forms.Label();
            this.okno_naped = new System.Windows.Forms.TextBox();
            this.Guzik_dodak = new System.Windows.Forms.Button();
            this.Kontakty_guzik = new System.Windows.Forms.Button();
            this.wyjscie_main = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okno_wynik
            // 
            this.okno_wynik.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.okno_wynik.FormattingEnabled = true;
            this.okno_wynik.ItemHeight = 25;
            this.okno_wynik.Location = new System.Drawing.Point(21, 145);
            this.okno_wynik.Name = "okno_wynik";
            this.okno_wynik.Size = new System.Drawing.Size(736, 154);
            this.okno_wynik.TabIndex = 0;
            this.okno_wynik.SelectedIndexChanged += new System.EventHandler(this.okno_wynik_SelectedIndexChanged);
            // 
            // okno_szukaj
            // 
            this.okno_szukaj.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.okno_szukaj.Location = new System.Drawing.Point(222, 53);
            this.okno_szukaj.Name = "okno_szukaj";
            this.okno_szukaj.Size = new System.Drawing.Size(197, 31);
            this.okno_szukaj.TabIndex = 1;
            this.okno_szukaj.TextChanged += new System.EventHandler(this.lastNameText_TextChanged);
            // 
            // Wprowadz_marke
            // 
            this.Wprowadz_marke.AutoSize = true;
            this.Wprowadz_marke.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Wprowadz_marke.Location = new System.Drawing.Point(38, 53);
            this.Wprowadz_marke.Name = "Wprowadz_marke";
            this.Wprowadz_marke.Size = new System.Drawing.Size(178, 25);
            this.Wprowadz_marke.TabIndex = 2;
            this.Wprowadz_marke.Text = "Wprowadź markę";
            this.Wprowadz_marke.Click += new System.EventHandler(this.Wprowadz_marke_Click);
            // 
            // Guzik_szukaj
            // 
            this.Guzik_szukaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Guzik_szukaj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Guzik_szukaj.Location = new System.Drawing.Point(425, 47);
            this.Guzik_szukaj.Name = "Guzik_szukaj";
            this.Guzik_szukaj.Size = new System.Drawing.Size(133, 42);
            this.Guzik_szukaj.TabIndex = 3;
            this.Guzik_szukaj.Text = "Search";
            this.Guzik_szukaj.UseVisualStyleBackColor = false;
            this.Guzik_szukaj.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // nazwa_marka
            // 
            this.nazwa_marka.AutoSize = true;
            this.nazwa_marka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nazwa_marka.Location = new System.Drawing.Point(38, 356);
            this.nazwa_marka.Name = "nazwa_marka";
            this.nazwa_marka.Size = new System.Drawing.Size(72, 25);
            this.nazwa_marka.TabIndex = 5;
            this.nazwa_marka.Text = "Marka";
            this.nazwa_marka.Click += new System.EventHandler(this.firstNameInsLabel_Click);
            // 
            // okno_marka
            // 
            this.okno_marka.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.okno_marka.Location = new System.Drawing.Point(254, 350);
            this.okno_marka.Name = "okno_marka";
            this.okno_marka.Size = new System.Drawing.Size(197, 31);
            this.okno_marka.TabIndex = 4;
            this.okno_marka.TextChanged += new System.EventHandler(this.okno_marka_TextChanged);
            // 
            // nazwa_rok
            // 
            this.nazwa_rok.AutoSize = true;
            this.nazwa_rok.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nazwa_rok.Location = new System.Drawing.Point(38, 393);
            this.nazwa_rok.Name = "nazwa_rok";
            this.nazwa_rok.Size = new System.Drawing.Size(42, 25);
            this.nazwa_rok.TabIndex = 7;
            this.nazwa_rok.Text = "rok";
            // 
            // okno_rok
            // 
            this.okno_rok.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.okno_rok.Location = new System.Drawing.Point(254, 387);
            this.okno_rok.Name = "okno_rok";
            this.okno_rok.Size = new System.Drawing.Size(197, 31);
            this.okno_rok.TabIndex = 6;
            this.okno_rok.TextChanged += new System.EventHandler(this.okno_rok_TextChanged);
            // 
            // nazwa_kolor
            // 
            this.nazwa_kolor.AutoSize = true;
            this.nazwa_kolor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nazwa_kolor.Location = new System.Drawing.Point(38, 430);
            this.nazwa_kolor.Name = "nazwa_kolor";
            this.nazwa_kolor.Size = new System.Drawing.Size(59, 25);
            this.nazwa_kolor.TabIndex = 9;
            this.nazwa_kolor.Text = "kolor";
            // 
            // okno_kolor
            // 
            this.okno_kolor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.okno_kolor.Location = new System.Drawing.Point(254, 424);
            this.okno_kolor.Name = "okno_kolor";
            this.okno_kolor.Size = new System.Drawing.Size(197, 31);
            this.okno_kolor.TabIndex = 8;
            this.okno_kolor.TextChanged += new System.EventHandler(this.okno_kolor_TextChanged);
            // 
            // nazwa_naped
            // 
            this.nazwa_naped.AutoSize = true;
            this.nazwa_naped.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nazwa_naped.Location = new System.Drawing.Point(38, 467);
            this.nazwa_naped.Name = "nazwa_naped";
            this.nazwa_naped.Size = new System.Drawing.Size(210, 25);
            this.nazwa_naped.TabIndex = 11;
            this.nazwa_naped.Text = "Napęd 4x4 (Tak/Nie)";
            // 
            // okno_naped
            // 
            this.okno_naped.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.okno_naped.Location = new System.Drawing.Point(254, 461);
            this.okno_naped.Name = "okno_naped";
            this.okno_naped.Size = new System.Drawing.Size(197, 31);
            this.okno_naped.TabIndex = 10;
            this.okno_naped.TextChanged += new System.EventHandler(this.okno_naped_TextChanged);
            // 
            // Guzik_dodak
            // 
            this.Guzik_dodak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Guzik_dodak.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Guzik_dodak.Location = new System.Drawing.Point(192, 509);
            this.Guzik_dodak.Name = "Guzik_dodak";
            this.Guzik_dodak.Size = new System.Drawing.Size(133, 42);
            this.Guzik_dodak.TabIndex = 12;
            this.Guzik_dodak.Text = "Dodaj";
            this.Guzik_dodak.UseVisualStyleBackColor = false;
            this.Guzik_dodak.Click += new System.EventHandler(this.Guzik_dodak_Click);
            // 
            // Kontakty_guzik
            // 
            this.Kontakty_guzik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kontakty_guzik.Location = new System.Drawing.Point(682, 305);
            this.Kontakty_guzik.Name = "Kontakty_guzik";
            this.Kontakty_guzik.Size = new System.Drawing.Size(75, 27);
            this.Kontakty_guzik.TabIndex = 14;
            this.Kontakty_guzik.Text = "Kontakty";
            this.Kontakty_guzik.UseVisualStyleBackColor = true;
            this.Kontakty_guzik.Click += new System.EventHandler(this.button1_Click);
            // 
            // wyjscie_main
            // 
            this.wyjscie_main.Location = new System.Drawing.Point(667, 545);
            this.wyjscie_main.Name = "wyjscie_main";
            this.wyjscie_main.Size = new System.Drawing.Size(96, 34);
            this.wyjscie_main.TabIndex = 15;
            this.wyjscie_main.Text = "Wyjście";
            this.wyjscie_main.UseVisualStyleBackColor = true;
            this.wyjscie_main.Click += new System.EventHandler(this.wyjscie_main_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(775, 591);
            this.Controls.Add(this.wyjscie_main);
            this.Controls.Add(this.Kontakty_guzik);
            this.Controls.Add(this.Guzik_dodak);
            this.Controls.Add(this.nazwa_naped);
            this.Controls.Add(this.okno_naped);
            this.Controls.Add(this.nazwa_kolor);
            this.Controls.Add(this.okno_kolor);
            this.Controls.Add(this.nazwa_rok);
            this.Controls.Add(this.okno_rok);
            this.Controls.Add(this.nazwa_marka);
            this.Controls.Add(this.okno_marka);
            this.Controls.Add(this.Guzik_szukaj);
            this.Controls.Add(this.Wprowadz_marke);
            this.Controls.Add(this.okno_szukaj);
            this.Controls.Add(this.okno_wynik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access Demo";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox okno_wynik;
        private System.Windows.Forms.TextBox okno_szukaj;
        private System.Windows.Forms.Label Wprowadz_marke;
        private System.Windows.Forms.Button Guzik_szukaj;
        private System.Windows.Forms.Label nazwa_marka;
        private System.Windows.Forms.TextBox okno_marka;
        private System.Windows.Forms.Label nazwa_rok;
        private System.Windows.Forms.TextBox okno_rok;
        private System.Windows.Forms.Label nazwa_kolor;
        private System.Windows.Forms.TextBox okno_kolor;
        private System.Windows.Forms.Label nazwa_naped;
        private System.Windows.Forms.TextBox okno_naped;
        private System.Windows.Forms.Button Guzik_dodak;
        private System.Windows.Forms.Button Kontakty_guzik;
        private System.Windows.Forms.Button wyjscie_main;
    }
}

