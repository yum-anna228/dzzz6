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
    public class BankAccount2
    {
        private static int counter = 1000;
        private readonly string number;
        private decimal balans;
        private readonly AccountType accountType;

        /// <summary>
        /// конструктор
        /// </summary>
        public BankAccount2(decimal initialBalans, AccountType accountType)
        {
            counter++;
            this.number = Generate_number();
            this.balans = initialBalans;
            this.accountType = accountType;
        }
        /// <summary>
        /// Генеарция уникального номера счёта
        /// </summary>
        private string Generate_number()
        {
            return "AC" + counter.ToString("D10");
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
