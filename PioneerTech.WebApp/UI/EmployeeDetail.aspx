<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="EmployeeDetail.aspx.cs" Inherits="PioneerTech.WebApp.UI.EmployeeDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style10 {
            width: 154px;
        }
        .auto-style11 {
            width: 523px;
        }
    .auto-style12 {
        width: 100%;
        height: 306px;
    }
    .auto-style13 {
        margin-left: 91px;
    }
        .auto-style14 {
            width: 154px;
            height: 49px;
        }
        .auto-style15 {
            width: 523px;
            height: 49px;
        }
        .auto-style16 {
            width: 89px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table id="EmployeeTable" class="auto-style12">
      
        <tr id =" FirstName">
            <td class="auto-style10">First Name</td>
            <td class="auto-style11">
                <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="FirstNameValidator" runat="server" ErrorMessage="Please Enter First Name" ControlToValidate="FirstNameTextBox"></asp:RequiredFieldValidator>
            </td>
         </tr>

        <tr id ="LastName">
            <td class="auto-style10" >Last Name</td>
            <td class="auto-style11" >
                <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>

          <tr id ="EmailID">
            <td class="auto-style10" >Email ID</td>
            <td class="auto-style11" >
                <asp:TextBox ID="EmailIdTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName" runat="server" ErrorMessage="Please Enter Last Name" ControlToValidate="EmailIdTextBox"></asp:RequiredFieldValidator>
              </td>
        </tr>  
        
        <tr id ="MobileNumber">

            <td class="auto-style10" >Mobile Number</td>
            <td class="auto-style11" >
                <asp:TextBox ID="MobileNumberTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter Mobile Number" ControlToValidate="MobileNumberTextBox"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Phone Number should be 10 digit" ControlToValidate="MobileNumberTextBox" ValidationExpression="((\(\d{3}\) ?)|(\d{3}))?\d{3}\d{4}"></asp:RegularExpressionValidator>
            </td>
        </tr>  

        <tr id ="AlternateMobileNumber">
            <td class="auto-style10" >Alternate Mobile Number</td>
            <td class="auto-style11" >
                <asp:TextBox ID="AlternateMobileNumberTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>

         <tr id ="Address1">
            <td class="auto-style10" >Address 1</td>
            <td class="auto-style11" >
                <asp:TextBox ID="Address1TextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Enter Address" ControlToValidate="Address1TextBox"></asp:RequiredFieldValidator>
             </td>
        </tr>
        
         <tr id ="Address2">
            <td class="auto-style10" >Address 2</td>
            <td class="auto-style11" >
                <asp:TextBox ID="Address2TextBox" runat="server"></asp:TextBox>
             </td>
        </tr>

        <tr id ="Home Country">
            <td class="auto-style14" >Home Country</td>
            <td class="auto-style15" >
                <asp:TextBox ID="HomeCountryTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please Enter Home Country" ControlToValidate="HomeCountryTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>        
       <tr id ="Current Country">
            <td class="auto-style10" >Current Country</td>
            <td class="auto-style11" >
                <asp:TextBox ID="CurrentCountryTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please Enter Current Country" ControlToValidate="CurrentCountryTextBox"></asp:RequiredFieldValidator>
            </td>

        <tr id ="Zip Code">
            <td class="auto-style10" >Zip Code</td>
            <td class="auto-style11" >
                <asp:TextBox ID="ZipCodeTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please Enter Zip Code" ControlToValidate="ZipCodeTextBox"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Incorrect Zip Code format" ValidationExpression="\d{5}(-\d{4})?" ControlToValidate="ZipCodeTextBox"></asp:RegularExpressionValidator>
            </td>
        </tr>        

         <tr id ="Buttons">
            <td class="auto-style10">
                <asp:Button ID="SaveButton" runat="server" Text="Save" Height="35px" Width="101px" OnClick="SaveButton_Click" />
             </td>
            <td class="auto-style11" >
                <asp:Button ID="EditButton" runat="server" Text="Edit" Height="35px" Width="100px" OnClick="EditButton_Click" />
                <asp:DropDownList ID="EditEmployeeDropDownList" runat="server" DataSourceID="EmployeeSqlDataSource" DataTextField="EmployeeID" DataValueField="EmployeeID" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="181px" AutoPostBack="True">
                </asp:DropDownList>
                <asp:SqlDataSource ID="EmployeeSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Pioneer_Employee_Database1ConnectionString %>" SelectCommand="SELECT [EmployeeID], [FirstName] FROM [EmployeeDetail]"></asp:SqlDataSource>
             </td>
             <td class="auto-style16">
                 <asp:Button ID="ClearButton" runat="server" Text="Clear" Height="36px" Width="102px" CssClass="auto-style13" OnClick="ClearButton_Click" />
             </td>
        </tr>    
        
        <tr>
            <td></td>
            <td class="auto-style11"> 


            </td>
        </tr>


        

    </table>

    
</asp:Content>
