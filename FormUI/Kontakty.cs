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
using Dapper;
using System.Configuration;


namespace FormUI
{
    public partial class Kontakty : Form
    {
        public Kontakty()
        {
            InitializeComponent();
        }
        private DataTable dtKontakty;

        private void Kontakty_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'skupAutDataSet.Kontakty' table. You can move, or remove it, as needed.
            this.kontaktyTableAdapter.Fill(this.skupAutDataSet.Kontakty);
            kontakty_okno.DataSource = GetData();
            kontakty_okno.DisplayMember = "email";
            
        }

        private DataTable GetData()
        {
         
            dtKontakty = new DataTable();
       

            string connectionString = ConfigurationManager.ConnectionStrings["Pew"].ConnectionString;
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.Lista_Kontaktow", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        conn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();

                        dtKontakty.Load(reader);


                    }

                }
            }


            return dtKontakty; //tymczasowo
        }

        private void okno_szukaj_kontakty_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dvKontakty = dtKontakty.DefaultView;
            dvKontakty.RowFilter = "Nazwisko LIKE '%" + okno_szukaj_kontakty.Text + "%'";
        }

        private void okno_szukaj_kontakty_TextChanged(object sender, EventArgs e)
        {

        }
    }
}  //tymczasowo











          //  dtKontakty = new DataTable();

            //StringSplitOptions connectionString = ConfigurationManager.ConnectionStrings["Pew"].ConnectionString;
        /*  
        }


        */
     //   private DataTable dtKontakty;  //dodane z https://www.youtube.com/watch?v=-F9FB6qgRfY
       // private string connectionString;      //SOLUTION 1

     //   public void kontakty_okno_SelectedIndexChanged(object sender, EventArgs e)
    //    {

            /*
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Support.CnnVal("Pew")))
                using (SqlCommand cmd = new SqlCommand("Lista_kontaktow", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = connection.ExecuteReader();
                    dtCountires.Load(reader);
                }
            }*/
            //connection.Execute("dbo.Lista_kontaktow");
            //var output = connection.Execute("dbo.Lista_kontaktow");
            // string connectionString = ConfigurationManager.ConnectionString
            //  Dostep Lista_kontaktow = new Dostep();
            // Lista_kontaktow.ToString.tes;
      //  }


   // }
//}

