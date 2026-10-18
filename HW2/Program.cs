using System;
using System.Collections.Generic;

namespace HW2
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Tên: {Name} | Tuổi: {Age}");
        }
    }

    class Program
    {
        static void BubbleSort(List<Person> list)
        {
            int n = list.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (list[j].Age > list[j + 1].Age)
                    {
                        Person temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Person> people = new List<Person>();

            Console.Write("Nhập số lượng người: ");
            if (int.TryParse(Console.ReadLine(), out int count))
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"\n--- Nhập thông tin người thứ {i + 1} ---");
                    Console.Write("Nhập tên: ");
                    string name = Console.ReadLine();

                    Console.Write("Nhập tuổi: ");
                    int age = int.Parse(Console.ReadLine());

                    people.Add(new Person(name, age));
                }

                Console.WriteLine("\n====================================");
                Console.WriteLine("Danh sách ban đầu:");
                foreach (var p in people)
                {
                    p.Display();
                }

                BubbleSort(people);

                Console.WriteLine("\nDanh sách sau khi sắp xếp theo tuổi (Bubble Sort):");
                foreach (var p in people)
                {
                    p.Display();
                }
            }
            Console.ReadKey();
        }
    }
}