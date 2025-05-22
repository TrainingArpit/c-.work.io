using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace1
{
    
        interface Flyable
        {
            void fly();
        }
        interface SwimAble
        {
            void Swim();
        }
        interface WalkAble
        {
            void Walk();
        }
        interface Voice
        {
        void Sound();
        }
        interface Working
        {
        void Work();
        }
        interface Animal
        {
        void eat();
        }
       
    class Human : Voice ,WalkAble ,Working
    {
        public void Sound()
        {
            Console.WriteLine("Hey I am a Human");
        }
        public void Walk()
        {
            Console.WriteLine("Walking tak! tak! tak!");
        }
        public void Work()
        {
            bool coffee = true;
            if(coffee != true)
            {
                Console.WriteLine("Let's Code now");
            }
            else
            {
                Console.WriteLine("Ahh! Let's Drink Some Coffee ,I am tired ");
            }
        }
    }
    class Duck : Animal,Flyable ,SwimAble ,Voice 
    {
        public void eat()
        {
            Console.WriteLine("Duck is Eating Small Fishes");
        }
        public void fly()
        {
            Console.WriteLine("Oops!! That duck flew away");
        }
        public void Swim()
        {
            Console.WriteLine("Look its Swimming");
        }
        public void Sound()
        {
            Console.WriteLine("Quack!! Quack!!");
        }

    }
    class Hawk : Animal, Flyable, Voice
    {
        public void eat()
        {
            int hunger = 70;
            if(hunger >= 100)
            {
                Console.WriteLine("Eating a healthy Rabit ");
            }
            else if(hunger ==50)
            {
                Console.WriteLine("eating a small fish");
            }
            else
            {
                Console.WriteLine("Fly away!! not Hungry");
            }
        }
        public void fly()
        {
            int preyfound = 0;
            if (preyfound != 1)
            {
                Console.WriteLine("Flying high to find a prey");
            }
            else
            {
                Console.WriteLine("Flying to get the prey");
            }
        }
        public void Sound()
        {
            Console.WriteLine("Evil krrryeeeaaaaaaaaaaa");
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            Hawk hawk = new Hawk();
            Human human = new Human();
            Duck duck = new Duck();

            Console.WriteLine("== HUMAN ==\n");
            human.Walk();

            Console.WriteLine("== HAWK ==\n");
            hawk.fly();

            Console.WriteLine("== DUCK ==\n");
            duck.Swim();
            duck.eat();

            //Polymorphism Example
            Console.WriteLine("== Polymorphism ==");
            Animal animal = duck;
            animal.eat();
        }
    }
}
