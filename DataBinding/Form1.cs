namespace DataBinding
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
         using (var database = new ShopContext())
         {
            ucApple.Product = database.Products.Single(p => p.Name == "Apple");
            ucBanana.Product = database.Products.Single(p => p.Name == "Banana");
         }
      }
   }
}