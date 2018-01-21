namespace FormUI
{
    partial class Kontakty
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
            this.components = new System.ComponentModel.Container();
            this.kontakty_okno = new System.Windows.Forms.ListBox();
            this.okno_szukaj_kontakty = new System.Windows.Forms.ListBox();
            this.kontaktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kontaktyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // kontakty_okno
            // 
            this.kontakty_okno.FormattingEnabled = true;
            this.kontakty_okno.Location = new System.Drawing.Point(95, 55);
            this.kontakty_okno.Name = "kontakty_okno";
            this.kontakty_okno.Size = new System.Drawing.Size(542, 368);
            this.kontakty_okno.TabIndex = 0;
            // 
            // okno_szukaj_kontakty
            // 
            this.okno_szukaj_kontakty.FormattingEnabled = true;
            this.okno_szukaj_kontakty.Location = new System.Drawing.Point(238, 19);
            this.okno_szukaj_kontakty.Name = "okno_szukaj_kontakty";
            this.okno_szukaj_kontakty.Size = new System.Drawing.Size(230, 30);
            this.okno_szukaj_kontakty.TabIndex = 2;
            this.okno_szukaj_kontakty.SelectedIndexChanged += new System.EventHandler(this.okno_szukaj_kontakty_SelectedIndexChanged);
            // 
            // kontaktyBindingSource
            // 
            this.kontaktyBindingSource.DataSource = typeof(FormUI.Kontakty);
            // 
            // kontaktyBindingSource1
            // 
            this.kontaktyBindingSource1.DataSource = typeof(FormUI.Kontakty);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(92, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Szukaj po nazwisku";
            // 
            // Kontakty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okno_szukaj_kontakty);
            this.Controls.Add(this.kontakty_okno);
            this.Name = "Kontakty";
            this.Text = "Kontakty";
            this.Load += new System.EventHandler(this.Kontakty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kontaktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox kontakty_okno;
        private System.Windows.Forms.BindingSource kontaktyBindingSource;
        private System.Windows.Forms.BindingSource kontaktyBindingSource1;
        private System.Windows.Forms.ListBox okno_szukaj_kontakty;
        protected internal System.Windows.Forms.Label label1;
    }
}