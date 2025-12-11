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

        public List<DTOOrdination> Ordinationer { get; set; }
        public int ReceptId { get; set; }
        public int YderNummer { get; set; }
        public int CprNummer { get; set; }



    }
}
