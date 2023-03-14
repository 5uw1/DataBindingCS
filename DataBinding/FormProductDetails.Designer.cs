namespace DataBinding
{
   partial class FormProductDetails
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
         label1 = new Label();
         button1 = new Button();
         label2 = new Label();
         label3 = new Label();
         ProductAmount = new TextBox();
         ProductPrice = new Label();
         ProductName = new Label();
         SuspendLayout();
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new Point(16, 24);
         label1.Name = "label1";
         label1.Size = new Size(49, 20);
         label1.TabIndex = 0;
         label1.Text = "Name";
         // 
         // button1
         // 
         button1.Location = new Point(68, 128);
         button1.Name = "button1";
         button1.Size = new Size(94, 29);
         button1.TabIndex = 1;
         button1.Text = "Buy";
         button1.UseVisualStyleBackColor = true;
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Location = new Point(16, 55);
         label2.Name = "label2";
         label2.Size = new Size(41, 20);
         label2.TabIndex = 2;
         label2.Text = "Price";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.Location = new Point(16, 89);
         label3.Name = "label3";
         label3.Size = new Size(62, 20);
         label3.TabIndex = 3;
         label3.Text = "Amount";
         // 
         // ProductAmount
         // 
         ProductAmount.Location = new Point(97, 86);
         ProductAmount.Name = "ProductAmount";
         ProductAmount.Size = new Size(125, 27);
         ProductAmount.TabIndex = 4;
         // 
         // ProductPrice
         // 
         ProductPrice.AutoSize = true;
         ProductPrice.Location = new Point(97, 55);
         ProductPrice.Name = "ProductPrice";
         ProductPrice.Size = new Size(50, 20);
         ProductPrice.TabIndex = 5;
         ProductPrice.Text = "label4";
         // 
         // ProductName
         // 
         ProductName.AutoSize = true;
         ProductName.Location = new Point(97, 24);
         ProductName.Name = "ProductName";
         ProductName.Size = new Size(50, 20);
         ProductName.TabIndex = 6;
         ProductName.Text = "label5";
         // 
         // FormProductDetails
         // 
         AutoScaleDimensions = new SizeF(8F, 20F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(800, 450);
         Controls.Add(ProductName);
         Controls.Add(ProductPrice);
         Controls.Add(ProductAmount);
         Controls.Add(label3);
         Controls.Add(label2);
         Controls.Add(button1);
         Controls.Add(label1);
         Name = "FormProductDetails";
         Text = "FormProductDetails";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private Label label1;
      private Button button1;
      private Label label2;
      private Label label3;
      private TextBox ProductAmount;
      private Label ProductPrice;
      private Label ProductName;
   }
}