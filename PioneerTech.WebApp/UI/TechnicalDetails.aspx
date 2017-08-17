<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="TechnicalDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.TechnicalDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 148px;
        }
        .auto-style2 {
            width: 248px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <table style="width: 100%;">
        <tr>
            <td class="auto-style1">UI</td>
            <td class="auto-style2">
                <asp:TextBox ID="UITextBox" runat="server" Width="185px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Programming Language</td>
            <td class="auto-style2">
                <asp:TextBox ID="ProgrammingLanguageTextBox" runat="server" Width="185px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Database</td>
            <td class="auto-style2">
                <asp:TextBox ID="DatabaseTextBox" runat="server" Width="182px"></asp:TextBox>
            </td>
        </tr>
              <tr>
            <td class="auto-style1">Employee Id</td>
            <td class="auto-style2">
                <asp:DropDownList ID="EmployeeIdDropDownList" runat="server" DataSourceID="SqlDataSource1" DataTextField="EmployeeID" DataValueField="EmployeeID" Height="16px" Width="190px" AutoPostBack="True">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Pioneer_Employee_Database1ConnectionString %>" SelectCommand="SELECT [EmployeeID] FROM [EmployeeDetail]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Button ID="SaveButton" runat="server" Text="Save" OnClick="SaveButton_Click" />
            </td>
            <td class="auto-style2">
                <asp:Button ID="EditButton" runat="server" Text="Edit" OnClick="EditButton_Click" />
                <asp:DropDownList ID="EditDropDownList" runat="server" Height="18px" Width="127px" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="EmployeeID" DataValueField="EmployeeID" OnSelectedIndexChanged="EditDropDownList_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Pioneer_Employee_Database1ConnectionString %>" SelectCommand="SELECT [EmployeeID] FROM [TechnicalDetail]"></asp:SqlDataSource>
            </td>
            <td>
                <asp:Button ID="ClearButton" runat="server" Text="Clear" OnClick="ClearButton_Click" />
            </td>
        </tr>

    </table>


</asp:Content>
