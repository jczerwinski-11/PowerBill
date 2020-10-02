using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PowerBill
{
    public class Customer
    {
        public int AccountNumber { get; set; }
        public string CustName { get; set; }
        public string CustomerType { get; set; }
        public double kWh1 { set; get; }
        private double chargeAmount;
        public double Charge
        {
            get { return chargeAmount; }
            set { chargeAmount = (value < 0) ? 0 : value; }
        }
        // constructor
        public Customer(string type = "Unknown", int acct = 0, string name = "Unknown", double usage = 0)
        {
            CustomerType = type;
            AccountNumber = acct; 
            CustName = name;
            kWh1 = usage;
        }

        public virtual double CalculateCharge()
        {
            return 0;
        }

        // overide ToString method to display string
        public override string ToString()
        {
            return CustomerType + ", " + AccountNumber.ToString() + ", " + CustName + "--" + chargeAmount.ToString("c");
        }

        // display line in the text file
        public string ToFileLine()
        {
            return CustomerType + "," + AccountNumber.ToString() + "," + CustName + "," + chargeAmount.ToString();
        }
    }
}