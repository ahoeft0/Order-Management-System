namespace OnlineStore
{
    partial class Home
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
            this.btnAdministration = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProducts = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdministration
            // 
            this.btnAdministration.Location = new System.Drawing.Point(300, 220);
            this.btnAdministration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdministration.Name = "btnAdministration";
            this.btnAdministration.Size = new System.Drawing.Size(170, 74);
            this.btnAdministration.TabIndex = 0;
            this.btnAdministration.Text = "Administration";
            this.btnAdministration.UseVisualStyleBackColor = true;
            this.btnAdministration.Click += new System.EventHandler(this.btnAdministration_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(514, 220);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(170, 74);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Online Store";
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(84, 220);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(170, 74);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(77, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(607, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "By Ashton Hoeft and Noah Huesman";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 454);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnAdministration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdministration;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Label label2;
    }
}

