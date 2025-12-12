using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    internal class Ordination
    {

        public Ordination() { }
        public Ordination(int ordinationId, int receptId, string beskrivelse, string dosis, 
                          int antalUdlv, int antalForetagneUdlv)
        {
            OrdinationId = ordinationId;
            ReceptId = receptId;
            Beskrivelse = beskrivelse;
            Dosis = dosis;
            AntalUdlv = antalUdlv;
            AntalForetagneUdlv = antalForetagneUdlv;
        }

        public int OrdinationId { get; set; }
        public int ReceptId { get; set; }
        public string Beskrivelse { get; set; } // beskriver lægemiddel
        public string Dosis { get; set; } 
        public int AntalUdlv { get; set; } // antal udleveringer
        public int AntalForetagneUdlv { get; set; } // antal foretagne udleveringer
    }
}
