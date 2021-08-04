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
            firstClass.InvokeDelegateForShow(secondClass.Calc((x, y) => (int)Math.Pow(x, y), 3, 3).Invoke(27));
        }
    }
}
