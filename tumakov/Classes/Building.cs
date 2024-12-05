using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov
{
    public class Building
    {
        /// <summary>
        /// закрытые поля
        private static int last_number = 1;
        private int number;
        private double height;
        private int floors;
        private int kvartira;
        private int podezd;

        /// <summary>
        /// конструктор
        /// </summary>
        public Building(double height, int floors, int kvartira, int podezd)
        {
            this.number = generate_number();
            this.height = height;
            this.floors = floors;
            this.kvartira = kvartira;
            this.podezd = podezd;
        }
        /// <summary>
        /// Метод для генерации уникаольного номера здания
        /// </summary>
        private static int generate_number()
        {
            return (last_number++);
        }
        /// <summary>
        /// Метод для вычисления высоты этажа
        /// </summary>
        public double FloorHeight()
        {
            return height / floors;
        }
        /// <summary>
        /// Метод для вычисления количества квартир в подъезде
        /// </summary>
        public int kvartiraVpodezd()
        {
            return kvartira / podezd;
        }
        /// <summary>
        /// метод для вычисления количества квартир на этаже
        /// </summary>
        public int kvartiraNpodezd()
        {
            return kvartira / floors;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Номер здания: {number}");
            Console.WriteLine($"Высота: {height} ");
            Console.WriteLine($"Количество этажей: {floors}");
            Console.WriteLine($"Количество квартир: {kvartira}");
            Console.WriteLine($"Количество подъездов: {podezd}");
            Console.WriteLine($"Высота на этаж: {FloorHeight():F2}");
            Console.WriteLine($"Количество квартир в подъезде: {kvartiraVpodezd()}");
            Console.WriteLine($"Количество квартир на этаже: {kvartiraNpodezd()}");
        }
    }
}
