<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="EducationDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.EducationDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 169px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    This is Education Detail

    <table style="width: 100%;">
        <tr>
            <td class="auto-style1">Course Type</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="185px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Course Year</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="185px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Course Specialization</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Width="182px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="SaveButton" runat="server" Text="Save" />
            </td>
            <td>
                <asp:Button ID="EditButton" runat="server" Text="Edit" Width="58px" />
            </td>
            <td>
                <asp:Button ID="ClearButton" runat="server" Text="Clear" />
            </td>
        </tr>

    </table>
</asp:Content>
