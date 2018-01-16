using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace FormUI

{
    public class Dostep
    {
        public List<Autko> GetAutko(string marka)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Support.CnnVal("Pew")))
            {
                var output = connection.Query<Autko>($"select * from auta where marka = '{ marka }'").ToList();
               // var output = connection.Query<Autko>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();
                return output;
            }
        }
        /*
        public void InsertPerson(string marka_x, int rok_x, string kolor_x, string Naped_4x4_x)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Support.CnnVal("SampleDB")))
            {
                //Person newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber };
                List<Autko> people = new List<Autko>();

                people.Add(new Autko { marka = marka_x, rok = rok_x, kolor = kolor_x, Naped_4x4 = Naped_4x4_x });

                connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);

            }
        }*/
    }
}
