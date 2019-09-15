using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//В коллекцию ArrayList, через вызов метода Add добавьте элементы структурного и ссылочного типа,
//переберите данную коллекцию с помощью, цикла for – С какой проблемой вы столкнулись?
//Ответ, нет Свойства Length, Данные разных типов может хранить
namespace Task1
{        
    class Program
    {
        static void Main(string[] args)
        {
            string c = "Строка";
            int a = 50;
            ArrayList arrayList = new ArrayList();
            arrayList.Add(c);
            arrayList.Add(a);
            arrayList.Add(new MyClass());
            arrayList.Add(new MyStruct());
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i].ToString());
            }
            Console.ReadKey();
        }
    }
}
