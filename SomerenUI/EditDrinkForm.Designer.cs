namespace SomerenUI
{
    partial class EditDrinkForm
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
            this.listViewSelectDrink = new System.Windows.Forms.ListView();
            this.editDrinkNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editDrinkName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editDrinkType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editSold = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtEditNumber = new System.Windows.Forms.TextBox();
            this.txtEditSold = new System.Windows.Forms.TextBox();
            this.txtEditStock = new System.Windows.Forms.TextBox();
            this.txtEditType = new System.Windows.Forms.TextBox();
            this.txtEditPrice = new System.Windows.Forms.TextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.btnSaveDrink = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewSelectDrink
            // 
            this.listViewSelectDrink.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.editDrinkNumber,
            this.editDrinkName,
            this.editPrice,
            this.editDrinkType,
            this.editStock,
            this.editSold});
            this.listViewSelectDrink.Location = new System.Drawing.Point(35, 41);
            this.listViewSelectDrink.Name = "listViewSelectDrink";
            this.listViewSelectDrink.Size = new System.Drawing.Size(821, 234);
            this.listViewSelectDrink.TabIndex = 0;
            this.listViewSelectDrink.UseCompatibleStateImageBehavior = false;
            this.listViewSelectDrink.View = System.Windows.Forms.View.Details;
            this.listViewSelectDrink.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // editDrinkNumber
            // 
            this.editDrinkNumber.Text = "Drink Number ";
            this.editDrinkNumber.Width = 105;
            // 
            // editDrinkName
            // 
            this.editDrinkName.Text = "Drink Name";
            this.editDrinkName.Width = 105;
            // 
            // editPrice
            // 
            this.editPrice.Text = "Price";
            this.editPrice.Width = 90;
            // 
            // editDrinkType
            // 
            this.editDrinkType.Text = "Drink Type";
            this.editDrinkType.Width = 105;
            // 
            // editStock
            // 
            this.editStock.Text = "Amount of Stock";
            this.editStock.Width = 105;
            // 
            // editSold
            // 
            this.editSold.Text = "Drinks Sold";
            this.editSold.Width = 105;
            // 
            // txtEditNumber
            // 
            this.txtEditNumber.Location = new System.Drawing.Point(44, 76);
            this.txtEditNumber.Name = "txtEditNumber";
            this.txtEditNumber.ReadOnly = true;
            this.txtEditNumber.Size = new System.Drawing.Size(86, 22);
            this.txtEditNumber.TabIndex = 1;
            // 
            // txtEditSold
            // 
            this.txtEditSold.Location = new System.Drawing.Point(720, 76);
            this.txtEditSold.Name = "txtEditSold";
            this.txtEditSold.Size = new System.Drawing.Size(86, 22);
            this.txtEditSold.TabIndex = 2;
            // 
            // txtEditStock
            // 
            this.txtEditStock.Location = new System.Drawing.Point(594, 76);
            this.txtEditStock.Name = "txtEditStock";
            this.txtEditStock.Size = new System.Drawing.Size(86, 22);
            this.txtEditStock.TabIndex = 3;
            // 
            // txtEditType
            // 
            this.txtEditType.Location = new System.Drawing.Point(457, 76);
            this.txtEditType.Name = "txtEditType";
            this.txtEditType.Size = new System.Drawing.Size(86, 22);
            this.txtEditType.TabIndex = 4;
            // 
            // txtEditPrice
            // 
            this.txtEditPrice.Location = new System.Drawing.Point(336, 76);
            this.txtEditPrice.Name = "txtEditPrice";
            this.txtEditPrice.Size = new System.Drawing.Size(86, 22);
            this.txtEditPrice.TabIndex = 5;
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(199, 76);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(86, 22);
            this.txtEditName.TabIndex = 6;
            // 
            // btnSaveDrink
            // 
            this.btnSaveDrink.Location = new System.Drawing.Point(203, 295);
            this.btnSaveDrink.Name = "btnSaveDrink";
            this.btnSaveDrink.Size = new System.Drawing.Size(219, 69);
            this.btnSaveDrink.TabIndex = 7;
            this.btnSaveDrink.Text = "Save Drink";
            this.btnSaveDrink.UseVisualStyleBackColor = true;
            this.btnSaveDrink.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(503, 295);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(219, 69);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove Drink";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // EditDrinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 515);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSaveDrink);
            this.Controls.Add(this.txtEditName);
            this.Controls.Add(this.txtEditPrice);
            this.Controls.Add(this.txtEditType);
            this.Controls.Add(this.txtEditStock);
            this.Controls.Add(this.txtEditSold);
            this.Controls.Add(this.txtEditNumber);
            this.Controls.Add(this.listViewSelectDrink);
            this.Name = "EditDrinkForm";
            this.Text = "Edit/Remove Drink";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSelectDrink;
        private System.Windows.Forms.ColumnHeader editDrinkNumber;
        private System.Windows.Forms.TextBox txtEditNumber;
        private System.Windows.Forms.ColumnHeader editDrinkName;
        private System.Windows.Forms.ColumnHeader editPrice;
        private System.Windows.Forms.ColumnHeader editDrinkType;
        private System.Windows.Forms.ColumnHeader editStock;
        private System.Windows.Forms.ColumnHeader editSold;
        private System.Windows.Forms.TextBox txtEditSold;
        private System.Windows.Forms.TextBox txtEditStock;
        private System.Windows.Forms.TextBox txtEditType;
        private System.Windows.Forms.TextBox txtEditPrice;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Button btnSaveDrink;
        private System.Windows.Forms.Button btnRemove;
    }
}