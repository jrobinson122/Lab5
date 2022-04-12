
namespace Lab5
{
    partial class ShoeDisplay
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
            this.typeLbl = new System.Windows.Forms.Label();
            this.genderLbl = new System.Windows.Forms.Label();
            this.manufacturerLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.imageLbl = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.shoeDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.shoeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.typeLbl.Location = new System.Drawing.Point(39, 64);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(105, 37);
            this.typeLbl.TabIndex = 0;
            this.typeLbl.Text = "Type: ";
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.genderLbl.Location = new System.Drawing.Point(39, 152);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(123, 37);
            this.genderLbl.TabIndex = 1;
            this.genderLbl.Text = "Gender";
            this.genderLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // manufacturerLbl
            // 
            this.manufacturerLbl.AutoSize = true;
            this.manufacturerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.manufacturerLbl.Location = new System.Drawing.Point(39, 228);
            this.manufacturerLbl.Name = "manufacturerLbl";
            this.manufacturerLbl.Size = new System.Drawing.Size(206, 37);
            this.manufacturerLbl.TabIndex = 2;
            this.manufacturerLbl.Text = "Manufacturer";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.priceLbl.Location = new System.Drawing.Point(39, 308);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(89, 37);
            this.priceLbl.TabIndex = 3;
            this.priceLbl.Text = "Price";
            // 
            // imageLbl
            // 
            this.imageLbl.AutoSize = true;
            this.imageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.imageLbl.Location = new System.Drawing.Point(39, 394);
            this.imageLbl.Name = "imageLbl";
            this.imageLbl.Size = new System.Drawing.Size(105, 37);
            this.imageLbl.TabIndex = 4;
            this.imageLbl.Text = "Image";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(490, 360);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(351, 114);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete Shoe:  ";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // shoeDataGridView
            // 
            this.shoeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shoeDataGridView.Location = new System.Drawing.Point(553, 115);
            this.shoeDataGridView.Name = "shoeDataGridView";
            this.shoeDataGridView.RowHeadersWidth = 62;
            this.shoeDataGridView.RowTemplate.Height = 28;
            this.shoeDataGridView.Size = new System.Drawing.Size(240, 150);
            this.shoeDataGridView.TabIndex = 6;
            this.shoeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shoeDataGridView_CellContentClick);
            // 
            // ShoeDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 609);
            this.Controls.Add(this.shoeDataGridView);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.imageLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.manufacturerLbl);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.typeLbl);
            this.Name = "ShoeDisplay";
            this.Text = "ShoeDisplay";
            this.Load += new System.EventHandler(this.ShoeDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shoeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.Label manufacturerLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label imageLbl;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView shoeDataGridView;
    }
}