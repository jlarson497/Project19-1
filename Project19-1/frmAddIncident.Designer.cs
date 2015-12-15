namespace Project19_1
{
    partial class frmAddIncident
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label productCodeLabel;
            System.Windows.Forms.Label nameLabel;
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.techSupportDataSet = new Project19_1.TechSupportDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new Project19_1.TechSupportDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new Project19_1.TechSupportDataSetTableAdapters.TableAdapterManager();
            this.incidentsTableAdapter = new Project19_1.TechSupportDataSetTableAdapters.IncidentsTableAdapter();
            this.productsTableAdapter = new Project19_1.TechSupportDataSetTableAdapters.ProductsTableAdapter();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.registrationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrationsTableAdapter = new Project19_1.TechSupportDataSetTableAdapters.RegistrationsTableAdapter();
            this.productCodeComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            customerIDLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            productCodeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(12, 25);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(68, 13);
            customerIDLabel.TabIndex = 3;
            customerIDLabel.Text = "Customer ID:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(50, 132);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 9;
            titleLabel.Text = "Title:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(17, 158);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 11;
            descriptionLabel.Text = "Description:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(116, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // techSupportDataSet
            // 
            this.techSupportDataSet.DataSetName = "TechSupportDataSet";
            this.techSupportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.techSupportDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.IncidentsTableAdapter = this.incidentsTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.RegistrationsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project19_1.TechSupportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // incidentsTableAdapter
            // 
            this.incidentsTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(86, 22);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerIDTextBox.TabIndex = 4;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.techSupportDataSet;
            // 
            // incidentsBindingSource
            // 
            this.incidentsBindingSource.DataMember = "Incidents";
            this.incidentsBindingSource.DataSource = this.techSupportDataSet;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentsBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(86, 129);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(194, 20);
            this.titleTextBox.TabIndex = 10;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(86, 155);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(194, 66);
            this.descriptionTextBox.TabIndex = 12;
            // 
            // registrationsBindingSource
            // 
            this.registrationsBindingSource.DataMember = "FK_Registrations_Products";
            this.registrationsBindingSource.DataSource = this.productsBindingSource;
            // 
            // registrationsTableAdapter
            // 
            this.registrationsTableAdapter.ClearBeforeFill = true;
            // 
            // productCodeLabel
            // 
            productCodeLabel.AutoSize = true;
            productCodeLabel.Location = new System.Drawing.Point(5, 105);
            productCodeLabel.Name = "productCodeLabel";
            productCodeLabel.Size = new System.Drawing.Size(75, 13);
            productCodeLabel.TabIndex = 12;
            productCodeLabel.Text = "Product Code:";
            // 
            // productCodeComboBox
            // 
            this.productCodeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationsBindingSource, "ProductCode", true));
            this.productCodeComboBox.FormattingEnabled = true;
            this.productCodeComboBox.Location = new System.Drawing.Point(86, 102);
            this.productCodeComboBox.Name = "productCodeComboBox";
            this.productCodeComboBox.Size = new System.Drawing.Size(121, 21);
            this.productCodeComboBox.TabIndex = 13;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(42, 51);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 13;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(86, 48);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 14;
            // 
            // frmAddIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 270);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(productCodeLabel);
            this.Controls.Add(this.productCodeComboBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmAddIncident";
            this.Text = "frmAddIncident";
            this.Load += new System.EventHandler(this.frmAddIncident_Load);
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private TechSupportDataSet techSupportDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private TechSupportDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private TechSupportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private TechSupportDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private TechSupportDataSetTableAdapters.IncidentsTableAdapter incidentsTableAdapter;
        private System.Windows.Forms.BindingSource incidentsBindingSource;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.BindingSource registrationsBindingSource;
        private TechSupportDataSetTableAdapters.RegistrationsTableAdapter registrationsTableAdapter;
        private System.Windows.Forms.ComboBox productCodeComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}