
namespace OOP
{
    public struct RationalNumber
    {
        /// <summary>
        /// Поля
        /// </summary>
        private int _numerator;
        private int _denominator;
        private float Rational=>((float)_numerator)/((float)_denominator);
        /// <summary>
        /// Свойства
        /// </summary>
        public int Numerator { get => _numerator; }
       
        public int Denominator { get => _denominator; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Numerator">Числитель</param>
        /// <param name="Denominator">Знаменатель</param>
        /// <exception cref="ArgumentException">исключение</exception>
        public RationalNumber(int Numerator, int Denominator)
        {
            if (Denominator == 0)
                throw new ArgumentException("Делитель не может быть равен нулю");

            if (Denominator < 0)
            {
                Numerator *= -1;
                Denominator *= -1;
            }

            _numerator = Numerator;
            _denominator = Denominator;

            ReduceToLowestTerms();

        }
        /// <summary>
        ///  Операторы преобразования типов между типом дробь,float, int
        /// </summary>
        /// <param name="r1"></param>
        public static implicit operator float(RationalNumber r1)=>r1.Rational;
        public static implicit operator RationalNumber(int r1) => new RationalNumber(r1, 1);

        /// <summary>
        /// Операторы сложения, вычитания, умножения и деления.
        /// </summary>
        /// <param name="r1">Первая дробь</param>
        /// <param name="r2">Вторая дробь</param>
        /// <returns></returns>
        public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
        {
            
                 return new RationalNumber((r1.Numerator * r2.Denominator)
                 + (r2.Numerator * r1.Denominator), r1.Denominator * r2.Denominator);
        }

        public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
        {
            return new RationalNumber((r1.Numerator * r2.Denominator)
                - (r2.Numerator * r1.Denominator), r1.Denominator * r2.Denominator);
        }

        public static RationalNumber operator ++(RationalNumber numb)
        {
            return new RationalNumber(numb.Numerator+1, numb.Denominator+1);
        }

        public static RationalNumber operator --(RationalNumber numb)
        {
            return new RationalNumber(numb.Numerator - 1, numb.Denominator - 1);
        }

        public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
        {
            return new RationalNumber(r1.Numerator * r2.Numerator, r1.Denominator * r2.Denominator);
        }

        public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
        {
            return new RationalNumber(r1.Numerator * r2.Denominator, r1.Denominator * r2.Numerator);
        }

        /// <summary>
        /// Операторы сравнения
        /// </summary>
        /// <param name="r1">Первая дробь</param>
        /// <param name="r2">Вторая дробь</param>
        /// <returns></returns>
        public static bool operator >(RationalNumber r1, RationalNumber r2)
        {
            return (r1 - r2).Numerator > 0;
        }
        public static bool operator <(RationalNumber r1, RationalNumber r2)
        {
            return (r1 - r2).Numerator < 0;
        }
        public static bool operator ==(RationalNumber r1, RationalNumber r2)
        {
            return (r1 - r2).Numerator == 0;
        }
        public static bool operator <=(RationalNumber r1, RationalNumber r2)
        {
            return !(r1 > r2);
        }
        public static bool operator >=(RationalNumber r1, RationalNumber r2)
        {
            return !(r1 < r2);
        }
        public static bool operator !=(RationalNumber r1, RationalNumber r2)
        {
            return !(r1 == r2);
        }
        /// <summary>
        /// Метод сокрашения дроби
        /// </summary>
        private void ReduceToLowestTerms()
        {
            int greatestCommonDivisor = RationalNumber.GetGCD(_numerator, _denominator);
            _numerator /= greatestCommonDivisor;
            _denominator /= greatestCommonDivisor;
        }
        private static int GetGCD(int term1, int term2)
        {
            if (term2 == 0)
                return term1;
            else
                return GetGCD(term2, term1 % term2);
        }
        public override bool Equals(object obj)
        {
            if (!(obj is RationalNumber))
            {
                return false;
            }

            var number = (RationalNumber)obj;
            return _numerator == number.Numerator &&
                   _denominator == number.Denominator;
        }
        public override string ToString()
        {
            return $"{this._numerator}/{this._denominator}";
        }

    }
}
