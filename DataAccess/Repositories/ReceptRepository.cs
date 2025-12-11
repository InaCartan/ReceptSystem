using DataAccess.Context;
using DataAccess.Mapper;
using DataAccess.Model;
using DTO.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    internal class ReceptRepository
    {
        public static DTORecept getRecept(int id)
        {
            using (Database db = new Database())
            {
                Recept rcpt = db.Recept.Where(r => r.ReceptId == id).First();
                if (rcpt == null)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return ReceptMapper.MapToDto(rcpt); 
            }
        }

        
        public static void AddRecept(DTORecept dtoRecept)
        {
            using (Database db = new Database())
            {
                Recept rcpt = ReceptMapper.MapFromDto(dtoRecept);
                db.Recept.Add(rcpt);
                db.SaveChanges();
            }
        }

        
    }
}
