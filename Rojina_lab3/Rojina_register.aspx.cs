using System;
using System.Xml.Linq;

namespace Rojina_Unit4
{
    public partial class Rojina_register : System.Web.UI.Page
    {
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid) // Ensures all validators pass
            {
                string name = txtName.Text;
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                string phone = txtPhone.Text;

                // Simulate saving to database or further processing
                lblMessage.Text = "Registration successful!";
                lblMessage.ForeColor = System.Drawing.Color.Green;

                // Optional: Clear the form fields after submission
                txtName.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
                txtPhone.Text = "";
            }
        }
    }
}
