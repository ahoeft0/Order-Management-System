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
            this.ordersTabControl = new System.Windows.Forms.TabControl();
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
            this.updateDeleteOrders = new System.Windows.Forms.TabPage();
            this.ordersTabControl.SuspendLayout();
            this.viewOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersTabControl
            // 
            this.ordersTabControl.Controls.Add(this.viewOrders);
            this.ordersTabControl.Controls.Add(this.createOrders);
            this.ordersTabControl.Controls.Add(this.updateDeleteOrders);
            this.ordersTabControl.Location = new System.Drawing.Point(12, 12);
            this.ordersTabControl.Name = "ordersTabControl";
            this.ordersTabControl.SelectedIndex = 0;
            this.ordersTabControl.Size = new System.Drawing.Size(776, 426);
            this.ordersTabControl.TabIndex = 0;
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
            this.viewOrders.Location = new System.Drawing.Point(4, 25);
            this.viewOrders.Name = "viewOrders";
            this.viewOrders.Padding = new System.Windows.Forms.Padding(3);
            this.viewOrders.Size = new System.Drawing.Size(768, 397);
            this.viewOrders.TabIndex = 0;
            this.viewOrders.Text = "View";
            this.viewOrders.UseVisualStyleBackColor = true;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(21, 269);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(173, 22);
            this.txtTotalPrice.TabIndex = 13;
            // 
            // txtDateOrdered
            // 
            this.txtDateOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateOrdered.Location = new System.Drawing.Point(21, 328);
            this.txtDateOrdered.Name = "txtDateOrdered";
            this.txtDateOrdered.ReadOnly = true;
            this.txtDateOrdered.Size = new System.Drawing.Size(173, 22);
            this.txtDateOrdered.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date Ordered";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNumber.Location = new System.Drawing.Point(21, 205);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.ReadOnly = true;
            this.txtOrderNumber.Size = new System.Drawing.Size(173, 22);
            this.txtOrderNumber.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Order Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
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
            this.dgvOrderInformation.Location = new System.Drawing.Point(258, 44);
            this.dgvOrderInformation.Name = "dgvOrderInformation";
            this.dgvOrderInformation.RowHeadersVisible = false;
            this.dgvOrderInformation.RowHeadersWidth = 51;
            this.dgvOrderInformation.RowTemplate.Height = 24;
            this.dgvOrderInformation.Size = new System.Drawing.Size(493, 329);
            this.dgvOrderInformation.TabIndex = 4;
            // 
            // cmbOrder
            // 
            this.cmbOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(21, 123);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(186, 24);
            this.cmbOrder.TabIndex = 3;
            this.cmbOrder.SelectionChangeCommitted += new System.EventHandler(this.cmbOrder_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(19, 44);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(186, 24);
            this.cmbCustomer.TabIndex = 0;
            this.cmbCustomer.SelectionChangeCommitted += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // createOrders
            // 
            this.createOrders.Location = new System.Drawing.Point(4, 25);
            this.createOrders.Name = "createOrders";
            this.createOrders.Padding = new System.Windows.Forms.Padding(3);
            this.createOrders.Size = new System.Drawing.Size(768, 397);
            this.createOrders.TabIndex = 1;
            this.createOrders.Text = "Create";
            this.createOrders.UseVisualStyleBackColor = true;
            // 
            // updateDeleteOrders
            // 
            this.updateDeleteOrders.Location = new System.Drawing.Point(4, 25);
            this.updateDeleteOrders.Name = "updateDeleteOrders";
            this.updateDeleteOrders.Size = new System.Drawing.Size(768, 397);
            this.updateDeleteOrders.TabIndex = 2;
            this.updateDeleteOrders.Text = "Update/Delete";
            this.updateDeleteOrders.UseVisualStyleBackColor = true;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ordersTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.ordersTabControl.ResumeLayout(false);
            this.viewOrders.ResumeLayout(false);
            this.viewOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ordersTabControl;
        private System.Windows.Forms.TabPage viewOrders;
        private System.Windows.Forms.TabPage createOrders;
        private System.Windows.Forms.TabPage updateDeleteOrders;
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
    }
}