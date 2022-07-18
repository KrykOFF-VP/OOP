
namespace OOP
{
    public struct RationalNumber
    {
        /// <summary>
        /// Поля
        /// </summary>
        private int _numerator;
        private int _denominator;
        /// <summary>
        /// Свойства
        /// </summary>
        public int Numerator { get => _numerator; }
       
        public int Denominator { get => _denominator; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <exception cref="ArgumentException"></exception>
        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Делитель не может быть равен нулю");

            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }

            _numerator = numerator;
            _denominator = denominator;

           
        }






    }
}
