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
            this.label1 = new System.Windows.Forms.Label();
            this.okno_szukaj_kontakty = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.skupAutDataSet = new FormUI.SkupAutDataSet();
            this.kontaktyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kontaktyTableAdapter = new FormUI.SkupAutDataSetTableAdapters.KontaktyTableAdapter();
            this.nAZWISKODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kontaktyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skupAutDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // kontakty_okno
            // 
            this.kontakty_okno.FormattingEnabled = true;
            this.kontakty_okno.Location = new System.Drawing.Point(30, 77);
            this.kontakty_okno.Name = "kontakty_okno";
            this.kontakty_okno.Size = new System.Drawing.Size(190, 394);
            this.kontakty_okno.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Szukaj";
            // 
            // okno_szukaj_kontakty
            // 
            this.okno_szukaj_kontakty.Location = new System.Drawing.Point(103, 39);
            this.okno_szukaj_kontakty.Name = "okno_szukaj_kontakty";
            this.okno_szukaj_kontakty.Size = new System.Drawing.Size(194, 20);
            this.okno_szukaj_kontakty.TabIndex = 4;
            this.okno_szukaj_kontakty.TextChanged += new System.EventHandler(this.okno_szukaj_kontakty_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAZWISKODataGridViewTextBoxColumn,
            this.iMIEDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kontaktyBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(236, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 394);
            this.dataGridView1.TabIndex = 5;
            // 
            // skupAutDataSet
            // 
            this.skupAutDataSet.DataSetName = "SkupAutDataSet";
            this.skupAutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kontaktyBindingSource2
            // 
            this.kontaktyBindingSource2.DataMember = "Kontakty";
            this.kontaktyBindingSource2.DataSource = this.skupAutDataSet;
            // 
            // kontaktyTableAdapter
            // 
            this.kontaktyTableAdapter.ClearBeforeFill = true;
            // 
            // nAZWISKODataGridViewTextBoxColumn
            // 
            this.nAZWISKODataGridViewTextBoxColumn.DataPropertyName = "NAZWISKO";
            this.nAZWISKODataGridViewTextBoxColumn.HeaderText = "NAZWISKO";
            this.nAZWISKODataGridViewTextBoxColumn.Name = "nAZWISKODataGridViewTextBoxColumn";
            // 
            // iMIEDataGridViewTextBoxColumn
            // 
            this.iMIEDataGridViewTextBoxColumn.DataPropertyName = "IMIE";
            this.iMIEDataGridViewTextBoxColumn.HeaderText = "IMIE";
            this.iMIEDataGridViewTextBoxColumn.Name = "iMIEDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // kontaktyBindingSource
            // 
            this.kontaktyBindingSource.DataSource = typeof(FormUI.Kontakty);
            // 
            // kontaktyBindingSource1
            // 
            this.kontaktyBindingSource1.DataSource = typeof(FormUI.Kontakty);
            // 
            // Kontakty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 486);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.okno_szukaj_kontakty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kontakty_okno);
            this.Name = "Kontakty";
            this.Text = "Kontakty";
            this.Load += new System.EventHandler(this.Kontakty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skupAutDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox kontakty_okno;
        private System.Windows.Forms.BindingSource kontaktyBindingSource;
        private System.Windows.Forms.BindingSource kontaktyBindingSource1;
        protected internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox okno_szukaj_kontakty;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SkupAutDataSet skupAutDataSet;
        private System.Windows.Forms.BindingSource kontaktyBindingSource2;
        private SkupAutDataSetTableAdapters.KontaktyTableAdapter kontaktyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWISKODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}