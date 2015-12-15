using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project19_1
{
    public partial class frmCustomerIncidents : Form
    {
        public frmCustomerIncidents()
        {
            InitializeComponent();
        }

        //public property so when I pass back a customer ID from a different form I have
        //somewhere to put it
        private string customerID = "1002";
        public string CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                customerID = value;
            }
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.techSupportDataSet);

        }

        //Load form event handler.  Loads the form with the current customer ID
        private void frmCustomerIncidents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techSupportDataSet.Incidents' table. You can move, or remove it, as needed.
            this.incidentsTableAdapter.Fill(this.techSupportDataSet.Incidents);
            // TODO: This line of code loads data into the 'techSupportDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.techSupportDataSet.Customers);
            
            customerIDToolStripTextBox.Text = CustomerID;
            PopulateCustomer();

        }

        private void fillByCustomerIDToolStripButton_Click(object sender, EventArgs e)
        {
            PopulateCustomer();

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            string shortDate = currentDateTime.ToShortDateString();
            
        }

        private void btnToolStripSearchByState_Click(object sender, EventArgs e)
        {
            Form FindCustomer = new frmFindCustomer();
            FindCustomer.ShowDialog();
            this.Hide();
            
        }

        private void LoadCustomerID(object sender, EventArgs e)
        {
            
        }

        private void PopulateCustomer()
        {
            try
            {
                int customerID = Convert.ToInt32(customerIDToolStripTextBox.Text);
                this.customersTableAdapter.FillByCustomerID(this.techSupportDataSet.Customers, customerID);

                if (customersBindingSource.Count <= 0)
                {
                    MessageBox.Show("No customer found with this ID.", "Error");
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnNewIncident_Click(object sender, EventArgs e)
        {
            frmAddIncident nextIncident = new frmAddIncident();
            nextIncident.CustomerID = customerIDTextBox.Text;
            nextIncident.ShowDialog();
            this.Hide();
        }


    }
}
