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
        // In Shaa Allah. Metoden tilføjer en allerede eksisterende Recept (recept oprettes i Recept Repository)
        public static void AddReceptToLaegehus(int receptcpr, int laegehusYdernr)
        {
            using (Database db = new Database())
            {
                Laegehus lgh = db.Laegehuse.Where(l => l.YderNummer == laegehusYdernr).Include(l => l.Recepter).FirstOrDefault();

                if (lgh != null)
                {
                    Recept rcpt = db.Recept.Where(r => r.CprNummer == receptcpr).FirstOrDefault();
                    lgh.Recepter.Add(rcpt);
                }
                db.SaveChanges();
            }
        }

        
    }


}
