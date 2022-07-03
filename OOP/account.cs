namespace OOP
{
    
    public class account
    {
        private static int _startnumber = 11211321;
        private decimal _balance;
        private byte _type;

        public int Getnumber()
        {
            int number = _startnumber++;
            return number;
        }
       public account(decimal balance)
        {
            _balance = balance;
            Console.WriteLine($"Cчет №:{Getnumber()} имеет баланс: {balance}");
            
        }
      


    }
}
