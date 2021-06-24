using System;

namespace OvningOOP
{
    public class Horse : Animal
    {
        public double Speed { get;  set; }

        public Horse(string name, int age, double weight,double speed) : base(name, age, weight)
        {
            Speed = speed;
        }
        public override void DoSound()
        {
            Console.WriteLine($"{ base.Name} says neigh neigh. ");
        }

        public override string Stats()
        {
            return $"{base.Name}'s speed: {Speed}";
        }
    }


}
