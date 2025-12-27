using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class DTORecept
    {
        private List<DTOOrdination> ordinationer;

        public DTORecept(List<DTOOrdination> ordinationer, int receptId, int yderNummer, int cprNummer)
        {
            this.ordinationer = ordinationer;
            ReceptId = receptId;
            YderNummer = yderNummer;
            CprNummer = cprNummer;
        }

        public List<DTOOrdination> Ordinationer { get; set; } = new List<DTOOrdination>();
        public int ReceptId { get; set; }
        public int YderNummer { get; set; }
        public int CprNummer { get; set; }



    }
}
