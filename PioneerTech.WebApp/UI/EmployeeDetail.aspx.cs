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
            EmployeeModel model = new EmployeeModel();
            model = GetEmployeeDetails(Convert.ToInt32(EditEmployeeDropDownList.Text));

            FirstNameTextBox.Text = model.FirstName;
            LastNameTextBox.Text = model.LastName;
            EmailIdTextBox.Text = model.EmailId;
            MobileNumberTextBox.Text = Convert.ToString(model.MobileNumber);
            AlternateMobileNumberTextBox.Text = Convert.ToString(model.AlternateMobileNumber);
            Address1TextBox.Text = model.Address1;
            Address2TextBox.Text = model.Address2;
            HomeCountryTextBox.Text = model.HomeCountry;
            CurrentCountryTextBox.Text = model.CurrentCountry;
            ZipCodeTextBox.Text = Convert.ToString(model.ZipCode);



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
        public EmployeeModel GetEmployeeDetails(int employeeid)
        {
            EmployeeModel empdmodel = new EmployeeModel();
           
                string connectionstring = "Data Source=PRAJWOLPC;Initial Catalog=Pioneer_Employee_Database1;" +
                       " Integrated Security=SSPI";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqldetails = ("Select * FROM EmployeeDetail WHERE EmployeeID=" + employeeid);
                SqlCommand command;
                command = new SqlCommand(sqldetails, mysqlconnection);
                SqlDataReader employeedatareader = command.ExecuteReader();
            
            while (employeedatareader.Read())
                {
                //empdmodel.EmployeeID = employeedatareader.GetInt32(employeedatareader.GetOrdinal("EmployeeID"));
                   
                     empdmodel.FirstName = employeedatareader.GetString(employeedatareader.GetOrdinal("FirstName"));
                    empdmodel.LastName = employeedatareader.GetString(employeedatareader.GetOrdinal("LastName"));
                    empdmodel.EmailId = employeedatareader.GetString(employeedatareader.GetOrdinal("Email"));
                    empdmodel.MobileNumber = employeedatareader.GetInt64(employeedatareader.GetOrdinal("ContactNumber"));
                    empdmodel.AlternateMobileNumber = employeedatareader.GetInt64(employeedatareader.GetOrdinal("AlternateContactNumber"));
                    empdmodel.Address1 = employeedatareader.GetString(employeedatareader.GetOrdinal("Address"));
                    empdmodel.Address2 = employeedatareader.GetString(employeedatareader.GetOrdinal("AlternateAddress"));
                    empdmodel.CurrentCountry = employeedatareader.GetString(employeedatareader.GetOrdinal("CurrentCountry"));
                    empdmodel.HomeCountry = employeedatareader.GetString(employeedatareader.GetOrdinal("HomeCountry"));
                    empdmodel.ZipCode = employeedatareader.GetInt32(employeedatareader.GetOrdinal("ZipCode"));
                }
                

          
            return empdmodel;
        }
    }
}
