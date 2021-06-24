using System;

namespace OvningOOP
{
    public class Hedgehog : Animal
    {
       public int SpikesNum { get; set; }
        

        public Hedgehog(string name, int age, double weight, int spikesnum) : base(name, age, weight)
        {
            SpikesNum = spikesnum;
        }
        public override void DoSound()
        {
            Console.WriteLine($"{base.Name} says sqeak hiss.");
        }

        public override string Stats()
        {
            return $"{base.Name} with {SpikesNum} spikes. ";
        }
    }


}
