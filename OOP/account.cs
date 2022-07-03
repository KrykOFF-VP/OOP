namespace OOP
{
    
    public class account
    {
        private static int _startnumber = 11211321;
       
        public int Getnumber()
        {
            int number = _startnumber++;
            return number;
        }
        public int number { get => Getnumber(); }

        public decimal balance { get ; set ; }

        public byte type { get; set ; }

    }
}
