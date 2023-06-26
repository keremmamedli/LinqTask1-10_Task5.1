using System;
using System.Linq;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Code_Academy_30tasks.linq_5._1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------------------Exercise 1-----------------------------------------------------------------
            //int[] Digits = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var EvenNums =
            //    from i in Digits
            //    where (i % 2) == 0
            //    select i;

            //foreach (int j in EvenNums)
            //{
            //    Console.Write(j + " ");
            //}

            //------------------------------------------------------Exercise 2-----------------------------------------------------------------
            //int[] Digits = {-4 ,4 ,23 ,42 , 42 ,-14 ,47381, 12, 23 ,1 ,3 ,5, 2 ,1 ,8, -325 };


            //var SelectedNums =
            //from i in Digits
            //where i > 0
            //where i < 12
            //select i;
            //foreach (var j in SelectedNums)
            //{
            //    Console.Write(j + " ");
            //}
            //------------------------------------------------------Exercise 3-----------------------------------------------------------------
            //int [] Numbers = new int [6] { 3, 9, 2, 8, 6, 5 };


            //var SelectedNums = from int Number in Numbers
            //           let SqrNo = Number * Number
            //           where SqrNo > 20
            //           select new { Number, SqrNo };

            //foreach (var j in SelectedNums)
            //{
            //    Console.WriteLine(j);
            //}
            //------------------------------------------------------Exercise 4-----------------------------------------------------------------
            //int[] Numbers = new int[] { 1,21,1,1,14,5,5,5,46,86,435,55,55,754,34};

            //var SelectedNum = from x in Numbers
            //        group x by x into y
            //        select y;
            //foreach (var j in SelectedNum)
            //{
            //    Console.WriteLine("Number " + j.Key + " appears " + j.Count() + " times"  + "\n");
            //}
            //------------------------------------------------------Exercise 5-----------------------------------------------------------------
            //string s = "Hello,World!";

            //var j = from x in s
            //    group x by x into y
            //    select y;
            //foreach (var i in j)
            //{
            //    Console.WriteLine("Number " + i.Key + " appears " + i.Count() + " times" + "\n");
            //}
            //------------------------------------------------------Exercise 6-----------------------------------------------------------------
            //string[] Week = new string[7] { "Sunday", "Monday", "Tuesday ", "Wednesday ", "Thursday", "Friday", "Saturday" };

            //var Days = from i in Week
            //           select i;

            //foreach (var day in Days)
            //{
            //    Console.WriteLine(day);
            //}
            //------------------------------------------------------Exercise 7-----------------------------------------------------------------
            //int[] Numbers = new int[] { 1,1,2,2,5,5,5,25,23,25,123,1,1 };

            //var SelectedNum = from x in Numbers
            //                  group x by x into y
            //                  select y;
            //foreach (var j in SelectedNum)
            //{
            //    Console.WriteLine(j.Key + " " + + j.Sum() + " " + j.Count() + "\n");
            //}
            //------------------------------------------------------Exercise 8----------------------------------------------------------------- 
            //string[] cities = { "London", "Baku", "Miami", "Dubai" };

            //string FirstLetter = "M";
            //string LastLetter = "i";

            //var SelectedCity = from i in cities
            //                   where i.StartsWith(FirstLetter) && i.EndsWith(LastLetter)
            //                   select i;
            //foreach (var city in SelectedCity)
            //{
            //    Console.WriteLine($"{city}`s First Letter is {FirstLetter} , Last Letter is {LastLetter}");
            //}
            //------------------------------------------------------Exercise 9----------------------------------------------------------------
            //int[] Digits = { 1, 241, 353, 133, 21, 24, 234, -1, 12, 22, 80 };

            //var GreaterThan80 = from i in Digits
            //                    where i > 80
            //                    select i;

            //foreach(var j in GreaterThan80)
            //{
            //    Console.WriteLine(j);
            //}
            //------------------------------------------------------Exercise 10----------------------------------------------------------------
            //Console.WriteLine("Enter number");
            //int n = int.Parse(Console.ReadLine());
            //int[] Digits = new int[n]; 

            //for(int i = 0; i < n; i++)
            //{
            //    Digits[i] = int.Parse(Console.ReadLine());
            //}
            //var GreaterThan59 = from i in Digits
            //                    where i > 59
            //                    select i;
            //Console.WriteLine("This Numbers greater than 59");
            //foreach(int j in GreaterThan59)
            //{ Console.WriteLine(j); }


        }
    }
}

