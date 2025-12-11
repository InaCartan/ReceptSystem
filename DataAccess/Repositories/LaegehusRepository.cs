using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;
using DataAccess.Mapper;
using DataAccess.Context;
using DTO.Model;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class LaegehusRepository
    {
        public static DTOLaegehus GetLaegehus(int id)
        {
            using (Database db = new Database())
            {
                Laegehus lgh = db.Laegehuse.Where(l => l.LaegehusId == id).First(); // In Shaa Allah, return first elemement of sequence
                
                if (lgh == null)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return LaegehusMapper.MapToDto(lgh);
            }
        }

        // Tilføj en allerede eksisterende Recept (recept oprettes i Recept Repository)
        public static void AddReceptToLaegehus(int receptId, int laegehusId)
        {
            using (Database db = new Database())
            {
                Laegehus lgh = db.Laegehuse.Where(l => l.LaegehusId == laegehusId).Include(l => l.Recepter).FirstOrDefault();

                if (lgh != null)
                {
                    Recept rcpt = db.Recept.Where(r => r.ReceptId == receptId).FirstOrDefault();
                    lgh.Recepter.Add(rcpt);
                }
                db.SaveChanges();
            }
        }

        
    }


}
