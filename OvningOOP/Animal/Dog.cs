using System;

namespace OvningOOP
{
    public class Dog : Animal
    {
        public string Owner { get; set; }
        public bool IsTrained { get; set; }
      
        public Dog(string name, int age, double weight,bool istrained,string owner) : base(name, age, weight)
        {
            IsTrained = istrained;
            Owner = owner;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{ Name} says woff woff.");
        }

        public override string Stats()
        {

            if (IsTrained == true)
                return $"{Name} is trained. ";
           
            else
                return $"{Name} needs training";
        }
         
        //ny metod 
        public string Shelter()
        {
            if (String.IsNullOrEmpty(Owner))
                return "sheltered dog";
            else
                return $"lives in {Owner} house";
        }

    }


}
