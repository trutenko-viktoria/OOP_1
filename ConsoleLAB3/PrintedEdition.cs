using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLAB3
{
    //базовий клас
    class PrintedEdition
    {
        //закриті загальні поля
        private string title; //з малої бо це внутрішн поле
        private double baseCost;
        private string language;
        private string category;

        //властивості для доступу (аксесори) 
        public string Title //з великої бо це властивість, зовнішня оболочка
        {
            get => title;
            set
            {
                // Перевірка на порожній рядок
                if (!string.IsNullOrWhiteSpace(value))
                    title = value;
                else
                    Console.WriteLine("eror! it can not be empty");
            }
        }

        public double BaseCost
        {
            get => baseCost;
            set
            {
                // Вартість не може бути від'ємною
                if (value >= 0)
                    baseCost = value;
                else
                    Console.WriteLine("Eror. it must be positive!");
            }
        }

        //тут вже без перевірок, але їх теж можна додати 
        public string Language { get => language; set => language = value; }
        public string Category { get => category; set => category = value; }

        //конструктор базового класу з параметрами
        public PrintedEdition(string title, double baseCost, string language, string category)
        {
            Title = title;
            BaseCost = baseCost;
            Language = language;
            Category = category;
        }

        //5 лаба - конструктор без парметрів 
        public PrintedEdition()
        {
            title = "No title";
            baseCost = 0;
            language = "Unknown";
            category = "Unknown";
        }

        //5 лаба- конструктор для копіювання
        public PrintedEdition(PrintedEdition other)
        {
            title = other.title;
            baseCost = other.baseCost;
            language = other.language;
            category = other.category;
        }

        //метод розрахунку вартості (базова ціна + 20 % вартості)
        //ЛАБА 5 - УДОСКОНАЛЕНННЯ
        public virtual double CalculateTotalCost(
       int copies,
       int pages,
       double pageCost,
       double coverCoefficient,
       double formatCoefficient,
       double colorCoefficient)
        {
            return copies * pages * pageCost *
                   coverCoefficient *
                   formatCoefficient *
                   colorCoefficient;
        }

        //ЛАБА 5 визначає КІЛЬКІСТЬ друкованих видань
        public virtual int CalculateCopies(double totalMoney, double oneCopyCost)
        {
            if (oneCopyCost <= 0) return 0;

            return (int)(totalMoney / oneCopyCost);
        }

        public virtual void DisplayInfo()
        {
            //використовую $ (інтерполяцію рядків)
            Console.WriteLine($"\nВидання: {title}");
            Console.WriteLine($"Категорія: {category}, Мова: {language}");
        }
    }
}

