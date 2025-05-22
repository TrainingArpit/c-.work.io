using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ppp1
{
    internal class Program
    {
        public abstract class Superhero
        {
            public string Name { get; set; }
            public string Gt { get; set; }
            public decimal Weight { get; set; }

            public Superhero(string name, string gt, decimal weight)
            {
                Name = name;
                Gt = gt;
                Weight = weight;
            }
            public abstract void power();
        }
        public class SpidermanD : Superhero
        {
            public string Costume { get; set; }

            public SpidermanD(string name, string gt, decimal weight, string costume) : base(name, gt, weight)
            {
                Costume = costume;
            }
            public override void power() {
                if (Costume != null)
                {
                    Console.WriteLine($"Hey i am peter parker and i love {Gt}");
                }
                else
                {
                    Console.WriteLine($"Here comes your family neighbourhood Spiderman ,\n  but he looks fat \n he looks almost {Weight} KG ");
                }
            }
        }
        public class MilesMorales : SpidermanD
        {
            

            public MilesMorales(string name, string gt, decimal weight, string costume) : base(name, gt, weight, costume)
            {
                
            }
            public override void power()
            {
                int Ability = 2;
                switch (Ability)
                {
                    case 1:
                        Console.WriteLine("Invisibility");
                        break;
                    case 2:
                        Console.WriteLine("Electricute");
                       break;
                    default:
                        Console.WriteLine("Can't use my ability ");
                        break;
                }
            }
        }
        public class SuperStrength : Superhero
        {
            public bool Super;
          

            public SuperStrength(string name,string gt,decimal weight,bool super):base(name, gt, weight) 
            {
                Super = true;
               
            }
            public void specialMove ()
            {
                Console.WriteLine("Thunder clap");
            }

            public override void power() {
                if (Super == true)
                {
                    Console.WriteLine("Hulk Smash!!");
                }
                else
                {
                    Console.WriteLine("Why can't i transform");
                }            
            }
        }
            static void Main(string[] args)
            {

             SpidermanD peter = new SpidermanD("pp", "Mary Jane", 120,"OG COSTUME");
             peter.power();

             SuperStrength Hulk = new SuperStrength("Bruce Banner","Natasha Romenoff", 300,true);
             Hulk.power();
             Hulk.specialMove();

            MilesMorales BS = new MilesMorales("Miles Morales", "Gwen Stacy", 56, "Black");
            BS.power();

        }
        }
    }

