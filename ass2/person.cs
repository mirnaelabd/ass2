using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2
{
    internal struct person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
        public person FindOldestPerson(person[] people)
        {
            person oldestPerson = people[0];

            for (int i = 1; i < people.Length; i++)
            {
                if (people[i].Age > oldestPerson.Age)
                {
                    oldestPerson = people[i];
                }
            }

            return oldestPerson;
        }


     }
}
