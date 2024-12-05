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
    class Ansambl : Musician_Festival
    {
        private int kol; //закрытые поля
        private string genre;

        public int Kol //свойства
        {
            get { return kol; }
            set { kol = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        /// <summary>
        /// конструктор, который принимает тип барабанов, имя и количество барабанов
        /// </summary>
        public Ansambl(int kol, string name, string genre) : base(name)
        {
            this.kol = kol;
            this.genre = genre;
        }
        /// <summary>
        /// Методы, которые выводят сообщение
        /// </summary>
        public override void Nomer1(string n)
        {
            Console.WriteLine($"{Name} исполняет {n} в жанре {Genre}.");
        }

        public override void Nomer2(string n)
        {
            Console.WriteLine($"{Name} выступает с песней {n} с составом из {Kol} участников.");
        }
        /// <summary>
        /// Метод, которые выводит информацию 
        /// </summary>
        public override void ShowInfo()
        {
            Console.WriteLine($"Ансамбль: {Name}, Количество участников: {Kol}, Жанр: {Genre}.");
        }
    }
}
