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
    public partial class TechnicalDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            TechnicalModel model = new TechnicalModel()
            {
                UI = UITextBox.Text,
                ProgrammingLanguage = ProgrammingLanguageTextBox.Text,
                DatabaseName = DatabaseTextBox.Text,
                EmployeeId = Convert.ToInt32(EmployeeIdDropDownList.Text)


            };
            EmployeeDataAccessLayer EmployeeDAL = new EmployeeDataAccessLayer();

            int NoOfRowsAffected = EmployeeDAL.SaveTechnicalData(model);


            if (NoOfRowsAffected > 0)
                ClientScript.RegisterStartupScript(this.GetType(), "Operation was", "alert(' Technical Details SUCCESSFULLY Saved');", true);
            else
                ClientScript.RegisterStartupScript(this.GetType(), "Operation was", "alert(' Save Unsuccesfull.Please Contact Administrator');", true);

        }

        protected void EditButton_Click(object sender, EventArgs e)
        {
            TechnicalModel model = new TechnicalModel()
            {
                UI = UITextBox.Text,
                ProgrammingLanguage = ProgrammingLanguageTextBox.Text,
                DatabaseName = DatabaseTextBox.Text,
                EmployeeId = Convert.ToInt32(EmployeeIdDropDownList.Text)


            };

            int EditEmployeeId = Convert.ToInt32(EditDropDownList.Text);

            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = PRAJWOLPC;database = Pioneer_Employee_Database1;Integrated security = SSPI";

            SqlCommand cmd = new SqlCommand("UPDATE [TechnicalDetail] SET[UI] = " +
                            "'" + model.UI + "',[ProgrammingLanguage] = '" + model.ProgrammingLanguage + "',[Database] = '" + model.DatabaseName + "'WHERE EmployeeID = " + EditEmployeeId, mysqlconnection);
            mysqlconnection.Open();

            int result = cmd.ExecuteNonQuery();
            ClientScript.RegisterStartupScript(this.GetType(), "Operation was", "alert(' Technical Details SUCCESSFULLY Edited');", true);

        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            UITextBox.Text = "";
            ProgrammingLanguageTextBox.Text = "";
            DatabaseTextBox.Text = "";
        }

        protected void EditDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            TechnicalModel model = new TechnicalModel();
            model = GetTechnicalDetails(Convert.ToInt32(EditDropDownList.Text));


            UITextBox.Text = model.UI;
            ProgrammingLanguageTextBox.Text =model.ProgrammingLanguage;
            DatabaseTextBox.Text = model.DatabaseName;
        }

        public TechnicalModel GetTechnicalDetails(int employeeid)
        {
            TechnicalModel empdmodel = new TechnicalModel();

            string connectionstring = "Data Source=PRAJWOLPC;Initial Catalog=Pioneer_Employee_Database1;" +
                   " Integrated Security=SSPI";
            SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            mysqlconnection.Open();
            string sqldetails = ("Select * FROM TechnicalDetail WHERE EmployeeID=" + employeeid);
            SqlCommand command;
            command = new SqlCommand(sqldetails, mysqlconnection);
            SqlDataReader employeedatareader = command.ExecuteReader();

            while (employeedatareader.Read())
            {

                empdmodel.UI = employeedatareader.GetString(employeedatareader.GetOrdinal("UI"));
                empdmodel.ProgrammingLanguage = employeedatareader.GetString(employeedatareader.GetOrdinal("ProgrammingLanguage"));
                empdmodel.DatabaseName = employeedatareader.GetString(employeedatareader.GetOrdinal("Database"));
                
            }
            return empdmodel;
        }

    }
}