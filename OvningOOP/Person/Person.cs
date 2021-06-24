using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningOOP
{
    public class Person
    {
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                if (age <= 0)
                {
                    throw new ArgumentException("Age should be greater that 0");
                }
            }
        }
        private string fname;

        public string Fname
        {
            get { return fname; }
            set
            {
                fname = value;
                if (fname.Length < 3 || fname.Length > 10)
                {
                    throw new ArgumentException("Length of First name should not be smaller than 2 and greater than 10 ");
                }
            }
        }
        private string lname;

        public string Lname
        {
            get { return lname; }
            set
            {
                lname = value;
                if (lname.Length < 4 || lname.Length > 15)
                {
                    throw new ArgumentException("Lenght of Last name should not be smaller than 3 and greater than 15");
                }
            }
        }
        private double height;

        public double Height
        {
            get { return height; }
            set
            {
                height = value;
                if (height <= 0)
                {
                    throw new ArgumentException("Height should be greater that 0");
                }
            }
        }
        private double weight;

        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                if (weight <= 0)
                {
                    throw new ArgumentException("Weight should be greater that 0");
                }
            }
        }

        public Person(int age, string fname, string lname, double height, double weight)
        {
            Age = age;
            Fname = fname;
            Lname = lname;
            Height = height;
            Weight = weight;
        }

        public Person()
        {
            Console.WriteLine("default construtor");

        }

        public override string ToString()
        {
            return $"{Fname} {Lname} is {Age} old and is {Height}cm tall and weights {Weight}kg";
        }
    }
}
