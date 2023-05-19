using System;

namespace mydemoproject
{
    class Card
    {
        public long cardNumber {get; set;}

        public int CVV {get; set;}

        public string time {get; set;}

        public string ownerName {get; set;}

        public string ownerSurname {get; set;}

        public string bankName {get; set;}

        public decimal Balance {get; private set;}

        public void IncreaseBalance(decimal sum)
        {
            if (sum<=0) return;
            Balance += sum;
        }
        
         public void decreaseBalance(decimal minus)
        {
            if (sum<=0) return;
            Balance -= minus;
        }
    }   

    public class Program {
        public static void Main(string[] args)
        {
            Card myCard = new Card();
            myCard.cardNumber = 4585698578998567;
            myCard.CVV = 256;
            myCard.time = "04/27";
            myCard.ownerName = "Miralam";
            myCard.ownerSurname = "safarov";
            myCard.bankName = "ABB";
            myCard.IncreaseBalance(250);
            myCard.decreaseBalance(150);
        }



    }




}