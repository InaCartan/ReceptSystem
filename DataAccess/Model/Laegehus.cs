using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    internal class Laegehus
    {
        private List<Recept> recepter;

        public Laegehus(){}

        public Laegehus(List<Recept> recepter, int laegehusId, int yderNummer, 
                        string navn, string telefon, string adresse)
        {
            this.recepter = recepter;
            LaegehusId = laegehusId;
            YderNummer = yderNummer;
            Navn = navn;
            Telefon = telefon;
            Adresse = adresse;
        }

        public List<Recept> Recepter { get { return recepter; } }
        public int LaegehusId { get; set; }
        public int YderNummer { get; set; }
        public string Navn { get; set; }
        public string Telefon { get; set; }
        public string Adresse { get; set; }

    }
}
