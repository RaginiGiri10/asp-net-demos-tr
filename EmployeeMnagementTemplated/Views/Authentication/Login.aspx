<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EmployeeMnagementTemplated.Views.Authentication.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

             <asp:Label ID="lblInvalidCredentials" runat="server" ForeColor ="Red" />
            <br />

            <asp:Label ID="lblUserName" runat="server" Text="UserName" />
            <br />
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rqvUserName" runat="server" ControlToValidate="txtUserName" 
                                        Text="User Name is mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />

             <asp:Label ID="lblPassword" runat="server" Text="Password" />
            <br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
              <asp:RequiredFieldValidator ID="rqvPassword" runat="server" ControlToValidate="txtPassword"
                                          Text="Password is mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />

            <asp:Button ID="btnRegister" runat="server" Text="Login" OnClick="btnRegister_Click" />
        </div>
    </form>
</body>
</html>
