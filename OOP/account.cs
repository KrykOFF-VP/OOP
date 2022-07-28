namespace OOP
{

    public class Account
    {


        public string Number { get; }
        public decimal Balance { get; set; }
        public byte Type { get; set; }

        private static int _accountNumber = 114342342;

        public Account(decimal balance, byte type)
        {
            Number = _accountNumber.ToString();
            _accountNumber++;

            Balance = balance;
            Type = type;
        }

        /// <summary>
        /// Метод перевода денежных средств
        /// </summary>
        /// <param name="Akk"> аккаунт</param>
        /// <param name="money">размер денежных средств</param>
        /// <returns></returns>
        public bool TransferMoney(ref Account Akk, decimal money)
        {

            if (Akk.balance >= money)
            {
                this.balance += money;
                Akk.balance -= money;
                return true;
               
            }
            else
                return false;
            
        }

    }
}