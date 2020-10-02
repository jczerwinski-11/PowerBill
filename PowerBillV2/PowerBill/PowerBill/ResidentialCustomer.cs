using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PowerBill
{

    public class ResidentialCustomer : Customer
    {
    const double BASE_CHARGE = 6.00;
    const double CHARGE_PER_KWH = 0.052;

    // constructor
    public ResidentialCustomer(string type = "R", int acct = 0, string name = "unknown", double used = 0)
        : base(type, acct, name, used)
    {

    }
    private double CalculateChargeRes()
    {
        return BASE_CHARGE + CHARGE_PER_KWH * kWh1;
    }

    // iverride inherited methods
    public override double CalculateCharge()
    {
        return base.CalculateCharge() + CalculateChargeRes();
    }
}
}
