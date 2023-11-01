using System.Windows.Forms;
using System;

namespace c_net_invoice_mt
{
    public partial class frmSalesTax : Form
    {
        public frmSalesTax()
        {
            InitializeComponent();
        }

        // Close form.
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // Confirm and close.
        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                this.Tag = NewTaxRate;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        // Validate tax input.
        private bool IsValidData()
        {
            if (!decimal.TryParse(txtSalesTaxNew.Text, out decimal taxRate) || taxRate <= 0 || taxRate >= 10)
            {
                MessageBox.Show("Invalid tax rate.", "Invalid Entry");
                txtSalesTaxNew.Focus();
                return false;
            }
            return true;
        }

        // Get tax rate.
        public decimal NewTaxRate
        {
            get
            {
                return Convert.ToDecimal(txtSalesTaxNew.Text) / 100;
            }
        }
    }
}
