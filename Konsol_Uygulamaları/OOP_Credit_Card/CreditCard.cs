using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Credit_Card
{
    internal class CreditCard
    {
        private string _cardNo;
        public string CardNo
        {
            get
            {

                return _cardNo.Substring(0, 4) + "**********" + _cardNo.Substring(14, 2);

            }
            set
            {
                if (value.Length == 16)
                    _cardNo = value;
                else
                {
                    Console.WriteLine("kart no 16 haneli olmalıdır numaranızı tekrar girin");
                    _cardNo = "****************";
                }
            }
        }

        private string _cvv;
        public string CVV
        {
            get
            {
                return "**" + _cvv.Substring(2);
            }
            set
            {
                if (value.Length == 3)
                    _cvv = value;
                else
                {
                    Console.WriteLine("CVV 3 haneli olmalıdır numaranızı tekrar girin");
                    _cvv = "***";
                }
            }
        }

        private DateTime _lastdate;

        public DateTime LastDate
        {
            get
            {
                return _lastdate.Date;
            }
            set { _lastdate = value; }
        }



        public CreditCard()
        {

        }
        public CreditCard(string cardNo, string cvv, DateTime date)
        {
            this.CardNo = cardNo;
            this.CVV = cvv;
            this.LastDate = date;
        }

    }
}
