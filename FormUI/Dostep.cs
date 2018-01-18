using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Windows.Forms;

namespace FormUI

{
    public class Dostep
    {
        public List<Autko> GetAutko(string marka)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Support.CnnVal("Pew")))
            {
                //var output = connection.Query<Autko>($"select * from auta where marka = '{ marka }'").ToList();
                var output = connection.Query<Autko>("dbo.Autka_marki @marka", new { marka = marka }).ToList();
                //używam procedury autka_marki zamiast konkretnego polecenia sql
                return output;
            }
        }


        public void InsertAutko(string marka_x, string rok_x, string kolor_x, string Naped_4x4_x)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Support.CnnVal("Pew")))
            {
                //Autko newAutko = new Autko { marka = marka_x, rok = rok_x, kolor = kolor_x, Naped_4x4 = Naped_4x4_x };
                List<Autko> auto = new List<Autko>();
                auto.Add(new Autko { marka = marka_x, rok = rok_x, kolor = kolor_x, Naped_4x4 = Naped_4x4_x });
                connection.Execute("dbo.Autka_wprowadz @Marka, @Rok, @Kolor, @Naped_4x4", auto);
            }
        }
    } }
                /*
       using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Support.CnnVal("Pew")))
       {
           //Person newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber };
           List<Autko> people = new List<Autko>();

           people.Add(new Autko { marka = marka_x, rok = rok_x, kolor = kolor_x, Naped_4x4 = Naped_4x4_x });

           connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);
           
                throw new NotImplementedException();
   }
        
        internal void InsertAutko(string text1, TextBox okno_rok, string text2, string text3)
        {
            throw new NotImplementedException();
        }*/
    
    

