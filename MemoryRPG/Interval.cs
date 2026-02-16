using System;

namespace MemoryRPG
{
    public struct Interval
    {
        private Random random = new Random();

        public int Min { get; }
        public int Max { get; }

        public Interval(int minValue, int maxValue)
        {
            if (minValue > maxValue)
            {
                (minValue, maxValue) = (maxValue, minValue);
                Console.WriteLine("Некорректные входные данные: minValue > maxValue, значения поменяны местами.");
            }
            if (minValue < 0)
            {
                minValue = 0;
                Console.WriteLine("Некорректные входные данные: minValue < 0, установлено значение 0.");
            }
            if (maxValue < 0)
            {
                maxValue = 0;
                Console.WriteLine("Некорректные входные данные: maxValue < 0, установлено значение 0.");
            }
            if (minValue == maxValue)
            {
                maxValue += 10;
                Console.WriteLine("Некорректные входные данные: minValue == maxValue, maxValue увеличено на 10.");
            }
            Min = minValue;
            Max = maxValue;
        }

        public int Get()
        {
            return random.Next(Min, Max + 1);
        }
    }
}