using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemGUI
{
    public partial class CustomerList : Form
    {
        private Thread th;
        private List<CustomerListControl> customerListControls = new List<CustomerListControl>();
        public CustomerList()
        {
            InitializeComponent();

        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            populateCustomers();
        }
        private void populateCustomers()
        {
            if (CustomerListFlowControlPanel.Controls.Count > 0)
            {
                CustomerListFlowControlPanel.Controls.Clear();
            }


            SqlConnection con = new SqlConnection(Program.ConString);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string query = "select * from person where BranchBankCode IN (" +
                 "select BranchBankCode from person where ssn = '" + Program.ssnGlobal + "') " +
                 "AND ssn <> '" + Program.ssnGlobal + "' " +
                 "AND type = 'Customer'";

                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        string ssnResult = sqlDataReader.GetString(0);
                        string usernameResult = sqlDataReader.GetString(1);
                        string passwordResult = sqlDataReader.GetString(2);
                        string phoneResult = sqlDataReader.GetString(4);
                        string addressResult = sqlDataReader.GetString(5);
                        int bankCodeResult = sqlDataReader.GetInt32(7);
                        int branchNumResult = sqlDataReader.GetInt32(6);

                        CustomerListControl customer = new CustomerListControl();
                        customer.Name = usernameResult;
                        customer.SSN = ssnResult;
                        customer.Phone = phoneResult;
                        customer.Address = addressResult;
                        customer.BankCode = bankCodeResult;
                        customer.BranchNumber = branchNumResult;
                        customerListControls.Add(customer);
                    }
                }
            }
            con.Close();

            if (customerListControls.Count <= 0)
            {
                this.Width = 388;
            }
            else
            {
                this.Width = 1113;
                for (int i = 0; i < customerListControls.Count; i++)
                {
                    CustomerListFlowControlPanel.Controls.Add(customerListControls[i]);
                }
            }
        }
        private void addCustomer_Click(object sender, EventArgs e)
        {
            if (!checkIfCustomerFill())
            {
                MessageBox.Show("Fill all the empty places !", "Error");
            }
            else
            {
                if (!isValidSSN())
                {
                    MessageBox.Show("The SSN is used Before, Please Insert a new one", "Error");
                }
                else
                {
                    this.Width = 1113;
                    CustomerListControl customer = new CustomerListControl();
                    customer.Name = customerNameTextBox.Text;
                    customer.SSN = customerSsnTextBox.Text;
                    customer.Phone = customerPhoneTextBox.Text;
                    customer.Address = customerAdderssTextBox.Text;
                    customer.BankCode = Program.bankCodeGlobal;
                    customer.BranchNumber = Program.branchNumberGlobal;
                    customerListControls.Add(customer);
                    CustomerListFlowControlPanel.Controls.Add(customer);

                    //Code to add customer
                    SqlConnection con = new SqlConnection(Program.ConString);
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        string query = "INSERT INTO Person(ssn, name, password, type, phone, address, " +
                            "BranchBranchNumber, BranchBankCode) " +
                            "VALUES ('" + customerSsnTextBox.Text.ToString() + "', '" + customerNameTextBox.Text.ToString() +
                            "', '" + 123 + "', 'Customer', " +
                            "'" + customerPhoneTextBox.Text.ToString() + "', '" + customerAdderssTextBox.Text.ToString() +
                            "', " + Program.branchNumberGlobal + ", " + Program.bankCodeGlobal + ")";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                    }

                    customerNameTextBox.Clear();
                    customerSsnTextBox.Clear();
                    customerPhoneTextBox.Clear();
                    customerAdderssTextBox.Clear();
                }
            }
        }
        private bool isValidSSN()
        {
            SqlConnection con = new SqlConnection(Program.ConString);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string query = "SELECT ssn FROM Person";
                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        string result = sqlDataReader.GetString(0);
                        if (result == customerSsnTextBox.Text)
                        {
                            return false;
                        }
                    }
                }
            }
            con.Close();
            return true;
        }

        private bool checkIfCustomerFill()
        {
            if (customerNameTextBox.TextLength == 0 || customerSsnTextBox.TextLength == 0
                || customerPhoneTextBox.TextLength == 0 || customerAdderssTextBox.TextLength == 0)
            {
                return false;
            }
            return true;
        }

        private void backToAdminLabel_Click(object sender, EventArgs e)
        {
            th = new Thread(openAdminForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        private void openAdminForm()
        {
            Application.Run(new AdminForm());
        }
    }
}
