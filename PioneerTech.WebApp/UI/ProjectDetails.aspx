<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="ProjectDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.ProjectDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    This Is Project Detail.

     <table style="width: 100%;">
        <tr>
            <td class="auto-style1">Project Name</td>
            <td>
                <asp:TextBox ID="ProjectNameTextBox" runat="server" Width="185px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ProjectNameTextBox" ErrorMessage="Please Enter Project Name"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Client Name</td>
            <td>
                <asp:TextBox ID="ClienNameTextBox" runat="server" Width="185px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ClienNameTextBox" ErrorMessage="Please Enter Client Name"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Location</td>
            <td>
                <asp:TextBox ID="LocationTextBox" runat="server" Width="182px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="LocationTextBox" ErrorMessage="Please Enter  Location"></asp:RequiredFieldValidator>
            </td>
        </tr>
          <tr>
            <td class="auto-style1">Roles</td>
            <td>
                <asp:TextBox ID="RolesTextBox" runat="server" Width="182px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="RolesTextBox" ErrorMessage="Please Enter Role"></asp:RequiredFieldValidator>
            </td>
        </tr>
          <tr>
            <td class="auto-style1">Employee Id</td>
            <td>
                <asp:DropDownList ID="EmployeeIdDropDownList" runat="server" DataSourceID="SqlDataSource2" DataTextField="EmployeeID" DataValueField="EmployeeID" Height="25px" Width="192px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Pioneer_Employee_Database1ConnectionString %>" SelectCommand="SELECT [EmployeeID] FROM [EmployeeDetail]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="SaveButton" runat="server" Text="Save" OnClick="SaveButton_Click" />
            </td>
            <td>
                <asp:Button ID="EditButton" runat="server" Text="Edit" Width="58px" OnClick="EditButton_Click" />
                <asp:DropDownList ID="EditEmployeeInProjectDropDownList" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="EmployeeID" DataValueField="EmployeeID" Height="16px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="130px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Pioneer_Employee_Database1ConnectionString %>" SelectCommand="SELECT [EmployeeID] FROM [ProjectDetail]"></asp:SqlDataSource>
            </td>
            <td>
                <asp:Button ID="ClearButton" runat="server" Text="Clear" OnClick="ClearButton_Click" />
            </td>
        </tr>

    </table>
</asp:Content>
