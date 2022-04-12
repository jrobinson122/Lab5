
namespace Lab5
{
    partial class ShoppingCart
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.customerInfoBox = new System.Windows.Forms.GroupBox();
            this.paymentInformationBox = new System.Windows.Forms.TextBox();
            this.typeOfPaymentBox = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.creditBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.billingInfoBox = new System.Windows.Forms.Label();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.numberLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.shoeDataSet1 = new Lab5.ShoeDataSet();
            this.emptyBtn = new System.Windows.Forms.Button();
            this.purchaseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.customerInfoBox.SuspendLayout();
            this.typeOfPaymentBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Price,
            this.Type,
            this.Image});
            this.dataGridView1.Location = new System.Drawing.Point(61, 532);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(812, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Manufacturer";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Gender";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.Width = 150;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.Width = 150;
            // 
            // Image
            // 
            this.Image.HeaderText = "Image";
            this.Image.MinimumWidth = 8;
            this.Image.Name = "Image";
            this.Image.Width = 150;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(576, 49);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(267, 57);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add Shoe To Shopping Cart: ";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(6, 78);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(190, 26);
            this.nameBox.TabIndex = 2;
            // 
            // customerInfoBox
            // 
            this.customerInfoBox.Controls.Add(this.paymentInformationBox);
            this.customerInfoBox.Controls.Add(this.typeOfPaymentBox);
            this.customerInfoBox.Controls.Add(this.label1);
            this.customerInfoBox.Controls.Add(this.billingInfoBox);
            this.customerInfoBox.Controls.Add(this.phoneNumberBox);
            this.customerInfoBox.Controls.Add(this.numberLbl);
            this.customerInfoBox.Controls.Add(this.nameLbl);
            this.customerInfoBox.Controls.Add(this.nameBox);
            this.customerInfoBox.Location = new System.Drawing.Point(12, 12);
            this.customerInfoBox.Name = "customerInfoBox";
            this.customerInfoBox.Size = new System.Drawing.Size(494, 510);
            this.customerInfoBox.TabIndex = 3;
            this.customerInfoBox.TabStop = false;
            this.customerInfoBox.Text = "Customer Information";
            // 
            // paymentInformationBox
            // 
            this.paymentInformationBox.Location = new System.Drawing.Point(11, 280);
            this.paymentInformationBox.Name = "paymentInformationBox";
            this.paymentInformationBox.Size = new System.Drawing.Size(190, 26);
            this.paymentInformationBox.TabIndex = 9;
            // 
            // typeOfPaymentBox
            // 
            this.typeOfPaymentBox.Controls.Add(this.radioButton2);
            this.typeOfPaymentBox.Controls.Add(this.creditBtn);
            this.typeOfPaymentBox.Location = new System.Drawing.Point(11, 382);
            this.typeOfPaymentBox.Name = "typeOfPaymentBox";
            this.typeOfPaymentBox.Size = new System.Drawing.Size(264, 132);
            this.typeOfPaymentBox.TabIndex = 8;
            this.typeOfPaymentBox.TabStop = false;
            this.typeOfPaymentBox.Text = "Type Of Payment";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 81);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Debit Card";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // creditBtn
            // 
            this.creditBtn.AutoSize = true;
            this.creditBtn.Location = new System.Drawing.Point(17, 38);
            this.creditBtn.Name = "creditBtn";
            this.creditBtn.Size = new System.Drawing.Size(114, 24);
            this.creditBtn.TabIndex = 0;
            this.creditBtn.TabStop = true;
            this.creditBtn.Text = "Credit Card";
            this.creditBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(6, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Payment Information";
            // 
            // billingInfoBox
            // 
            this.billingInfoBox.AutoSize = true;
            this.billingInfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.billingInfoBox.Location = new System.Drawing.Point(6, 229);
            this.billingInfoBox.Name = "billingInfoBox";
            this.billingInfoBox.Size = new System.Drawing.Size(205, 29);
            this.billingInfoBox.TabIndex = 6;
            this.billingInfoBox.Text = "Billing Information";
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(6, 166);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(190, 26);
            this.phoneNumberBox.TabIndex = 5;
            // 
            // numberLbl
            // 
            this.numberLbl.AutoSize = true;
            this.numberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numberLbl.Location = new System.Drawing.Point(6, 124);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(176, 29);
            this.numberLbl.TabIndex = 4;
            this.numberLbl.Text = "Phone Number";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameLbl.Location = new System.Drawing.Point(6, 37);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(78, 29);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Name";
            // 
            // shoeDataSet1
            // 
            this.shoeDataSet1.DataSetName = "ShoeDataSet";
            this.shoeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emptyBtn
            // 
            this.emptyBtn.Location = new System.Drawing.Point(576, 178);
            this.emptyBtn.Name = "emptyBtn";
            this.emptyBtn.Size = new System.Drawing.Size(248, 71);
            this.emptyBtn.TabIndex = 4;
            this.emptyBtn.Text = "Empty Shopping Cart";
            this.emptyBtn.UseVisualStyleBackColor = true;
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.Location = new System.Drawing.Point(576, 329);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Size = new System.Drawing.Size(248, 71);
            this.purchaseBtn.TabIndex = 5;
            this.purchaseBtn.Text = "Purchase Shopping Cart";
            this.purchaseBtn.UseVisualStyleBackColor = true;
            this.purchaseBtn.Click += new System.EventHandler(this.purchaseBtn_Click);
            // 
            // ShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 831);
            this.Controls.Add(this.purchaseBtn);
            this.Controls.Add(this.emptyBtn);
            this.Controls.Add(this.customerInfoBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShoppingCart";
            this.Text = "ShoppingCart";
            this.Load += new System.EventHandler(this.ShoppingCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.customerInfoBox.ResumeLayout(false);
            this.customerInfoBox.PerformLayout();
            this.typeOfPaymentBox.ResumeLayout(false);
            this.typeOfPaymentBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoeDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.GroupBox customerInfoBox;
        private System.Windows.Forms.TextBox paymentInformationBox;
        private System.Windows.Forms.GroupBox typeOfPaymentBox;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton creditBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label billingInfoBox;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.Label nameLbl;
        private ShoeDataSet shoeDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
        private System.Windows.Forms.Button emptyBtn;
        private System.Windows.Forms.Button purchaseBtn;
    }
}