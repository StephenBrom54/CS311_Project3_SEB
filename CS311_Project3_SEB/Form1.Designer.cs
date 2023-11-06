namespace CS311_Project3_SEB
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
            pict = new PictureBox();
            lblName = new Label();
            lblSize = new Label();
            cboSize = new ComboBox();
            rdoThin = new RadioButton();
            radbtnThick = new RadioButton();
            radbtnRegular = new RadioButton();
            lblCrustType = new Label();
            lblTopings = new Label();
            checkedListBox1 = new CheckedListBox();
            btnCalculate = new Button();
            lblSubTotal = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            txtSubTotal = new TextBox();
            txtTax = new TextBox();
            txtTotal = new TextBox();
            rtfOrderSummary = new RichTextBox();
            lblOrderSummary = new Label();
            ((System.ComponentModel.ISupportInitialize)pict).BeginInit();
            SuspendLayout();
            // 
            // pict
            // 
            pict.Image = Properties.Resources.Pizza_image;
            pict.InitialImage = null;
            pict.Location = new Point(26, 12);
            pict.Name = "pict";
            pict.Size = new Size(732, 1067);
            pict.SizeMode = PictureBoxSizeMode.CenterImage;
            pict.TabIndex = 0;
            pict.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Snap ITC", 22.125F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            lblName.Location = new Point(764, 12);
            lblName.Name = "lblName";
            lblName.Size = new Size(683, 76);
            lblName.TabIndex = 1;
            lblName.Text = "Brom's Pizza Place";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(764, 116);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(171, 32);
            lblSize.TabIndex = 2;
            lblSize.Text = "Pick Pizza Size:";
            // 
            // cboSize
            // 
            cboSize.FormattingEnabled = true;
            cboSize.Items.AddRange(new object[] { "Small", "Medium", "Large", "X-Large", "Ginormous" });
            cboSize.Location = new Point(941, 116);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(242, 40);
            cboSize.TabIndex = 3;
            cboSize.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // rdoThin
            // 
            rdoThin.AutoSize = true;
            rdoThin.Location = new Point(941, 162);
            rdoThin.Name = "rdoThin";
            rdoThin.Size = new Size(92, 36);
            rdoThin.TabIndex = 4;
            rdoThin.TabStop = true;
            rdoThin.Text = "Thin";
            rdoThin.UseVisualStyleBackColor = true;
            rdoThin.CheckedChanged += radbtnThin_CheckedChanged;
            // 
            // radbtnThick
            // 
            radbtnThick.AutoSize = true;
            radbtnThick.Location = new Point(1039, 162);
            radbtnThick.Name = "radbtnThick";
            radbtnThick.Size = new Size(101, 36);
            radbtnThick.TabIndex = 5;
            radbtnThick.TabStop = true;
            radbtnThick.Text = "Thick";
            radbtnThick.UseVisualStyleBackColor = true;
            // 
            // radbtnRegular
            // 
            radbtnRegular.AutoSize = true;
            radbtnRegular.Location = new Point(1146, 162);
            radbtnRegular.Name = "radbtnRegular";
            radbtnRegular.Size = new Size(125, 36);
            radbtnRegular.TabIndex = 6;
            radbtnRegular.TabStop = true;
            radbtnRegular.Text = "Regular";
            radbtnRegular.UseVisualStyleBackColor = true;
            // 
            // lblCrustType
            // 
            lblCrustType.AutoSize = true;
            lblCrustType.Location = new Point(764, 162);
            lblCrustType.Name = "lblCrustType";
            lblCrustType.Size = new Size(139, 32);
            lblCrustType.TabIndex = 7;
            lblCrustType.Text = "Crust Type: ";
            // 
            // lblTopings
            // 
            lblTopings.AutoSize = true;
            lblTopings.Location = new Point(764, 209);
            lblTopings.Name = "lblTopings";
            lblTopings.Size = new Size(116, 32);
            lblTopings.TabIndex = 8;
            lblTopings.Text = "Toppings:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Pepperoni", "Sausage", "Canadian Bacon", "Spicy Italian Sausage", "Onion", "Green Pepper", "Black Olives", "Green Olives", "Banana Peppers", "Jalepeno", "Extra Cheese", "Mushroom" });
            checkedListBox1.Location = new Point(764, 244);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(306, 436);
            checkedListBox1.TabIndex = 9;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(764, 707);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(285, 89);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(795, 825);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(118, 32);
            lblSubTotal.TabIndex = 11;
            lblSubTotal.Text = "Sub Total:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(851, 876);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(52, 32);
            lblTax.TabIndex = 12;
            lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(833, 933);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(70, 32);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total:";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(919, 818);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(200, 39);
            txtSubTotal.TabIndex = 14;
            txtSubTotal.TextChanged += txtSubTotal_TextChanged;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(919, 872);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(200, 39);
            txtTax.TabIndex = 15;
            txtTax.TextChanged += txtTax_TextChanged;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(919, 917);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(200, 39);
            txtTotal.TabIndex = 16;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // rtfOrderSummary
            // 
            rtfOrderSummary.Location = new Point(1176, 675);
            rtfOrderSummary.Name = "rtfOrderSummary";
            rtfOrderSummary.Size = new Size(1017, 341);
            rtfOrderSummary.TabIndex = 17;
            rtfOrderSummary.Text = "";
            rtfOrderSummary.TextChanged += rtfOrderSummary_TextChanged;
            // 
            // lblOrderSummary
            // 
            lblOrderSummary.AutoSize = true;
            lblOrderSummary.Location = new Point(1176, 624);
            lblOrderSummary.Name = "lblOrderSummary";
            lblOrderSummary.Size = new Size(188, 32);
            lblOrderSummary.TabIndex = 18;
            lblOrderSummary.Text = "Order Summary:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2351, 1149);
            Controls.Add(lblOrderSummary);
            Controls.Add(rtfOrderSummary);
            Controls.Add(txtTotal);
            Controls.Add(txtTax);
            Controls.Add(txtSubTotal);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(lblSubTotal);
            Controls.Add(btnCalculate);
            Controls.Add(checkedListBox1);
            Controls.Add(lblTopings);
            Controls.Add(lblCrustType);
            Controls.Add(radbtnRegular);
            Controls.Add(radbtnThick);
            Controls.Add(rdoThin);
            Controls.Add(cboSize);
            Controls.Add(lblSize);
            Controls.Add(lblName);
            Controls.Add(pict);
            Name = "Form1";
            Text = "Brom Pizza Place";
            ((System.ComponentModel.ISupportInitialize)pict).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pict;
        private Label lblName;
        private Label lblSize;
        private ComboBox cboSize;
        private RadioButton rdoThin;
        private RadioButton radbtnThick;
        private RadioButton radbtnRegular;
        private Label lblCrustType;
        private Label lblTopings;
        private CheckedListBox checkedListBox1;
        private Button btnCalculate;
        private Label lblSubTotal;
        private Label lblTax;
        private Label lblTotal;
        private TextBox txtSubTotal;
        private TextBox txtTax;
        private TextBox txtTotal;
        private RichTextBox rtfOrderSummary;
        private Label lblOrderSummary;
        private CheckBox Pepperoni;
        private CheckBox Sausage;
        private CheckBox CanadianBacon;
        private CheckBox SpicySausage;
        private CheckBox Onion;
        private CheckBox GreenPepper;
        private CheckBox BlackOlives;
        private CheckBox GreenOlives;
        private CheckBox BananaPeppers;
        private CheckBox Jalapeno;
        private CheckBox ExtraCheese;
        private CheckBox Mushroom;
        private ComboBox ComboBox1;
        private RadioButton rdoThick;
        private RadioButton rdoRegular;
        private CheckBox ckbBacon;



        private void Summarize()
        {
            // Calculate sizePrice based on the selected pizza size
            sizePrice = 0.0;
            if (cboSize.SelectedItem != null)
            {
                string selectedSize = cboSize.SelectedItem.ToString();

                // Define prices for pizza sizes
                Dictionary<string, double> sizePrices = new Dictionary<string, double>
        {
            { "Small", 5.00 },
            { "Medium", 7.00 },
            { "Large", 10.00 },
            { "X-Large", 12.00 },
            { "Ginormous", 15.00 }
        };

                if (sizePrices.TryGetValue(selectedSize, out double price))
                {
                    sizePrice = price;
                }
            }

            // Calculate crustPrice based on the selected crust type
            double crustPrice = 0.0;
            if (rdoThin.Checked)
            {
                crustPrice = 2.00; // Thin crust price
            }
            else if (radbtnThick.Checked)
            {
                crustPrice = 3.00; // Thick crust price
            }
            else if (radbtnRegular.Checked)
            {
                crustPrice = 2.50; // Regular crust price
            }

            // Calculate toppingPrice based on selected toppings
            toppingPrice = 0.0;
            List<string> selectedToppings = GetSelectedToppings();

            // Define prices for toppings
            Dictionary<string, double> toppingPrices = new Dictionary<string, double>
    {
        { "Pepperoni", 2.00 },
        { "Sausage", 2.00 },
        { "Canadian Bacon", 2.00 },
        { "Spicy Italian Sausage", 2.00 },
        { "Onion", 1.00 },
        { "Green Pepper", 1.00 },
        { "Black Olives", 1.00 },
        { "Green Olives", 1.00 },
        { "Banana Peppers", 1.00 },
        { "Jalapeno", 1.00 },
        { "Extra Cheese", 1.00 },
        { "Mushroom", 1.00 }
    };

            foreach (var topping in selectedToppings)
            {
                if (toppingPrices.TryGetValue(topping, out double toppingPriceValue))
                {
                    toppingPrice += toppingPriceValue;
                }
            }

            // Calculate SubTotal
            double subTotal = sizePrice + crustPrice + toppingPrice;
            txtSubTotal.Text = subTotal.ToString("C");

            // Calculate Tax (assuming 7% tax rate)
            double taxRate = 0.07;
            double tax = subTotal * taxRate;
            txtTax.Text = tax.ToString("C");

            // Calculate Total
            double total = subTotal + tax;
            txtTotal.Text = total.ToString("C");

            // Display results in the RichTextBox
            //rtfOrderSummary.Text = "Order Summary\n\n";
            rtfOrderSummary.Text += "Pizza Size: " + cboSize.SelectedItem + "\n";
            rtfOrderSummary.Text += "Crust Type: " + GetSelectedCrustType() + "\n";
            rtfOrderSummary.Text += "Toppings: " + string.Join(", ", selectedToppings) + "\n\n";
            // rtfOrderSummary.Text += "SubTotal: " + subTotal.ToString("C") + "\n";
            // rtfOrderSummary.Text += "Tax: " + tax.ToString("C") + "\n";
            // rtfOrderSummary.Text += "Total: " + total.ToString("C") + "\n";
        }


        private List<string> GetSelectedToppings()
        {
            List<string> toppings = new List<string>();

            foreach (var checkBox in checkedListBox1.CheckedItems)
            {
                toppings.Add(checkBox.ToString());
            }

            return toppings;
        }
        private string GetSelectedCrustType()
        {
            if (rdoThin.Checked)
            {
                return "Thin";
            }
            else if (radbtnThick.Checked)
            {
                return "Thick";
            }
            else if (radbtnRegular.Checked)
            {
                return "Regular";
            }
            else
            {
                return "N/A"; // No crust type selected
            }
        }

    }

}