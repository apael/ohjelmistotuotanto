using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohjelmistotuotanto
{
    public class Kohde
    {
        public int mokki_id { get; set; }
        public int toimintaalue_id { get; set; }
        public string postinro { get; set; }
        public string mokkinimi { get; set; }
        public string katuosoite { get; set; }
        public string kuvaus { get; set; }
        public int henkilomaara { get; set; }

    }
}
