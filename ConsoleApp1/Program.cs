using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product comp = new Computer();
        }
    }

    interface IProduct
    {
        string Name { get; }
        string Date { get; }
        double Price { get; }
    }

    class Test : IProduct
    {

    }

    abstract class Product
    {
        protected string Test { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime Created { get; set; }

        public abstract void Buy();
    }

    class Computer : Product 
    {

        public override void Buy()
        {
            Console.WriteLine("Перевіряють на наявність на складі");
            Console.WriteLine("Перевіряють на працездатність");
            Console.WriteLine("Питають комплектацію");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Test = "123";
        }
    }

    abstract class ProductWithDate : Product
    {
        public DateTime Expired { get; set; }

        public abstract void ExpiredDate();

        public override void Buy()
        {
            
        }
    }

    class Kovbasa : ProductWithDate
    {
        public override void ExpiredDate()
        {
            Console.WriteLine("Prise - 50%");
        }
    }

    class Sur : ProductWithDate
    {
        public override void ExpiredDate()
        {
            
        }
    }
}