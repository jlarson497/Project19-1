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
    public partial class frmAddIncident : Form
    {
        public frmAddIncident()
        {
            InitializeComponent();
        }

        //property for holding a customer ID
        private string customerID = "";
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

        private void frmAddIncident_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'techSupportDataSet.Registrations' table. You can move, or remove it, as needed.
            this.registrationsTableAdapter.Fill(this.techSupportDataSet.Registrations);
            // TODO: This line of code loads data into the 'techSupportDataSet.Incidents' table. You can move, or remove it, as needed.
            this.incidentsTableAdapter.Fill(this.techSupportDataSet.Incidents);
            // TODO: This line of code loads data into the 'techSupportDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.techSupportDataSet.Products);
            // TODO: This line of code loads data into the 'techSupportDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.techSupportDataSet.Customers);
            customerIDTextBox.Text = this.CustomerID;
        }




    }
}
