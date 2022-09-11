using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkbankWeb3Practicum.Models
{
    public class DailyEarning
    {
        int toplamKazanc = 0;

        public void Earning(Int64 HgsNo)
        {
            if (HgsNo == 123456789)
            {
                toplamKazanc += 50;
            }
            else if (HgsNo == 123456788)
            {
                toplamKazanc += 75;
            }
            else if (HgsNo == 123456787)
            {
                toplamKazanc += 100;
            }
        }

        public void PrintTheGain()
        {
            Console.WriteLine("Günlük toplam kazanç: " + toplamKazanc);
        }
    }
}
