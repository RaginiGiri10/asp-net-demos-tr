
<%--Step 1 - Remove existing HTML.
Step2 - Add the MasterPage file path in the @Page
Step 3 - add the content control and map the contentplaceholderid with the id of
         ContentPlaceHolder of master page.
    
Step 4 - Make usre that runat="server" is added.
--%>


<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="EmployeeMnagementTemplated.AddEmployee" MasterPageFile="~/Site.Master" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
    <br />
    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>

    <asp:RequiredFieldValidator runat="server" ID="rqfvtxtFirstName" ControlToValidate="txtFirstName" ErrorMessage ="First Name is mandatory" ForeColor="Red"></asp:RequiredFieldValidator>

    <br />
     <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
    <br />
    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
     <asp:RequiredFieldValidator runat="server" ID="rqfvtxtLastName" ControlToValidate="txtLastName" ErrorMessage ="Last Name is mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />

     <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
    <br />
   
    <asp:RadioButtonList ID="radioGenderList" runat="server" RepeatColumns="2">
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
    </asp:RadioButtonList>
 <asp:RequiredFieldValidator runat="server" ID="rqfvRadioGenderList" ControlToValidate="radioGenderList" 
     ErrorMessage ="Select gender" ForeColor="Red"></asp:RequiredFieldValidator>

    
    <br />

    <asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label>
     <br />
    <asp:DropDownList ID="ddlCountries" runat="server"></asp:DropDownList>
    <br />

    <asp:Button ID="btnAddEmployee" runat="server" Text="Add Employee" OnClick="btnAddEmployee_Click" />

</asp:Content>