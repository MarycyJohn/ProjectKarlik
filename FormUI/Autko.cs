using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Autko
    {
        public int id { get; set; }
        public string marka { get; set; }
        public int rok { get; set; }
        public string kolor { get; set; }
        public string Naped_4x4 { get; set; }
        
        public string FullInfo
        {
            get
            {
                return $"{ marka } rocznik:{ rok } kolor:{ kolor } ";
            }
        }

    }
}
