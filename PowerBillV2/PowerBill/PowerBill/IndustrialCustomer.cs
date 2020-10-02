using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerBill
{
    public class IndustrialCustomer : Customer
    {
        // declarations
        const double PEAK_BASE_CHARGE = 76;
        const double PEAK_CHARGE_PER_kWh = 0.065;
        const double OFF_PEAK_BASE_CHARGE = 40;
        const double OFF_PEAK_CHARGE_PER_kWh = 0.028;
        const double THRESHOLD = 1000;
        double peakCost;
        double offPkCost;
        double combinedCost;
        double totalCost;
        double combinedLessCap;

        // off peak hours usage
        public double kWh2 { get; set; }

        // constructor
        public IndustrialCustomer(string type = "I", int acct = 0, string name = "unknown", double used = 0)
            : base(type, acct, name, used)
        {
        }

        // calculating industrial charge
        private double CalculateChargeInd()
        {
            if (kWh1 <= THRESHOLD && kWh2 <= THRESHOLD)
                peakCost = PEAK_BASE_CHARGE + OFF_PEAK_BASE_CHARGE;
            else if (kWh2 > THRESHOLD && kWh2 == 0)
                peakCost = THRESHOLD + (kWh1 - THRESHOLD) * kWh2;
            else if (kWh2 <= THRESHOLD && kWh1 == 0)
                kWh2 = OFF_PEAK_BASE_CHARGE;
            else if (kWh2 > THRESHOLD && kWh1 == 0)
                offPkCost = OFF_PEAK_BASE_CHARGE + (kWh2 - OFF_PEAK_BASE_CHARGE) * OFF_PEAK_CHARGE_PER_kWh;
            else if (kWh2 <= THRESHOLD && kWh1 <= THRESHOLD)
                combinedLessCap = PEAK_BASE_CHARGE + OFF_PEAK_BASE_CHARGE;
            else
                combinedCost = offPkCost + (kWh2 - THRESHOLD) * OFF_PEAK_CHARGE_PER_kWh +
                    OFF_PEAK_BASE_CHARGE + (kWh1 - THRESHOLD) * OFF_PEAK_CHARGE_PER_kWh;

            // adding all calculation for final charge
            totalCost = peakCost + offPkCost + combinedCost + combinedLessCap;
            Charge = totalCost;

            // calculated total
            return Charge;
        }
        // overiding inherited method
        public override double CalculateCharge()
        {
            return base.CalculateCharge() + CalculateChargeInd();
        }
    }
}

