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
    public class ReceptRepository
    {
        public static DTORecept getRecept(int cpr)
        {
            using (Database db = new Database())
            {
                Recept rcpt = db.Recept.Where(r => r.CprNummer == cpr).FirstOrDefault();
                if (rcpt == null)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return ReceptMapper.MapToDto(rcpt); 
            }
        }


        public static List<DTORecept> GetAllRecept()
        {
            List<DTORecept> recepter = new List<DTORecept>();
            using (Database db = new Database())
            {
                foreach (Recept r in db.Recept)
                {
                    recepter.Add(ReceptMapper.MapToDto(r));
                }
            }
            return recepter;
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

        public static void AddOrdinationToRecept(int ordinationId, int receptId)
        {
            using (Database db = new Database()){
                Recept rcpt = db.Recept.Where(r => r.ReceptId == receptId).Include(r => r.Ordinationer).FirstOrDefault();
                if (rcpt != null)
                {
                    Ordination ordtn = db.Ordination.Where(o => o.OrdinationId == ordinationId).FirstOrDefault();
                    rcpt.Ordinationer.Add(ordtn);
                }
                db.SaveChanges();
            }
        }

        
    }
}
