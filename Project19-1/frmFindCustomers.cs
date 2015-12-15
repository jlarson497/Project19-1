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
    public partial class frmFindCustomer : Form
    {
        public frmFindCustomer()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.techSupportDataSet);

        }

        private void Find_Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techSupportDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.techSupportDataSet.Customers);

        }

        private void fillByStateCodeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customersTableAdapter.FillByStateCode(this.techSupportDataSet.Customers, stateToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            
            string customerID = customersDataGridView[0, customersDataGridView.CurrentRow.Index].Value.ToString();
            frmCustomerIncidents newMainForm = new frmCustomerIncidents();
            newMainForm.CustomerID = customerID;
            newMainForm.Show();
            this.Close();

        }
    }
}
