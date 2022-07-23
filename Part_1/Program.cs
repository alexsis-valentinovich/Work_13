using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//   Задан класс Building, который описывает здание. Класс содержит следующие элементы:
//адрес здания;
//длина здания;
//ширина здания;
//высота здания.
//    В классе Building нужно реализовать следующие методы:
//конструктор с 4 параметрами;
//свойства get/set для доступа к полям класса;
//метод Print(), который выводит информацию о здании.
//    Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность. В классе MultiBuilding
//реализовать следующие элементы:
//конструктор с 5 параметрами – реализует вызов конструктора базового класса;
//свойство get/set доступа к внутреннему полю класса;
//метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
//    Класс MultiBuilding сделать таким, что не может быть унаследован.

namespace Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите праметры первого здания");
            Console.Write("Адрес:");
            string adress = Console.ReadLine();
            Console.Write("Длина здания:");
            int dlina = Convert.ToInt32(Console.ReadLine());
            Console.Write("Высота здания:");
            int vusota = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ширина здания:");
            int shirina = Convert.ToInt32(Console.ReadLine());
            Building building = new Building(adress, dlina, vusota, shirina);
            Console.WriteLine();
            Console.WriteLine(building.Print());
            Console.WriteLine();
            Console.WriteLine("Введите этажность второго здания");
            int numberFloors = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            MultiBuilding multiBuilding = new MultiBuilding(adress, dlina, vusota, shirina, numberFloors);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
