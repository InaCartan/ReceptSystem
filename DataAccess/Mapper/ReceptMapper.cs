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
           
            return new DTORecept(
                OrdinationMapper.MapListToDto(recept.Ordinationer), 
                recept.ReceptId, 
                recept.YderNummer, 
                recept.CprNummer
            ); 
        }


        public static Recept MapFromDto(DTORecept recept)
        {

            return new Recept(
                OrdinationMapper.MapListFromDto(recept.Ordinationer), 
                recept.ReceptId, 
                recept.YderNummer, 
                recept.CprNummer
                );
        }

        
        public static void Update(DTORecept receptDto, Recept recept)
        {
            receptDto.CprNummer = recept.CprNummer;
            receptDto.YderNummer = recept.YderNummer;
            receptDto.Ordinationer = OrdinationMapper.MapListToDto(recept.Ordinationer);
        }
    }
}
