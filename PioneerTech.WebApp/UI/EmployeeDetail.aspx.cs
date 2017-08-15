using Pioneer.Database.Model;
using PioneerEmployeeDatabase;
using PioneerEmployeeDatabase.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace PioneerTech.WebApp.UI
{
    public partial class EmployeeDetail : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            EmployeeModel model = new EmployeeModel()
            {
                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                EmailId = EmailIdTextBox.Text,
                MobileNumber = Convert.ToInt64(MobileNumberTextBox.Text),
                AlternateMobileNumber = Convert.ToInt64(AlternateMobileNumberTextBox.Text),
                Address1 = Address1TextBox.Text,
                Address2 = Address2TextBox.Text,
                HomeCountry = HomeCountryTextBox.Text,
                CurrentCountry = CurrentCountryTextBox.Text,
                ZipCode = Convert.ToInt32(ZipCodeTextBox.Text)

                
            };



            EmployeeDataAccessLayer EmployeeDAL = new EmployeeDataAccessLayer();

            int NoOfRowsAffected = EmployeeDAL.SaveEmployeeData(model);



            ClientScript.RegisterStartupScript(this.GetType(), "Operation was", "alert(' Employee Details SUCCESSFULLY saved');", true);
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            EmailIdTextBox.Text = "";
            MobileNumberTextBox.Text = "";
            AlternateMobileNumberTextBox.Text = "";
            Address1TextBox.Text = "";
            Address2TextBox.Text = "";
            HomeCountryTextBox.Text = "";
            CurrentCountryTextBox.Text = "";
            ZipCodeTextBox.Text = "";
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void EditButton_Click(object sender, EventArgs e)
        {
            EmployeeModel model = new EmployeeModel()
            {
                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                EmailId = EmailIdTextBox.Text,
                MobileNumber = Convert.ToInt64(MobileNumberTextBox.Text),
                AlternateMobileNumber = Convert.ToInt64(AlternateMobileNumberTextBox.Text),
                Address1 = Address1TextBox.Text,
                Address2 = Address2TextBox.Text,
                HomeCountry = HomeCountryTextBox.Text,
                CurrentCountry = CurrentCountryTextBox.Text,
                ZipCode = Convert.ToInt32(ZipCodeTextBox.Text)


            };

            int EditEmployeeId = Convert.ToInt32(EditEmployeeDropDownList.Text);
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = PRAJWOLPC;database = Pioneer_Employee_Database1;Integrated security = SSPI";

            SqlCommand cmd = new SqlCommand("UPDATE [EmployeeDetail] SET[FirstName] = " +
                            "'" + model.FirstName + "',[LastName] = '" + model.LastName + "',[Email] = '" + model.EmailId + "',[ContactNumber] = " +
                            model.MobileNumber + ",[AlternateContactNumber] = " + model.AlternateMobileNumber + ",[Address] = '" + model.Address1 + "',[AlternateAddress] = '" + model.Address2 +
                            "',[CurrentCountry] = '" + model.CurrentCountry + "',[HomeCountry] = '" + model.HomeCountry + "',[ZipCode] = " + model.ZipCode + "WHERE EmployeeID = "+EditEmployeeId, mysqlconnection);
            mysqlconnection.Open();
            
            int result = cmd.ExecuteNonQuery();
            ClientScript.RegisterStartupScript(this.GetType(), "Operation was", "alert(' Employee Details SUCCESSFULLY Edited');", true);

        }
    }
}