using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    internal class Recept
    {
        private List<Ordination> ordinationer;


        public Recept() { }
        public Recept(List<Ordination> ordinationer, int receptId, int yderNummer, int cprNummer)
        {
            this.ordinationer = ordinationer;
            ReceptId = receptId;
            YderNummer = yderNummer;
            CprNummer = cprNummer;
        }

        public List<Ordination> Ordinationer { get; set; } = new List<Ordination>();
        public int ReceptId { get; set; }
        public int YderNummer { get; set; }
        public int CprNummer { get; set; }
        
    }
}
