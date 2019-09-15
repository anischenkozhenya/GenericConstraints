using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте класс CarCollection<T>. Реализуйте в простейшем приближении возможность
//использования его экземпляра для создания парка машин. Минимально требуемый интерфейс
//взаимодействия с экземпляром, должен включать метод добавления машин с названием машины и
//года ее выпуска, индексатор для получения значения элемента по указанному индексу и свойство
//только для чтения для получения общего количества элементов.
//Создайте метод удаления всех машин автопарка. 
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("lada", 1994);
            Car car1 = new Car("lada", 1995);
            CarCollection<Car> carCollection = new CarCollection<Car>();
            carCollection.Add(car);
            carCollection.Add(car1);
            carCollection.Add(new Car("bmw", 2000));
            Console.WriteLine("Машин в коллекции: "+carCollection.Count);
            Console.WriteLine("Машин в коллекции подиндексом 1:" + carCollection[1]);
            Console.WriteLine("Коллекция: " + carCollection.ToString());
            Console.WriteLine(new string('-',20)+"\n Коллекция после очистки");
            carCollection.Clear();
            Console.WriteLine("Машин в коллекции: " + carCollection.Count);
            Console.WriteLine(carCollection.ToString());
            Console.ReadKey();
        }
    }
}
