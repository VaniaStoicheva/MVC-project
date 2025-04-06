using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Views
{
    public class Display
    {
        public double Amount { get; set; }
        public double Percent { get; set; }
        public double TipAmount { get; set; }
        public double Total { get; set; }
        public Display()
        {
            Amount = 0;
            Percent = 0;
            TipAmount = 0;
            Total = 0;
            GetValues();
        }
        public void GetValues()
        {
            Console.WriteLine("The bill is:");
            double bill = double.Parse(Console.ReadLine());
            Amount = bill;
            Console.WriteLine("The percent is:");
            double percent=double.Parse(Console.ReadLine());
            Percent = percent;
        }

        public void PrintBillAndTip()
        {
            Console.WriteLine($"The tip is:{TipAmount}");
            Console.WriteLine($"The total amount is:{Total}");
        }
    }
}
