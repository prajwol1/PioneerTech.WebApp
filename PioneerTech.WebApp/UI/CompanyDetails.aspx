<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="CompanyDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.CompanyDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 276px;
        }
        .auto-style2 {
            width: 179px;
        }
        .auto-style3 {
            width: 179px;
            height: 177px;
        }
        .auto-style4 {
            width: 276px;
            height: 177px;
        }
        .auto-style5 {
            height: 177px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


      <table id="CompanyDetail" style="width: 100%; height: 191px;">
        <tr>
            <td class="auto-style2">Company Details</td>
         </tr>

        <tr id =" EmployerName">
            <td class="auto-style2">Employer Name</td>
            <td class="auto-style1">
                <asp:TextBox ID="EmployerNameTextBox" runat="server"></asp:TextBox>
            </td>
         </tr>
         
          <tr id="EmployerContactNumber">
              <td class="auto-style2">Contact Number</td>
              <td class="auto-style1">
                  <asp:TextBox ID="EmployerContactNumberTextBox" runat="server"></asp:TextBox>
              </td>
          </tr>

          <tr id="EmployerLocation">
              <td class="auto-style2">Location</td>
              <td class="auto-style1">
                  <asp:TextBox ID="EmployerLocationTextBox" runat="server"></asp:TextBox>
              </td>
          </tr>

          <tr id="EmployerWebsite">
              <td class="auto-style2">Website</td>
              <td class="auto-style1">
                  <asp:TextBox ID="EmployerWebsiteTextBox" runat="server"></asp:TextBox>
              </td>
          </tr>
          <tr id="EmployeeId">
              <td class="auto-style2">Employee Id</td>
              <td class="auto-style1">
                  <asp:TextBox ID="EmployeeIdTextBox" runat="server"></asp:TextBox>
                  <asp:DropDownList ID="EmployeeIdCompanyDropDownList" runat="server" DataSourceID="EmployeeSqlDataSource" DataTextField="EmployeeID" DataValueField="EmployeeID">
                  </asp:DropDownList>
              </td>
          </tr>

          <tr>
              <td class="auto-style3">
                  <asp:Button ID="CompanySaveButton" runat="server" Text="Save" Height="28px" OnClick="CompanySaveButton_Click" Width="71px" />
              </td>
              <td class="auto-style4">
                  <asp:Button ID="CompanyEditButton" runat="server" Text="Edit" Height="26px" Width="69px" OnClick="CompanyEditButton_Click" />
                  <br />
                  Employee Id<asp:DropDownList ID="EditCompanyEmployeeIdDropDownList" runat="server" AutoPostBack="True" DataSourceID="EmployeeSqlDataSource" DataTextField="EmployeeID" DataValueField="EmployeeID" Height="16px" OnInit="DropDownList2_SelectedIndexChanged" OnSelectedIndexChanged="EditCompanyEmployeeIdDropDownList_SelectedIndexChanged" Width="167px">
                  </asp:DropDownList>
                  <asp:SqlDataSource ID="EmployeeSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Pioneer_Employee_Database1ConnectionString %>" SelectCommand="SELECT [EmployeeID] FROM [CompanyDetail]"></asp:SqlDataSource>
                  Company Id<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="CompanyID" DataValueField="CompanyID" Height="17px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Width="161px">
                  </asp:DropDownList>
                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Pioneer_Employee_Database1ConnectionString %>" SelectCommand="SELECT [CompanyID] FROM [CompanyDetail] WHERE ([EmployeeID] = @EmployeeID)">
                      <SelectParameters>
                          <asp:ControlParameter ControlID="EditCompanyEmployeeIdDropDownList" Name="EmployeeID" PropertyName="SelectedValue" Type="Int32" />
                      </SelectParameters>
                  </asp:SqlDataSource>
              </td>
              <td class="auto-style5">
                  <asp:Button ID="CompanyClearButton" runat="server" Text="Clear" Height="28px" OnClick="CompanyClearButton_Click" Width="67px" />
              </td>
          </tr>
    This Is Company Detail.
</asp:Content>
