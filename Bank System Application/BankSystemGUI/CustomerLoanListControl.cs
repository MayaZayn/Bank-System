﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankSystemGUI
{
    public partial class CustomerLoanListControl : UserControl
    {
        public CustomerLoanListControl()
        {
            InitializeComponent();
        }

        private string type;
        private int number;
        private string state;
        private SqlMoney amount;
        private int branchNumber;
        private int bankCode;
        private string ssnPerson;
        private int loanPersonID;
        private string employeeName;
        private string customerNameComma;
        private string customerName;
        public string Type
        {
            get { return type; }
            set { this.type = value; loanTypeLabel.Text = value + " Loan"; }
        }
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; loanDescriptionLabel.Text += "\nEmployee: " + value; }
        }
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; loanDescriptionLabel.Text += "\nCustomer: " + value; }
        }

        public string CustomerNameComma
        {
            get { return customerName; }
            set { customerName = value; loanDescriptionLabel.Text += ", Customer: " + value; }
        }
        public int LoanPersonID
        {
            get { return loanPersonID; }
            set { this.loanPersonID = value; loanDescriptionLabel.Text += "Code: " + value; }
        }

        public string State
        {
            get { return state; }
            set { this.state = value; loanDescriptionLabel.Text += ",  State: " + value; }
        }
        public string SSNPerson
        {
            get { return ssnPerson; }
            set { ssnPerson = value; loanDescriptionLabel.Text += "\nSSN: " + value; }
        }
        public int Number
        {
            get { return number; }
            set { this.number = value; loanDescriptionLabel.Text += ("Code: " + value); }
        }
        public SqlMoney Amount
        {
            get { return amount; }
            set { this.amount = value; loanDescriptionLabel.Text += ("\nAmount: " + value + "$"); }
        }
        public int BankCode
        {
            get { return bankCode; }
            set { this.bankCode = value; loanDescriptionLabel.Text += "\nBank Code: " + value; }
        }
        public int BranchNumber
        {
            get { return branchNumber; }
            set { this.branchNumber = value; loanDescriptionLabel.Text += ",   Branch Number: " + value; }
        }

    }
}
