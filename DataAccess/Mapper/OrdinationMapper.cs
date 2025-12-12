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
                ordination.ReceptId,
                ordination.Beskrivelse,
                ordination.Dosis,
                ordination.AntalUdlv,
                ordination.AntalForetagneUdlv
            );
        }

        public static List<DTOOrdination> MapListToDto(List<Ordination> ordinationListe)
        {
            List<DTOOrdination> dtoOrdinationer = new List<DTOOrdination>();

            foreach (Ordination ordination in ordinationListe)
            {
                dtoOrdinationer.Add(OrdinationMapper.MapToDto(ordination));
            }
            return dtoOrdinationer;
        }

        public static Ordination MapFromDto(DTOOrdination ordination)
        {
            return new Ordination
            (
                ordination.OrdinationId,
                ordination.ReceptId,
                ordination.Beskrivelse,
                ordination.Dosis,
                ordination.AntalUdlv,
                ordination.AntalForetagneUdlv
            );
        }


        public static List<Ordination> MapListFromDto(List<DTOOrdination> dtoOrdinationListe)
        {
            List<Ordination> ordinationer = new List<Ordination>();

            foreach (DTOOrdination dtoOrdination in dtoOrdinationListe)
            {
                ordinationer.Add(OrdinationMapper.MapFromDto(dtoOrdination));
            }
            return ordinationer;
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
