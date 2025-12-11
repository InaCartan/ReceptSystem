using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class DTOApotek
    {
        public DTOApotek(int apotekId, string navn, string telefon, string adresse)
        {
            ApotekId = apotekId;
            Navn = navn;
            Telefon = telefon;
            Adresse = adresse;
        }

        public int ApotekId { get; set; }
        public string Navn { get; set; }
        public string Telefon { get; set; }
        public string Adresse { get; set; }
    }
}
