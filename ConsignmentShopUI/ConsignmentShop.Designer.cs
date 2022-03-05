
namespace ConsignmentShopUI
{
    partial class ConsignmentShop
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderText = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.ItemsListBoxLabel = new System.Windows.Forms.Label();
            this.AddToCart = new System.Windows.Forms.Button();
            this.ShoppingCartListBoxLabel = new System.Windows.Forms.Label();
            this.ShoppingCartListBox = new System.Windows.Forms.ListBox();
            this.MakePurchase = new System.Windows.Forms.Button();
            this.VendorListBoxLabel = new System.Windows.Forms.Label();
            this.VendorListBox = new System.Windows.Forms.ListBox();
            this.StoreProfitLabel = new System.Windows.Forms.Label();
            this.StoreProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSize = true;
            this.HeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderText.Location = new System.Drawing.Point(40, 40);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(405, 37);
            this.HeaderText.TabIndex = 0;
            this.HeaderText.Text = "Consignment Shop Demo";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 20;
            this.ItemsListBox.Location = new System.Drawing.Point(47, 128);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(398, 264);
            this.ItemsListBox.TabIndex = 1;
            // 
            // ItemsListBoxLabel
            // 
            this.ItemsListBoxLabel.AutoSize = true;
            this.ItemsListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsListBoxLabel.Location = new System.Drawing.Point(43, 105);
            this.ItemsListBoxLabel.Name = "ItemsListBoxLabel";
            this.ItemsListBoxLabel.Size = new System.Drawing.Size(103, 20);
            this.ItemsListBoxLabel.TabIndex = 2;
            this.ItemsListBoxLabel.Text = "Store Items";
            // 
            // AddToCart
            // 
            this.AddToCart.Location = new System.Drawing.Point(470, 242);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(157, 49);
            this.AddToCart.TabIndex = 3;
            this.AddToCart.Text = "Add To Cart ->";
            this.AddToCart.UseVisualStyleBackColor = true;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // ShoppingCartListBoxLabel
            // 
            this.ShoppingCartListBoxLabel.AutoSize = true;
            this.ShoppingCartListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoppingCartListBoxLabel.Location = new System.Drawing.Point(645, 105);
            this.ShoppingCartListBoxLabel.Name = "ShoppingCartListBoxLabel";
            this.ShoppingCartListBoxLabel.Size = new System.Drawing.Size(124, 20);
            this.ShoppingCartListBoxLabel.TabIndex = 5;
            this.ShoppingCartListBoxLabel.Text = "Shopping Cart";
            // 
            // ShoppingCartListBox
            // 
            this.ShoppingCartListBox.FormattingEnabled = true;
            this.ShoppingCartListBox.ItemHeight = 20;
            this.ShoppingCartListBox.Location = new System.Drawing.Point(649, 128);
            this.ShoppingCartListBox.Name = "ShoppingCartListBox";
            this.ShoppingCartListBox.Size = new System.Drawing.Size(398, 264);
            this.ShoppingCartListBox.TabIndex = 4;
            // 
            // MakePurchase
            // 
            this.MakePurchase.Location = new System.Drawing.Point(890, 398);
            this.MakePurchase.Name = "MakePurchase";
            this.MakePurchase.Size = new System.Drawing.Size(157, 49);
            this.MakePurchase.TabIndex = 6;
            this.MakePurchase.Text = "Purchase";
            this.MakePurchase.UseVisualStyleBackColor = true;
            this.MakePurchase.Click += new System.EventHandler(this.MakePurchase_Click);
            // 
            // VendorListBoxLabel
            // 
            this.VendorListBoxLabel.AutoSize = true;
            this.VendorListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorListBoxLabel.Location = new System.Drawing.Point(43, 464);
            this.VendorListBoxLabel.Name = "VendorListBoxLabel";
            this.VendorListBoxLabel.Size = new System.Drawing.Size(76, 20);
            this.VendorListBoxLabel.TabIndex = 8;
            this.VendorListBoxLabel.Text = "Vendors";
            // 
            // VendorListBox
            // 
            this.VendorListBox.FormattingEnabled = true;
            this.VendorListBox.ItemHeight = 20;
            this.VendorListBox.Location = new System.Drawing.Point(47, 487);
            this.VendorListBox.Name = "VendorListBox";
            this.VendorListBox.Size = new System.Drawing.Size(398, 264);
            this.VendorListBox.TabIndex = 7;
            // 
            // StoreProfitLabel
            // 
            this.StoreProfitLabel.AutoSize = true;
            this.StoreProfitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreProfitLabel.Location = new System.Drawing.Point(777, 720);
            this.StoreProfitLabel.Name = "StoreProfitLabel";
            this.StoreProfitLabel.Size = new System.Drawing.Size(177, 31);
            this.StoreProfitLabel.TabIndex = 9;
            this.StoreProfitLabel.Text = "Store Profit：";
            // 
            // StoreProfitValue
            // 
            this.StoreProfitValue.AutoSize = true;
            this.StoreProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreProfitValue.Location = new System.Drawing.Point(960, 720);
            this.StoreProfitValue.Name = "StoreProfitValue";
            this.StoreProfitValue.Size = new System.Drawing.Size(87, 31);
            this.StoreProfitValue.TabIndex = 10;
            this.StoreProfitValue.Text = "$0.00";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 791);
            this.Controls.Add(this.StoreProfitValue);
            this.Controls.Add(this.StoreProfitLabel);
            this.Controls.Add(this.VendorListBoxLabel);
            this.Controls.Add(this.VendorListBox);
            this.Controls.Add(this.MakePurchase);
            this.Controls.Add(this.ShoppingCartListBoxLabel);
            this.Controls.Add(this.ShoppingCartListBox);
            this.Controls.Add(this.AddToCart);
            this.Controls.Add(this.ItemsListBoxLabel);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.HeaderText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label ItemsListBoxLabel;
        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.Label ShoppingCartListBoxLabel;
        private System.Windows.Forms.ListBox ShoppingCartListBox;
        private System.Windows.Forms.Button MakePurchase;
        private System.Windows.Forms.Label VendorListBoxLabel;
        private System.Windows.Forms.ListBox VendorListBox;
        private System.Windows.Forms.Label StoreProfitLabel;
        private System.Windows.Forms.Label StoreProfitValue;
    }
}

