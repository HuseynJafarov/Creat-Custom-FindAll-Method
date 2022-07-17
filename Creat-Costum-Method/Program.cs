using Creat_Costum_Method.Models;
using System;
using System.Collections.Generic;

namespace Creat_Costum_Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            //MyList<int> nums = new MyList<int>();
            //nums.Add(1);
            //nums.Add(2);
            //nums.Add(3);
            //nums.Add(4);
            //nums.Add(5);
            //nums.Add(6);
            //nums.Add(7);
            //nums.Add(8);
            //nums.Add(9);
            //nums.Add(10);
            //nums.Add(11);


            //nums.Clear();

            //nums.Add(1);
            //nums.Add(2);

            //nums.GetAll();
            //var result = nums.Find(m => m == 3);

            //Console.WriteLine(result);

            //List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            //list.FindAll(2);


            //nums.AddRange(list);
            //nums.GetAll();


            MyList<string> names = new MyList<string>();
            names.Add("Huseyn");
            names.Add("Huseyn");
            names.Add("Huseyn");
            names.Add("Eli");
            names.Add("AZer");
            names.Add("Maqa");

            var result = names.FindAll(m => m ==m);
            Console.WriteLine(result);



            //var result = names.Find(m => m == "Huseyn");
            //Console.WriteLine(result);


            //MyList<Book> books = new MyList<Book>();
            //books.Add(new Book { Name = "Xosrov" });
            //books.Add(new Book { Name = "Shirin" });
            //books.Add(new Book { Name = "Leyli" });
            //books.Add(new Book { Name = "Ayka" });
            ////forech
        }
    }

    //public class Book
    //{
    //    public string Name { get; set; }
    //}




}    
