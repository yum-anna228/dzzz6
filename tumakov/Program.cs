﻿namespace tumakov
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
        //Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета(использовать перечислимый тип из упр. 3.1). Предусмотреть методы для
        //доступа к данным – заполнения и чтения.Создать объект класса, заполнить его поля и
        //вывести информацию об объекте класса на печать.
        static void Task1()
        {
            Console.WriteLine("Упражнение 7.1");
            BankAccount myAccount = new BankAccount("56789403", 100000, AccountType.Сберегательный);
            myAccount.Info();
        }
        //Изменить класс счет в банке из упражнения 7.1 таким образом, чтобы
        //номер счета генерировался сам и был уникальным.
        static void Task2()
        {
            Console.WriteLine("Упражнение 7.2");
            BankAccount2 account1 = new BankAccount2(1000000, AccountType.Текущий);
            account1.Info();
        }
        //Добавить в класс счет в банке два метода: снять со счета и положить на счёт
        static void Task3()
        {
            Console.WriteLine("Упражнение 7.3");
            BankAccount3 account = new BankAccount3(1000000, AccountType.Сберегательный);

            account.Info();

            account.Popolnenie(50000);
            account.Withdraw(2000);

            account.Info();
            account.Withdraw(15000);
            account.Info();
        }
        //Реализовать класс для описания здания (уникальный номер здания,
        //высота, этажность, количество квартир, подъездов). Поля сделать закрытыми,
        //предусмотреть методы для заполнения полей и получения значений полей для печати.
        //Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества
        //квартир на этаже и т.д.Предусмотреть возможность, чтобы уникальный номер здания
        //генерировался программно.Для этого в классе предусмотреть статическое поле, которое бы
        //хранило последний использованный номер здания, и предусмотреть метод, который
        //увеличивал бы значение этого поля.
        static void Task4()
        {
            Console.WriteLine("Домашнее упражнение 7.1");
            Building building = new Building(50.0, 15, 150, 3);
            building.PrintInfo();
        }
    }
}
