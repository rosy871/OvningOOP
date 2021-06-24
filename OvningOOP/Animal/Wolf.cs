using System;

namespace OvningOOP
{
    public class Wolf : Animal
    {
        public bool WolfPack { get; set; }

        public Wolf(string name, int age, double weight, bool wolfpack) : base(name, age, weight)
        {
            WolfPack = wolfpack;
        }
        public override void DoSound()
        {
            Console.WriteLine($"{ Name} says roar roar");
        }

        public override string Stats()
        {
            if (WolfPack == true)
                return $"{base.Name} is part of wolfpack.";
            else
                return $"{base.Name} is lone wolf.";
        }
    }

    public class Wolfman : Wolf,IPerson
    {
        public Wolfman(string name, int age, double weight, bool wolfpack) : base(name, age, weight, wolfpack)
        {  }
       
        public string Talk()
        {
            return $"{Name} says : I am learning c#..ha ha";
        }

        
    }

}
