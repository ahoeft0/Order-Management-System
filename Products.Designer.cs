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
            this.updateDeleteProducts = new System.Windows.Forms.TabPage();
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
            this.productsTabControl.Location = new System.Drawing.Point(12, 12);
            this.productsTabControl.Name = "productsTabControl";
            this.productsTabControl.SelectedIndex = 0;
            this.productsTabControl.Size = new System.Drawing.Size(776, 426);
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
            this.productView.Location = new System.Drawing.Point(4, 25);
            this.productView.Name = "productView";
            this.productView.Padding = new System.Windows.Forms.Padding(3);
            this.productView.Size = new System.Drawing.Size(768, 397);
            this.productView.TabIndex = 0;
            this.productView.Text = "View";
            this.productView.UseVisualStyleBackColor = true;
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Location = new System.Drawing.Point(17, 170);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(119, 45);
            this.btnClearFilters.TabIndex = 26;
            this.btnClearFilters.Text = "Clear Filters";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // txtExpensiveProduct
            // 
            this.txtExpensiveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpensiveProduct.Location = new System.Drawing.Point(15, 335);
            this.txtExpensiveProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExpensiveProduct.Name = "txtExpensiveProduct";
            this.txtExpensiveProduct.ReadOnly = true;
            this.txtExpensiveProduct.Size = new System.Drawing.Size(208, 22);
            this.txtExpensiveProduct.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Most Expensive Product";
            // 
            // txtPopularProduct
            // 
            this.txtPopularProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPopularProduct.Location = new System.Drawing.Point(15, 271);
            this.txtPopularProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPopularProduct.Name = "txtPopularProduct";
            this.txtPopularProduct.ReadOnly = true;
            this.txtPopularProduct.Size = new System.Drawing.Size(208, 22);
            this.txtPopularProduct.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Most Popular Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
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
            this.dgvProductInformation.Location = new System.Drawing.Point(265, 48);
            this.dgvProductInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductInformation.Name = "dgvProductInformation";
            this.dgvProductInformation.RowHeadersVisible = false;
            this.dgvProductInformation.RowHeadersWidth = 51;
            this.dgvProductInformation.RowTemplate.Height = 24;
            this.dgvProductInformation.Size = new System.Drawing.Size(493, 329);
            this.dgvProductInformation.TabIndex = 18;
            // 
            // cmbCategoryFilter
            // 
            this.cmbCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoryFilter.FormattingEnabled = true;
            this.cmbCategoryFilter.Location = new System.Drawing.Point(17, 127);
            this.cmbCategoryFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            this.cmbCategoryFilter.Size = new System.Drawing.Size(185, 24);
            this.cmbCategoryFilter.TabIndex = 17;
            this.cmbCategoryFilter.SelectionChangeCommitted += new System.EventHandler(this.cmbCategoryFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Category Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Provider Filter";
            // 
            // cmbProviderFilter
            // 
            this.cmbProviderFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProviderFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProviderFilter.FormattingEnabled = true;
            this.cmbProviderFilter.Location = new System.Drawing.Point(15, 48);
            this.cmbProviderFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProviderFilter.Name = "cmbProviderFilter";
            this.cmbProviderFilter.Size = new System.Drawing.Size(185, 24);
            this.cmbProviderFilter.TabIndex = 14;
            this.cmbProviderFilter.SelectionChangeCommitted += new System.EventHandler(this.cmbProviderFilter_SelectedIndexChanged);
            // 
            // createProducts
            // 
            this.createProducts.Location = new System.Drawing.Point(4, 25);
            this.createProducts.Name = "createProducts";
            this.createProducts.Padding = new System.Windows.Forms.Padding(3);
            this.createProducts.Size = new System.Drawing.Size(768, 397);
            this.createProducts.TabIndex = 1;
            this.createProducts.Text = "Create";
            this.createProducts.UseVisualStyleBackColor = true;
            // 
            // updateDeleteProducts
            // 
            this.updateDeleteProducts.Location = new System.Drawing.Point(4, 25);
            this.updateDeleteProducts.Name = "updateDeleteProducts";
            this.updateDeleteProducts.Padding = new System.Windows.Forms.Padding(3);
            this.updateDeleteProducts.Size = new System.Drawing.Size(768, 397);
            this.updateDeleteProducts.TabIndex = 2;
            this.updateDeleteProducts.Text = "Update/Delete";
            this.updateDeleteProducts.UseVisualStyleBackColor = true;
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
            this.productPriceChanges.Location = new System.Drawing.Point(4, 25);
            this.productPriceChanges.Name = "productPriceChanges";
            this.productPriceChanges.Padding = new System.Windows.Forms.Padding(3);
            this.productPriceChanges.Size = new System.Drawing.Size(768, 397);
            this.productPriceChanges.TabIndex = 3;
            this.productPriceChanges.Text = "Price Changes";
            this.productPriceChanges.UseVisualStyleBackColor = true;
            // 
            // btnOriginalPrice
            // 
            this.btnOriginalPrice.Enabled = false;
            this.btnOriginalPrice.Location = new System.Drawing.Point(161, 265);
            this.btnOriginalPrice.Name = "btnOriginalPrice";
            this.btnOriginalPrice.Size = new System.Drawing.Size(119, 45);
            this.btnOriginalPrice.TabIndex = 34;
            this.btnOriginalPrice.Text = "Revert to Initial Price";
            this.btnOriginalPrice.UseVisualStyleBackColor = true;
            this.btnOriginalPrice.Click += new System.EventHandler(this.btnOriginalPrice_Click);
            // 
            // txtCurrentPrice
            // 
            this.txtCurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPrice.Location = new System.Drawing.Point(17, 346);
            this.txtCurrentPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCurrentPrice.Name = "txtCurrentPrice";
            this.txtCurrentPrice.ReadOnly = true;
            this.txtCurrentPrice.Size = new System.Drawing.Size(263, 22);
            this.txtCurrentPrice.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Current Price";
            // 
            // txtReasonForChange
            // 
            this.txtReasonForChange.Location = new System.Drawing.Point(17, 173);
            this.txtReasonForChange.Multiline = true;
            this.txtReasonForChange.Name = "txtReasonForChange";
            this.txtReasonForChange.Size = new System.Drawing.Size(263, 76);
            this.txtReasonForChange.TabIndex = 31;
            this.txtReasonForChange.TextChanged += new System.EventHandler(this.txtReasonForChange_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 25);
            this.label9.TabIndex = 30;
            this.label9.Text = "Reason For Change";
            // 
            // nupUpdatedPrice
            // 
            this.nupUpdatedPrice.DecimalPlaces = 2;
            this.nupUpdatedPrice.Location = new System.Drawing.Point(16, 111);
            this.nupUpdatedPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupUpdatedPrice.Name = "nupUpdatedPrice";
            this.nupUpdatedPrice.Size = new System.Drawing.Size(264, 22);
            this.nupUpdatedPrice.TabIndex = 29;
            this.nupUpdatedPrice.ThousandsSeparator = true;
            this.nupUpdatedPrice.ValueChanged += new System.EventHandler(this.nupUpdatedPrice_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Updated Price";
            // 
            // btnSubmitPriceChange
            // 
            this.btnSubmitPriceChange.Enabled = false;
            this.btnSubmitPriceChange.Location = new System.Drawing.Point(15, 265);
            this.btnSubmitPriceChange.Name = "btnSubmitPriceChange";
            this.btnSubmitPriceChange.Size = new System.Drawing.Size(120, 45);
            this.btnSubmitPriceChange.TabIndex = 27;
            this.btnSubmitPriceChange.Text = "Submit Price Change";
            this.btnSubmitPriceChange.UseVisualStyleBackColor = true;
            this.btnSubmitPriceChange.Click += new System.EventHandler(this.btnSubmitPriceChange_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(294, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 25);
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
            this.dgvPriceChangeHistory.Location = new System.Drawing.Point(299, 48);
            this.dgvPriceChangeHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPriceChangeHistory.Name = "dgvPriceChangeHistory";
            this.dgvPriceChangeHistory.RowHeadersVisible = false;
            this.dgvPriceChangeHistory.RowHeadersWidth = 51;
            this.dgvPriceChangeHistory.RowTemplate.Height = 24;
            this.dgvPriceChangeHistory.Size = new System.Drawing.Size(459, 329);
            this.dgvPriceChangeHistory.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Product";
            // 
            // cmbProductPriceChange
            // 
            this.cmbProductPriceChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductPriceChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductPriceChange.FormattingEnabled = true;
            this.cmbProductPriceChange.Location = new System.Drawing.Point(15, 48);
            this.cmbProductPriceChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProductPriceChange.Name = "cmbProductPriceChange";
            this.cmbProductPriceChange.Size = new System.Drawing.Size(265, 24);
            this.cmbProductPriceChange.TabIndex = 6;
            this.cmbProductPriceChange.SelectionChangeCommitted += new System.EventHandler(this.cmbProductPriceChange_SelectedIndexChanged);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productsTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.productsTabControl.ResumeLayout(false);
            this.productView.ResumeLayout(false);
            this.productView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInformation)).EndInit();
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
    }
}