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
                Console.WriteLine("Database is running");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while running app: " + ex.Message);
                Console.WriteLine(ex);
            }
        }
    }
}