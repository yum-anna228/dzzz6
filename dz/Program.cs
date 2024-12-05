namespace dz
{
    internal class Program
    {
        //Написать программу, в которой реализованы все принципы ООП. Для этого
        //необходимо реализовать не менее 4 классов:
        //● Один должен быть абстрактным
        //● Должно быть не менее 2 наследников
        //● Не менее 5 методов в каждом классе(необходимо показать свойство на
        //чтение и на чтение-запись)
        //● Не менее 4 свойств
        //● Должно быть не менее 2 конструкторов в классах наследниках
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя гитариста:");
            string guitaristName = Console.ReadLine();
            Console.WriteLine("Введите тип гитары:");
            string guitarType = Console.ReadLine();
            Console.WriteLine("Введите опыт гитариста (в годах):");
            if (!int.TryParse(Console.ReadLine(), out int experienceYears))
            {
                Console.WriteLine("Ошибка: введено некорректное количество лет.");
                return;
            }
            Guitarist g = new Guitarist(guitarType, guitaristName, experienceYears);
            g.ShowInfo();
            g.Nomer1("Облака");
            Console.WriteLine("\nВведите имя ансамбля:");
            string ansamblName = Console.ReadLine();
            Console.WriteLine("Введите количество участников");
            if (!int.TryParse(Console.ReadLine(), out int kol))
            {
                Console.WriteLine("Ошибка: введено некорректное количество участников.");
                return;
            }
            Console.WriteLine("Введите жанр ансамбля:");
            string genre = Console.ReadLine();

            Ansambl a = new Ansambl(kol, ansamblName, genre);
            a.ShowInfo();
            a.Nomer2("Путь");

            Console.WriteLine("\nВведите имя барабанщика:");
            string drummerName = Console.ReadLine();
            Console.WriteLine("Введите тип барабанов:");
            string drumType = Console.ReadLine();
            Console.WriteLine("Введите количество барабанов");
            if (!int.TryParse(Console.ReadLine(), out int numberOfDrums))
            {
                Console.WriteLine("Ошибка: введено некорректное количество барабанов.");
                return;
            }
            Drummer d = new Drummer(drumType, drummerName, numberOfDrums);
            d.ShowInfo();
            d.Nomer1("Ритм жизни");

            Console.ReadKey();
        }
    }
}
