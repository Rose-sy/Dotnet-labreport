using System;

namespace Rojina_Unit4
{
    public partial class Default : System.Web.UI.Page
    {
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve input values
                decimal principal = Convert.ToDecimal(txtPrincipal.Text);
                decimal rate = Convert.ToDecimal(txtRate.Text);
                decimal time = Convert.ToDecimal(txtTime.Text);

                // Calculate simple interest
                decimal simpleInterest = (principal * rate * time) / 100;

                // Display the result
                lblResult.Text = $"The Simple Interest is: {simpleInterest:C}";
            }
            catch (Exception ex)
            {
                lblResult.Text = "Error: Please enter valid numeric values.";
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
