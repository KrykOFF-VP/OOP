namespace OOP
{

    public class Account
    {


        public string Number { get; }
        public decimal Balance { get; set; }
        public byte Type { get; set; }

        private static int _accountNumber= 114342342;

        public Account( decimal balance, byte type)
        {
            Number = _accountNumber.ToString();
            _accountNumber++;

            Balance = balance;
            Type = type;
        }


    }
}
