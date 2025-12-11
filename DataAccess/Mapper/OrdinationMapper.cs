using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;
using DTO.Model;

namespace DataAccess.Mapper
{
    internal class OrdinationMapper
    {
        public static DTOOrdination MapToDto(Ordination ordination)
        {
            return new DTOOrdination
            (
                ordination.OrdinationId,
                ordination.Beskrivelse,
                ordination.Dosis,
                ordination.AntalUdlv,
                ordination.AntalForetagneUdlv
            );
        }

        public static Ordination MapFromDto(DTOOrdination ordination)
        {
            return new Ordination
            (
                ordination.OrdinationId,
                ordination.Beskrivelse,
                ordination.Dosis,
                ordination.AntalUdlv,
                ordination.AntalForetagneUdlv
            );
        }

        public static void Update(DTOOrdination ordinationDto, Ordination ordination)
        {
            ordinationDto.Beskrivelse = ordination.Beskrivelse;
            ordinationDto.Dosis = ordination.Dosis;
            ordinationDto.AntalUdlv = ordination.AntalUdlv;
            ordinationDto.AntalForetagneUdlv = ordination.AntalForetagneUdlv;
        }
        
            
        
    }
}
