using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    public class Tip
    {
        private double amount;
        private double percent;
        public Tip(double amount,double percent) 
        { 
            this.Amount = amount;
            this.Percent = percent;
        }
        public Tip() :this(0,0){ }
        public double Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }
        public double Percent
        {
            get { return this.percent; }
            set
            {
                if (value > 1)
                {
                    this.percent = value / 100;
                }
                else
                {
                    this.percent = value;
                }

            }
        }

        public double CalculateTip() { return Amount * Percent; }
        public double CalculateTotal()
        { return CalculateTip() + Amount; }
    }
}
