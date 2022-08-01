namespace OOP
{

    public class Account
    {


        public string _Number { get; }
        public decimal _Balance { get; set; }
        public byte _Type { get; set; }

        private static int _AccountNumber = 114342342;

        public Account(decimal balance, byte type)
        {
            _Number = _AccountNumber.ToString();
            _AccountNumber++;

            _Balance = balance;
            _Type = type;
        }

        /// <summary>
        /// Метод перевода денежных средств
        /// </summary>
        /// <param name="Akk"> аккаунт</param>
        /// <param name="money">размер денежных средств</param>
        /// <returns></returns>
        public bool TransferMoney(ref Account Akk, decimal money)
        {

            if (Akk._Balance >= money)
            {
                this._Balance += money;
                Akk._Balance -= money;
                return true;

            }
            else
                return false;

        }

        public static bool operator ==(Account a, Account b)
        {


            if (a._Balance == b._Balance && a._Type == b._Type)
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        public static bool operator !=(Account a, Account b)
        {
            if (a._Balance != b._Balance && a._Type != b._Type)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Account))
            {
                Account Akk = (Account)obj;
                if (Akk._Balance == this._Balance && Akk._Type == this._Type)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode() => (this._Number, this._Balance, this._Type).GetHashCode();
        public override string ToString() => $"Номер счета: {_Number}\nБаланс: {_Balance}\nТип счета: {_Type}";

       
    }
}