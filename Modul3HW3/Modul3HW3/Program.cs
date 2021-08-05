using System;

namespace Modul3HW3
{
    public class Program
    {
        public static void Show(bool result)
        {
            Console.WriteLine(result);
        }

        public static void Main(string[] args)
        {
            var firstClass = new Class1();
            var secondClass = new Class2();
            firstClass.ShowHandler += Show;
            firstClass.ShowHandler.Invoke(secondClass.Calc(firstClass.Pow, 4, 8).Invoke(5));
        }
    }
}
