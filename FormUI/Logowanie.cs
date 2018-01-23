using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FormUI
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guzik_exit_login_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guzik_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SRV-SQL5;Initial Catalog=SkupAut;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Rola from dbo.Tabela_uzytkownicy where [Username] ='" + okienko_login.Text + "' and [Password] = '" +  okienko_haslo.Text + "'  ", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                this.Hide();
                MDIParent1 ss = new MDIParent1(dt.Rows[0][0].ToString());
                ss.Show();
                //((Form)ss).Controls["Status_label"].Text = dt.Rows[0][0].ToString();

            }
        }

        private void okno_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tab(object sender, KeyEventArgs e)
        {
                if (e.KeyCode.Equals(Keys.Tab))
                {
                    okienko_haslo.Focus();
                }
            }

        private void Tab(object sender, KeyPressEventArgs e)
        {

        }
    }
    }

