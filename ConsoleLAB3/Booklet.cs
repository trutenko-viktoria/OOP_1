using System;

namespace ConsoleLAB3
{
    // Буклет
    class Booklet : PrintedEdition
    {
        private int pages;
        private double printCoefficient;

        public int Pages { get => pages; set => pages = value; }
        public double PrintCoefficient { get => printCoefficient; set => printCoefficient = value; }

        // Конструктор без параметрів - задає нульові значення
        public Booklet()
            : base("No title", 0, "Unknown", "Booklet")
        {
            pages = 0;
            printCoefficient = 1.0;
        }

        // Конструктор з параметрами - задає значення
        public Booklet(string title, double baseCost, string language, string category,
                       int pages, double printCoefficient)
            : base(title, baseCost, language, category)
        {
            this.pages = pages;
            this.printCoefficient = printCoefficient;
        }

        // Конструктор копіювання - копіює дані з іншого об'єкта
        public Booklet(Booklet other)
            : base(other.Title, other.BaseCost, other.Language, other.Category)
        {
            this.pages = other.pages;
            this.printCoefficient = other.printCoefficient;
        }

        // Перевизначення розрахунку вартості
        public override double CalculateTotalCost(
            int copies,
            int pages,
            double pageCost,
            double coverCoefficient,
            double formatCoefficient,
            double colorCoefficient)
        {
            double baseCost = base.CalculateTotalCost(
                copies,
                pages,
                pageCost,
                coverCoefficient,
                formatCoefficient,
                colorCoefficient);

            // Для буклетів додаємо 5%
            return baseCost * 1.05;
        }

        //лаба5 розрахунок к-сті примірників 
        public override int CalculateCopies(double totalMoney, double oneCopyCost)
        {
            int baseCopies = base.CalculateCopies(totalMoney, oneCopyCost);

            // буклети дуже дешеві - ще більше
            return (int)(baseCopies * 1.5);
        }

        // бінарні оператори 

        public override bool Equals(object obj)
        {
            if (obj is Booklet b)
                return this.BaseCost == b.BaseCost;

            return false;
        }

        public override int GetHashCode()
        {
            return BaseCost.GetHashCode();
        }
        public static bool operator ==(Booklet a, Booklet b)
        {
            return a.BaseCost == b.BaseCost;
        }

        public static bool operator !=(Booklet a, Booklet b)
        {
            return a.BaseCost != b.BaseCost;
        }

        public static bool operator >(Booklet a, Booklet b)
        {
            return a.BaseCost > b.BaseCost;
        }

        public static bool operator <(Booklet a, Booklet b)
        {
            return a.BaseCost < b.BaseCost;
        }

        //унарні оператори 
        public static Booklet operator ++(Booklet b)
        {
            b.BaseCost *= 1.02;
            return b;
        }

        public static Booklet operator --(Booklet b)
        {
            b.BaseCost *= 0.98;
            return b;
        }


        public static Booklet operator +(Booklet b, double value)
        {
            b.BaseCost += value;
            return b;
        }

        public static Booklet operator -(Booklet b, double value)
        {
            b.BaseCost -= value;
            if (b.BaseCost < 0) b.BaseCost = 0;
            return b;
        }

        // Вивід інформації
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Сторінок:" + pages + " Коефіцієнт друку: " + printCoefficient);
        }
    }
}