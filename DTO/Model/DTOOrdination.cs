using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class DTOOrdination
    {
        public DTOOrdination(int ordinationId, string beskrivelse, string dosis, 
                             int antalUdlv, int antalForetagneUdlv)
        {
            OrdinationId = ordinationId;
            Beskrivelse = beskrivelse;
            Dosis = dosis;
            AntalUdlv = antalUdlv;
            AntalForetagneUdlv = antalForetagneUdlv;
        }

        public int OrdinationId { get; set; }
        public string Beskrivelse { get; set; } // beskriver lægemiddel
        public string Dosis { get; set; }
        public int AntalUdlv { get; set; } // antal udleveringer
        public int AntalForetagneUdlv { get; set; } // antal foretagne udleveringer
    }
}
