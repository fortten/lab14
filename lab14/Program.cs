using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    /* Разработать абстрактный класс Animal, который описывает животное и содержит элементы: абстрактное свойство - название животного; конструктор, устанавливающий
     * значение по умолчанию для названия, абстрактный метод Say()б которые выводит звук животного; неабстрактный метод ShowInfo(), который выводит на консоль
     * последовательно название, а затем звук (через метод Say()).
     * Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal. Реализовать в них элементы: свойство - название животного; метод Say(), выводящий
     * "Мяу", либо "Гав" соответственно.*/
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Кокос");
            cat.ShowInfo();
            Console.WriteLine();
            Dog dog = new Dog("Шани");
            dog.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }        

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Say();
        
        public void ShowInfo()
        {
            Console.Write("{0} говорит: ", Name);
            Say();
        }
    }

    class Cat : Animal
    {
        public override string Name { get; set; }

        public Cat(string Name)
            : base (Name)
        {
            this.Name = Name;
        }

        public override void Say()
        {
            Console.WriteLine("Мяу! Покорми меня!");
        }
    }

    class Dog : Animal
    {
        public override string Name { get; set; }

        public Dog(string Name)
            : base(Name)
        {
            this.Name = Name;
        }

        public override void Say()
        {
            Console.WriteLine("Гав! Пойдем гулять!");
        }
    }
}
