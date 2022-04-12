
namespace Lab5
{
    partial class ShoeForm
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
            this.shoeTypeBox = new System.Windows.Forms.GroupBox();
            this.casualBtn = new System.Windows.Forms.RadioButton();
            this.basketballBtn = new System.Windows.Forms.RadioButton();
            this.dressBtn = new System.Windows.Forms.RadioButton();
            this.runningBtn = new System.Windows.Forms.RadioButton();
            this.hikingBtn = new System.Windows.Forms.RadioButton();
            this.genderBox = new System.Windows.Forms.GroupBox();
            this.unisexBtn = new System.Windows.Forms.RadioButton();
            this.femaleBtn = new System.Windows.Forms.RadioButton();
            this.maleBtn = new System.Windows.Forms.RadioButton();
            this.manufacturerBox = new System.Windows.Forms.GroupBox();
            this.vansBtn = new System.Windows.Forms.RadioButton();
            this.poloBtn = new System.Windows.Forms.RadioButton();
            this.hokaBtn = new System.Windows.Forms.RadioButton();
            this.adidasBtn = new System.Windows.Forms.RadioButton();
            this.nikeBtn = new System.Windows.Forms.RadioButton();
            this.genderBtn = new System.Windows.Forms.Button();
            this.typeBtn = new System.Windows.Forms.Button();
            this.storeBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.imageComboBox = new System.Windows.Forms.ComboBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.priceBox = new System.Windows.Forms.GroupBox();
            this.expensiveBtn = new System.Windows.Forms.RadioButton();
            this.expensiveMiddleBtn = new System.Windows.Forms.RadioButton();
            this.cheapMiddleBtn = new System.Windows.Forms.RadioButton();
            this.cheapBtn = new System.Windows.Forms.RadioButton();
            this.shoeTypeBox.SuspendLayout();
            this.genderBox.SuspendLayout();
            this.manufacturerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.priceBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // shoeTypeBox
            // 
            this.shoeTypeBox.Controls.Add(this.casualBtn);
            this.shoeTypeBox.Controls.Add(this.basketballBtn);
            this.shoeTypeBox.Controls.Add(this.dressBtn);
            this.shoeTypeBox.Controls.Add(this.runningBtn);
            this.shoeTypeBox.Controls.Add(this.hikingBtn);
            this.shoeTypeBox.Location = new System.Drawing.Point(12, 12);
            this.shoeTypeBox.Name = "shoeTypeBox";
            this.shoeTypeBox.Size = new System.Drawing.Size(197, 253);
            this.shoeTypeBox.TabIndex = 0;
            this.shoeTypeBox.TabStop = false;
            this.shoeTypeBox.Text = "Shoe Type";
            this.shoeTypeBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // casualBtn
            // 
            this.casualBtn.AutoSize = true;
            this.casualBtn.Location = new System.Drawing.Point(0, 145);
            this.casualBtn.Name = "casualBtn";
            this.casualBtn.Size = new System.Drawing.Size(83, 24);
            this.casualBtn.TabIndex = 7;
            this.casualBtn.TabStop = true;
            this.casualBtn.Text = "Casual";
            this.casualBtn.UseVisualStyleBackColor = true;
            // 
            // basketballBtn
            // 
            this.basketballBtn.AutoSize = true;
            this.basketballBtn.Location = new System.Drawing.Point(0, 25);
            this.basketballBtn.Name = "basketballBtn";
            this.basketballBtn.Size = new System.Drawing.Size(108, 24);
            this.basketballBtn.TabIndex = 3;
            this.basketballBtn.TabStop = true;
            this.basketballBtn.Text = "Basketball";
            this.basketballBtn.UseVisualStyleBackColor = true;
            this.basketballBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dressBtn
            // 
            this.dressBtn.AutoSize = true;
            this.dressBtn.Location = new System.Drawing.Point(0, 115);
            this.dressBtn.Name = "dressBtn";
            this.dressBtn.Size = new System.Drawing.Size(76, 24);
            this.dressBtn.TabIndex = 6;
            this.dressBtn.TabStop = true;
            this.dressBtn.Text = "Dress";
            this.dressBtn.UseVisualStyleBackColor = true;
            // 
            // runningBtn
            // 
            this.runningBtn.AutoSize = true;
            this.runningBtn.Location = new System.Drawing.Point(0, 55);
            this.runningBtn.Name = "runningBtn";
            this.runningBtn.Size = new System.Drawing.Size(94, 24);
            this.runningBtn.TabIndex = 4;
            this.runningBtn.TabStop = true;
            this.runningBtn.Text = "Running";
            this.runningBtn.UseVisualStyleBackColor = true;
            // 
            // hikingBtn
            // 
            this.hikingBtn.AutoSize = true;
            this.hikingBtn.Location = new System.Drawing.Point(0, 85);
            this.hikingBtn.Name = "hikingBtn";
            this.hikingBtn.Size = new System.Drawing.Size(78, 24);
            this.hikingBtn.TabIndex = 5;
            this.hikingBtn.TabStop = true;
            this.hikingBtn.Text = "Hiking";
            this.hikingBtn.UseVisualStyleBackColor = true;
            // 
            // genderBox
            // 
            this.genderBox.Controls.Add(this.unisexBtn);
            this.genderBox.Controls.Add(this.femaleBtn);
            this.genderBox.Controls.Add(this.maleBtn);
            this.genderBox.Location = new System.Drawing.Point(235, 12);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(197, 253);
            this.genderBox.TabIndex = 1;
            this.genderBox.TabStop = false;
            this.genderBox.Text = "Gender";
            // 
            // unisexBtn
            // 
            this.unisexBtn.AutoSize = true;
            this.unisexBtn.Location = new System.Drawing.Point(6, 132);
            this.unisexBtn.Name = "unisexBtn";
            this.unisexBtn.Size = new System.Drawing.Size(82, 24);
            this.unisexBtn.TabIndex = 10;
            this.unisexBtn.TabStop = true;
            this.unisexBtn.Text = "Unisex";
            this.unisexBtn.UseVisualStyleBackColor = true;
            // 
            // femaleBtn
            // 
            this.femaleBtn.AutoSize = true;
            this.femaleBtn.Location = new System.Drawing.Point(6, 85);
            this.femaleBtn.Name = "femaleBtn";
            this.femaleBtn.Size = new System.Drawing.Size(87, 24);
            this.femaleBtn.TabIndex = 9;
            this.femaleBtn.TabStop = true;
            this.femaleBtn.Text = "Female";
            this.femaleBtn.UseVisualStyleBackColor = true;
            // 
            // maleBtn
            // 
            this.maleBtn.AutoSize = true;
            this.maleBtn.Location = new System.Drawing.Point(6, 36);
            this.maleBtn.Name = "maleBtn";
            this.maleBtn.Size = new System.Drawing.Size(68, 24);
            this.maleBtn.TabIndex = 8;
            this.maleBtn.TabStop = true;
            this.maleBtn.Text = "Male";
            this.maleBtn.UseVisualStyleBackColor = true;
            // 
            // manufacturerBox
            // 
            this.manufacturerBox.Controls.Add(this.vansBtn);
            this.manufacturerBox.Controls.Add(this.poloBtn);
            this.manufacturerBox.Controls.Add(this.hokaBtn);
            this.manufacturerBox.Controls.Add(this.adidasBtn);
            this.manufacturerBox.Controls.Add(this.nikeBtn);
            this.manufacturerBox.Location = new System.Drawing.Point(483, 12);
            this.manufacturerBox.Name = "manufacturerBox";
            this.manufacturerBox.Size = new System.Drawing.Size(197, 253);
            this.manufacturerBox.TabIndex = 1;
            this.manufacturerBox.TabStop = false;
            this.manufacturerBox.Text = "Manufacturer";
            // 
            // vansBtn
            // 
            this.vansBtn.AutoSize = true;
            this.vansBtn.Location = new System.Drawing.Point(6, 223);
            this.vansBtn.Name = "vansBtn";
            this.vansBtn.Size = new System.Drawing.Size(71, 24);
            this.vansBtn.TabIndex = 15;
            this.vansBtn.TabStop = true;
            this.vansBtn.Text = "Vans";
            this.vansBtn.UseVisualStyleBackColor = true;
            // 
            // poloBtn
            // 
            this.poloBtn.AutoSize = true;
            this.poloBtn.Location = new System.Drawing.Point(6, 177);
            this.poloBtn.Name = "poloBtn";
            this.poloBtn.Size = new System.Drawing.Size(65, 24);
            this.poloBtn.TabIndex = 14;
            this.poloBtn.TabStop = true;
            this.poloBtn.Text = "Polo";
            this.poloBtn.UseVisualStyleBackColor = true;
            this.poloBtn.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // hokaBtn
            // 
            this.hokaBtn.AutoSize = true;
            this.hokaBtn.Location = new System.Drawing.Point(6, 132);
            this.hokaBtn.Name = "hokaBtn";
            this.hokaBtn.Size = new System.Drawing.Size(72, 24);
            this.hokaBtn.TabIndex = 13;
            this.hokaBtn.TabStop = true;
            this.hokaBtn.Text = "Hoka";
            this.hokaBtn.UseVisualStyleBackColor = true;
            // 
            // adidasBtn
            // 
            this.adidasBtn.AutoSize = true;
            this.adidasBtn.Location = new System.Drawing.Point(6, 85);
            this.adidasBtn.Name = "adidasBtn";
            this.adidasBtn.Size = new System.Drawing.Size(83, 24);
            this.adidasBtn.TabIndex = 12;
            this.adidasBtn.TabStop = true;
            this.adidasBtn.Text = "Adidas";
            this.adidasBtn.UseVisualStyleBackColor = true;
            // 
            // nikeBtn
            // 
            this.nikeBtn.AutoSize = true;
            this.nikeBtn.Location = new System.Drawing.Point(6, 36);
            this.nikeBtn.Name = "nikeBtn";
            this.nikeBtn.Size = new System.Drawing.Size(65, 24);
            this.nikeBtn.TabIndex = 11;
            this.nikeBtn.TabStop = true;
            this.nikeBtn.Text = "Nike";
            this.nikeBtn.UseVisualStyleBackColor = true;
            // 
            // genderBtn
            // 
            this.genderBtn.Location = new System.Drawing.Point(12, 384);
            this.genderBtn.Name = "genderBtn";
            this.genderBtn.Size = new System.Drawing.Size(295, 52);
            this.genderBtn.TabIndex = 4;
            this.genderBtn.Text = "Search By Gender";
            this.genderBtn.UseVisualStyleBackColor = true;
            this.genderBtn.Click += new System.EventHandler(this.genderBtn_Click);
            // 
            // typeBtn
            // 
            this.typeBtn.Location = new System.Drawing.Point(12, 466);
            this.typeBtn.Name = "typeBtn";
            this.typeBtn.Size = new System.Drawing.Size(295, 52);
            this.typeBtn.TabIndex = 5;
            this.typeBtn.Text = "Search By Type";
            this.typeBtn.UseVisualStyleBackColor = true;
            this.typeBtn.Click += new System.EventHandler(this.typeBtn_Click);
            // 
            // storeBtn
            // 
            this.storeBtn.Location = new System.Drawing.Point(14, 564);
            this.storeBtn.Name = "storeBtn";
            this.storeBtn.Size = new System.Drawing.Size(295, 52);
            this.storeBtn.TabIndex = 6;
            this.storeBtn.Text = "Store Shoe";
            this.storeBtn.UseVisualStyleBackColor = true;
            this.storeBtn.Click += new System.EventHandler(this.storeBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(12, 644);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(295, 52);
            this.viewBtn.TabIndex = 7;
            this.viewBtn.Text = "View Shoe";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(399, 368);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(240, 150);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // imageComboBox
            // 
            this.imageComboBox.FormattingEnabled = true;
            this.imageComboBox.Items.AddRange(new object[] {
            "basketabll.jpg",
            "casual.jpg",
            "running.jpg",
            "hiking.jpg",
            "dress.jpg"});
            this.imageComboBox.Location = new System.Drawing.Point(14, 272);
            this.imageComboBox.Name = "imageComboBox";
            this.imageComboBox.Size = new System.Drawing.Size(121, 28);
            this.imageComboBox.TabIndex = 9;
            this.imageComboBox.SelectedIndexChanged += new System.EventHandler(this.imageComboBox_SelectedIndexChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(374, 564);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(295, 52);
            this.updateBtn.TabIndex = 10;
            this.updateBtn.Text = "Update Shoe: ";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(364, 644);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(295, 52);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Add To Cart";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(704, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 52);
            this.button1.TabIndex = 12;
            this.button1.Text = "Update Shoe: ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(704, 644);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(295, 52);
            this.confirmBtn.TabIndex = 13;
            this.confirmBtn.Text = "Confirm Shoe: ";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // priceBox
            // 
            this.priceBox.Controls.Add(this.expensiveBtn);
            this.priceBox.Controls.Add(this.expensiveMiddleBtn);
            this.priceBox.Controls.Add(this.cheapMiddleBtn);
            this.priceBox.Controls.Add(this.cheapBtn);
            this.priceBox.Location = new System.Drawing.Point(719, 22);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(197, 253);
            this.priceBox.TabIndex = 16;
            this.priceBox.TabStop = false;
            this.priceBox.Text = "Price";
            // 
            // expensiveBtn
            // 
            this.expensiveBtn.AutoSize = true;
            this.expensiveBtn.Location = new System.Drawing.Point(6, 177);
            this.expensiveBtn.Name = "expensiveBtn";
            this.expensiveBtn.Size = new System.Drawing.Size(93, 24);
            this.expensiveBtn.TabIndex = 14;
            this.expensiveBtn.TabStop = true;
            this.expensiveBtn.Text = "200-250";
            this.expensiveBtn.UseVisualStyleBackColor = true;
            // 
            // expensiveMiddleBtn
            // 
            this.expensiveMiddleBtn.AutoSize = true;
            this.expensiveMiddleBtn.Location = new System.Drawing.Point(6, 132);
            this.expensiveMiddleBtn.Name = "expensiveMiddleBtn";
            this.expensiveMiddleBtn.Size = new System.Drawing.Size(93, 24);
            this.expensiveMiddleBtn.TabIndex = 13;
            this.expensiveMiddleBtn.TabStop = true;
            this.expensiveMiddleBtn.Text = "150-200";
            this.expensiveMiddleBtn.UseVisualStyleBackColor = true;
            // 
            // cheapMiddleBtn
            // 
            this.cheapMiddleBtn.AutoSize = true;
            this.cheapMiddleBtn.Location = new System.Drawing.Point(6, 85);
            this.cheapMiddleBtn.Name = "cheapMiddleBtn";
            this.cheapMiddleBtn.Size = new System.Drawing.Size(93, 24);
            this.cheapMiddleBtn.TabIndex = 12;
            this.cheapMiddleBtn.TabStop = true;
            this.cheapMiddleBtn.Text = "100-150";
            this.cheapMiddleBtn.UseVisualStyleBackColor = true;
            // 
            // cheapBtn
            // 
            this.cheapBtn.AutoSize = true;
            this.cheapBtn.Location = new System.Drawing.Point(6, 36);
            this.cheapBtn.Name = "cheapBtn";
            this.cheapBtn.Size = new System.Drawing.Size(84, 24);
            this.cheapBtn.TabIndex = 11;
            this.cheapBtn.TabStop = true;
            this.cheapBtn.Text = "50-100";
            this.cheapBtn.UseVisualStyleBackColor = true;
            // 
            // ShoeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 770);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.imageComboBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.storeBtn);
            this.Controls.Add(this.typeBtn);
            this.Controls.Add(this.genderBtn);
            this.Controls.Add(this.manufacturerBox);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.shoeTypeBox);
            this.Name = "ShoeForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.shoeTypeBox.ResumeLayout(false);
            this.shoeTypeBox.PerformLayout();
            this.genderBox.ResumeLayout(false);
            this.genderBox.PerformLayout();
            this.manufacturerBox.ResumeLayout(false);
            this.manufacturerBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.priceBox.ResumeLayout(false);
            this.priceBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox shoeTypeBox;
        private System.Windows.Forms.GroupBox genderBox;
        private System.Windows.Forms.GroupBox manufacturerBox;
        private System.Windows.Forms.RadioButton basketballBtn;
        private System.Windows.Forms.RadioButton runningBtn;
        private System.Windows.Forms.RadioButton hikingBtn;
        private System.Windows.Forms.RadioButton dressBtn;
        private System.Windows.Forms.RadioButton casualBtn;
        private System.Windows.Forms.RadioButton unisexBtn;
        private System.Windows.Forms.RadioButton femaleBtn;
        private System.Windows.Forms.RadioButton maleBtn;
        private System.Windows.Forms.RadioButton vansBtn;
        private System.Windows.Forms.RadioButton poloBtn;
        private System.Windows.Forms.RadioButton hokaBtn;
        private System.Windows.Forms.RadioButton adidasBtn;
        private System.Windows.Forms.RadioButton nikeBtn;
        private System.Windows.Forms.Button genderBtn;
        private System.Windows.Forms.Button typeBtn;
        private System.Windows.Forms.Button storeBtn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.DataGridView shoeDataGridView;
        private System.Windows.Forms.ComboBox imageComboBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.GroupBox priceBox;
        private System.Windows.Forms.RadioButton expensiveBtn;
        private System.Windows.Forms.RadioButton expensiveMiddleBtn;
        private System.Windows.Forms.RadioButton cheapMiddleBtn;
        private System.Windows.Forms.RadioButton cheapBtn;
    }
}

