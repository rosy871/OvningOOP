using System;

namespace OvningOOP
{
    public class Bird : Animal
    {
       

        public double WingSpan { get; set; }
       

        public Bird(string name, int age, double weight, double wingspan) : base(name, age, weight) 
        {
            WingSpan = wingspan;
        }
       
        public override void DoSound()
        {
            Console.WriteLine($"{ Name} says coo coo.");
        }

        public override string Stats()
        {
            return $"{Name}'s wingspan : {WingSpan} cm";
        }
    }

    public class Pelican : Bird
    {
        private double throatPouchLength;

        public double ThroatPouchLength
        {
            get { return throatPouchLength; }
            set { throatPouchLength = value; }
        }

        public Pelican(string name, int age, double weight, double wingspan, double thpclen):base(name, age, weight, wingspan)
        {
            ThroatPouchLength = thpclen;
        }
       
    } 
        

        
    public class Flamingo : Bird
    {
        public double OneLegStandingTime { get; set; }

        public Flamingo(string name, int age, double wingspan, double weight, double standingtime):base(name, age, weight, wingspan)
        {
            OneLegStandingTime = standingtime;
        }
       
    } 
       

        
    public class Swan : Bird
    {
        public string Color { get; set; }

        public Swan(string name, int age,  double weight, double wingspan, string color):base(name, age, weight, wingspan)
        {
            Color = color;
        }
       
    }
      

        
}
