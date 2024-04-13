namespace OnlineStore
{
    partial class Orders
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
            this.tabOrders = new System.Windows.Forms.TabControl();
            this.viewOrders = new System.Windows.Forms.TabPage();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtDateOrdered = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvOrderInformation = new System.Windows.Forms.DataGridView();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.createOrders = new System.Windows.Forms.TabPage();
            this.nupCreateQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.btnRemoveFromOrder = new System.Windows.Forms.Button();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lstBxOrderSummary = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCreateTotalPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCreateProduct = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCreateCustomer = new System.Windows.Forms.ComboBox();
            this.updateOrders = new System.Windows.Forms.TabPage();
            this.nupUpdateQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnUpdateRemoveOrder = new System.Windows.Forms.Button();
            this.btnUpdateAddToOrder = new System.Windows.Forms.Button();
            this.lstBxUpdateOrderInfo = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUpdateTotalCost = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbUpdateProduct = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbUpdateOrder = new System.Windows.Forms.ComboBox();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.tabOrders.SuspendLayout();
            this.viewOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInformation)).BeginInit();
            this.createOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCreateQuantity)).BeginInit();
            this.updateOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupUpdateQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // tabOrders
            // 
            this.tabOrders.Controls.Add(this.viewOrders);
            this.tabOrders.Controls.Add(this.createOrders);
            this.tabOrders.Controls.Add(this.updateOrders);
            this.tabOrders.Location = new System.Drawing.Point(9, 10);
            this.tabOrders.Margin = new System.Windows.Forms.Padding(2);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.SelectedIndex = 0;
            this.tabOrders.Size = new System.Drawing.Size(582, 346);
            this.tabOrders.TabIndex = 0;
            this.tabOrders.SelectedIndexChanged += new System.EventHandler(this.ordersTabControl_SelectedIndexChanged);
            // 
            // viewOrders
            // 
            this.viewOrders.Controls.Add(this.txtTotalPrice);
            this.viewOrders.Controls.Add(this.txtDateOrdered);
            this.viewOrders.Controls.Add(this.label6);
            this.viewOrders.Controls.Add(this.label5);
            this.viewOrders.Controls.Add(this.txtOrderNumber);
            this.viewOrders.Controls.Add(this.label4);
            this.viewOrders.Controls.Add(this.label3);
            this.viewOrders.Controls.Add(this.dgvOrderInformation);
            this.viewOrders.Controls.Add(this.cmbOrder);
            this.viewOrders.Controls.Add(this.label2);
            this.viewOrders.Controls.Add(this.label1);
            this.viewOrders.Controls.Add(this.cmbCustomer);
            this.viewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrders.Location = new System.Drawing.Point(4, 22);
            this.viewOrders.Margin = new System.Windows.Forms.Padding(2);
            this.viewOrders.Name = "viewOrders";
            this.viewOrders.Padding = new System.Windows.Forms.Padding(2);
            this.viewOrders.Size = new System.Drawing.Size(574, 320);
            this.viewOrders.TabIndex = 0;
            this.viewOrders.Text = "View";
            this.viewOrders.UseVisualStyleBackColor = true;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(8, 219);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(131, 19);
            this.txtTotalPrice.TabIndex = 13;
            // 
            // txtDateOrdered
            // 
            this.txtDateOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateOrdered.Location = new System.Drawing.Point(8, 266);
            this.txtDateOrdered.Margin = new System.Windows.Forms.Padding(2);
            this.txtDateOrdered.Name = "txtDateOrdered";
            this.txtDateOrdered.ReadOnly = true;
            this.txtDateOrdered.Size = new System.Drawing.Size(131, 19);
            this.txtDateOrdered.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 200);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date Ordered";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNumber.Location = new System.Drawing.Point(8, 167);
            this.txtOrderNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.ReadOnly = true;
            this.txtOrderNumber.Size = new System.Drawing.Size(131, 19);
            this.txtOrderNumber.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Order Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Order Information";
            // 
            // dgvOrderInformation
            // 
            this.dgvOrderInformation.AllowUserToAddRows = false;
            this.dgvOrderInformation.AllowUserToDeleteRows = false;
            this.dgvOrderInformation.AllowUserToResizeColumns = false;
            this.dgvOrderInformation.AllowUserToResizeRows = false;
            this.dgvOrderInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderInformation.Location = new System.Drawing.Point(194, 36);
            this.dgvOrderInformation.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrderInformation.Name = "dgvOrderInformation";
            this.dgvOrderInformation.RowHeadersVisible = false;
            this.dgvOrderInformation.RowHeadersWidth = 51;
            this.dgvOrderInformation.RowTemplate.Height = 24;
            this.dgvOrderInformation.Size = new System.Drawing.Size(370, 267);
            this.dgvOrderInformation.TabIndex = 4;
            // 
            // cmbOrder
            // 
            this.cmbOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(8, 100);
            this.cmbOrder.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(140, 21);
            this.cmbOrder.TabIndex = 3;
            this.cmbOrder.SelectionChangeCommitted += new System.EventHandler(this.cmbOrder_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(7, 36);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(140, 21);
            this.cmbCustomer.TabIndex = 0;
            this.cmbCustomer.SelectionChangeCommitted += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // createOrders
            // 
            this.createOrders.Controls.Add(this.nupCreateQuantity);
            this.createOrders.Controls.Add(this.btnSubmitOrder);
            this.createOrders.Controls.Add(this.btnRemoveFromOrder);
            this.createOrders.Controls.Add(this.btnAddToOrder);
            this.createOrders.Controls.Add(this.lstBxOrderSummary);
            this.createOrders.Controls.Add(this.label11);
            this.createOrders.Controls.Add(this.txtCreateTotalPrice);
            this.createOrders.Controls.Add(this.label10);
            this.createOrders.Controls.Add(this.label9);
            this.createOrders.Controls.Add(this.cmbCreateProduct);
            this.createOrders.Controls.Add(this.label7);
            this.createOrders.Controls.Add(this.label8);
            this.createOrders.Controls.Add(this.cmbCreateCustomer);
            this.createOrders.Location = new System.Drawing.Point(4, 22);
            this.createOrders.Margin = new System.Windows.Forms.Padding(2);
            this.createOrders.Name = "createOrders";
            this.createOrders.Padding = new System.Windows.Forms.Padding(2);
            this.createOrders.Size = new System.Drawing.Size(574, 320);
            this.createOrders.TabIndex = 1;
            this.createOrders.Text = "Create";
            this.createOrders.UseVisualStyleBackColor = true;
            // 
            // nupCreateQuantity
            // 
            this.nupCreateQuantity.Location = new System.Drawing.Point(8, 167);
            this.nupCreateQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.nupCreateQuantity.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nupCreateQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupCreateQuantity.Name = "nupCreateQuantity";
            this.nupCreateQuantity.Size = new System.Drawing.Size(140, 20);
            this.nupCreateQuantity.TabIndex = 21;
            this.nupCreateQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Enabled = false;
            this.btnSubmitOrder.Location = new System.Drawing.Point(468, 264);
            this.btnSubmitOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(92, 44);
            this.btnSubmitOrder.TabIndex = 20;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // btnRemoveFromOrder
            // 
            this.btnRemoveFromOrder.Enabled = false;
            this.btnRemoveFromOrder.Location = new System.Drawing.Point(193, 264);
            this.btnRemoveFromOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveFromOrder.Name = "btnRemoveFromOrder";
            this.btnRemoveFromOrder.Size = new System.Drawing.Size(92, 44);
            this.btnRemoveFromOrder.TabIndex = 19;
            this.btnRemoveFromOrder.Text = "Remove from Order";
            this.btnRemoveFromOrder.UseVisualStyleBackColor = true;
            this.btnRemoveFromOrder.Click += new System.EventHandler(this.btnRemoveFromOrder_Click);
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Enabled = false;
            this.btnAddToOrder.Location = new System.Drawing.Point(8, 203);
            this.btnAddToOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(92, 44);
            this.btnAddToOrder.TabIndex = 18;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // lstBxOrderSummary
            // 
            this.lstBxOrderSummary.FormattingEnabled = true;
            this.lstBxOrderSummary.Location = new System.Drawing.Point(193, 36);
            this.lstBxOrderSummary.Margin = new System.Windows.Forms.Padding(2);
            this.lstBxOrderSummary.MultiColumn = true;
            this.lstBxOrderSummary.Name = "lstBxOrderSummary";
            this.lstBxOrderSummary.Size = new System.Drawing.Size(368, 212);
            this.lstBxOrderSummary.TabIndex = 17;
            this.lstBxOrderSummary.SelectedIndexChanged += new System.EventHandler(this.lstBxOrderSummary_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(190, 13);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Order Summary";
            // 
            // txtCreateTotalPrice
            // 
            this.txtCreateTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateTotalPrice.Location = new System.Drawing.Point(312, 285);
            this.txtCreateTotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreateTotalPrice.Name = "txtCreateTotalPrice";
            this.txtCreateTotalPrice.ReadOnly = true;
            this.txtCreateTotalPrice.Size = new System.Drawing.Size(131, 19);
            this.txtCreateTotalPrice.TabIndex = 15;
            this.txtCreateTotalPrice.Text = "$0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(337, 266);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Total Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 144);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Quantity";
            // 
            // cmbCreateProduct
            // 
            this.cmbCreateProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCreateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCreateProduct.FormattingEnabled = true;
            this.cmbCreateProduct.Location = new System.Drawing.Point(8, 100);
            this.cmbCreateProduct.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCreateProduct.Name = "cmbCreateProduct";
            this.cmbCreateProduct.Size = new System.Drawing.Size(140, 21);
            this.cmbCreateProduct.TabIndex = 7;
            this.cmbCreateProduct.SelectionChangeCommitted += new System.EventHandler(this.cmbCreateProduct_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Customer";
            // 
            // cmbCreateCustomer
            // 
            this.cmbCreateCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCreateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCreateCustomer.FormattingEnabled = true;
            this.cmbCreateCustomer.Location = new System.Drawing.Point(7, 36);
            this.cmbCreateCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCreateCustomer.Name = "cmbCreateCustomer";
            this.cmbCreateCustomer.Size = new System.Drawing.Size(140, 21);
            this.cmbCreateCustomer.TabIndex = 4;
            this.cmbCreateCustomer.SelectionChangeCommitted += new System.EventHandler(this.cmbCreateCustomer_SelectedIndexChanged);
            // 
            // updateOrders
            // 
            this.updateOrders.Controls.Add(this.btnDeleteOrder);
            this.updateOrders.Controls.Add(this.nupUpdateQuantity);
            this.updateOrders.Controls.Add(this.btnUpdateOrder);
            this.updateOrders.Controls.Add(this.btnUpdateRemoveOrder);
            this.updateOrders.Controls.Add(this.btnUpdateAddToOrder);
            this.updateOrders.Controls.Add(this.lstBxUpdateOrderInfo);
            this.updateOrders.Controls.Add(this.label12);
            this.updateOrders.Controls.Add(this.txtUpdateTotalCost);
            this.updateOrders.Controls.Add(this.label13);
            this.updateOrders.Controls.Add(this.label14);
            this.updateOrders.Controls.Add(this.cmbUpdateProduct);
            this.updateOrders.Controls.Add(this.label15);
            this.updateOrders.Controls.Add(this.label16);
            this.updateOrders.Controls.Add(this.cmbUpdateOrder);
            this.updateOrders.Location = new System.Drawing.Point(4, 22);
            this.updateOrders.Margin = new System.Windows.Forms.Padding(2);
            this.updateOrders.Name = "updateOrders";
            this.updateOrders.Size = new System.Drawing.Size(574, 320);
            this.updateOrders.TabIndex = 2;
            this.updateOrders.Text = "Update/Delete";
            this.updateOrders.UseVisualStyleBackColor = true;
            // 
            // nupUpdateQuantity
            // 
            this.nupUpdateQuantity.Location = new System.Drawing.Point(8, 167);
            this.nupUpdateQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.nupUpdateQuantity.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nupUpdateQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupUpdateQuantity.Name = "nupUpdateQuantity";
            this.nupUpdateQuantity.Size = new System.Drawing.Size(140, 20);
            this.nupUpdateQuantity.TabIndex = 34;
            this.nupUpdateQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Enabled = false;
            this.btnUpdateOrder.Location = new System.Drawing.Point(468, 264);
            this.btnUpdateOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(92, 44);
            this.btnUpdateOrder.TabIndex = 33;
            this.btnUpdateOrder.Text = "Update Order";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnUpdateRemoveOrder
            // 
            this.btnUpdateRemoveOrder.Enabled = false;
            this.btnUpdateRemoveOrder.Location = new System.Drawing.Point(193, 264);
            this.btnUpdateRemoveOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateRemoveOrder.Name = "btnUpdateRemoveOrder";
            this.btnUpdateRemoveOrder.Size = new System.Drawing.Size(92, 44);
            this.btnUpdateRemoveOrder.TabIndex = 32;
            this.btnUpdateRemoveOrder.Text = "Remove from Order";
            this.btnUpdateRemoveOrder.UseVisualStyleBackColor = true;
            this.btnUpdateRemoveOrder.Click += new System.EventHandler(this.btnUpdateRemoveOrder_Click);
            // 
            // btnUpdateAddToOrder
            // 
            this.btnUpdateAddToOrder.Enabled = false;
            this.btnUpdateAddToOrder.Location = new System.Drawing.Point(8, 203);
            this.btnUpdateAddToOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateAddToOrder.Name = "btnUpdateAddToOrder";
            this.btnUpdateAddToOrder.Size = new System.Drawing.Size(92, 44);
            this.btnUpdateAddToOrder.TabIndex = 31;
            this.btnUpdateAddToOrder.Text = "Add to Order";
            this.btnUpdateAddToOrder.UseVisualStyleBackColor = true;
            this.btnUpdateAddToOrder.Click += new System.EventHandler(this.btnUpdateAddToOrder_Click);
            // 
            // lstBxUpdateOrderInfo
            // 
            this.lstBxUpdateOrderInfo.FormattingEnabled = true;
            this.lstBxUpdateOrderInfo.Location = new System.Drawing.Point(193, 36);
            this.lstBxUpdateOrderInfo.Margin = new System.Windows.Forms.Padding(2);
            this.lstBxUpdateOrderInfo.MultiColumn = true;
            this.lstBxUpdateOrderInfo.Name = "lstBxUpdateOrderInfo";
            this.lstBxUpdateOrderInfo.Size = new System.Drawing.Size(368, 212);
            this.lstBxUpdateOrderInfo.TabIndex = 30;
            this.lstBxUpdateOrderInfo.SelectedIndexChanged += new System.EventHandler(this.lstBxUpdateOrderInfo_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(190, 13);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Order Summary";
            // 
            // txtUpdateTotalCost
            // 
            this.txtUpdateTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateTotalCost.Location = new System.Drawing.Point(312, 285);
            this.txtUpdateTotalCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateTotalCost.Name = "txtUpdateTotalCost";
            this.txtUpdateTotalCost.ReadOnly = true;
            this.txtUpdateTotalCost.Size = new System.Drawing.Size(131, 19);
            this.txtUpdateTotalCost.TabIndex = 28;
            this.txtUpdateTotalCost.Text = "$0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(337, 266);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "Total Price";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 144);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Quantity";
            // 
            // cmbUpdateProduct
            // 
            this.cmbUpdateProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUpdateProduct.FormattingEnabled = true;
            this.cmbUpdateProduct.Location = new System.Drawing.Point(8, 100);
            this.cmbUpdateProduct.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUpdateProduct.Name = "cmbUpdateProduct";
            this.cmbUpdateProduct.Size = new System.Drawing.Size(140, 21);
            this.cmbUpdateProduct.TabIndex = 25;
            this.cmbUpdateProduct.SelectedIndexChanged += new System.EventHandler(this.cmbUpdateProduct_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 77);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "Product";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(4, 13);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 20);
            this.label16.TabIndex = 23;
            this.label16.Text = "Order";
            // 
            // cmbUpdateOrder
            // 
            this.cmbUpdateOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUpdateOrder.FormattingEnabled = true;
            this.cmbUpdateOrder.Location = new System.Drawing.Point(7, 36);
            this.cmbUpdateOrder.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUpdateOrder.Name = "cmbUpdateOrder";
            this.cmbUpdateOrder.Size = new System.Drawing.Size(140, 21);
            this.cmbUpdateOrder.TabIndex = 22;
            this.cmbUpdateOrder.SelectionChangeCommitted += new System.EventHandler(this.cmbUpdateOrder_SelectedIndexChanged);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Enabled = false;
            this.btnDeleteOrder.Location = new System.Drawing.Point(8, 260);
            this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(92, 44);
            this.btnDeleteOrder.TabIndex = 35;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.tabOrders.ResumeLayout(false);
            this.viewOrders.ResumeLayout(false);
            this.viewOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInformation)).EndInit();
            this.createOrders.ResumeLayout(false);
            this.createOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCreateQuantity)).EndInit();
            this.updateOrders.ResumeLayout(false);
            this.updateOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupUpdateQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOrders;
        private System.Windows.Forms.TabPage viewOrders;
        private System.Windows.Forms.TabPage createOrders;
        private System.Windows.Forms.TabPage updateOrders;
        private System.Windows.Forms.DataGridView dgvOrderInformation;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtDateOrdered;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCreateProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCreateCustomer;
        private System.Windows.Forms.ListBox lstBxOrderSummary;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCreateTotalPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nupCreateQuantity;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.Button btnRemoveFromOrder;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.NumericUpDown nupUpdateQuantity;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnUpdateRemoveOrder;
        private System.Windows.Forms.Button btnUpdateAddToOrder;
        private System.Windows.Forms.ListBox lstBxUpdateOrderInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUpdateTotalCost;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbUpdateProduct;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbUpdateOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
    }
}