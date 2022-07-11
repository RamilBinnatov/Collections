using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> nums = new List<int>();
            //nums.Add(5);
            //nums.Add(55);
            //nums.Add(53);
            //nums.Add(9);

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < nums.Count; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            //if (nums.Count == 4)
            //{
            //    Console.WriteLine("list count is {0}",nums.Count);
            //}

            //Person person1 = new Person();
            //person1.Name = "sadas";

            //people.Add(person1);

            //List<Person> people = new List<Person>();

            //Person person1 = new Person();
            //person1.Name = "sadiq";
            //person1.Id = 5;
            //person1.MailAdress = "sadiq@gmail.com";


            //Person person2 = new Person
            //{
            //    Id = 6,
            //    Name = "Ramil",
            //    MailAdress = "ramil@gmail.com"

            //};
            //people.Add(person2);
            //people.Add(person1);



            //people.Add(new Person { Id = 1, Name = "Ramil", MailAdress = "ramin@gmail.com" });
            //people.Add(new Person { Id = 2, Name = "Emil", MailAdress = "emil@gmail.com" });
            //people.Add(new Person { Id = 3, Name = "Orxan", MailAdress = "orxan@gmail.com" });
            //people.Add(new Person { Id = 4, Name = "Cavid", MailAdress = "cavid@gmail.com" });

            ////GetStudent(people);

            //var result = GetPersonByName(people, "Ramil");

            //Console.WriteLine(result.Name + "-" + result.Id + "-" + result.MailAdress);







            Hashtable datas = new Hashtable();

            datas.Add(1, "Togrul");
            datas.Add(2, "Fidan");
            foreach (DictionaryEntry item in datas)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }























        } 
        public static Person GetPersonByName(List<Person> people, string name)
        {
            var person = people.Find(m => m.Name == name);

            return person;
        }

        public static void GetStudent(List<Person> students)
        {
            foreach (var stu in students)
            {
                Console.WriteLine("Students : Id - {0}, Name - {1}, Mail - {2} ", stu.Id, stu.Name, stu.MailAdress);
            }
        }

    }
    class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string MailAdress { get; set; }
    }
}
