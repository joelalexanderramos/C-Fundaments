using System;
using System.Collections;
using System.Collections.Generic;

namespace Enumerators
{
    public class AllDaysOfWeek : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            Console.WriteLine("Calling generic GetEnumerator");
            yield return "Monday";
            yield return "Tuesday";
            yield return "Wednesday";
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            float[,] valores = new float[3, 4];
            valores[0, 0] = 0;
            valores[0, 1] = 1;
            valores[0, 2] = 2;
            valores[0, 3] = 3;

            valores[1, 0] = 10;
            valores[1, 1] = 11;
            valores[1, 2] = 12;
            valores[1, 3] = 13;

            valores[2, 0] = 20;
            valores[2, 1] = 21;
            valores[2, 2] = 22;
            valores[2, 3] = 23;

            //foreach (var valor in valores)
            //{
            //    Console.WriteLine(valor);
            //}

            Console.WriteLine(valores.Length);
            Console.WriteLine(valores.Rank); //2 = 2D array, 1 = normal array

            // valores.GetLength(0) = first dimension, valores.GetLength(1) = second dimension
            for (int x = 0; x < valores.GetLength(0); x++)
            {
                for (int y = 0; y < valores.GetLength(1); y++)
                {
                    Console.Write(valores[x, y] + ", ");
                }
                Console.WriteLine();
            }



            //// enumerable covariance
            //string str = "Hello, World!";
            //object obj = str;

            //var strList = new List<string> { "Monday", "Tuesday" };
            ////List<object> objList = (List<object>)strList;
            //IEnumerable<object> objEnum = strList;

            //var strList = new string[] { "Monday", "Tuesday" };
            //object[] objList = strList;


            // writing your own enumerator
            //AllDaysOfWeek allDays = new AllDaysOfWeek();

            //foreach (var day in allDays)
            //{
            //    Console.WriteLine(day);
            //}

            //string[] daysOfWeek =
            //{
            //    "Monday","Tuesday","Wedneday","Thursday","Friday","Saturday","Sunday"

            //};

            ////DisplayItems(daysOfWeek);
            //DisplayItems2(daysOfWeek);

            //var days = new List<string>
            //{
            //    "Monday","Tuesday","Wedneday"
            //};



            //foreach (var day in days)
            //{
            //    // bad practice change collection while enumerating
            //    //days[1] = "2nd day";
            //    Console.WriteLine(day);
            //}
        }

        public static void DisplayItems<T>(IEnumerable<T> collection)
        {
            using (IEnumerator<T> enumerator = collection.GetEnumerator())
            {
                bool moreItems = enumerator.MoveNext();
                while (moreItems)
                {
                    T item = enumerator.Current;
                    Console.WriteLine(item);
                    moreItems = enumerator.MoveNext();
                }

            }
        }

        public static void DisplayItems2<T>(IEnumerable<T> collection)
        {
            using (IEnumerator<T> enumerator = collection.GetEnumerator())
            {
                foreach (T item in collection)
                {
                    Console.WriteLine(item);
                }

            }
        }

        //static void DisplayItems2(IEnumerable<string> days)
        //{
        //    foreach (var day in days)
        //    {
        //        Console.WriteLine(day);
        //    }
        //}
    }
}
