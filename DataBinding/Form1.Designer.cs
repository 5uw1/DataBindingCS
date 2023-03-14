namespace DataBinding
{
   partial class Form1
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
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
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         components = new System.ComponentModel.Container();
         bindingSource1 = new BindingSource(components);
         ucApple = new UCProduct();
         ucBanana = new UCProduct();
         ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
         SuspendLayout();
         // 
         // ucApple
         // 
         ucApple.Location = new Point(178, 10);
         ucApple.Margin = new Padding(2, 2, 2, 2);
         ucApple.Name = "ucApple";
         ucApple.Size = new Size(238, 109);
         ucApple.TabIndex = 1;
         // 
         // ucBanana
         // 
         ucBanana.Location = new Point(178, 123);
         ucBanana.Margin = new Padding(2, 2, 2, 2);
         ucBanana.Name = "ucBanana";
         ucBanana.Size = new Size(238, 114);
         ucBanana.TabIndex = 2;
         // 
         // Form1
         // 
         AutoScaleDimensions = new SizeF(8F, 20F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(640, 360);
         Controls.Add(ucBanana);
         Controls.Add(ucApple);
         Margin = new Padding(2, 2, 2, 2);
         Name = "Form1";
         Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
         ResumeLayout(false);
      }

      #endregion

      private BindingSource bindingSource1;
      private UCProduct ucApple;
      private UCProduct ucBanana;
   }
}