using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store Store = new Store();
        private List<Item> ShoppingCartData = new List<Item>();
        BindingSource ItemsBinding = new BindingSource();
        BindingSource CartBinding = new BindingSource();
        BindingSource VendorsBinding = new BindingSource();
        private decimal StoreProfit = 0;

        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            ItemsBinding.DataSource = Store.Items;
            ItemsListBox.DataSource = ItemsBinding;
            ItemsListBox.DisplayMember = "Display";
            ItemsListBox.ValueMember = "Display";

            CartBinding.DataSource = ShoppingCartData;
            ShoppingCartListBox.DataSource = CartBinding;
            ShoppingCartListBox.DisplayMember = "Display";
            ShoppingCartListBox.ValueMember = "Display";

            VendorsBinding.DataSource = Store.Vendors;
            VendorListBox.DataSource = VendorsBinding;
            VendorListBox.DisplayMember = "Display";
            VendorListBox.ValueMember = "Display";
        }

        private void SetupData()
        {
            Store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
            Store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });

            Store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "A book about a whale",
                Price = 4.50M,
                Owner = Store.Vendors[0]
            });
            Store.Items.Add(new Item
            {
                Title = "A Tale of Two Cities",
                Description = "A book about a revolution",
                Price = 3.80M,
                Owner = Store.Vendors[1]
            });
            Store.Items.Add(new Item
            {
                Title = "Harry Potter Book 1",
                Description = "A book about a boy",
                Price = 5.20M,
                Owner = Store.Vendors[1]
            });
            Store.Items.Add(new Item
            {
                Title = "Jane Austion",
                Description = "A book about a girl",
                Price = 1.50M,
                Owner = Store.Vendors[0]
            });

            Store.Name = "Seconds are Better";

        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)ItemsListBox.SelectedItem;

            ShoppingCartData.Add(selectedItem);
            // BindingSource更新後はResetBindingsメソッドを実行
            CartBinding.ResetBindings(false);
        }

        private void MakePurchase_Click(object sender, EventArgs e)
        {
            foreach (Item item in ShoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                StoreProfit += (1 - (decimal)item.Owner.Commission) * item.Price;
            }

            ShoppingCartData.Clear();
            ItemsBinding.DataSource = Store.Items.FindAll(x => x.Sold == false);
            StoreProfitValue.Text = string.Format("${0}", StoreProfit);

            CartBinding.ResetBindings(false);
            ItemsBinding.ResetBindings(false);
            VendorsBinding.ResetBindings(false);
        }
    }
}
