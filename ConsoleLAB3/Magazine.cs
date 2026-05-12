using System;

namespace ConsoleLAB3
{

    class Magazine : PrintedEdition
    {
        private int issueNumber;
        private int year;
        private int salesCount;

        //аксесори
        public int IssueNumber { get => issueNumber; set => issueNumber = value; }
        public int Year { get => year; set => year = value; }
        public int SalesCount { get => salesCount; set => salesCount = value; }

        //конструктор 
        public Magazine(string title, double baseCost, string language, string category,
                        int issueNumber, int year, int salesCount)
            : base(title, baseCost, language, category)
        {
            this.issueNumber = issueNumber;
            this.year = year;
            this.salesCount = salesCount;
        }

        //лаба 5 - констр без параметрів
        public Magazine()
    : base()
        {
            issueNumber = 0;
            year = 0;
            salesCount = 0;
        }


        //лаба5 - констр для копіювання
        public Magazine(Magazine other)
    : base(other)
        {
            issueNumber = other.issueNumber;
            year = other.year;
            salesCount = other.salesCount;
        }

        //ЛАБА 5 - розрахунок вартості
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

            // Для журналів знижуємо вартість на 10%
            return baseCost * 0.9;
        }

        //лаба 5 розрахунок к-сті примірників
        public override int CalculateCopies(double totalMoney, double oneCopyCost)
        {
            int baseCopies = base.CalculateCopies(totalMoney, oneCopyCost);

            // журнали дешевші - більше примірників
            return (int)(baseCopies * 1.2);
        }

        //лаба5 бінарні оператори 
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

        public static bool operator ==(Magazine a, Magazine b)
        {
            return a.BaseCost == b.BaseCost;
        }

        public static bool operator !=(Magazine a, Magazine b)
        {
            return a.BaseCost != b.BaseCost;
        }

        public static bool operator >(Magazine a, Magazine b)
        {
            return a.BaseCost > b.BaseCost;
        }

        public static bool operator <(Magazine a, Magazine b)
        {
            return a.BaseCost < b.BaseCost;
        }

        //лаба5 унарні оператори 
        public static Magazine operator ++(Magazine m)
        {
            m.BaseCost *= 1.05;
            return m;
        }

        public static Magazine operator --(Magazine m)
        {
            m.BaseCost *= 0.95;
            return m;
        }

        //лаба5 
        public Magazine[] Items = new Magazine[10];

        public Magazine this[int index]
        {
            get { return Items[index]; }
            set { Items[index] = value; }
        }

        //розрахунок рейтингу 
        public double CalculateRating()
        {
            if (salesCount > 2000) return 5.0;
            if (salesCount > 1500) return 4.0;
            else return 3.0;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Номер: {issueNumber}, Рік: {year}");
            Console.WriteLine($"Продажі: {salesCount}. Рейтинг: {CalculateRating()}");
        }
    }
}
