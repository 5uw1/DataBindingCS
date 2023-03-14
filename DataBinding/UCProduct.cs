using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBinding
{
   [System.ComponentModel.DefaultBindingProperty("Product")]
   public partial class UCProduct : UserControl
   {
      public Product Product
      {
         set
         {
            ProductName.Text = value.Name;
            ProductPrice.Text = value.Price.ToString();
            ProductAmount.Text = value.Amount.ToString();
         }
         get => new Product()
         {
            Name = ProductName.Text,
            Price = Convert.ToDouble(ProductPrice.Text),
            Amount = Convert.ToDouble(ProductAmount.Text)
         };
      }

      public UCProduct()
      {
         InitializeComponent();
      }

      private void ReadMoreBtn_Click(object sender, EventArgs e)
      {
         FormProductDetails productDetail = new FormProductDetails();
         productDetail.Product = Product;
         productDetail.Show();
      }
   }
}
