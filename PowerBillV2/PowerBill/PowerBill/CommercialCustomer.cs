using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerBill
{
   public class CommercialCustomer : Customer
    {
        // declarations
        const double BASE_CHARGE = 60;
        const double CHARGE_PER_kWh = 0.045;
        const double THRESHOLD = 1000;

        // constructor
        public CommercialCustomer(string type = "C", int acct = 0, string name = "unknown", double used = 0)
            : base(type, acct, name, used)
        {
        }
        // calculating charge for commercial customer
        private double CalculateChargeCom()
        {
            if (kWh1 <= THRESHOLD) return BASE_CHARGE;
            else return BASE_CHARGE + CHARGE_PER_kWh * (kWh1 - THRESHOLD); //Flat fee + usage

        }

        // override inherited method
        public override double CalculateCharge()
        {
            return base.CalculateCharge() + CalculateChargeCom();
        }
    }
}
