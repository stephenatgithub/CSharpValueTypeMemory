using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpValueTypeMemory
{
    internal class TestClass
    {
        // value type is created in heap memory with its parent class
        //private int testNumber = 69;


        // value type is created in stack memory when it is argument of a method
        //public void SomeMethod(int methodNumber)
        //{
        //}


        public void PrintDateFromLocalVar()
        {
            int day = 6;
            int month = 7;
            int year = 2023;

            Console.WriteLine($"Date = {year} - {month} - {day}");
        }

    }
}
