using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pioneer.Database.Model;
using PioneerEmployeeDatabase.DAL;
using System.Data.SqlClient;

namespace PioneerTech.WebApp.UI
{
    public partial class CompanyDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CompanySaveButton_Click(object sender, EventArgs e)
        {
            CompanyModel model = new CompanyModel
            {
                EmployerName = EmployerNameTextBox.Text,
                EmployerContactNumber = Convert.ToInt32(EmployerContactNumberTextBox.Text),
                EmployerAddress = EmployerLocationTextBox.Text,
                Website = EmployerWebsiteTextBox.Text,
                EmployeeId = Convert.ToInt32(EmployeeIdCompanyDropDownList.Text)
                
            };

            EmployeeDataAccessLayer EmployeeDAL = new EmployeeDataAccessLayer();

            int NoOfRowsAffected = EmployeeDAL.SaveCompanyData(model);
            ClientScript.RegisterStartupScript(this.GetType(), "Operation was", "alert(' Company Details SUCCESSFULLY saved');", true);
        }

        protected void CompanyClearButton_Click(object sender, EventArgs e)
        {
            EmployerNameTextBox.Text = "";
            EmployerContactNumberTextBox.Text = "";
            EmployerLocationTextBox.Text = "";
            EmployerWebsiteTextBox.Text = "";
            EmployeeIdTextBox.Text = "";



        }

        protected void EditCompanyEmployeeIdDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.DataBind();

        }
            protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DropDownList2.DataBind();

        }

        protected void CompanyEditButton_Click(object sender, EventArgs e)
        {
            CompanyModel model = new CompanyModel
            {
                EmployerName = EmployerNameTextBox.Text,
                EmployerContactNumber = Convert.ToInt32(EmployerContactNumberTextBox.Text),
                EmployerAddress = EmployerLocationTextBox.Text,
                Website = EmployerWebsiteTextBox.Text,
                EmployeeId = Convert.ToInt32(EEmployeeIdCompanyDropDownList.Text)

            };

            int EditCompanyId = Convert.ToInt32(DropDownList2.Text);
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = PRAJWOLPC;database = Pioneer_Employee_Database1;Integrated security = SSPI";

            SqlCommand cmd = new SqlCommand("UPDATE [CompanyDetail] SET[EmployerName] = " +
                            "'" + model.Website + "',[ContactNumber] = " + model.EmployerContactNumber + ",[Location] = '" + model.EmployerAddress + "',[Website] =' " +
                            "',[EmployeeID] = " + model.EmployeeId + "WHERE CompanyID = " + EditCompanyId, mysqlconnection);
            mysqlconnection.Open();

            int result = cmd.ExecuteNonQuery();
            ClientScript.RegisterStartupScript(this.GetType(), "Operation was", "alert(' Company Details SUCCESSFULLY Edited');", true);


        }
    }
}