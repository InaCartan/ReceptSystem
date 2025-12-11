using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;
using DTO.Model;

namespace DataAccess.Mapper
{
    internal class LaegehusMapper
    {
        public static DTOLaegehus MapToDto(Laegehus laegehus)
        {
            DTOLaegehus dtoLaegehus = new DTOLaegehus();

            dtoLaegehus.Navn = laegehus.Navn;
            dtoLaegehus.YderNummer = laegehus.YderNummer;
            dtoLaegehus.Adresse = laegehus.Adresse;
            dtoLaegehus.Telefon = laegehus.Telefon;
            dtoLaegehus.Recepter = MapListToDto(laegehus.Recepter);

            return dtoLaegehus;
        }

        public static List<DTORecept> MapListToDto(List<Recept> recepterList)
        {
            List<DTORecept> dtoRecepter = new List<DTORecept>();
            foreach (Recept recept in recepterList)
            {
                dtoRecepter.Add(ReceptMapper.MapToDto(recept));
            }
            return dtoRecepter;
        }

        public static void Update(DTOLaegehus lagehusDto, Laegehus laegehus)
        {
            lagehusDto.Navn = laegehus.Navn;
            lagehusDto.YderNummer = laegehus.YderNummer;
            lagehusDto.Adresse = laegehus.Adresse;
            lagehusDto.Telefon = laegehus.Telefon;
            lagehusDto.Recepter = MapListToDto(laegehus.Recepter);
        }
    }
}
