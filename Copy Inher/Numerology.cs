using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Inher
{
    class Numerology : Magic

    {
        //straight up field. I really don't need a property. Just using globally so random behaves well.
        //private Random random = new Random();

        //properties
        //protected List<string> Phrases { get; set; } = new List<string>(5);

        public override string Name { get; set; } = "Numerology";


        public override void Work()
        {
            base.Work();
            //now let's call a method that will get a result for the crystal ball
            //this.Result = GetPhrase();

        }

        public void MatchPhrases()
        {
            Console.WriteLine("Please enter your favorite number, 1-5.");
            int userNum = int.Parse(Console.ReadLine());
            string numfortune = "";

            switch (userNum)
            {
                case 1:
                    numfortune = "1 is a doer, a powerful force that produces results and does not allow anything or anyone to limit its potential.";
                    break;
                case 2:
                    numfortune = "2 You will recognize a symbolic representation of the ultimate survivor and an extremely resilient force";
                    break;
                case 3:
                    numfortune = "3 Is like a gifted teenager who is still under the protection of its parents: a bit spoiled, certainly scattered and perpetually in need of guidance. ";
                    break;
                case 4:
                    numfortune = " 4 You will see that the hard angles are a proper symbolic representation of this rather straight-edged workaholic, who is neither creative nor artistic, but is good at working with his hands";
                    break;
                case 5:
                    numfortune = " 5 Generally does not find a suitable career until she has tried a number of different jobs, many of them lasting barely long enough to warrant a full paycheck, especially if there is any kind of routine involved boredom sets in almost immediately.";
                    break;
                default:
                    numfortune = "Make sure you choose numbers 1-5";
                    break;

            }
            Console.WriteLine(numfortune);
            
        }

        //let's create an overloaded method now
        //protected void CreatePhrases(string phrase)
        //{
        //    Phrases.Add(phrase);
        //}

        //private string GetPhrase()
        //{
        //    //local variable
        //    int randomNumber = random.Next(Phrases.Count);
        //    return Phrases.ElementAt(randomNumber);

        //constructor
        //let's override some of the properties of what we inherited from magic and service here.
        public Numerology()
        {
            this.Price = 15.00M;
            this.PercentEffective =70;
            this.BlackMagic = true;
            this.Expertise = "beginner";
            //I want to call my initializer for phrases.
            // CreatePhrases();
        }
    }
}



