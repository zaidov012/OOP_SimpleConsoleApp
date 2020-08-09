using System;
using System.Collections.Generic;

namespace OOP_SmallApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Promoter> promotersList = new List<Promoter>()
            {
                new XSClubPromoter("Asif", "Zaidov", "+994772717721"), 
                new XSClubPromoter("Jack", "Daniels", "+994552558555"), 
                new OmniaClubPromoter("Sophie", "July", "+994772111112")
            };
            
            List<Writer> writersList = new List<Writer>()
            {
                new BookWriter("Ray", "Bradburry"),
                new BookWriter("Robert", "Kiyosaki"),
                new BlogWriter("Brian", "Clark")
            };

            List<IBodyBuilder> bodyBuildersList = new List<IBodyBuilder>()
            {
                new XSClubPromoter("Bruce", "Lee", "+5512345678"),
                new XSClubPromoter("Conor", "McGregor", "+7945214568")
            };

            List<IVlogger> vloggersList = new List<IVlogger>()
            {
                new BookWriter("Lev", "Tolstoy"),
                new BlogWriter("Andrew", "Sulliwan")
            };

            foreach(var item in promotersList)
            {
                item.Promote();
                Console.WriteLine("--------------------------------------------");
            }

            foreach(var item in writersList)
            {
                item.Write();
                Console.WriteLine("--------------------------------------------");
            }

            foreach(var item in bodyBuildersList)
            {
                item.Workout();
                Console.WriteLine("--------------------------------------------");
            }

            foreach(var item in vloggersList)
            {
                item.Vlog();
                Console.WriteLine("--------------------------------------------");
            }
        }
    }
}
