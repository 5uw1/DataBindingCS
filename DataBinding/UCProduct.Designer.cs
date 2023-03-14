namespace DataBinding
{
   partial class UCProduct
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         components = new System.ComponentModel.Container();
         label1 = new Label();
         label2 = new Label();
         label3 = new Label();
         ProductAmount = new Label();
         productBindingSource = new BindingSource(components);
         ProductPrice = new Label();
         ProductName = new Label();
         productBindingSource1 = new BindingSource(components);
         ReadMoreBtn = new Button();
         ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
         ((System.ComponentModel.ISupportInitialize)productBindingSource1).BeginInit();
         SuspendLayout();
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new Point(10, 12);
         label1.Margin = new Padding(2, 0, 2, 0);
         label1.Name = "label1";
         label1.Size = new Size(52, 20);
         label1.TabIndex = 0;
         label1.Text = "Name:";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Location = new Point(10, 41);
         label2.Margin = new Padding(2, 0, 2, 0);
         label2.Name = "label2";
         label2.Size = new Size(44, 20);
         label2.TabIndex = 1;
         label2.Text = "Price:";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.Location = new Point(10, 70);
         label3.Margin = new Padding(2, 0, 2, 0);
         label3.Name = "label3";
         label3.Size = new Size(65, 20);
         label3.TabIndex = 2;
         label3.Text = "Amount:";
         // 
         // ProductAmount
         // 
         ProductAmount.AutoSize = true;
         ProductAmount.DataBindings.Add(new Binding("Text", productBindingSource, "Amount", true));
         ProductAmount.Location = new Point(80, 70);
         ProductAmount.Margin = new Padding(2, 0, 2, 0);
         ProductAmount.Name = "ProductAmount";
         ProductAmount.Size = new Size(50, 20);
         ProductAmount.TabIndex = 3;
         ProductAmount.Text = "label4";
         // 
         // productBindingSource
         // 
         productBindingSource.DataSource = typeof(Product);
         // 
         // ProductPrice
         // 
         ProductPrice.AutoSize = true;
         ProductPrice.DataBindings.Add(new Binding("Text", productBindingSource, "Price", true));
         ProductPrice.Location = new Point(80, 41);
         ProductPrice.Margin = new Padding(2, 0, 2, 0);
         ProductPrice.Name = "ProductPrice";
         ProductPrice.Size = new Size(50, 20);
         ProductPrice.TabIndex = 4;
         ProductPrice.Text = "label5";
         // 
         // ProductName
         // 
         ProductName.AutoSize = true;
         ProductName.DataBindings.Add(new Binding("Text", productBindingSource, "Name", true));
         ProductName.Location = new Point(80, 12);
         ProductName.Margin = new Padding(2, 0, 2, 0);
         ProductName.Name = "ProductName";
         ProductName.Size = new Size(50, 20);
         ProductName.TabIndex = 5;
         ProductName.Text = "label6";
         // 
         // productBindingSource1
         // 
         productBindingSource1.DataSource = typeof(Product);
         // 
         // ReadMoreBtn
         // 
         ReadMoreBtn.Location = new Point(10, 106);
         ReadMoreBtn.Name = "ReadMoreBtn";
         ReadMoreBtn.Size = new Size(94, 29);
         ReadMoreBtn.TabIndex = 6;
         ReadMoreBtn.Text = "Read more";
         ReadMoreBtn.UseVisualStyleBackColor = true;
         ReadMoreBtn.Click += ReadMoreBtn_Click;
         // 
         // UCProduct
         // 
         AutoScaleDimensions = new SizeF(8F, 20F);
         AutoScaleMode = AutoScaleMode.Font;
         Controls.Add(ReadMoreBtn);
         Controls.Add(ProductName);
         Controls.Add(ProductPrice);
         Controls.Add(ProductAmount);
         Controls.Add(label3);
         Controls.Add(label2);
         Controls.Add(label1);
         Margin = new Padding(2);
         Name = "UCProduct";
         Size = new Size(298, 232);
         ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
         ((System.ComponentModel.ISupportInitialize)productBindingSource1).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private Label label1;
      private Label label2;
      private Label label3;
      private Label ProductAmount;
      private Label ProductPrice;
      private Label ProductName;
      private BindingSource productBindingSource;
      private BindingSource productBindingSource1;
      private Button ReadMoreBtn;
   }
}
