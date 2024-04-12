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
            this.SuspendLayout();
            // 
            // btnAdministration
            // 
            this.btnAdministration.Location = new System.Drawing.Point(147, 176);
            this.btnAdministration.Name = "btnAdministration";
            this.btnAdministration.Size = new System.Drawing.Size(151, 59);
            this.btnAdministration.TabIndex = 0;
            this.btnAdministration.Text = "Administration";
            this.btnAdministration.UseVisualStyleBackColor = true;
            this.btnAdministration.Click += new System.EventHandler(this.btnAdministration_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(371, 176);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(151, 59);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Online Store";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnAdministration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}

