using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov
{
    /// <summary>
    /// Класс, который будет представлять банковский счёт
    /// </summary>
    public class BankAccount3
    {
        private static int counter = 1000;
        private readonly string number;
        private decimal balans;
        private readonly AccountType accountType;

        /// <summary>
        /// конструктор 
        /// </summary>
        public BankAccount3(decimal initialBalans, AccountType accountType)
        {
            counter++;
            this.number = Generate_number();
            this.balans = initialBalans;
            this.accountType = accountType;
        }
        /// <summary>
        /// Генерация уникаольного номера счёта
        /// </summary>
        private string Generate_number()
        {
            return "AC" + counter.ToString("D10");
        }

        /// <summary>
        /// Метод пополнения счёта
        public void Popolnenie(decimal symma)
        {
            if (symma > 0)
            {
                balans += symma;
                Console.WriteLine($"Произошло пополнение на {symma}. Новый баланс {balans}");
            }
            else
            {
                Console.WriteLine("Сумма не может быть отрицательной!");
            }
        }
        /// <summary>
        /// Метод вывода со счёта
        /// </summary>
        public void Withdraw(decimal symma)
        {
            if (symma <= 0)
            {
                Console.WriteLine("Сумма вывода должна быть положительной");
                return;
            }
            if (symma > balans)
            {
                Console.WriteLine("У вас недостаточно средств");
            }
            else
            {
                balans -= symma;
                Console.WriteLine($"Произошел вывод средств на {symma}. Новый баланс {balans}");
            }
        }
        /// <summary>
        /// Метод, который выводит информацию
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"Номер счета: {number}");
            Console.WriteLine($"Баланс: {balans}");
            Console.WriteLine($"Тип счета: {accountType}");
        }

    }
}
