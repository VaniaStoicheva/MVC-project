using Calculator.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Model;

namespace Calculator.Controllers
{
    public class CalculatorController
    {
        private Tip tip;
        private Display display;
        public CalculatorController()
        {
                
            display = new Display();
            tip = new Tip(display.Amount, display.Percent);
            display.TipAmount = tip.CalculateTip();
            display.Total=tip.CalculateTotal();
            display.PrintBillAndTip();
        }
    }
}
