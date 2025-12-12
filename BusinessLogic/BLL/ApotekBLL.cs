using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;
using DTO.Model;

namespace BusinessLogic.BLL
{
    public class ApotekBLL
    {
        public static DTORecept getRecept(int cprNr)
        {
            return ReceptRepository.getRecept(cprNr);
        }

        // TODO: Foretage udlevering
    }
}
