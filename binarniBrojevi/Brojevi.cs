using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarniBrojevi
{
    class Brojevi
    {
        public string binarni { get; set; }
        public int decimalni { get; set; }

        public List<Brojevi> listaBrojeva;

        public Brojevi() 
        {
            listaBrojeva = new List<Brojevi>();
        }


        public int BinToDec(string broj)
        {
            int dec = Convert.ToInt32(broj, 2);
            return dec;
        }
    }
}
