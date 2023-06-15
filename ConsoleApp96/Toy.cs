using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp96
{
    abstract class Toy
    {
        public string Material { get; set; }
        public Size Size { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }

        public abstract void Play();
    }

    class SoftToy : Toy
    {
        public string Type { get; set; }
        public SoftToy()
        {
            Material = "Сентапон";
            Size = new Size(23, 20);
            Name = "Лисичка";
            Type = "Плюшева";
        }
        public void Jmakat()
        {

        }

        public override void Play()
        {
            Console.WriteLine("Жмяк мур");
        }
    }


    class SexToy : Toy
    {
        public SexToy()
        {
            Material = "Силікон";
            Size = new Size(23, 20);
            Name = "XXX";
        }

        public override void Play()
        {
            
        }
    }
}
