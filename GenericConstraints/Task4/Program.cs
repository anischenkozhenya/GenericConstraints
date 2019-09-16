using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте класс ArrayList. Реализуйте в простейшем приближении возможность использования его
//экземпляра аналогично экземпляру класса ArrayList из пространства имен System.Collections.

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var myArrayList = new MyArrayList();            
            myArrayList.Add(15051994);
            myArrayList.Add('a');
            myArrayList.Add(3.1417);
            myArrayList.Add("Евгений");
            Console.WriteLine("Элементов в массиве " + myArrayList.Count);
            Console.WriteLine("Массив: "+myArrayList.ToString());
            Console.ReadKey();
        }
    }
}
