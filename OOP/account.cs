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
       
        public decimal Getbalance()
        {
            return _balance;
        }
        public void Setbalance(decimal balance)
        {
            _balance =balance ;
        }
        public byte Gettype()
        {
            return _type;
        }
        public void Settype(byte type)
        {
            _type=type;
        }   
        
        
        
    }
}
