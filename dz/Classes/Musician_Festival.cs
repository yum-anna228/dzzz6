using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz
{
    /// <summary>
    /// Абстрактный класс
    /// </summary>
    abstract class Musician_Festival
    {
        /// <summary>
        /// Объявление защищённого поля
        /// </summary>
        protected string name;
        /// <summary>
        /// конструктор
        /// </summary>
        public Musician_Festival(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Два абстрактных метода
        /// </summary>
        public abstract void Nomer1(string n);
        public abstract void Nomer2(string n);
        /// <summary>
        /// Свойство
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// Абстрактный метод
        /// </summary>
        public abstract void ShowInfo();
    }
}
