using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class DTOLaegehus
    {
        public List<DTORecept> Recepter { get; set; }
        public int LaegehusId { get; set; }
        public int YderNummer { get; set; }
        public string Navn { get; set; }
        public string Telefon { get; set; }
        public string Adresse { get; set; }

    }
}
