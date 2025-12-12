using DataAccess.Mapper;
using DataAccess.Model;
using DTO.Model;
using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class OrdinationRepository
    {
        public static void AddOrdination(DTOOrdination dtoOrdination)
        {
            using (Database db = new Database())
            {
                Ordination ordtn = OrdinationMapper.MapFromDto(dtoOrdination);
                db.Ordination.Add(ordtn);
                db.SaveChanges();
            }
        }
    }
}
