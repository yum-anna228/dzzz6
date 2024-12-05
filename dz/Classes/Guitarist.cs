using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace dz
{
    //Наследник от класса музыкального фестиваля
    class Guitarist : Musician_Festival
    {
        private string guitarType; //закрытые поля
        private int experienceYears;

        public string GuitarType //свойства
        {
            get { return guitarType; }
            set { guitarType = value; }
        }

        public int ExperienceYears
        {
            get { return experienceYears; }
            set { experienceYears = value; }
        }
        /// <summary>
        /// конструктор, который принимает тип гитары, имя и год опыта
        /// </summary>
        public Guitarist(string guitarType, string name, int experienceYears) : base(name)
        {
            this.guitarType = guitarType;
            this.experienceYears = experienceYears;
        }
        /// <summary>
        /// 3 метода ,которые выводят сообщения
        /// </summary>
        public override void Nomer1(string n)
        {
            Console.WriteLine($"{Name} выступает с песней {n} на гитаре типа {GuitarType}.");
        }

        public override void Nomer2(string n)
        {
            Console.WriteLine($"{Name} исполняет {n}.");
        }
        /// <summary>
        /// метод, который выводит информацию о гитаристе
        /// </summary>
        public override void ShowInfo()
        {
            Console.WriteLine($"Гитарист: {Name}, Тип гитары: {GuitarType}, Опыт: {ExperienceYears} лет.");
        }
    }
}
