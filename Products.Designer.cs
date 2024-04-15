namespace OnlineStore
{
    partial class Products
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
            this.productsTabControl = new System.Windows.Forms.TabControl();
            this.productView = new System.Windows.Forms.TabPage();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.txtExpensiveProduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPopularProduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProductInformation = new System.Windows.Forms.DataGridView();
            this.cmbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProviderFilter = new System.Windows.Forms.ComboBox();
            this.createProducts = new System.Windows.Forms.TabPage();
            this.cmbCreateProductIsAvailable = new System.Windows.Forms.ComboBox();
            this.cmbCreateProductProvider = new System.Windows.Forms.ComboBox();
            this.cmbCreateProductCategory = new System.Windows.Forms.ComboBox();
            this.txtCreateProductDescription = new System.Windows.Forms.TextBox();
            this.mtxtCreateProductStock = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCreateProductPrice = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCreateProductName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.updateDeleteProducts = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbProductSelect = new System.Windows.Forms.ComboBox();
            this.pProductInfo = new System.Windows.Forms.Panel();
            this.cmbUpdateProductIsAvailable = new System.Windows.Forms.ComboBox();
            this.cmbUpdateProductProvider = new System.Windows.Forms.ComboBox();
            this.cmbUpdateProductCategory = new System.Windows.Forms.ComboBox();
            this.txtUpdateProductDescription = new System.Windows.Forms.TextBox();
            this.mtxtUpdateProductStock = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtUpdateProductName = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.productPriceChanges = new System.Windows.Forms.TabPage();
            this.btnOriginalPrice = new System.Windows.Forms.Button();
            this.txtCurrentPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtReasonForChange = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nupUpdatedPrice = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSubmitPriceChange = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPriceChangeHistory = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProductPriceChange = new System.Windows.Forms.ComboBox();
            this.productsTabControl.SuspendLayout();
            this.productView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInformation)).BeginInit();
            this.createProducts.SuspendLayout();
            this.updateDeleteProducts.SuspendLayout();
            this.pProductInfo.SuspendLayout();
            this.productPriceChanges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupUpdatedPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceChangeHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // productsTabControl
            // 
            this.productsTabControl.Controls.Add(this.productView);
            this.productsTabControl.Controls.Add(this.createProducts);
            this.productsTabControl.Controls.Add(this.updateDeleteProducts);
            this.productsTabControl.Controls.Add(this.productPriceChanges);
            this.productsTabControl.Location = new System.Drawing.Point(14, 15);
            this.productsTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productsTabControl.Name = "productsTabControl";
            this.productsTabControl.SelectedIndex = 0;
            this.productsTabControl.Size = new System.Drawing.Size(873, 532);
            this.productsTabControl.TabIndex = 0;
            this.productsTabControl.SelectedIndexChanged += new System.EventHandler(this.productsTabControl_SelectedIndexChanged);
            // 
            // productView
            // 
            this.productView.Controls.Add(this.btnClearFilters);
            this.productView.Controls.Add(this.txtExpensiveProduct);
            this.productView.Controls.Add(this.label6);
            this.productView.Controls.Add(this.txtPopularProduct);
            this.productView.Controls.Add(this.label4);
            this.productView.Controls.Add(this.label3);
            this.productView.Controls.Add(this.dgvProductInformation);
            this.productView.Controls.Add(this.cmbCategoryFilter);
            this.productView.Controls.Add(this.label2);
            this.productView.Controls.Add(this.label1);
            this.productView.Controls.Add(this.cmbProviderFilter);
            this.productView.Location = new System.Drawing.Point(4, 29);
            this.productView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productView.Name = "productView";
            this.productView.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productView.Size = new System.Drawing.Size(865, 499);
            this.productView.TabIndex = 0;
            this.productView.Text = "View";
            this.productView.UseVisualStyleBackColor = true;
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Location = new System.Drawing.Point(19, 212);
            this.btnClearFilters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(134, 56);
            this.btnClearFilters.TabIndex = 26;
            this.btnClearFilters.Text = "Clear Filters";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // txtExpensiveProduct
            // 
            this.txtExpensiveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpensiveProduct.Location = new System.Drawing.Point(17, 419);
            this.txtExpensiveProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExpensiveProduct.Name = "txtExpensiveProduct";
            this.txtExpensiveProduct.ReadOnly = true;
            this.txtExpensiveProduct.Size = new System.Drawing.Size(234, 25);
            this.txtExpensiveProduct.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Most Expensive Product";
            // 
            // txtPopularProduct
            // 
            this.txtPopularProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPopularProduct.Location = new System.Drawing.Point(17, 339);
            this.txtPopularProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPopularProduct.Name = "txtPopularProduct";
            this.txtPopularProduct.ReadOnly = true;
            this.txtPopularProduct.Size = new System.Drawing.Size(234, 25);
            this.txtPopularProduct.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Most Popular Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Products";
            // 
            // dgvProductInformation
            // 
            this.dgvProductInformation.AllowUserToAddRows = false;
            this.dgvProductInformation.AllowUserToDeleteRows = false;
            this.dgvProductInformation.AllowUserToResizeColumns = false;
            this.dgvProductInformation.AllowUserToResizeRows = false;
            this.dgvProductInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductInformation.Location = new System.Drawing.Point(298, 60);
            this.dgvProductInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductInformation.Name = "dgvProductInformation";
            this.dgvProductInformation.RowHeadersVisible = false;
            this.dgvProductInformation.RowHeadersWidth = 51;
            this.dgvProductInformation.RowTemplate.Height = 24;
            this.dgvProductInformation.Size = new System.Drawing.Size(555, 411);
            this.dgvProductInformation.TabIndex = 18;
            // 
            // cmbCategoryFilter
            // 
            this.cmbCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoryFilter.FormattingEnabled = true;
            this.cmbCategoryFilter.Location = new System.Drawing.Point(19, 159);
            this.cmbCategoryFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            this.cmbCategoryFilter.Size = new System.Drawing.Size(208, 28);
            this.cmbCategoryFilter.TabIndex = 17;
            this.cmbCategoryFilter.SelectionChangeCommitted += new System.EventHandler(this.cmbCategoryFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Category Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Provider Filter";
            // 
            // cmbProviderFilter
            // 
            this.cmbProviderFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProviderFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProviderFilter.FormattingEnabled = true;
            this.cmbProviderFilter.Location = new System.Drawing.Point(17, 60);
            this.cmbProviderFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProviderFilter.Name = "cmbProviderFilter";
            this.cmbProviderFilter.Size = new System.Drawing.Size(208, 28);
            this.cmbProviderFilter.TabIndex = 14;
            this.cmbProviderFilter.SelectionChangeCommitted += new System.EventHandler(this.cmbProviderFilter_SelectedIndexChanged);
            // 
            // createProducts
            // 
            this.createProducts.Controls.Add(this.cmbCreateProductIsAvailable);
            this.createProducts.Controls.Add(this.cmbCreateProductProvider);
            this.createProducts.Controls.Add(this.cmbCreateProductCategory);
            this.createProducts.Controls.Add(this.txtCreateProductDescription);
            this.createProducts.Controls.Add(this.mtxtCreateProductStock);
            this.createProducts.Controls.Add(this.mtxtCreateProductPrice);
            this.createProducts.Controls.Add(this.label13);
            this.createProducts.Controls.Add(this.label14);
            this.createProducts.Controls.Add(this.btnCreateProduct);
            this.createProducts.Controls.Add(this.label12);
            this.createProducts.Controls.Add(this.label15);
            this.createProducts.Controls.Add(this.label16);
            this.createProducts.Controls.Add(this.label17);
            this.createProducts.Controls.Add(this.txtCreateProductName);
            this.createProducts.Controls.Add(this.label18);
            this.createProducts.Location = new System.Drawing.Point(4, 29);
            this.createProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createProducts.Name = "createProducts";
            this.createProducts.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createProducts.Size = new System.Drawing.Size(865, 499);
            this.createProducts.TabIndex = 1;
            this.createProducts.Text = "Create";
            this.createProducts.UseVisualStyleBackColor = true;
            // 
            // cmbCreateProductIsAvailable
            // 
            this.cmbCreateProductIsAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCreateProductIsAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCreateProductIsAvailable.FormattingEnabled = true;
            this.cmbCreateProductIsAvailable.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cmbCreateProductIsAvailable.Location = new System.Drawing.Point(183, 289);
            this.cmbCreateProductIsAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCreateProductIsAvailable.Name = "cmbCreateProductIsAvailable";
            this.cmbCreateProductIsAvailable.Size = new System.Drawing.Size(235, 28);
            this.cmbCreateProductIsAvailable.TabIndex = 42;
            // 
            // cmbCreateProductProvider
            // 
            this.cmbCreateProductProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCreateProductProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCreateProductProvider.FormattingEnabled = true;
            this.cmbCreateProductProvider.Location = new System.Drawing.Point(183, 136);
            this.cmbCreateProductProvider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCreateProductProvider.Name = "cmbCreateProductProvider";
            this.cmbCreateProductProvider.Size = new System.Drawing.Size(235, 28);
            this.cmbCreateProductProvider.TabIndex = 41;
            // 
            // cmbCreateProductCategory
            // 
            this.cmbCreateProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCreateProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCreateProductCategory.FormattingEnabled = true;
            this.cmbCreateProductCategory.Location = new System.Drawing.Point(183, 86);
            this.cmbCreateProductCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCreateProductCategory.Name = "cmbCreateProductCategory";
            this.cmbCreateProductCategory.Size = new System.Drawing.Size(235, 28);
            this.cmbCreateProductCategory.TabIndex = 40;
            // 
            // txtCreateProductDescription
            // 
            this.txtCreateProductDescription.Location = new System.Drawing.Point(183, 340);
            this.txtCreateProductDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateProductDescription.Name = "txtCreateProductDescription";
            this.txtCreateProductDescription.Size = new System.Drawing.Size(235, 26);
            this.txtCreateProductDescription.TabIndex = 39;
            // 
            // mtxtCreateProductStock
            // 
            this.mtxtCreateProductStock.Location = new System.Drawing.Point(183, 190);
            this.mtxtCreateProductStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtCreateProductStock.Mask = "00000";
            this.mtxtCreateProductStock.Name = "mtxtCreateProductStock";
            this.mtxtCreateProductStock.Size = new System.Drawing.Size(235, 26);
            this.mtxtCreateProductStock.TabIndex = 38;
            this.mtxtCreateProductStock.ValidatingType = typeof(int);
            // 
            // mtxtCreateProductPrice
            // 
            this.mtxtCreateProductPrice.Location = new System.Drawing.Point(183, 239);
            this.mtxtCreateProductPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtCreateProductPrice.Mask = "$9999.99";
            this.mtxtCreateProductPrice.Name = "mtxtCreateProductPrice";
            this.mtxtCreateProductPrice.Size = new System.Drawing.Size(235, 26);
            this.mtxtCreateProductPrice.TabIndex = 37;
            this.mtxtCreateProductPrice.ValidatingType = typeof(int);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.ForeColor = System.Drawing.Color.Firebrick;
            this.label13.Location = new System.Drawing.Point(19, 285);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 29);
            this.label13.TabIndex = 36;
            this.label13.Text = "*Is Available:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.ForeColor = System.Drawing.Color.Firebrick;
            this.label14.Location = new System.Drawing.Point(19, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 29);
            this.label14.TabIndex = 35;
            this.label14.Text = "*Price:";
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCreateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCreateProduct.Location = new System.Drawing.Point(88, 391);
            this.btnCreateProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(212, 58);
            this.btnCreateProduct.TabIndex = 34;
            this.btnCreateProduct.Text = "Create";
            this.btnCreateProduct.UseVisualStyleBackColor = false;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(19, 336);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 29);
            this.label12.TabIndex = 30;
            this.label12.Text = "Description:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.ForeColor = System.Drawing.Color.Firebrick;
            this.label15.Location = new System.Drawing.Point(19, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 29);
            this.label15.TabIndex = 25;
            this.label15.Text = "*Stock:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.ForeColor = System.Drawing.Color.Firebrick;
            this.label16.Location = new System.Drawing.Point(19, 138);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 29);
            this.label16.TabIndex = 22;
            this.label16.Text = "*Provider:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label17.ForeColor = System.Drawing.Color.Firebrick;
            this.label17.Location = new System.Drawing.Point(19, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 29);
            this.label17.TabIndex = 20;
            this.label17.Text = "*Category:";
            // 
            // txtCreateProductName
            // 
            this.txtCreateProductName.Location = new System.Drawing.Point(183, 35);
            this.txtCreateProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateProductName.Name = "txtCreateProductName";
            this.txtCreateProductName.Size = new System.Drawing.Size(235, 26);
            this.txtCreateProductName.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label18.ForeColor = System.Drawing.Color.Firebrick;
            this.label18.Location = new System.Drawing.Point(19, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 29);
            this.label18.TabIndex = 18;
            this.label18.Text = "*Name:";
            // 
            // updateDeleteProducts
            // 
            this.updateDeleteProducts.Controls.Add(this.label11);
            this.updateDeleteProducts.Controls.Add(this.cmbProductSelect);
            this.updateDeleteProducts.Controls.Add(this.pProductInfo);
            this.updateDeleteProducts.Location = new System.Drawing.Point(4, 29);
            this.updateDeleteProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateDeleteProducts.Name = "updateDeleteProducts";
            this.updateDeleteProducts.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateDeleteProducts.Size = new System.Drawing.Size(865, 499);
            this.updateDeleteProducts.TabIndex = 2;
            this.updateDeleteProducts.Text = "Update/Delete";
            this.updateDeleteProducts.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(1, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 29);
            this.label11.TabIndex = 57;
            this.label11.Text = "Select a Product:";
            // 
            // cmbProductSelect
            // 
            this.cmbProductSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductSelect.FormattingEnabled = true;
            this.cmbProductSelect.Location = new System.Drawing.Point(218, 10);
            this.cmbProductSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProductSelect.Name = "cmbProductSelect";
            this.cmbProductSelect.Size = new System.Drawing.Size(378, 28);
            this.cmbProductSelect.TabIndex = 56;
            this.cmbProductSelect.SelectionChangeCommitted += new System.EventHandler(this.cmbProductSelect_SelectedIndexChanged);
            // 
            // pProductInfo
            // 
            this.pProductInfo.Controls.Add(this.cmbUpdateProductIsAvailable);
            this.pProductInfo.Controls.Add(this.cmbUpdateProductProvider);
            this.pProductInfo.Controls.Add(this.cmbUpdateProductCategory);
            this.pProductInfo.Controls.Add(this.txtUpdateProductDescription);
            this.pProductInfo.Controls.Add(this.mtxtUpdateProductStock);
            this.pProductInfo.Controls.Add(this.label19);
            this.pProductInfo.Controls.Add(this.label21);
            this.pProductInfo.Controls.Add(this.label22);
            this.pProductInfo.Controls.Add(this.label23);
            this.pProductInfo.Controls.Add(this.label24);
            this.pProductInfo.Controls.Add(this.txtUpdateProductName);
            this.pProductInfo.Controls.Add(this.label25);
            this.pProductInfo.Controls.Add(this.btnDeleteProduct);
            this.pProductInfo.Controls.Add(this.btnUpdateProduct);
            this.pProductInfo.Location = new System.Drawing.Point(7, 54);
            this.pProductInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pProductInfo.Name = "pProductInfo";
            this.pProductInfo.Size = new System.Drawing.Size(590, 436);
            this.pProductInfo.TabIndex = 55;
            // 
            // cmbUpdateProductIsAvailable
            // 
            this.cmbUpdateProductIsAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdateProductIsAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUpdateProductIsAvailable.FormattingEnabled = true;
            this.cmbUpdateProductIsAvailable.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cmbUpdateProductIsAvailable.Location = new System.Drawing.Point(232, 230);
            this.cmbUpdateProductIsAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUpdateProductIsAvailable.Name = "cmbUpdateProductIsAvailable";
            this.cmbUpdateProductIsAvailable.Size = new System.Drawing.Size(235, 28);
            this.cmbUpdateProductIsAvailable.TabIndex = 56;
            // 
            // cmbUpdateProductProvider
            // 
            this.cmbUpdateProductProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdateProductProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUpdateProductProvider.FormattingEnabled = true;
            this.cmbUpdateProductProvider.Location = new System.Drawing.Point(232, 124);
            this.cmbUpdateProductProvider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUpdateProductProvider.Name = "cmbUpdateProductProvider";
            this.cmbUpdateProductProvider.Size = new System.Drawing.Size(235, 28);
            this.cmbUpdateProductProvider.TabIndex = 55;
            // 
            // cmbUpdateProductCategory
            // 
            this.cmbUpdateProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdateProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUpdateProductCategory.FormattingEnabled = true;
            this.cmbUpdateProductCategory.Location = new System.Drawing.Point(232, 74);
            this.cmbUpdateProductCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUpdateProductCategory.Name = "cmbUpdateProductCategory";
            this.cmbUpdateProductCategory.Size = new System.Drawing.Size(235, 28);
            this.cmbUpdateProductCategory.TabIndex = 54;
            // 
            // txtUpdateProductDescription
            // 
            this.txtUpdateProductDescription.Location = new System.Drawing.Point(232, 282);
            this.txtUpdateProductDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUpdateProductDescription.Name = "txtUpdateProductDescription";
            this.txtUpdateProductDescription.Size = new System.Drawing.Size(235, 26);
            this.txtUpdateProductDescription.TabIndex = 53;
            // 
            // mtxtUpdateProductStock
            // 
            this.mtxtUpdateProductStock.Location = new System.Drawing.Point(232, 178);
            this.mtxtUpdateProductStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtUpdateProductStock.Mask = "00000";
            this.mtxtUpdateProductStock.Name = "mtxtUpdateProductStock";
            this.mtxtUpdateProductStock.Size = new System.Drawing.Size(235, 26);
            this.mtxtUpdateProductStock.TabIndex = 52;
            this.mtxtUpdateProductStock.ValidatingType = typeof(int);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(83, 225);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(141, 29);
            this.label19.TabIndex = 50;
            this.label19.Text = "Is Available:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label21.Location = new System.Drawing.Point(83, 276);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(141, 29);
            this.label21.TabIndex = 48;
            this.label21.Text = "Description:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(83, 172);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 29);
            this.label22.TabIndex = 47;
            this.label22.Text = "Stock:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(83, 124);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(110, 29);
            this.label23.TabIndex = 46;
            this.label23.Text = "Provider:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(83, 69);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(116, 29);
            this.label24.TabIndex = 45;
            this.label24.Text = "Category:";
            // 
            // txtUpdateProductName
            // 
            this.txtUpdateProductName.Location = new System.Drawing.Point(232, 22);
            this.txtUpdateProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUpdateProductName.Name = "txtUpdateProductName";
            this.txtUpdateProductName.Size = new System.Drawing.Size(235, 26);
            this.txtUpdateProductName.TabIndex = 44;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(83, 18);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 29);
            this.label25.TabIndex = 43;
            this.label25.Text = "Name:";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeleteProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteProduct.Location = new System.Drawing.Point(281, 325);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(212, 58);
            this.btnDeleteProduct.TabIndex = 34;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdateProduct.Location = new System.Drawing.Point(64, 325);
            this.btnUpdateProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(212, 58);
            this.btnUpdateProduct.TabIndex = 33;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // productPriceChanges
            // 
            this.productPriceChanges.Controls.Add(this.btnOriginalPrice);
            this.productPriceChanges.Controls.Add(this.txtCurrentPrice);
            this.productPriceChanges.Controls.Add(this.label10);
            this.productPriceChanges.Controls.Add(this.txtReasonForChange);
            this.productPriceChanges.Controls.Add(this.label9);
            this.productPriceChanges.Controls.Add(this.nupUpdatedPrice);
            this.productPriceChanges.Controls.Add(this.label8);
            this.productPriceChanges.Controls.Add(this.btnSubmitPriceChange);
            this.productPriceChanges.Controls.Add(this.label5);
            this.productPriceChanges.Controls.Add(this.dgvPriceChangeHistory);
            this.productPriceChanges.Controls.Add(this.label7);
            this.productPriceChanges.Controls.Add(this.cmbProductPriceChange);
            this.productPriceChanges.Location = new System.Drawing.Point(4, 29);
            this.productPriceChanges.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productPriceChanges.Name = "productPriceChanges";
            this.productPriceChanges.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productPriceChanges.Size = new System.Drawing.Size(865, 499);
            this.productPriceChanges.TabIndex = 3;
            this.productPriceChanges.Text = "Price Changes";
            this.productPriceChanges.UseVisualStyleBackColor = true;
            // 
            // btnOriginalPrice
            // 
            this.btnOriginalPrice.Enabled = false;
            this.btnOriginalPrice.Location = new System.Drawing.Point(181, 331);
            this.btnOriginalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOriginalPrice.Name = "btnOriginalPrice";
            this.btnOriginalPrice.Size = new System.Drawing.Size(134, 56);
            this.btnOriginalPrice.TabIndex = 34;
            this.btnOriginalPrice.Text = "Revert to Initial Price";
            this.btnOriginalPrice.UseVisualStyleBackColor = true;
            this.btnOriginalPrice.Click += new System.EventHandler(this.btnOriginalPrice_Click);
            // 
            // txtCurrentPrice
            // 
            this.txtCurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPrice.Location = new System.Drawing.Point(19, 432);
            this.txtCurrentPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCurrentPrice.Name = "txtCurrentPrice";
            this.txtCurrentPrice.ReadOnly = true;
            this.txtCurrentPrice.Size = new System.Drawing.Size(295, 25);
            this.txtCurrentPrice.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 25);
            this.label10.TabIndex = 32;
            this.label10.Text = "Current Price";
            // 
            // txtReasonForChange
            // 
            this.txtReasonForChange.Location = new System.Drawing.Point(19, 216);
            this.txtReasonForChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReasonForChange.Multiline = true;
            this.txtReasonForChange.Name = "txtReasonForChange";
            this.txtReasonForChange.Size = new System.Drawing.Size(295, 94);
            this.txtReasonForChange.TabIndex = 31;
            this.txtReasonForChange.TextChanged += new System.EventHandler(this.txtReasonForChange_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 29);
            this.label9.TabIndex = 30;
            this.label9.Text = "Reason For Change";
            // 
            // nupUpdatedPrice
            // 
            this.nupUpdatedPrice.DecimalPlaces = 2;
            this.nupUpdatedPrice.Location = new System.Drawing.Point(18, 139);
            this.nupUpdatedPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nupUpdatedPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupUpdatedPrice.Name = "nupUpdatedPrice";
            this.nupUpdatedPrice.Size = new System.Drawing.Size(297, 26);
            this.nupUpdatedPrice.TabIndex = 29;
            this.nupUpdatedPrice.ThousandsSeparator = true;
            this.nupUpdatedPrice.ValueChanged += new System.EventHandler(this.nupUpdatedPrice_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 29);
            this.label8.TabIndex = 28;
            this.label8.Text = "Updated Price";
            // 
            // btnSubmitPriceChange
            // 
            this.btnSubmitPriceChange.Enabled = false;
            this.btnSubmitPriceChange.Location = new System.Drawing.Point(17, 331);
            this.btnSubmitPriceChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmitPriceChange.Name = "btnSubmitPriceChange";
            this.btnSubmitPriceChange.Size = new System.Drawing.Size(135, 56);
            this.btnSubmitPriceChange.TabIndex = 27;
            this.btnSubmitPriceChange.Text = "Submit Price Change";
            this.btnSubmitPriceChange.UseVisualStyleBackColor = true;
            this.btnSubmitPriceChange.Click += new System.EventHandler(this.btnSubmitPriceChange_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(331, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price Change History";
            // 
            // dgvPriceChangeHistory
            // 
            this.dgvPriceChangeHistory.AllowUserToAddRows = false;
            this.dgvPriceChangeHistory.AllowUserToDeleteRows = false;
            this.dgvPriceChangeHistory.AllowUserToResizeColumns = false;
            this.dgvPriceChangeHistory.AllowUserToResizeRows = false;
            this.dgvPriceChangeHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPriceChangeHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPriceChangeHistory.Location = new System.Drawing.Point(336, 60);
            this.dgvPriceChangeHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPriceChangeHistory.Name = "dgvPriceChangeHistory";
            this.dgvPriceChangeHistory.RowHeadersVisible = false;
            this.dgvPriceChangeHistory.RowHeadersWidth = 51;
            this.dgvPriceChangeHistory.RowTemplate.Height = 24;
            this.dgvPriceChangeHistory.Size = new System.Drawing.Size(516, 411);
            this.dgvPriceChangeHistory.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Product";
            // 
            // cmbProductPriceChange
            // 
            this.cmbProductPriceChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductPriceChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductPriceChange.FormattingEnabled = true;
            this.cmbProductPriceChange.Location = new System.Drawing.Point(17, 60);
            this.cmbProductPriceChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProductPriceChange.Name = "cmbProductPriceChange";
            this.cmbProductPriceChange.Size = new System.Drawing.Size(298, 28);
            this.cmbProductPriceChange.TabIndex = 6;
            this.cmbProductPriceChange.SelectionChangeCommitted += new System.EventHandler(this.cmbProductPriceChange_SelectedIndexChanged);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.productsTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.productsTabControl.ResumeLayout(false);
            this.productView.ResumeLayout(false);
            this.productView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInformation)).EndInit();
            this.createProducts.ResumeLayout(false);
            this.createProducts.PerformLayout();
            this.updateDeleteProducts.ResumeLayout(false);
            this.updateDeleteProducts.PerformLayout();
            this.pProductInfo.ResumeLayout(false);
            this.pProductInfo.PerformLayout();
            this.productPriceChanges.ResumeLayout(false);
            this.productPriceChanges.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupUpdatedPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceChangeHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl productsTabControl;
        private System.Windows.Forms.TabPage productView;
        private System.Windows.Forms.TabPage createProducts;
        private System.Windows.Forms.TabPage updateDeleteProducts;
        private System.Windows.Forms.TextBox txtExpensiveProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPopularProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvProductInformation;
        private System.Windows.Forms.ComboBox cmbCategoryFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProviderFilter;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.TabPage productPriceChanges;
        private System.Windows.Forms.Button btnSubmitPriceChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPriceChangeHistory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbProductPriceChange;
        private System.Windows.Forms.NumericUpDown nupUpdatedPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReasonForChange;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCurrentPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOriginalPrice;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCreateProductName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCreateProductDescription;
        private System.Windows.Forms.MaskedTextBox mtxtCreateProductStock;
        private System.Windows.Forms.MaskedTextBox mtxtCreateProductPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbCreateProductIsAvailable;
        private System.Windows.Forms.ComboBox cmbCreateProductProvider;
        private System.Windows.Forms.ComboBox cmbCreateProductCategory;
        private System.Windows.Forms.Panel pProductInfo;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbProductSelect;
        private System.Windows.Forms.ComboBox cmbUpdateProductIsAvailable;
        private System.Windows.Forms.ComboBox cmbUpdateProductProvider;
        private System.Windows.Forms.ComboBox cmbUpdateProductCategory;
        private System.Windows.Forms.TextBox txtUpdateProductDescription;
        private System.Windows.Forms.MaskedTextBox mtxtUpdateProductStock;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtUpdateProductName;
        private System.Windows.Forms.Label label25;
    }
}