using System;

namespace ass2
{
 
    internal class Program
    {
  
        static void Main()
        {
            #region part 1 
            person[] people = new person[3];
            people[0] = new person { Name = "mm", Age = 30 };
            people[1] = new person { Name = "Bb", Age = 25 };
            people[2] = new person { Name = "cc", Age = 35 };
            /*            for (int i = 0; i < people.Length; i++)
                        {
                            Console.WriteLine($"Person {i + 1}: Name = {people[i].Name}, Age = {people[i].Age}");
                        }*/
            foreach (var person in people)
            {
                person.Display();
            }
            person oldestPerson = new person();
            oldestPerson.FindOldestPerson(people);
            Console.WriteLine($"\nThe oldest person is:");
            oldestPerson.Display();

            #endregion

            #region part2
            HiringDate hiringDate = new HiringDate(15, 7, 2023);

            try
            {
             
                Employee[] empArr = new Employee[3];

              
                empArr[0] = new Employee(1, "John ", SecurityLevel.DBA, 75000.50m, hiringDate, 'M');
                empArr[1] = new Employee(2, "Jane ", SecurityLevel.Guest, 45000.75m, hiringDate, 'F');
                empArr[2] = new Employee(3, "Sam ", SecurityLevel.Secretary, 60000.00m, hiringDate, 'M');

           
                foreach (var emp in empArr)
                {
                    Console.WriteLine(emp);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        #endregion

    }
    }

