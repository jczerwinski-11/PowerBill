using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Sample Solution to CPRG Lab 1
 * Author: Jolanta 
 * Program calculates charge for electrical power used for three types of customers
 */

namespace PowerBill
{
    public partial class frmMain : Form
    {
        List<Customer> customerList = new List<Customer>(); // empty list 

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {
            customerList = CustomerList.ReadCustomers(); // reads customer data from the list, if data exists
            DisplayCustomers(); // display the customer list data, if exists
        }

        // user select Residential
        private void radResidential_CheckedChanged(object sender, EventArgs e)
        {
            HideSecondInput();
        }

        // user selects Commercial
        private void radCommercial_CheckedChanged(object sender, EventArgs e)
        {
            HideSecondInput();
        }

        // user selects Industrial
        private void radIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            ShowSecondInput();
        }

        // hide second input prompt and txt box; 
        // adjust prompt for first input: generic kWh
        private void HideSecondInput()
        {
            txtCustName.Focus();        // sets focus on customer name
            lblkWh1Prompt.Text = "Used kWh:";
            lblkWh2Prompt.Visible = false;
            txtkWh2.Visible = false;
            DisplayCustomers();         //displays customer data 
           
        }

        // hide second input prompt and txt box; 
        // adjust prompt for first input: peak kWh
        private void ShowSecondInput()
        {
            lblkWh1Prompt.Text = "Peak kWh:";     
            lblkWh2Prompt.Visible = true;
            txtkWh2.Visible = true;
            txtkWh1.Focus(); // focus on first input box
            DisplayCustomers();
        }

        // calculate customer charge
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (radResidential.Checked)
            {
                if(Validator.IsPresent(txtkWh1, "kWh") &&
                   Validator.IsNonNegativeInteger(txtkWh1, "kWh"))
                {
                    // to creat residential customer and collect input
                    ResidentialCustomer c = new ResidentialCustomer();
                    c.AccountNumber = Convert.ToInt32(txtAccountNumber.Text);
                    c.CustName = txtCustName.Text;
                    c. kWh1= Convert.ToInt32(txtkWh1.Text);
                    c.Charge = c.CalculateCharge();
                    customerList.Add(c);
                    DisplayCustomers();
                }
            }
            else if (radCommercial.Checked)
            {
                if (Validator.IsPresent(txtkWh1, "Used kWh") &&
                   Validator.IsNonNegativeInteger(txtkWh1, "kWh"))
                {
                    CommercialCustomer c = new CommercialCustomer();
                    c.AccountNumber = Convert.ToInt32(txtAccountNumber.Text);
                    c.CustName = txtCustName.Text;
                    c.kWh1 = Convert.ToInt32(txtkWh1.Text);
                    c.Charge = c.CalculateCharge();
                    customerList.Add(c);
                    DisplayCustomers();
                }
            }
            else // must be industrial
            {
                if (Validator.IsPresent(txtkWh1, "Peak kWh") &&
                    Validator.IsNonNegativeInteger(txtkWh1, "Peak kWh") &&
                    Validator.IsPresent(txtkWh2, "Off-peak kWh") &&
                    Validator.IsNonNegativeInteger(txtkWh2, "Off-peak kWh"))
                {
                    IndustrialCustomer c = new IndustrialCustomer();
                    c.AccountNumber = Convert.ToInt32(txtAccountNumber.Text);
                    c.CustName = txtCustName.Text;
                    c.kWh1 = Convert.ToInt32(txtkWh1.Text);
                    c.kWh2 = Convert.ToInt32(txtkWh2.Text);
                    c.Charge = c.CalculateCharge();
                    customerList.Add(c);
                    DisplayCustomers();
                }
            }
        }

        // clear controls and make Residential selected
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccountNumber.Text = "";
            txtCustName.Text = "";
            txtkWh1.Text = "";
            txtkWh2.Text = "";
            radResidential.Checked = true;
            txtkWh1.Focus();

        }
        //  calculating the sum of charges for customers in the list
        private double SumCharge()
        {
            double sum = 0;
            foreach (Customer c in customerList)
                sum += c.Charge;
                    return sum;  // sum of all the customer types charges
        }
        // calculating the sum of all residential customers charge amount in the list
        private double ResSumCharge()
        {
            double resSum = 0;
            foreach (Customer c in customerList)
                if (c.CustomerType == "R") resSum += c.Charge;
                    return resSum;  // sum of residential customers charges
        }

        // calculating sum of charges for commercial customers

        private double ComSumCharge()
        {
            double comSum = 0;
            foreach (Customer c in customerList)
                if (c.CustomerType == "C") comSum += c.Charge;
                    return comSum; // sum of all the commercial customer charges 
        }
        // calculating the sum of the industrial customers chage amount in the list
        private double IndSumCharge()
        {
            double indSum = 0;
            foreach (Customer c in customerList)
                if (c.CustomerType == "I") indSum += c.Charge;
                    return indSum; // sum of all the industrial customer charges     
        }

        // display the customerlist       
        private void DisplayCustomers()
        {
            lstCustomers.Items.Clear(); // start with empty list box
            foreach (Customer c in customerList)
                lstCustomers.Items.Add(c); // add to the list box
                lblTotCus.Text = customerList.Count.ToString(); // count of the customers
                lblTotCharge.Text = SumCharge().ToString("c");
                lblResCharge.Text = ResSumCharge().ToString("c");
                lblComCharge.Text = ComSumCharge().ToString("c");
                lblIndCharge.Text = IndSumCharge().ToString("c");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            CustomerList.SaveCustomers(customerList);  // save the data in the .txt file when form closes
        }
    }
}
