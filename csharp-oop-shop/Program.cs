using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;

namespace csharp_oop_shop
    
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            

            string p1_name = "toothbrush";
            string p1_overview = "Used by dentists worldwide, Oral-B present the Pro 1 650 Turquoise Electric Toothbrush, arriving with a pro-expert toothpaste. Together, this duo aims to support optimal mouthcare for teeth and gums.";
            double p1_price=4.66;
            int p1_vat = 20;

            Product p1 = new Product(p1_name, p1_overview, p1_price, p1_vat);
            p1.TellMeAll();


            //BONUS
            //1)reate un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri
            //(ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
            int numeroPerFunzionePadLeft = 5;
            Console.WriteLine(numeroPerFunzionePadLeft.ToString("D8"));

            //Usando un array negozio, dichiarate un elenco di prodotti.
            //Stampate poi l’elenco dei prodotti .

            Product [] shop = new Product[4];
            shop[0] = p1;
            shop[1] = new Product(
                "meat tenderizer", 
                "Meat Tenderizer Hammer Two Sides ABS Plastic Blade with Silver Head Black Handle Beef Pork Chicken Beater Meat Hammer Mallet Tenderizer",
                12.45,
                22);

            shop[2] = new Product(
            "swiffer Duster",
            "Made with specially coated fibers that grab onto dust & do not let go",
            21.00,
            22);
            shop[3] = new Product(
          "fried chicken wings",
          "These fried chicken wings are marinated in buttermilk, then coated in seasoned flour and deep fried to golden brown perfection. Serve your fried wings with a side of ranch for an easy and satisfying appetizer or main course",
          9.99,
          10);

            foreach (Product p in shop) { p.TellMeAll(); }








        }
    }
}