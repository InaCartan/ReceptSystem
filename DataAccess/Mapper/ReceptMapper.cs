using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;
using DTO.Model;

namespace DataAccess.Mapper
{
    internal class ReceptMapper
    {
        public static DTORecept MapToDto(Recept recept)
        {
            DTORecept dtoRecept = new DTORecept();

            dtoRecept.ReceptId = recept.ReceptId;
            dtoRecept.CprNummer = recept.CprNummer;
            dtoRecept.YderNummer = recept.YderNummer;
            dtoRecept.Ordinationer = MapListToDto(recept.Ordinationer);
            return dtoRecept;
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

        public static void Update(DTORecept receptDto, Recept recept)
        {
            receptDto.CprNummer = recept.CprNummer;
            receptDto.YderNummer = recept.YderNummer;
            receptDto.Ordinationer = MapListToDto(recept.Ordinationer);
        }
    }
}
