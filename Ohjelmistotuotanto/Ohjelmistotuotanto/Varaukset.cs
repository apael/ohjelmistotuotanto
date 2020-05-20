using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohjelmistotuotanto
{
    public class Varaukset
    {

        public int varaus_id { get; set; }
        public int asiakas_id { get; set; }
        public int mokki_mokki_id { get; set; }
        public DateTime varattu_alkupvm { get; set; }
        public DateTime varattu_loppupvm { get; set; }

    }
}
