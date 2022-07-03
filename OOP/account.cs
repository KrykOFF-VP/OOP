namespace OOP
{
    public class account
    {
       
        private int _number;
        private decimal _balance;
        private byte _type;

        public int Getnumber()
        {
            return _number;
        }
        public void Setnumber(int number)
        {
            _number = number;
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
