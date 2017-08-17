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
           UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
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
            //EmployeeIdTextBox.Text = "";



        }

        protected void EditCompanyEmployeeIdDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.DataBind();

        }
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                //CompanyModel model = new CompanyModel();
                ////  int companyId = Convert.ToInt32(DropDownList2.Text);
                ////model = GetCompanyDetails(5);


                //model = GetCompanyDetails(Convert.ToInt32(DropDownList2.Text));

                //EmployerNameTextBox.Text = model.EmployerName;
                //EmployerContactNumberTextBox.Text = Convert.ToString(model.EmployerContactNumber);
                //EmployerLocationTextBox.Text = model.EmployerAddress;
                //EmployerWebsiteTextBox.Text = model.Website;
                //EmployeeIdCompanyDropDownList.Text = Convert.ToString(model.EmployeeId);
          

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
                EmployeeId = Convert.ToInt32(EmployeeIdCompanyDropDownList.Text)

            };

            int EditCompanyId = Convert.ToInt32(DropDownList2.Text);
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = PRAJWOLPC;database = Pioneer_Employee_Database1;Integrated security = SSPI";

            SqlCommand cmd = new SqlCommand("UPDATE [CompanyDetail] SET[EmployerName] = " +
                            "'" + model.EmployerName + "',[ContactNumber] = " + model.EmployerContactNumber + ",[Location] = '" + model.EmployerAddress + "',[Website] =' " + model.Website +
                            "',[EmployeeID] = " + model.EmployeeId + "WHERE CompanyID = " + EditCompanyId, mysqlconnection);
            mysqlconnection.Open();

            int result = cmd.ExecuteNonQuery();
            ClientScript.RegisterStartupScript(this.GetType(), "Operation was", "alert(' Company Details SUCCESSFULLY Edited');", true);


        }

       // public CompanyModel GetCompanyDetails(int companyId)
        //{
            //CompanyModel companyModel = new CompanyModel();

            //string connectionstring = "Data Source=PRAJWOLPC;Initial Catalog=Pioneer_Employee_Database1;" +
            //       " Integrated Security=SSPI";
            //SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            //mysqlconnection.Open();
            //string sqldetails = ("Select * FROM CompanyDetail WHERE CompanyID=" + companyId);
            //SqlCommand command;
            //command = new SqlCommand(sqldetails, mysqlconnection);
            //SqlDataReader employeedatareader = command.ExecuteReader();
            
            //while (employeedatareader.Read())
            //{
            //    //empdmodel.EmployeeID = employeedatareader.GetInt32(employeedatareader.GetOrdinal("EmployeeID"));

            //    companyModel.EmployerName= employeedatareader.GetString(employeedatareader.GetOrdinal("EmployerName"));
            //    companyModel.EmployerContactNumber = employeedatareader.GetInt64(employeedatareader.GetOrdinal("ContactNumber"));
            //    companyModel.EmployerAddress = employeedatareader.GetString(employeedatareader.GetOrdinal("Location"));
            //    companyModel.Website = employeedatareader.GetString(employeedatareader.GetOrdinal("Website"));
            //    companyModel.EmployeeId = employeedatareader.GetInt32(employeedatareader.GetOrdinal("EmployeeID"));

               
            //}



            //return companyModel;
       // }

        protected void EmployeeSqlDataSource_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}