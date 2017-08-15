<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="EmployeeDetail.aspx.cs" Inherits="PioneerTech.WebApp.UI.EmployeeDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style10 {
            width: 154px;
        }
        .auto-style11 {
        width: 287px;
    }
    .auto-style12 {
        width: 100%;
        height: 306px;
    }
    .auto-style13 {
        margin-left: 91px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table id="EmployeeTable" class="auto-style12">
        <tr>
            <td class="auto-style10">Employee Details</td>
         </tr>

        <tr id =" FirstName">
            <td class="auto-style10">First Name</td>
            <td class="auto-style11">
                <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox>
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
              </td>
        </tr>  
        
        <tr id ="MobileNumber">

            <td class="auto-style10" >Mobile Number</td>
            <td class="auto-style11" >
                <asp:TextBox ID="MobileNumberTextBox" runat="server"></asp:TextBox>
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
             </td>
        </tr>
        
         <tr id ="Address2">
            <td class="auto-style10" >Address 2</td>
            <td class="auto-style11" >
                <asp:TextBox ID="Address2TextBox" runat="server"></asp:TextBox>
             </td>
        </tr>

        <tr id ="Home Country">
            <td class="auto-style10" >Home Country</td>
            <td class="auto-style11" >
                <asp:TextBox ID="HomeCountryTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>        
       <tr id ="Current Country">
            <td class="auto-style10" >Current Country</td>
            <td class="auto-style11" >
                <asp:TextBox ID="CurrentCountryTextBox" runat="server"></asp:TextBox>
            </td>

        <tr id ="Zip Code">
            <td class="auto-style10" >Zip Code</td>
            <td class="auto-style11" >
                <asp:TextBox ID="ZipCodeTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>        

         <tr id ="Buttons">
            <td class="auto-style10">
                <asp:Button ID="SaveButton" runat="server" Text="Save" Height="25px" Width="74px" OnClick="SaveButton_Click" />
             </td>
            <td class="auto-style11" >
                <asp:Button ID="EditButton" runat="server" Text="Edit" Height="20px" Width="84px" OnClick="EditButton_Click" />
                <asp:DropDownList ID="EditEmployeeDropDownList" runat="server" DataSourceID="EmployeeSqlDataSource" DataTextField="EmployeeID" DataValueField="EmployeeID" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="181px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="EmployeeSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Pioneer_Employee_Database1ConnectionString %>" SelectCommand="SELECT [EmployeeID], [FirstName] FROM [EmployeeDetail]"></asp:SqlDataSource>
             </td>
             <td>
                 <asp:Button ID="ClearButton" runat="server" Text="Clear" Height="23px" Width="75px" CssClass="auto-style13" OnClick="ClearButton_Click" />
             </td>
        </tr>    
        
        <tr>
            <td></td>
            <td class="auto-style11"> 


            </td>
        </tr>


        

    </table>

    
</asp:Content>
