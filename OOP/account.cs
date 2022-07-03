namespace OOP
{
    public class account
    {
        private int _number;
        private decimal _balance;
        private byte _type;

        public int number {get => _number; set => _number = value;}
            
        public decimal balance {get => _balance; set => _balance = value;}
        
        public byte type { get => _type; set => _type = value; }
        
        
    }
}
