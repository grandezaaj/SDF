using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Animal
    {
        private string type;
        private double weight;
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public virtual void MakeNoise()
        {
            Console.WriteLine("Animal is making noise...");
        }

        public virtual void Move()
        {
            Console.WriteLine("Animal is moving..");
        }        
    }


    class Dog : Animal
    {
        private string breed;

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public void WagTail()
        {
            string dogBreed = breed == string.Empty ? "Dog" : breed;
            Console.WriteLine(string.Format("{0} is wagging its tail...", dogBreed));
        }

        public override void Move()
        {
            string dogBreed = breed == string.Empty ? "Dog" : breed;
            Console.WriteLine(string.Format("{0} is moving", dogBreed));
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog spot = new Dog();

            Console.ReadKey();
        }
    }
}
