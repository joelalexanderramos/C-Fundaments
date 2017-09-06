using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {

        }



        static void Main(string[] args)
        {
            var presidents = new LinkedList<string>();
            presidents.AddLast("JFK");
            presidents.AddLast("Nixon");
            presidents.AddLast("Carter");

            var nixon = presidents.Find("Nixon");
            presidents.AddAfter(nixon, "Obama");

            foreach (var item in presidents)
            {
                Console.WriteLine("\nItem is " + item);
            }


            //ObservableCollection<string> presidents = new ObservableCollection<string>
            //{
            //    "Bush",
            //    "Obama",
            //    "Trump"
            //};

            //presidents.CollectionChanged += OnCollectionChanged;

            //var presidents = new List<string>
            //{
            //    "Obama",
            //    "Bush"
            //};

            //Console.WriteLine(presidents.Count);
            //Console.WriteLine(presidents.Capacity);

            //presidents.Add("Trump");
            //Console.WriteLine(presidents.Capacity);

            //presidents.Add("Leonel");
            //Console.WriteLine(presidents.Capacity);

            //presidents.Add("Danilo");
            //Console.WriteLine(presidents.Capacity);



            //foreach (var item in presidents)
            //{
            //    Console.WriteLine(item);
            //}

            //string monday = "Monday";

            //string[] daysOfWeek =
            //{
            //    "Monday",
            //    "Tuesday",
            //    "Wednesday",
            //    "Thursday",
            //    "Friday",
            //    "Saturday",
            //    "Sunday"
            //};

            //ICollection<string> collection = (ICollection<string>)daysOfWeek;

            //if (!collection.IsReadOnly)
            //    collection.Add("SlaveDay");
            //else
            //    Console.WriteLine("Collection is ReadOnly");

            //foreach (var item in collection)
            //{
            //    Console.WriteLine(item);
            //}


            // Array.Sort(daysOfWeek);



            //     foreach (var item in daysOfWeek)
            //     {
            //         Console.WriteLine(item);
            //     }

            // // array declarations #1
            // int[] numbers = { 1, 2, 3 };

            // foreach (var item in numbers)
            // {
            //     Console.WriteLine(item);
            // }

            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     Console.WriteLine(numbers[i]);
            // }

            // // array declarations #2
            // // int[] numbers1 = new int[] { 1, 2, 3 };

            // // array declarations #3
            // // var numbers2 = new int[] { 1,2,3};

            // int[] numbers33 = { 1, 2, 3, 4 };
            // int[] copyn33 = new int[6];
            // numbers33.CopyTo(copyn33, 2);


            // foreach (var item in copyn33)
            // {
            //     Console.WriteLine(item);
            // }


            // string[] daysOfWeek2 =
            //{
            //     "Monday",
            //     "Tuesday",
            //     "Wednesday",
            //     "Thursday",
            //     "Friday",
            //     "Saturday",
            //     "Sunday"
            // };

            // var comparer = new StringLenghtComparer();
            // Array.Sort(daysOfWeek2, comparer);

            // foreach (var item in daysOfWeek2)
            // {
            //     Console.WriteLine(item);
            // }
        }

        
    }

    class StringLenghtComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.Length.CompareTo(y.Length);
        }
    }
}
