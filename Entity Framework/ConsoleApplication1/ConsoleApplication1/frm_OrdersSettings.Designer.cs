namespace ConsoleApplication1
{
    partial class frm_OrdersSettings
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
            System.Windows.Forms.Label customerNameLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label orderIdLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label categoryIdLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label productIdLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label unitsInStockLabel;
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.orderIdTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.categoryIdTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.unitsInStockTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_Anulowane = new System.Windows.Forms.RadioButton();
            this.RB_Zaplacone = new System.Windows.Forms.RadioButton();
            this.RB_Nowe = new System.Windows.Forms.RadioButton();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            customerNameLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            orderIdLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            companyNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            categoryIdLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            productIdLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            unitsInStockLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new System.Drawing.Point(223, 83);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(128, 20);
            customerNameLabel.TabIndex = 1;
            customerNameLabel.Text = "Customer Name:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(223, 116);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(48, 20);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Date:";
            // 
            // orderIdLabel
            // 
            orderIdLabel.AutoSize = true;
            orderIdLabel.Location = new System.Drawing.Point(223, 147);
            orderIdLabel.Name = "orderIdLabel";
            orderIdLabel.Size = new System.Drawing.Size(71, 20);
            orderIdLabel.TabIndex = 5;
            orderIdLabel.Text = "Order Id:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(223, 179);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(114, 20);
            productNameLabel.TabIndex = 7;
            productNameLabel.Text = "Product Name:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(223, 211);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(72, 20);
            quantityLabel.TabIndex = 9;
            quantityLabel.Text = "Quantity:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(223, 243);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(60, 20);
            statusLabel.TabIndex = 11;
            statusLabel.Text = "Status:";
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new System.Drawing.Point(223, 309);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(126, 20);
            companyNameLabel.TabIndex = 13;
            companyNameLabel.Text = "Company Name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(223, 341);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 15;
            descriptionLabel.Text = "Description:";
            // 
            // categoryIdLabel
            // 
            categoryIdLabel.AutoSize = true;
            categoryIdLabel.Location = new System.Drawing.Point(223, 407);
            categoryIdLabel.Name = "categoryIdLabel";
            categoryIdLabel.Size = new System.Drawing.Size(95, 20);
            categoryIdLabel.TabIndex = 17;
            categoryIdLabel.Text = "Category Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(223, 439);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 19;
            nameLabel.Text = "Name:";
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Location = new System.Drawing.Point(223, 471);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new System.Drawing.Size(86, 20);
            productIdLabel.TabIndex = 21;
            productIdLabel.Text = "Product Id:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(223, 503);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(81, 20);
            unitPriceLabel.TabIndex = 23;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // unitsInStockLabel
            // 
            unitsInStockLabel.AutoSize = true;
            unitsInStockLabel.Location = new System.Drawing.Point(223, 535);
            unitsInStockLabel.Name = "unitsInStockLabel";
            unitsInStockLabel.Size = new System.Drawing.Size(113, 20);
            unitsInStockLabel.TabIndex = 25;
            unitsInStockLabel.Text = "Units In Stock:";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(ConsoleApplication1.Order);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "CustomerName", true));
            this.customerNameTextBox.Location = new System.Drawing.Point(357, 80);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(200, 26);
            this.customerNameTextBox.TabIndex = 2;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(357, 112);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dateDateTimePicker.TabIndex = 4;
            // 
            // orderIdTextBox
            // 
            this.orderIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderId", true));
            this.orderIdTextBox.Location = new System.Drawing.Point(357, 144);
            this.orderIdTextBox.Name = "orderIdTextBox";
            this.orderIdTextBox.Size = new System.Drawing.Size(200, 26);
            this.orderIdTextBox.TabIndex = 6;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "ProductName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(357, 176);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(200, 26);
            this.productNameTextBox.TabIndex = 8;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(357, 208);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(200, 26);
            this.quantityTextBox.TabIndex = 10;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(357, 240);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(200, 26);
            this.statusTextBox.TabIndex = 12;
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Customer.CompanyName", true));
            this.companyNameTextBox.Location = new System.Drawing.Point(355, 306);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.companyNameTextBox.TabIndex = 14;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Customer.Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(355, 338);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 26);
            this.descriptionTextBox.TabIndex = 16;
            // 
            // categoryIdTextBox
            // 
            this.categoryIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Product.CategoryId", true));
            this.categoryIdTextBox.Location = new System.Drawing.Point(342, 404);
            this.categoryIdTextBox.Name = "categoryIdTextBox";
            this.categoryIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.categoryIdTextBox.TabIndex = 18;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Product.Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(342, 436);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 26);
            this.nameTextBox.TabIndex = 20;
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Product.ProductId", true));
            this.productIdTextBox.Location = new System.Drawing.Point(342, 468);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.productIdTextBox.TabIndex = 22;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Product.UnitPrice", true));
            this.unitPriceTextBox.Location = new System.Drawing.Point(342, 500);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(100, 26);
            this.unitPriceTextBox.TabIndex = 24;
            // 
            // unitsInStockTextBox
            // 
            this.unitsInStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Product.UnitsInStock", true));
            this.unitsInStockTextBox.Location = new System.Drawing.Point(342, 532);
            this.unitsInStockTextBox.Name = "unitsInStockTextBox";
            this.unitsInStockTextBox.Size = new System.Drawing.Size(100, 26);
            this.unitsInStockTextBox.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_Anulowane);
            this.groupBox1.Controls.Add(this.RB_Zaplacone);
            this.groupBox1.Controls.Add(this.RB_Nowe);
            this.groupBox1.Location = new System.Drawing.Point(674, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 172);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // RB_Anulowane
            // 
            this.RB_Anulowane.AutoSize = true;
            this.RB_Anulowane.Location = new System.Drawing.Point(22, 122);
            this.RB_Anulowane.Name = "RB_Anulowane";
            this.RB_Anulowane.Size = new System.Drawing.Size(113, 24);
            this.RB_Anulowane.TabIndex = 2;
            this.RB_Anulowane.TabStop = true;
            this.RB_Anulowane.Text = "Anulowane";
            this.RB_Anulowane.UseVisualStyleBackColor = true;
            // 
            // RB_Zaplacone
            // 
            this.RB_Zaplacone.AutoSize = true;
            this.RB_Zaplacone.Location = new System.Drawing.Point(22, 79);
            this.RB_Zaplacone.Name = "RB_Zaplacone";
            this.RB_Zaplacone.Size = new System.Drawing.Size(110, 24);
            this.RB_Zaplacone.TabIndex = 1;
            this.RB_Zaplacone.TabStop = true;
            this.RB_Zaplacone.Text = "Zapłacone";
            this.RB_Zaplacone.UseVisualStyleBackColor = true;
            // 
            // RB_Nowe
            // 
            this.RB_Nowe.AutoSize = true;
            this.RB_Nowe.Location = new System.Drawing.Point(22, 38);
            this.RB_Nowe.Name = "RB_Nowe";
            this.RB_Nowe.Size = new System.Drawing.Size(74, 24);
            this.RB_Nowe.TabIndex = 0;
            this.RB_Nowe.TabStop = true;
            this.RB_Nowe.Text = "Nowe";
            this.RB_Nowe.UseVisualStyleBackColor = true;
            // 
            // btOK
            // 
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Location = new System.Drawing.Point(551, 555);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(173, 53);
            this.btOK.TabIndex = 29;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(756, 555);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(173, 53);
            this.btCancel.TabIndex = 28;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // frm_OrdersSettings
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(982, 693);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(categoryIdLabel);
            this.Controls.Add(this.categoryIdTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(productIdLabel);
            this.Controls.Add(this.productIdTextBox);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(unitsInStockLabel);
            this.Controls.Add(this.unitsInStockTextBox);
            this.Controls.Add(companyNameLabel);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(customerNameLabel);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(orderIdLabel);
            this.Controls.Add(this.orderIdTextBox);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Name = "frm_OrdersSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_Orders";
            this.Load += new System.EventHandler(this.frm_Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox orderIdTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox categoryIdTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox unitsInStockTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_Nowe;
        private System.Windows.Forms.RadioButton RB_Anulowane;
        private System.Windows.Forms.RadioButton RB_Zaplacone;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
    }
}