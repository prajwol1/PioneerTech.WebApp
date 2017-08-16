using Pioneer.Database.Model;
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
    public partial class EducationDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public EducationModel GetEducationDetails(int employeeid)
        {
            EducationModel empdmodel = new EducationModel();

            string connectionstring = "Data Source=PRAJWOLPC;Initial Catalog=Pioneer_Employee_Database1;" +
                   " Integrated Security=SSPI";
            SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            mysqlconnection.Open();
            string sqldetails = ("Select * FROM EducationDetail WHERE EmployeeID=" + employeeid);
            SqlCommand command;
            command = new SqlCommand(sqldetails, mysqlconnection);
            SqlDataReader employeedatareader = command.ExecuteReader();

            while (employeedatareader.Read())
            {


                empdmodel.CourseType = employeedatareader.GetString(employeedatareader.GetOrdinal("CourseType"));
                empdmodel.YearOfPass = Convert.ToString(employeedatareader.GetInt32(employeedatareader.GetOrdinal("YearOfPass")));
                empdmodel.CourseSpecialization = employeedatareader.GetString(employeedatareader.GetOrdinal("CourseSpecilization"));
                empdmodel.EmployeeId = employeedatareader.GetInt32(employeedatareader.GetOrdinal("EmployeeID"));

            }
            return empdmodel;
        }

        protected void EditEmployeeIdInEducationDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            EducationModel model = new EducationModel();
            model = GetEducationDetails(Convert.ToInt32(EditEmployeeIdInEducationDropDownList.Text));

            CourseTypeTextBox.Text = model.CourseType;
            CourseYearTextBox.Text = model.YearOfPass;
            CourseSpecialiazationTextBox.Text = model.CourseSpecialization;
            EmployeeIdDropDownList.Text = Convert.ToString(model.EmployeeId);

        }

        protected void EditButton_Click(object sender, EventArgs e)
        {
            EducationModel model = new EducationModel()
            {
                CourseType = CourseTypeTextBox.Text,
                YearOfPass = CourseYearTextBox.Text,
                CourseSpecialization = CourseSpecialiazationTextBox.Text,
                EmployeeId = Convert.ToInt32(EmployeeIdDropDownList.Text)


            };

            int EditEmployeeId = Convert.ToInt32(EditEmployeeIdInEducationDropDownList.Text);

            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = PRAJWOLPC;database = Pioneer_Employee_Database1;Integrated security = SSPI";

            SqlCommand cmd = new SqlCommand("UPDATE [EducationDetail] SET[CourseType] = " +
                            "'" + model.CourseType + "',[YearOfPass] = " + Convert.ToInt32(model.YearOfPass) + ",[CourseSpecilization] = '" + model.CourseSpecialization + "'WHERE EmployeeID = " + EditEmployeeId, mysqlconnection);
            mysqlconnection.Open();

            int result = cmd.ExecuteNonQuery();
            ClientScript.RegisterStartupScript(this.GetType(), "Operation was", "alert(' Education Details SUCCESSFULLY Edited');", true);

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            EducationModel model = new EducationModel()
            {
                CourseType = CourseTypeTextBox.Text,
                YearOfPass = CourseYearTextBox.Text,
                CourseSpecialization = CourseSpecialiazationTextBox.Text,
                EmployeeId = Convert.ToInt32(EmployeeIdDropDownList.Text)


            };
            EmployeeDataAccessLayer EmployeeDAL = new EmployeeDataAccessLayer();

            int NoOfRowsAffected = EmployeeDAL.SaveEducationData(model);
            if (NoOfRowsAffected > 0)
                ClientScript.RegisterStartupScript(this.GetType(), "Operation was", "alert(' Education Details SUCCESSFULLY Edited');", true);
            else
                ClientScript.RegisterStartupScript(this.GetType(), "Operation was", "alert(' Save Unsuccesfull.Please Contact Administrator');", true);
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            CourseSpecialiazationTextBox.Text = "";
            CourseTypeTextBox.Text = "";
            CourseYearTextBox.Text = "";
            EmployeeIdDropDownList.Text = "";
        }
    }
}