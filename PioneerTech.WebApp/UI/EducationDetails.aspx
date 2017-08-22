<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="EducationDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.EducationDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 169px;
        }
        .auto-style2 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table style="width: 100%;">
        <tr>
            <td class="auto-style1">Course Type</td>
            <td>
                <asp:TextBox ID="CourseTypeTextBox" runat="server" Width="185px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="CourseTypeTextBox" ErrorMessage="Please Enter Course Type"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Course Year</td>
            <td>
                <asp:TextBox ID="CourseYearTextBox" runat="server" Width="185px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="CourseYearTextBox" ErrorMessage="Please Enter Course Year"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Course Specialization</td>
            <td>
                <asp:TextBox ID="CourseSpecialiazationTextBox" runat="server" Width="182px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="CourseSpecialiazationTextBox" ErrorMessage="Please Enter Course Specialization"></asp:RequiredFieldValidator>
            </td>
        </tr>
              <tr>
            <td class="auto-style1">Employee Id</td>
            <td>
                <asp:DropDownList ID="EmployeeIdDropDownList" runat="server" DataSourceID="SqlDataSource1" DataTextField="EmployeeID" DataValueField="EmployeeID" Height="26px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="194px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Pioneer_Employee_Database1ConnectionString %>" SelectCommand="SELECT [EmployeeID] FROM [EmployeeDetail]"></asp:SqlDataSource>
            </td>
        </tr>

        <tr>
            <td>          
                <asp:Button ID="SaveButton" runat="server" Text="Save" OnClick="SaveButton_Click" />
            </td>
            <td>  
                <asp:Button ID="EditButton" runat="server" Text="Edit" Width="58px" OnClick="EditButton_Click" />
            </td>
            <td> 
                <asp:Button ID="ClearButton" runat="server" Text="Clear" OnClick="ClearButton_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
            </td>
            <td class="auto-style2">
                <asp:DropDownList ID="EditEmployeeIdInEducationDropDownList" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="EmployeeID" DataValueField="EmployeeID" Height="17px" OnSelectedIndexChanged="EditEmployeeIdInEducationDropDownList_SelectedIndexChanged" Width="136px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Pioneer_Employee_Database1ConnectionString %>" SelectCommand="SELECT [EmployeeID] FROM [EducationDetail]"></asp:SqlDataSource>
            </td>
            <td class="auto-style2">
            </td>
        </tr>

    </table>
</asp:Content>
