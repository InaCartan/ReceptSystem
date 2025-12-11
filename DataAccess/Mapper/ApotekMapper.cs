using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Model;
using DataAccess.Model;

namespace DataAccess.Mapper
{
    internal class ApotekMapper
    {
        public static DTOApotek MapToDto(Apotek apotek)
        {
            return new DTOApotek
            (
                apotek.ApotekId,
                apotek.Navn,
                apotek.Telefon,
                apotek.Adresse
            );
        }


        public static Apotek MapFromDto(DTOApotek apotek)
        {
            return new Apotek
            (
                apotek.ApotekId,
                 apotek.Navn,
                 apotek.Telefon,
                 apotek.Adresse
            );
        }

        public static void Update(DTOApotek apotekDto, Apotek apotek)
        {
            apotekDto.Navn = apotek.Navn;
            apotekDto.Telefon = apotek.Telefon;
            apotekDto.Adresse = apotek.Adresse;
        }

        
    }
}
