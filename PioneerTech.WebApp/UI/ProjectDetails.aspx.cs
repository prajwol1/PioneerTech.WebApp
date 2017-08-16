using Pioneer.Database.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PioneerEmployeeDatabase.DAL;

namespace PioneerTech.WebApp.UI
{
    public partial class ProjectDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectModel model = new ProjectModel();
            model = GetProjectDetails(Convert.ToInt32(EditEmployeeInProjectDropDownList.Text));

            ProjectNameTextBox.Text = model.ProjectName;
            ClienNameTextBox.Text = model.ClientName;
            LocationTextBox.Text = model.Place;
            RolesTextBox.Text = model.Role;
            EmployeeIdDropDownList.Text = Convert.ToString(model.EmployeeId);


        }



        public ProjectModel GetProjectDetails(int employeeid)
        {
            ProjectModel empdmodel = new ProjectModel();

            string connectionstring = "Data Source=PRAJWOLPC;Initial Catalog=Pioneer_Employee_Database1;" +
                   " Integrated Security=SSPI";
            SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            mysqlconnection.Open();
            string sqldetails = ("Select * FROM ProjectDetail WHERE EmployeeID=" + employeeid);
            SqlCommand command;
            command = new SqlCommand(sqldetails, mysqlconnection);
            SqlDataReader employeedatareader = command.ExecuteReader();

            while (employeedatareader.Read())
            {


                empdmodel.ProjectName = employeedatareader.GetString(employeedatareader.GetOrdinal("ProjectName"));
                empdmodel.ClientName = employeedatareader.GetString(employeedatareader.GetOrdinal("ClientName"));
                empdmodel.Place = employeedatareader.GetString(employeedatareader.GetOrdinal("Location"));
                empdmodel.Role = employeedatareader.GetString(employeedatareader.GetOrdinal("Roles"));
                empdmodel.EmployeeId = employeedatareader.GetInt32(employeedatareader.GetOrdinal("EmployeeID"));

            }



            return empdmodel;
        }

        protected void EditButton_Click(object sender, EventArgs e)
        {
            ProjectModel model = new ProjectModel()
            {
                ProjectName = ProjectNameTextBox.Text,
                ClientName = ClienNameTextBox.Text,
                Place = LocationTextBox.Text,
                Role=RolesTextBox.Text,
                EmployeeId = Convert.ToInt32(EmployeeIdDropDownList.Text)


            };

            int EditEmployeeId = Convert.ToInt32(EditEmployeeInProjectDropDownList.Text);
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = PRAJWOLPC;database = Pioneer_Employee_Database1;Integrated security = SSPI";

            SqlCommand cmd = new SqlCommand("UPDATE [ProjectDetail] SET[ProjectName] = " +
                            "'" + model.ProjectName + "',[ClientName] = '" + model.ClientName + "',[Location] = '" + model.Place + "',[Roles] = '" + model.Role + "'WHERE EmployeeID = " + EditEmployeeId, mysqlconnection);
            mysqlconnection.Open();

            int result = cmd.ExecuteNonQuery();
            ClientScript.RegisterStartupScript(this.GetType(), "Operation was", "alert(' Project Details SUCCESSFULLY Edited');", true);

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            ProjectModel model = new ProjectModel()
            {
                ProjectName = ProjectNameTextBox.Text,
                ClientName = ClienNameTextBox.Text,
                Place = LocationTextBox.Text,
                Role = RolesTextBox.Text,
                EmployeeId = Convert.ToInt32(EmployeeIdDropDownList.Text)


            };
            EmployeeDataAccessLayer EmployeeDAL = new EmployeeDataAccessLayer();

            int NoOfRowsAffected = EmployeeDAL.SaveProjectData(model);
            if (NoOfRowsAffected >0)
                ClientScript.RegisterStartupScript(this.GetType(), "Operation was", "alert(' Project Details SUCCESSFULLY Edited');", true);
            else
                ClientScript.RegisterStartupScript(this.GetType(), "Operation was", "alert(' Save Unsuccesfull.Please Contact Administrator');", true);
        }
    }
}