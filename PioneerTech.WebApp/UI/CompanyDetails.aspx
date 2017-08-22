<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="CompanyDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.CompanyDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 426px;
        }
        .auto-style2 {
            width: 179px;
        }
        .auto-style5 {
            height: 19px;
        }
        .auto-style6 {
            width: 179px;
            height: 20px;
        }
        .auto-style7 {
            width: 426px;
            height: 20px;
        }
        .auto-style8 {
            width: 100%;
            height: 383px;
        }
        .auto-style9 {
            height: 14px;
        }
        .auto-style10 {
            width: 426px;
            height: 14px;
        }
        .auto-style11 {
            width: 179px;
            height: 19px;
        }
        .auto-style12 {
            width: 426px;
            height: 19px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


      <table id="CompanyDetail" class="auto-style8">
       
        <tr id =" EmployerName">
            <td class="auto-style6">Employer Name</td>
            <td class="auto-style7">
                <asp:TextBox ID="EmployerNameTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="EmployerNameTextBox" ErrorMessage="Please Enter Employer Name"></asp:RequiredFieldValidator>
            </td>
         </tr>
         
          <tr id="EmployerContactNumber">
              <td class="auto-style6">Contact Number</td>
              <td class="auto-style7">
                  <asp:TextBox ID="EmployerContactNumberTextBox" runat="server"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="EmployerContactNumberTextBox" ErrorMessage="Please Enter Contact Number"></asp:RequiredFieldValidator>
              </td>
          </tr>

          <tr id="EmployerLocation">
              <td class="auto-style6">Location</td>
              <td class="auto-style7">
                  <asp:TextBox ID="EmployerLocationTextBox" runat="server"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="EmployerLocationTextBox" ErrorMessage="Please Enter Location"></asp:RequiredFieldValidator>
              </td>
          </tr>

          <tr id="EmployerWebsite">
              <td class="auto-style6">Website</td>
              <td class="auto-style7">
                  <asp:TextBox ID="EmployerWebsiteTextBox" runat="server" ></asp:TextBox>
              </td>
          </tr>
          <tr id="EmployeeId">
              <td class="auto-style6">Employee Id</td>
              <td class="auto-style7">
                  <asp:DropDownList ID="EmployeeIdCompanyDropDownList" runat="server" DataSourceID="EmployeeSqlDataSource" DataTextField="EmployeeID" DataValueField="EmployeeID" Width="169px" >
                  </asp:DropDownList>
              </td>
          </tr>

           <tr>
              <td class="auto-style9">
                  <asp:Button ID="CompanySaveButton" runat="server" Text="Save" Height="28px" OnClick="CompanySaveButton_Click" Width="71px" />
               </td>
              <td class="auto-style10">
                  <asp:Button ID="CompanyEditButton" runat="server" Text="Edit" Height="26px" Width="69px" OnClick="CompanyEditButton_Click" />
                  </td>
               <td class="auto-style9">

                  <asp:Button ID="CompanyClearButton" runat="server" Text="Clear" Height="28px" OnClick="CompanyClearButton_Click" Width="67px" />

               </td>
          </tr>

          <tr>
              <td class="auto-style11">
                  </td>
              <td class="auto-style12">
                  Employee Id<asp:DropDownList ID="EditCompanyEmployeeIdDropDownList" runat="server" AutoPostBack="True" DataSourceID="EmployeeSqlDataSource" DataTextField="EmployeeID" DataValueField="EmployeeID" Height="16px" OnInit="DropDownList2_SelectedIndexChanged" OnSelectedIndexChanged="EditCompanyEmployeeIdDropDownList_SelectedIndexChanged" Width="167px">
                  </asp:DropDownList>
                  <br />
                  <asp:SqlDataSource ID="EmployeeSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Pioneer_Employee_Database1ConnectionString %>" OnSelecting="EmployeeSqlDataSource_Selecting" SelectCommand="SELECT [EmployeeID] FROM [EmployeeDetail]"></asp:SqlDataSource>
                  Company Id<asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="CompanyID" DataValueField="CompanyID" Height="17px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Width="167px">
                  </asp:DropDownList>
                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Pioneer_Employee_Database1ConnectionString %>" SelectCommand="SELECT [CompanyID] FROM [CompanyDetail] WHERE ([EmployeeID] = @EmployeeID)">
                      <SelectParameters>
                          <asp:ControlParameter ControlID="EditCompanyEmployeeIdDropDownList" Name="EmployeeID" PropertyName="SelectedValue" Type="Int32" />
                      </SelectParameters>
                  </asp:SqlDataSource>
              </td>
              <td class="auto-style5">
                  &nbsp;&nbsp;&nbsp;
                  </td>
          </tr>

          <tr>
              <td></td>
              <td class="auto-style1"></td>
          </tr>
  </table>
</asp:Content>
