using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{

    //Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop.
    internal class Product
    {
        //Un prodotto è caratterizzato da:
        private Int64 code;
        private string name;
        private string overview;
        private double price;
        private int vat;

        //Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità”
        //per fare in modo che:

        public Product(string name_, string overview_, double price_, int vat_)
        {
            //alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
            string rowCode = "";
            for (int i = 0; i < 8; i++)
            {
                rowCode += (new Random().Next(0, 10)).ToString(); ;
            }

            this.code = Convert.ToInt64(rowCode);

            this.name = name_;
            this.overview = overview_;
            this.price = price_;
            this.vat = vat_;
        }

        //Il codice prodotto sia accessibile solo in lettura
        public Int64 getCode() => this.code; 
        //Gli altri attributi siano accessibili sia in lettura che in scrittura (public non mi piace)

        //name
        public string getName() => this.name; 
        public void setName(string name_) => this.name=name_; 

        //overview
        public string getOverview()=> this.overview; 
        public void setOverview(string overview_) => this.overview = overview_;
       
        //iva
        public int getVat() => this.vat; 
        public void setVat(int vat_) => this.vat = vat_; 

        //Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
        
        //BasePrice
        public double getBasePrice()=> this.price; 
        public void setBasePrice(double price_) => this.price = price_;

        //FinalPrice
       public double getVatPrice() => this.price + ((this.price/100) * this.vat); 
       // public double getVatPrice() { return (this.price * (1+(this.vat/100))); }

        //Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
        public string getExtendedName () => this.code +"-"+ (this.name).ToUpper();



        string DoubleToString(double doubleNumber)
        {
            return doubleNumber.ToString("F2");
        }


        public void TellMeAll()
        {
            Console.WriteLine($"codice: {getCode()}");
            Console.WriteLine($"nome: {getName()}");
            Console.WriteLine($"nome esteso : {getExtendedName()}");
            Console.WriteLine($"descrizione : {getOverview()}");
            Console.WriteLine($"prezzo di listino : {getBasePrice()}");
            Console.WriteLine($"iva : {getVat()}%");
            Console.WriteLine($"prezzo ivato : {DoubleToString(getVatPrice())}");
        }
    }

    
}
