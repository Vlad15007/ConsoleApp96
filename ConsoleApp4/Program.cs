namespace ConsoleApp4
{

    interface IMove
    {
        void Move();
        string Speed { get; }
        IMove Next { get; }
    }
    interface IFly
    {
        void Move();
        string Speed { get; }
        IMove Next { get; }
    }

    class MoveBy4 : IMove
    {
        public MoveBy4()
        {
            Speed = "голосно та повільно";
        }
        public string Speed { get; set; }

        public IMove Next
        {
            get
            {
                return new MoveBy2();
            }
        }

        public void Move()
        {
            Console.WriteLine("шляп шмяк бум шмак");
        }
    }
    class MoveBy2 : IMove
    {
        public MoveBy2()
        {
            Speed = "Тихо і швидко";
        }
        public string Speed { get; set; }
        public IMove Next
        {
            get
            {
                return new MoveBy3();
            }
        }
        public void Move()
        {
            Console.WriteLine("вших вших");
        }
    }
    class MoveBy3 : IMove
    {
        public MoveBy3()
        {
            Speed = "Тихо і повільно";
        }
        public string Speed { get; set; }
        public IMove Next
        {
            get
            {
                return null;
            }
        }
        public void Move()
        {
            Console.WriteLine("вших вших цок");
        }
    }



    class Human
    {
        IMove move;
        public string Name { get; set; }

        public Human(string name)
        {
            Name = name;
            move = new MoveBy4();
        }

        public void Move()
        {
            move.Move();
        }

        public void Grow()
        {
            var newMove = move.Next;
            if(newMove != null)
            {
                move = newMove;
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Human vlad = new Human("Влад");
            //vlad.Move();

            //Console.WriteLine("Через 11 місяців");
            //vlad.Grow();    
            //vlad.Move();

            //Console.WriteLine("Через 840 місяців");
            //vlad.Grow();
            //vlad.Move();




            IMove egl = new Bird();
            egl.Move();
        }
    }
















    class Bird : IMove, IFly
    {
        public string Speed { get; set; }

        public IMove Next { get; set; }

        void IMove.Move()
        {
            Console.WriteLine("ших ших");
        }
        void IFly.Move()
        {
            Console.WriteLine("вшиииииииииииииииииииииииииииииииииииих фуууух");
        }
    }






}