namespace SomerenUI
{
    partial class NewForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.newDrinkNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newDrinkName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newDrinkType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newStockAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newStocksSold = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDrinkNum = new System.Windows.Forms.TextBox();
            this.txtDrinkName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDrinkType = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtSold = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.newDrinkNumber,
            this.newDrinkName,
            this.newPrice,
            this.newDrinkType,
            this.newStockAmount,
            this.newStocksSold});
            this.listView1.Location = new System.Drawing.Point(32, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(801, 446);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // newDrinkNumber
            // 
            this.newDrinkNumber.Text = "Drink Number";
            this.newDrinkNumber.Width = 110;
            // 
            // newDrinkName
            // 
            this.newDrinkName.Text = "Drink Name";
            this.newDrinkName.Width = 110;
            // 
            // newPrice
            // 
            this.newPrice.Text = "Price";
            this.newPrice.Width = 90;
            // 
            // newDrinkType
            // 
            this.newDrinkType.Text = "Drink Type ";
            this.newDrinkType.Width = 105;
            // 
            // newStockAmount
            // 
            this.newStockAmount.Text = "Stock Amount";
            this.newStockAmount.Width = 105;
            // 
            // newStocksSold
            // 
            this.newStocksSold.Text = "Stocks Sold";
            this.newStocksSold.Width = 105;
            // 
            // txtDrinkNum
            // 
            this.txtDrinkNum.Location = new System.Drawing.Point(46, 90);
            this.txtDrinkNum.Name = "txtDrinkNum";
            this.txtDrinkNum.Size = new System.Drawing.Size(97, 22);
            this.txtDrinkNum.TabIndex = 1;
            // 
            // txtDrinkName
            // 
            this.txtDrinkName.Location = new System.Drawing.Point(198, 90);
            this.txtDrinkName.Name = "txtDrinkName";
            this.txtDrinkName.Size = new System.Drawing.Size(97, 22);
            this.txtDrinkName.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(333, 90);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(97, 22);
            this.txtPrice.TabIndex = 3;
            // 
            // txtDrinkType
            // 
            this.txtDrinkType.Location = new System.Drawing.Point(455, 90);
            this.txtDrinkType.Name = "txtDrinkType";
            this.txtDrinkType.Size = new System.Drawing.Size(97, 22);
            this.txtDrinkType.TabIndex = 4;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(589, 90);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(97, 22);
            this.txtStock.TabIndex = 5;
            // 
            // txtSold
            // 
            this.txtSold.Location = new System.Drawing.Point(722, 90);
            this.txtSold.Name = "txtSold";
            this.txtSold.Size = new System.Drawing.Size(97, 22);
            this.txtSold.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(358, 155);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 49);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 533);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtSold);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtDrinkType);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDrinkName);
            this.Controls.Add(this.txtDrinkNum);
            this.Controls.Add(this.listView1);
            this.Name = "NewForm";
            this.Text = "Create New Drinks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader newDrinkNumber;
        private System.Windows.Forms.ColumnHeader newDrinkName;
        private System.Windows.Forms.ColumnHeader newPrice;
        private System.Windows.Forms.ColumnHeader newDrinkType;
        private System.Windows.Forms.ColumnHeader newStockAmount;
        private System.Windows.Forms.ColumnHeader newStocksSold;
        private System.Windows.Forms.TextBox txtDrinkNum;
        private System.Windows.Forms.TextBox txtDrinkName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDrinkType;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtSold;
        private System.Windows.Forms.Button btnSubmit;
    }
}