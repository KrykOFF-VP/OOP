namespace OOP
{

    public class Account
    {

        private static int _startnumber = 11211321;

        public int Getnumber()
        {
            int number = _startnumber++;

            return number;
        }



        public int number { get => Getnumber(); }

        public decimal balance { get; set; }

        public byte type { get; set; }


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