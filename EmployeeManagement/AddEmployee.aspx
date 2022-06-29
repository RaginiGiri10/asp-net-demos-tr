<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="EmployeeManagement.AddEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Label2" runat="server" Text="FirstName"></asp:Label>
            <br />
&nbsp;<asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName" ErrorMessage="FirstName is required." ForeColor="#CC3300"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="LastName"></asp:Label>
            <br />
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label>
            <br />
            <asp:RadioButton ID="radioMale" runat="server" GroupName="genderGroup" Text="Male" />
            <asp:RadioButton ID="radioFemale" runat="server" GroupName="genderGroup" Text="Female" />
            <br />
            <br />
            <asp:Button ID="btnAddEmployee" runat="server" OnClick="btnAddEmployee_Click" Text="Add Employee" />
        </div>
    </form>
</body>
</html>
