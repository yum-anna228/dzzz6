using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace dz
{
    /// <summary>
    /// Наследник от класса музыкального фестиваля
    /// </summary>
    class Drummer : Musician_Festival
    {
        private string drumType; //закрытые поля
        private int numberOfDrums;

        public string DrumType //свойства
        {
            get { return drumType; }
            set { drumType = value; }
        }

        public int NumberOfDrums
        {
            get { return numberOfDrums; }
            set { numberOfDrums = value; }
        }
        /// <summary>
        /// Конструктор, который принимает количество участников, имя и жанр
        /// </summary>
        public Drummer(string drumType, string name, int numberOfDrums) : base(name)
        {
            this.drumType = drumType;
            this.numberOfDrums = numberOfDrums;
        }
        /// <summary>
        /// Методы, которые выводят сообщение
        /// </summary>
        public override void Nomer1(string n)
        {
            Console.WriteLine($"{Name} исполняет ритм для песни {n} на барабанах типа {DrumType}.");
        }

        public override void Nomer2(string n)
        {
            Console.WriteLine($"{Name} выступает с песней {n} с использованием {NumberOfDrums} барабанов.");
        }
        /// <summary>
        /// Метод, который выводит информацию
        /// </summary>
        public override void ShowInfo()
        {
            Console.WriteLine($"Барабанщик: {Name}, Тип барабанов: {DrumType}, Количество барабанов: {NumberOfDrums}.");
        }
    }
}
