using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CS311_Project3_SEB
{
    public partial class Form1 : Form
    {
        private double toppingPrice;
        private double sizePrice;
        private double price;
        private double total;

        public Form1()
        {
            InitializeComponent();
            Pepperoni = new CheckBox();
            Sausage = new CheckBox();
            CanadianBacon = new CheckBox();
            SpicySausage = new CheckBox();
            Onion = new CheckBox();
            GreenPepper = new CheckBox();
            BlackOlives = new CheckBox();
            GreenOlives = new CheckBox();
            BananaPeppers = new CheckBox();
            Jalapeno = new CheckBox();
            ExtraCheese = new CheckBox();
            Mushroom = new CheckBox();

            sizePrice = 0.0;
            toppingPrice = 0.0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void UpdateTaxAndTotal()
        {
            // Calculate Tax (assuming 7% tax rate)
            double taxRate = 0.07;
            double tax = sizePrice + toppingPrice * taxRate;

            // Calculate SubTotal
            double subTotal = sizePrice + toppingPrice;

            // Calculate Total (SubTotal + Tax)
            total = subTotal + tax;  // Update the total variable

            // Update the TextBoxes with the calculated values
            txtSubTotal.Text = subTotal.ToString("C");
            txtTax.Text = tax.ToString("C");
            txtTotal.Text = total.ToString("C");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Calculate the sizePrice based on the selected pizza size
            if (cboSize.SelectedItem != null)
            {
                string selectedSize = cboSize.SelectedItem.ToString();

                // Define prices for pizza sizes
                Dictionary<string, double> sizePrices = new Dictionary<string, double>
        {
            { "Small", 2.00 },
            { "Medium", 5.00 },
            { "Large", 10.00 },
            { "X-Large", 15.00 },
            { "Ginormous", 20.00 }
        };

                if (sizePrices.TryGetValue(selectedSize, out double sizeprice))
                {
                    this.sizePrice = sizeprice;
                }
            }


            Summarize();
            UpdateTaxAndTotal();
        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





        private void radbtnThin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtSubTotal_TextChanged(object sender, EventArgs e)
        {
            // Calculate SubTotal
            double subTotal = (double)sizePrice + toppingPrice;
            txtSubTotal.Text = subTotal.ToString("C");
        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {
            object Tax = null;
            //txtTax.Text = Tax.ToString("C");

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Text = total.ToString("C");
        }

        private void rtfOrderSummary_TextChanged(object sender, EventArgs e)
        {

        }
        private void Pepperoni_CheckedChanged(object sender, EventArgs e)
        {
            HandleToppingCheckbox(Pepperoni, 2.00);
        }

        private void Sausage_CheckedChanged(object sender, EventArgs e)
        {
            HandleToppingCheckbox(Sausage, 2.00);
        }

        private void CanadianBacon_CheckedChanged(object sender, EventArgs e)
        {
            HandleToppingCheckbox(CanadianBacon, 2.00);
        }

        private void SpicySausage_CheckedChanged(object sender, EventArgs e)
        {
            HandleToppingCheckbox(SpicySausage, 2.00);
        }

        private void Onion_CheckedChanged(object sender, EventArgs e)
        {
            HandleToppingCheckbox(Onion, 1.00);
        }

        private void GreenPepper_CheckedChanged(object sender, EventArgs e)
        {
            HandleToppingCheckbox(GreenPepper, 1.00);
        }

        private void BlackOlives_CheckedChanged(object sender, EventArgs e)
        {
            HandleToppingCheckbox(BlackOlives, 1.00);
        }

        private void GreenOlives_CheckedChanged(object sender, EventArgs e)
        {
            HandleToppingCheckbox(GreenOlives, 1.00);
        }

        private void BananaPeppers_CheckedChanged(object sender, EventArgs e)
        {
            HandleToppingCheckbox(BananaPeppers, 1.00);
        }

        private void Jalapeno_CheckedChanged(object sender, EventArgs e)
        {
            HandleToppingCheckbox(Jalapeno, 1.00);
        }

        private void ExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            HandleToppingCheckbox(ExtraCheese, 1.00);
        }

        private void Mushroom_CheckedChanged(object sender, EventArgs e)
        {
            HandleToppingCheckbox(Mushroom, 1.00);
        }

        private void HandleToppingCheckbox(CheckBox checkbox, double toppingPrice)
        {
            if (checkbox.Checked)
            {
                // Topping is selected, add its price to the overall price
                price += toppingPrice;
            }
            else
            {
                // Topping is deselected, subtract its price from the overall price
                price -= toppingPrice;
            }

            // Update the SubTotal display
            txtSubTotal.Text = price.ToString("C");

            // Recalculate Tax and Total
            UpdateTaxAndTotal();
        }

    }

}

