using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте класс Dictionary<TKey, TValue>. Реализуйте в простейшем приближении возможность
//использования его экземпляра аналогично экземпляру класса Dictionary из пространства имен
//System.Collections.Generic.Минимально требуемый интерфейс взаимодействия с экземпляром,
//должен включать метод добавления пар элементов, индексатор для получения значения элемента по
//указанному индексу и свойство только для чтения для получения общего количества пар элементов.
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Словарь чисел:");
            var dictionary = new Dictionary<string, string>();
            dictionary.AddToDictionary("один", "one");
            dictionary.AddToDictionary("два", "two");
            dictionary.AddToDictionary("три", "three");
            dictionary.AddToDictionary("четыре", "four");
            dictionary.AddToDictionary("пять", "five");
            dictionary.AddToDictionary("шесть", "six");
            Console.WriteLine(dictionary.ToString());
            Console.WriteLine();
            Console.WriteLine("Число запичей :{0}", dictionary.Lenght);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Введите номер записи в словаре:");
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
                Console.WriteLine("Вы не ввели номер записив словаре");
            else
            {
                int nomer = Convert.ToInt32(str);
                Console.WriteLine(dictionary[nomer - 1]);
            }
            Console.WriteLine("Введите значение для поиска");
            string p = Console.ReadLine();
            Console.WriteLine(dictionary[p]);            
            Console.ReadKey();
        }
    }
}
