using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pioneer.Database.Model;

namespace PioneerEmployeeDatabase.DAL
{
    public class EmployeeDataAccessLayer
    {


        public int SaveEmployeeData(EmployeeModel p_detail)
        {


            SqlConnection conn = new SqlConnection("Data Source = PRAJWOLPC;database = Pioneer_Employee_Database1;Integrated security = SSPI");

            conn.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "s";


            //command.Parameters.AddWithValue("@FirstName", p_detail.FirstName);
            command.Parameters.AddWithValue("@FirstName", "TEST$$$$");
            command.Parameters.AddWithValue("@LastName", p_detail.LastName);
            command.Parameters.AddWithValue("@EmailID", p_detail.EmailId);
            command.Parameters.AddWithValue("@ContactNumber", p_detail.MobileNumber);
            command.Parameters.AddWithValue("@alternateContactNumber", p_detail.AlternateMobileNumber);
            command.Parameters.AddWithValue("@AdressLine1", p_detail.Address1);
            command.Parameters.AddWithValue("@AddressLine2", p_detail.Address2);
            command.Parameters.AddWithValue("@CurrentCountry", p_detail.CurrentCountry);
            command.Parameters.AddWithValue("@HomeCountry", p_detail.HomeCountry);
            command.Parameters.AddWithValue("@ZipCode", p_detail.ZipCode);
            //command.Parameters.AddWithValue("@employeeID", p_detail.EmployeeID);

            //SqlCommand cmd = new SqlCommand("INSERT INTO EmployeeDetail VALUES(" +
            //                "'" + model.FirstName + "','" + model.LastName + "','" + model.EmailId + "'," +
            //                model.MobileNumber + "," + model.AlternateMobileNumber + ",'" + model.Address1 + "','" + model.Address2 +
            //                "','" + model.CurrentCountry + "','" + model.HomeCountry + "'," + model.ZipCode + ")", mysqlconnection);
            ////Opening Sql Database Connection

            //mysqlconnection.Open();


            ////SqlDataReader Dr = cmd.ExecuteReader();
            //result = cmd.ExecuteNonQuery();
            int result1 = 1;
            return result1;

        }


            public int SaveProjectData(ProjectModel model)
            {
                int result;
                SqlConnection mysqlconnection = new SqlConnection()
                {
                    ConnectionString = "Data Source = PRAJWOLPC;database = Pioneer_Employee_Database1;Integrated security = SSPI"
                };
                SqlCommand cmd = new SqlCommand("INSERT INTO ProjectDetail VALUES(" +
                                "'" + model.ProjectName + "','" + model.ClientName + "','" + model.Place + "','" + model.Role + "'," + model.EmployeeId + ")", mysqlconnection);
                //Opening Sql Database Connection

                mysqlconnection.Open();


                //SqlDataReader Dr = cmd.ExecuteReader();
                result = cmd.ExecuteNonQuery();
                return result;
            }

            public int SaveCompanyData(CompanyModel model)
            {
                int result;
                SqlConnection mysqlconnection = new SqlConnection()
                {
                    ConnectionString = "Data Source = PRAJWOLPC;database = Pioneer_Employee_Database1;Integrated security = SSPI"
                };
                SqlCommand cmd = new SqlCommand("INSERT INTO CompanyDetail VALUES('" + model.EmployerName + "'," + model.EmployerContactNumber + ",'" + model.EmployerAddress + "','" + model.Website + "'," + model.EmployeeId + ")", mysqlconnection);
                mysqlconnection.Open();
                result = cmd.ExecuteNonQuery();
                return result;
            }

            public int SaveTechnicalData(TechnicalModel model)
            {
                int result;
                SqlConnection mysqlconnection = new SqlConnection()
                {
                    ConnectionString = "Data Source = PRAJWOLPC;database = Pioneer_Employee_Database1;Integrated security = SSPI"
                };
                SqlCommand cmd = new SqlCommand("EXEC [dbo].[saveTechnicalDetails] '" + model.UI + "','" + model.ProgrammingLanguage + "','" + model.DatabaseName + "'," + model.EmployeeId + " GO", mysqlconnection);
                // SqlCommand cmd = new SqlCommand("INSERT INTO TechnicalDetail VALUES('" + model.UI + "','" + model.ProgrammingLanguage + "','" + model.DatabaseName + "'," + model.EmployeeId + ")", mysqlconnection);


                mysqlconnection.Open();
                result = cmd.ExecuteNonQuery();
                return result;
            }



            public int SaveEducationData(EducationModel model)
            {
                int result;
                SqlConnection mysqlconnection = new SqlConnection()
                {
                    ConnectionString = "Data Source = PRAJWOLPC;database = Pioneer_Employee_Database1;Integrated security = SSPI"
                };
                SqlCommand cmd = new SqlCommand("INSERT INTO EducationDetail VALUES('" + model.CourseType + "'," + model.YearOfPass + ",'" + model.CourseSpecialization + "'," + model.EmployeeId + ")", mysqlconnection);

                mysqlconnection.Open();
                result = cmd.ExecuteNonQuery();
                return result;
            }


            public void DashBoardDisplay()
            {


            }
        }


    }

