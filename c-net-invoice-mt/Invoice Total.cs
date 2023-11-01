using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_net_invoice_mt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Button exit logic
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Tax initiation with default value
        private decimal taxPercent = 0.0775m;  // default value

        // Method IsValidData() that checks that the product total textbox is not empty, has
        // a decimal value and is within range 1 to 100000.
        private bool IsValidData()
        {
            // Check if string have white spaces or empty
            if (string.IsNullOrWhiteSpace(txtProductTotal.Text))
            {
                MessageBox.Show("Product total is required.", "Entry Error");
                txtProductTotal.Focus();
                return false;
            }

            // Ensure productTotal is a valid decimal and within the range of 1 to 100,000
            if (!decimal.TryParse(txtProductTotal.Text, out decimal productTotal) || productTotal < 1 || productTotal > 100000)
            {
                MessageBox.Show("Product total must be a decimal value between 1 and 100000.", "Entry Error");
                txtProductTotal.Focus();
                return false;
            }

            // Validity pass
            return true;
        }


        // Button Calculate logic
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Checking if entry data is correct
                if (!IsValidData())
                {
                    return;
                }

                // Convert the product total input from text to a decimal value.
                decimal productTotal = Convert.ToDecimal(txtProductTotal.Text);

                // Initialize the discount percentage to default value of 0.
                decimal discountPercent = 0m;

                // Determine the discount percentage based on the product total.
                if (productTotal >= 250)
                    discountPercent = 0.25m;  // Set a 25% discount for product totals of 250 or more.
                else if (productTotal >= 100)
                    discountPercent = 0.10m;  // Set a 10% discount for product totals between 100 and 249.99.

                // Calculate the discount amount by multiplying the product total by the discount percentage.
                decimal discountAmount = productTotal * discountPercent;

                // Calculate the subtotal by subtracting the discount amount from the product total.
                decimal subTotal = productTotal - discountAmount;

                // Calculate the tax amount using the tax percentage.
                decimal tax = subTotal * taxPercent;

                // Calculate the final total by adding tax to the subtotal.
                decimal total = subTotal + tax;

                // Display the calculated amounts in their respective text boxes with currency formatting.
                txtDiscountAmount.Text = discountAmount.ToString("c");
                txtSubtotal.Text = subTotal.ToString("c");
                textBox1.Text = tax.ToString("c");
                txtTotal.Text = total.ToString("c");

                // Set the focus back to the product total text box for the next input.
                txtProductTotal.Focus();
            }

            // Throw an exception 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handles the "Change Percent" button click.
        private void btnChangePercent_Click(object sender, EventArgs e)
        {
            // Open the Sales Tax form.
            frmSalesTax salesTaxForm = new frmSalesTax();
            DialogResult result = salesTaxForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    // Update the tax percent from the Sales Tax form.
                    taxPercent = salesTaxForm.NewTaxRate;

                    // Display the new tax percentage.
                    lbTax.Text = $"Tax ({taxPercent:P})";
                }
                catch (Exception ex)
                {
                    // Display errors, if any.
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
