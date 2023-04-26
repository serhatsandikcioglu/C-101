using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class BookActions
    {
        List<Person> persons = new List<Person>();
        public BookActions()
        {
            persons.Add(new Person("Username1", "Surname1", "111111111"));
            persons.Add(new Person("Username2", "Surname2", "222222222"));
            persons.Add(new Person("Username3", "Surname3", "333333333"));
            persons.Add(new Person("Username4", "Surname4", "444444444"));
            persons.Add(new Person("Username5", "Surname5", "555555555"));
        }
        public void AddPhoneNumber()
        {
            Console.Write("Please Enter Name: ");
            var name = Console.ReadLine();
            Console.Write("Please Enter Surname: ");
            var surname = Console.ReadLine();
            Console.Write("Plase Enter Number: ");
            var number = Console.ReadLine();
            Person newperson = new Person(name,surname,number);
            persons.Add(newperson);
            Console.WriteLine("The person has been added to the guide");
        }
        public void DeletePhoneNumber()
        {
            Console.WriteLine("Searching For Name Or Surname: ");
            string nameOrSurname = Console.ReadLine().ToLower();
            var counter = 0;
            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i].name.ToLower().Equals(nameOrSurname) || persons[i].surName.ToLower().Equals(nameOrSurname))
                {
                    counter++;
                    Console.WriteLine(persons[i].name + " The named person is about to be deleted from the directory, do you approve?(y/n)");
                    var input = Console.ReadLine();
                    if (input == "y")
                    {
                        persons.Remove(persons[i]);
                        Console.WriteLine("The person has been deleted");
                    }
                    else if (input == "n")
                    {
                        continue;
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("The data suitable for the criteria you are looking for could not be found in the contacts. Please make a choice.\n" +
                    "* To terminate the deletion : (1)\n* To try again: (2)");
                var input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    
                }
                else if (input == 2)
                {
                    DeletePhoneNumber();
                }
            }
        }
        public void UpdatePhoneNumber()
        {
            Console.WriteLine("Please enter the name or surname of the person whose number you want to update: ");
            var nameOrSurname = Console.ReadLine();
            var counter = 0;
            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i].name.ToLower().Equals(nameOrSurname) || persons[i].surName.ToLower().Equals(nameOrSurname))
                {
                    counter++;
                    Console.WriteLine(persons[i].name + " The named person is about to be updated from the directory, do you approve?(y/n)");
                    var input = Console.ReadLine();
                    if (input == "y")
                    {
                        Console.WriteLine("Yeni numarayı giriniz: ");
                        var newNumber = Console.ReadLine();
                        persons[i].number = newNumber;
                        Console.WriteLine("The person has been updated");
                    }
                    else if (input == "n")
                    {
                        continue;
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("The data suitable for the criteria you are looking for could not be found in the contacts. Please make a choice.\n" +
                    "* To terminate the updating : (1)\n* To try again: (2)");
                var input = int.Parse(Console.ReadLine());
                if (input == 1)
                {

                }
                else if (input == 2)
                {
                    UpdatePhoneNumber();
                }
            }
        }
        public void GetAllList()
        {
            Console.WriteLine("To list numbers A-Z (1), to list numbers Z-A (2)");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
               var newlist = persons.OrderBy(v => v.name);
                foreach (var item in newlist)
                {
                    Console.WriteLine("*******************");
                    Console.WriteLine("Name: " + item.name);
                    Console.WriteLine("Surname: " + item.surName);
                    Console.WriteLine("Number: " + item.number);
                }
            }
            else if (input == 2)
            {
                var newlist = persons.OrderBy(v => v.name).Reverse();
                foreach (var item in newlist)
                {
                    Console.WriteLine("*******************");
                    Console.WriteLine("Name: " + item.name);
                    Console.WriteLine("Surname: " + item.surName);
                    Console.WriteLine("Number: " + item.number);
                }
            }
            else
            {
                Console.WriteLine("Number Must Be 1 or 2");
            }
      
        }
        public void SearchNumber()
        {
            Console.WriteLine("Searching For Name or Surname: (1)\n Searching For Number: (2)");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("Enter name or surname");
                var nameOrSurname = Console.ReadLine();
                for (int i = 0; i < persons.Count; i++)
                {
                    if (persons[i].name.ToLower().Equals(nameOrSurname) || persons[i].surName.ToLower().Equals(nameOrSurname))
                    {
                        Console.WriteLine("Name: " + persons[i].name + "\n Surname: " + persons[i].surName + "\n Number: " + persons[i].number);
                    }
                }
            }
            else if (input == 2)
            {
                Console.WriteLine("Enter number");
                var number = Console.ReadLine();
                for (int i = 0; i < persons.Count; i++)
                {
                    if (persons[i].number.Equals(number))
                    {
                        Console.WriteLine("Name: " + persons[i].name + "\n Surname: " + persons[i].surName + "\n Number: " + persons[i].number);
                    }
                }
            }
            Console.WriteLine("Searching is done");
        }
    }
}
