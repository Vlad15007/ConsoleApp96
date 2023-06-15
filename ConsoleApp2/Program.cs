namespace ConsoleApp2
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Reproduction();
        }
    }



    interface ILife
    {
        void Eat();
        void Excretion();
        void Reproduction();
    }

    class Cito : ILife
    {
        public virtual void Eat()
        {
            
        }

        public virtual void Excretion()
        {
            
        }

        public virtual void Reproduction()
        {
            
        }
    }
    abstract class Pluricellular : Cito
    {
    }

    abstract class Mamalia : Pluricellular
    {
        public virtual void Mur()
        {

        }
    }
    class Cat : Mamalia
    {
        public override void Eat()
        {

        }

        public override void Excretion()
        {

        }

        public override void Reproduction()
        {

        }
    }
}