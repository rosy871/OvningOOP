using System;

namespace OvningOOP
{
    public class Worm : Animal
    {
       

        public bool IsPoisnous { get; set; }
     
        public Worm(string name, int age, double weight, bool poisonous) : base(name, age, weight)
        {
            IsPoisnous = poisonous;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{base.Name} is silent\n");
        }

        public override string Stats()
        {
            if (IsPoisnous == true)
                return $"{base.Name} is poisonous";
            else
                return $"{base.Name} is not poisonous";
        }
    }


}
