using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace tumakov
{
    /// <summary>
    /// Перечисление типов счёта
    /// </summary>
    public enum AccountType
    {
        Текущий,
        Сберегательный
    }
    /// <summary>
    /// Класс, который будет представлять банковский счёт
    /// </summary>
    public class BankAccount
    {
        private string number;
        private decimal balans;
        private AccountType accountType;

        /// <summary>
        /// конструктор
        /// </summary>
        public BankAccount(string number, decimal initialBalans, AccountType accountType)
        {
            this.number = number;
            this.balans = initialBalans;
            this.accountType = accountType;
        }
        /// <summary>
        /// Метод, который выводит всю информацию о счёте
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"Номер счета: {number}");
            Console.WriteLine($"Баланс: {balans}");
            Console.WriteLine($"Тип счета: {accountType}");
        }

    }
}
