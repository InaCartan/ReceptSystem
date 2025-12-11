using System;
using System.Linq;
using DataAccess.Context;
using DataAccess.Model;


namespace DataAccess.HuskAtSLette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using var db = new Database();

                Console.WriteLine("Apoteker:");
                foreach (var a in db.Apoteker.ToList())
                {
                    Console.WriteLine($"[{a.ApotekId}] {a.Navn} - {a.Telefon} - {a.Adresse}");
                }

                Console.WriteLine();
                Console.WriteLine("Lægehuse:");
                foreach (var l in db.Laegehuse.ToList())
                {
                    Console.WriteLine($"[{l.LaegehusId}] {l.Navn} - Yder: {l.YderNummer} - {l.Telefon} - {l.Adresse}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while running app: " + ex.Message);
                Console.WriteLine(ex);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}