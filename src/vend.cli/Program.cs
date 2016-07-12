using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vend.cli
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var choiceText = "\nPlease choose a coin\n\n1. 10p\n2. 20p\n3. 50p\n";
            System.Console.WriteLine("Insert coins...\n");
            System.Console.WriteLine(choiceText);
            
            Console.ReadLine();
        }
    }
    
    public enum Size
    {
        Small = 0,
        Medium,
        Large
    }
    
    public enum Weight
    {
       Small = 0, 
       Medium,
       Large
    }

    public interface IPrinter
    {
       string Print(Coin coin);
    }
    
    public class TextPrinter : IPrinter
    {
        public string Print(Coin coin)
        {
            return coin.Value().ToString() + " Pence";
        }
    }

    public class VendingMachine
    {
        private IPrinter _printer;
        private List<Coin> _coins = new List<Coin>();

        public VendingMachine(IPrinter printer)
        {
            _printer = printer;
        }

        public void Accept(Coin coin)
        {
            _coins.Add(coin);
        }

        public string Display()
        {
            return _printer.Print(_coins.First());
        }
    }
    
    public class Coin
    {
        public Coin(Size size, Weight weight)
        {
            Size = size;
            Weight = weight;
        }
        
        private Size Size {get; set; }
        private Weight Weight {get; set; }
        
        public decimal Value() 
        {
            if(Size == Size.Small && Weight == Weight.Small)
                return 0.10m;
            
            if(Size == Size.Medium && Weight == Weight.Medium )
                return 0.20m;
                
            return 0.50m; 
        }

    }
}
