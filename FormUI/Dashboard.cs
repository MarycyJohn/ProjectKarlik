using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
            okno_wynik.DataSource = auto;
            okno_wynik.DisplayMember = "FullInfo";
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


        /*
        private void lastNameInsText_TextChanged(object sender, EventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;

        }*/

/*
        private void lastNameInsText_TextChanged(object sender, KeyEventArgs e)
        {
            // Rejects any keys not in the range of 0-9 (by ASCII number),
            //   the Delete key or the Back key
            if ((e.KeyValue < 48 || e.KeyValue > 57) && e.KeyCode != Keys.Delete
                         && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
                SystemSounds.Beep.Play();
            }
        }
        */

        private void okno_rok_TextChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        ///  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>



        private void Guzik_dodak_Click(object sender, EventArgs e)
        {
            Dostep db = new Dostep();

            db.InsertAutko(okno_marka.Text, okno_rok, okno_kolor.Text, okno_naped.Text);

            okno_marka.Text = "";
            okno_rok.Text = "";
            okno_kolor.Text = "";
            okno_naped.Text = "";
        }

        private void okno_marka_TextChanged(object sender, EventArgs e)
        {

        }

        private void okno_kolor_TextChanged(object sender, EventArgs e)
        {

        }

        private void okno_naped_TextChanged(object sender, EventArgs e)
        {

        }

        private void okno_wynik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Wprowadz_marke_Click(object sender, EventArgs e)
        {

        }
    }
}
