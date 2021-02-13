using System;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("asdasd");
            myList.Add("asdasd");
            myList.Add("asdasd");

            Console.WriteLine(myList.Length);
            //foreach (var x in myList.Items)
            //{
            //    Console.WriteLine(x);
            //}
            Console.WriteLine(myList.Items[myList.Length-1]); // tanımlanan yeni listeler bu şekilde de çağırılabilir.
        }
    }
}
