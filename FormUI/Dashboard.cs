using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Autko> auto = new List<Autko>();

        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            peopleFoundListbox.DataSource = auto;
            peopleFoundListbox.DisplayMember = "FullInfo";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Dostep db = new Dostep();

            auto = db.GetAutko(okno_szukaj.Text);

            UpdateBinding();
        }
        /*
        private void insertRecordButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.SkupAut(markaInsText.Text, rokInsText.Text, kolorInsText.Text, Naped_4x4InsText.Text);

            firstNameInsText.Text = "";
            lastNameInsText.Text = "";
            emailAddressInsText.Text = "";
            phoneNumberInsText.Text = "";
        }
        */
        private void lastNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameInsLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastNameInsText_TextChanged(object sender, EventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {


                e.Handled = false;

            }
            else
            {
                MessageBox.Show("Prosze wprowadzic jedynie rok.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;

            }

        }

        private void Guzik_dodak_Click(object sender, EventArgs e)
        {
            Dostep db = new Dostep();

            db.InsertAutko(okno_marka.Text, okno_rok.Text, okno_kolor.Text, okno_naped.Text);

            okno_marka.Text = "";
            okno_rok.Text = "";
            okno_kolor.Text = "";
            okno_naped.Text = "";
        }
    }
}
