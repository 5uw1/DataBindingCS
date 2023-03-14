using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBinding
{
   public partial class FormProductDetails : Form
   {
      public Product Product
      {
         set
         {
            ProductName.Text = value.Name;
            ProductPrice.Text = value.Price.ToString();
            ProductAmount.Text = value.Amount.ToString();
         }
      }
      public FormProductDetails()
      {
         InitializeComponent();
      }
   }
}
