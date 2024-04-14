namespace OnlineStore
{
    partial class Administration
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
            this.administrationTabControl = new System.Windows.Forms.TabControl();
            this.customer = new System.Windows.Forms.TabPage();
            this.CRUDTabControl = new System.Windows.Forms.TabControl();
            this.createCustomer = new System.Windows.Forms.TabPage();
            this.updateCustomer = new System.Windows.Forms.TabPage();
            this.deleteCustomer = new System.Windows.Forms.TabPage();
            this.viewCustomer = new System.Windows.Forms.TabPage();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.order = new System.Windows.Forms.TabPage();
            this.category = new System.Windows.Forms.TabPage();
            this.provider = new System.Windows.Forms.TabPage();
            this.product = new System.Windows.Forms.TabPage();
            this.priceChange = new System.Windows.Forms.TabPage();
            this.itemsOrdered = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.administrationTabControl.SuspendLayout();
            this.customer.SuspendLayout();
            this.CRUDTabControl.SuspendLayout();
            this.createCustomer.SuspendLayout();
            this.viewCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // administrationTabControl
            // 
            this.administrationTabControl.Controls.Add(this.customer);
            this.administrationTabControl.Controls.Add(this.order);
            this.administrationTabControl.Controls.Add(this.category);
            this.administrationTabControl.Controls.Add(this.provider);
            this.administrationTabControl.Controls.Add(this.product);
            this.administrationTabControl.Controls.Add(this.priceChange);
            this.administrationTabControl.Controls.Add(this.itemsOrdered);
            this.administrationTabControl.Location = new System.Drawing.Point(14, 15);
            this.administrationTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.administrationTabControl.Name = "administrationTabControl";
            this.administrationTabControl.SelectedIndex = 0;
            this.administrationTabControl.Size = new System.Drawing.Size(873, 532);
            this.administrationTabControl.TabIndex = 1;
            // 
            // customer
            // 
            this.customer.Controls.Add(this.CRUDTabControl);
            this.customer.Location = new System.Drawing.Point(4, 29);
            this.customer.Name = "customer";
            this.customer.Padding = new System.Windows.Forms.Padding(3);
            this.customer.Size = new System.Drawing.Size(865, 499);
            this.customer.TabIndex = 0;
            this.customer.Text = "Customer";
            this.customer.UseVisualStyleBackColor = true;
            // 
            // CRUDTabControl
            // 
            this.CRUDTabControl.Controls.Add(this.createCustomer);
            this.CRUDTabControl.Controls.Add(this.updateCustomer);
            this.CRUDTabControl.Controls.Add(this.deleteCustomer);
            this.CRUDTabControl.Controls.Add(this.viewCustomer);
            this.CRUDTabControl.Location = new System.Drawing.Point(6, 7);
            this.CRUDTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CRUDTabControl.Name = "CRUDTabControl";
            this.CRUDTabControl.SelectedIndex = 0;
            this.CRUDTabControl.Size = new System.Drawing.Size(853, 485);
            this.CRUDTabControl.TabIndex = 2;
            // 
            // createCustomer
            // 
            this.createCustomer.Controls.Add(this.txtEmail);
            this.createCustomer.Controls.Add(this.label3);
            this.createCustomer.Controls.Add(this.txtLastName);
            this.createCustomer.Controls.Add(this.label2);
            this.createCustomer.Controls.Add(this.txtFirstName);
            this.createCustomer.Controls.Add(this.label1);
            this.createCustomer.Location = new System.Drawing.Point(4, 29);
            this.createCustomer.Name = "createCustomer";
            this.createCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.createCustomer.Size = new System.Drawing.Size(845, 452);
            this.createCustomer.TabIndex = 0;
            this.createCustomer.Text = "Create";
            this.createCustomer.UseVisualStyleBackColor = true;
            // 
            // updateCustomer
            // 
            this.updateCustomer.Location = new System.Drawing.Point(4, 29);
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.updateCustomer.Size = new System.Drawing.Size(845, 452);
            this.updateCustomer.TabIndex = 1;
            this.updateCustomer.Text = "Update";
            this.updateCustomer.UseVisualStyleBackColor = true;
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.Location = new System.Drawing.Point(4, 29);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.deleteCustomer.Size = new System.Drawing.Size(845, 452);
            this.deleteCustomer.TabIndex = 2;
            this.deleteCustomer.Text = "Delete";
            this.deleteCustomer.UseVisualStyleBackColor = true;
            // 
            // viewCustomer
            // 
            this.viewCustomer.Controls.Add(this.dgvCustomers);
            this.viewCustomer.Location = new System.Drawing.Point(4, 29);
            this.viewCustomer.Name = "viewCustomer";
            this.viewCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.viewCustomer.Size = new System.Drawing.Size(845, 452);
            this.viewCustomer.TabIndex = 3;
            this.viewCustomer.Text = "View";
            this.viewCustomer.UseVisualStyleBackColor = true;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeColumns = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(6, 4);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(833, 441);
            this.dgvCustomers.TabIndex = 5;
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(4, 29);
            this.order.Name = "order";
            this.order.Padding = new System.Windows.Forms.Padding(3);
            this.order.Size = new System.Drawing.Size(865, 499);
            this.order.TabIndex = 1;
            this.order.Text = "Order";
            this.order.UseVisualStyleBackColor = true;
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(4, 29);
            this.category.Name = "category";
            this.category.Padding = new System.Windows.Forms.Padding(3);
            this.category.Size = new System.Drawing.Size(865, 499);
            this.category.TabIndex = 2;
            this.category.Text = "Category";
            this.category.UseVisualStyleBackColor = true;
            // 
            // provider
            // 
            this.provider.Location = new System.Drawing.Point(4, 29);
            this.provider.Name = "provider";
            this.provider.Padding = new System.Windows.Forms.Padding(3);
            this.provider.Size = new System.Drawing.Size(865, 499);
            this.provider.TabIndex = 3;
            this.provider.Text = "Provider";
            this.provider.UseVisualStyleBackColor = true;
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(4, 29);
            this.product.Name = "product";
            this.product.Padding = new System.Windows.Forms.Padding(3);
            this.product.Size = new System.Drawing.Size(865, 499);
            this.product.TabIndex = 4;
            this.product.Text = "Product";
            this.product.UseVisualStyleBackColor = true;
            // 
            // priceChange
            // 
            this.priceChange.Location = new System.Drawing.Point(4, 29);
            this.priceChange.Name = "priceChange";
            this.priceChange.Padding = new System.Windows.Forms.Padding(3);
            this.priceChange.Size = new System.Drawing.Size(865, 499);
            this.priceChange.TabIndex = 5;
            this.priceChange.Text = "Price Changes";
            this.priceChange.UseVisualStyleBackColor = true;
            // 
            // itemsOrdered
            // 
            this.itemsOrdered.Location = new System.Drawing.Point(4, 29);
            this.itemsOrdered.Name = "itemsOrdered";
            this.itemsOrdered.Padding = new System.Windows.Forms.Padding(3);
            this.itemsOrdered.Size = new System.Drawing.Size(865, 499);
            this.itemsOrdered.TabIndex = 6;
            this.itemsOrdered.Text = "Items Ordered";
            this.itemsOrdered.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(865, 499);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Items Ordered";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(865, 499);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Price Changes";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(865, 499);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Product";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(865, 499);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Provider";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(865, 499);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Category";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(865, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(865, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(149, 29);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(174, 26);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(149, 79);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(174, 26);
            this.txtLastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(149, 130);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(174, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.administrationTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Administration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration";
            this.administrationTabControl.ResumeLayout(false);
            this.customer.ResumeLayout(false);
            this.CRUDTabControl.ResumeLayout(false);
            this.createCustomer.ResumeLayout(false);
            this.createCustomer.PerformLayout();
            this.viewCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl administrationTabControl;
        private System.Windows.Forms.TabPage category;
        private System.Windows.Forms.TabPage provider;
        private System.Windows.Forms.TabPage product;
        private System.Windows.Forms.TabPage priceChange;
        private System.Windows.Forms.TabPage itemsOrdered;
        private System.Windows.Forms.TabPage customer;
        private System.Windows.Forms.TabControl CRUDTabControl;
        private System.Windows.Forms.TabPage createCustomer;
        private System.Windows.Forms.TabPage order;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage updateCustomer;
        private System.Windows.Forms.TabPage deleteCustomer;
        private System.Windows.Forms.TabPage viewCustomer;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
    }
}