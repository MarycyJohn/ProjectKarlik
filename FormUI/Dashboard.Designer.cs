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
            this.peopleFoundListbox = new System.Windows.Forms.ListBox();
            this.okno_szukaj = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.nazwa_marka = new System.Windows.Forms.Label();
            this.okno_marka = new System.Windows.Forms.TextBox();
            this.nazwa_rok = new System.Windows.Forms.Label();
            this.okno_rok = new System.Windows.Forms.TextBox();
            this.nazwa_kolor = new System.Windows.Forms.Label();
            this.okno_kolor = new System.Windows.Forms.TextBox();
            this.nazwa_naped = new System.Windows.Forms.Label();
            this.okno_naped = new System.Windows.Forms.TextBox();
            this.insertRecordButton = new System.Windows.Forms.Button();
            this.Guzik_dodak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFoundListbox
            // 
            this.peopleFoundListbox.FormattingEnabled = true;
            this.peopleFoundListbox.ItemHeight = 25;
            this.peopleFoundListbox.Location = new System.Drawing.Point(21, 145);
            this.peopleFoundListbox.Name = "peopleFoundListbox";
            this.peopleFoundListbox.Size = new System.Drawing.Size(736, 154);
            this.peopleFoundListbox.TabIndex = 0;
            // 
            // okno_szukaj
            // 
            this.okno_szukaj.Location = new System.Drawing.Point(159, 50);
            this.okno_szukaj.Name = "okno_szukaj";
            this.okno_szukaj.Size = new System.Drawing.Size(197, 31);
            this.okno_szukaj.TabIndex = 1;
            this.okno_szukaj.TextChanged += new System.EventHandler(this.lastNameText_TextChanged);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(38, 53);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(115, 25);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(362, 44);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(133, 42);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // nazwa_marka
            // 
            this.nazwa_marka.AutoSize = true;
            this.nazwa_marka.Location = new System.Drawing.Point(38, 356);
            this.nazwa_marka.Name = "nazwa_marka";
            this.nazwa_marka.Size = new System.Drawing.Size(72, 25);
            this.nazwa_marka.TabIndex = 5;
            this.nazwa_marka.Text = "Marka";
            this.nazwa_marka.Click += new System.EventHandler(this.firstNameInsLabel_Click);
            // 
            // okno_marka
            // 
            this.okno_marka.Location = new System.Drawing.Point(254, 350);
            this.okno_marka.Name = "okno_marka";
            this.okno_marka.Size = new System.Drawing.Size(197, 31);
            this.okno_marka.TabIndex = 4;
            // 
            // nazwa_rok
            // 
            this.nazwa_rok.AutoSize = true;
            this.nazwa_rok.Location = new System.Drawing.Point(38, 393);
            this.nazwa_rok.Name = "nazwa_rok";
            this.nazwa_rok.Size = new System.Drawing.Size(42, 25);
            this.nazwa_rok.TabIndex = 7;
            this.nazwa_rok.Text = "rok";
            // 
            // okno_rok
            // 
            this.okno_rok.Location = new System.Drawing.Point(254, 387);
            this.okno_rok.Name = "okno_rok";
            this.okno_rok.Size = new System.Drawing.Size(197, 31);
            this.okno_rok.TabIndex = 6;
            this.okno_rok.TextChanged += new System.EventHandler(this.lastNameInsText_TextChanged);
            // 
            // nazwa_kolor
            // 
            this.nazwa_kolor.AutoSize = true;
            this.nazwa_kolor.Location = new System.Drawing.Point(38, 430);
            this.nazwa_kolor.Name = "nazwa_kolor";
            this.nazwa_kolor.Size = new System.Drawing.Size(59, 25);
            this.nazwa_kolor.TabIndex = 9;
            this.nazwa_kolor.Text = "kolor";
            // 
            // okno_kolor
            // 
            this.okno_kolor.Location = new System.Drawing.Point(254, 424);
            this.okno_kolor.Name = "okno_kolor";
            this.okno_kolor.Size = new System.Drawing.Size(197, 31);
            this.okno_kolor.TabIndex = 8;
            // 
            // nazwa_naped
            // 
            this.nazwa_naped.AutoSize = true;
            this.nazwa_naped.Location = new System.Drawing.Point(38, 467);
            this.nazwa_naped.Name = "nazwa_naped";
            this.nazwa_naped.Size = new System.Drawing.Size(210, 25);
            this.nazwa_naped.TabIndex = 11;
            this.nazwa_naped.Text = "Napęd 4x4 (Tak/Nie)";
            // 
            // okno_naped
            // 
            this.okno_naped.Location = new System.Drawing.Point(254, 461);
            this.okno_naped.Name = "okno_naped";
            this.okno_naped.Size = new System.Drawing.Size(197, 31);
            this.okno_naped.TabIndex = 10;
            // 
            // insertRecordButton
            // 
            this.insertRecordButton.Location = new System.Drawing.Point(0, 0);
            this.insertRecordButton.Name = "insertRecordButton";
            this.insertRecordButton.Size = new System.Drawing.Size(75, 23);
            this.insertRecordButton.TabIndex = 0;
            // 
            // Guzik_dodak
            // 
            this.Guzik_dodak.Location = new System.Drawing.Point(192, 509);
            this.Guzik_dodak.Name = "Guzik_dodak";
            this.Guzik_dodak.Size = new System.Drawing.Size(133, 42);
            this.Guzik_dodak.TabIndex = 12;
            this.Guzik_dodak.Text = "Dodaj";
            this.Guzik_dodak.UseVisualStyleBackColor = true;
            this.Guzik_dodak.Click += new System.EventHandler(this.Guzik_dodak_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 591);
            this.Controls.Add(this.Guzik_dodak);
            this.Controls.Add(this.insertRecordButton);
            this.Controls.Add(this.nazwa_naped);
            this.Controls.Add(this.okno_naped);
            this.Controls.Add(this.nazwa_kolor);
            this.Controls.Add(this.okno_kolor);
            this.Controls.Add(this.nazwa_rok);
            this.Controls.Add(this.okno_rok);
            this.Controls.Add(this.nazwa_marka);
            this.Controls.Add(this.okno_marka);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.okno_szukaj);
            this.Controls.Add(this.peopleFoundListbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListbox;
        private System.Windows.Forms.TextBox okno_szukaj;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label nazwa_marka;
        private System.Windows.Forms.TextBox okno_marka;
        private System.Windows.Forms.Label nazwa_rok;
        private System.Windows.Forms.TextBox okno_rok;
        private System.Windows.Forms.Label nazwa_kolor;
        private System.Windows.Forms.TextBox okno_kolor;
        private System.Windows.Forms.Label nazwa_naped;
        private System.Windows.Forms.TextBox okno_naped;
        private System.Windows.Forms.Button insertRecordButton;
        private System.Windows.Forms.Button Guzik_dodak;
    }
}

