using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;
using DTO.Model;

namespace BusinessLogic.BLL
{
    public class LaegehusBLL
    {

        public static DTORecept getRecept(int cprNr)
        {
            return ReceptRepository.getRecept(cprNr);
        }


        public static void AddOrdinationToRecept(DTOOrdination ordination)
        {
            OrdinationRepository.AddOrdination(ordination);
            ReceptRepository.AddOrdinationToRecept(ordination.OrdinationId, ordination.ReceptId);

        }

        public static void AddReceptToLaegehus(DTORecept recept)
        {
            ReceptRepository.AddRecept(recept);
            LaegehusRepository.AddReceptToLaegehus(recept.CprNummer, recept.YderNummer);
        }

    }
}
