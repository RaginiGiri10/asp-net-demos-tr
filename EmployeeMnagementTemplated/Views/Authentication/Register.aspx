<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="EmployeeMnagementTemplated.Views.Authentication.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="lblUserExists" runat="server" ForeColor ="Red" />
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

             <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password" />
            <br />
            <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
             <asp:RequiredFieldValidator ID="rqvConfirmPassword" runat="server" ControlToValidate="txtConfirmPassword"
                                          Text="*" ForeColor="Red"></asp:RequiredFieldValidator>

            <asp:CompareValidator ID="cvPasswordValidator" runat="server"
                ErrorMessage="Password & Confirm Password must match"
                ForeColor="Red" 
                ControlToValidate="txtPassword" 
                ControlToCompare="txtConfirmPassword"></asp:CompareValidator>
            <br />

              <asp:TextBox ID="txtAge" runat="server" TextMode="Number" />
             <asp:RangeValidator ID="rangeAgeValidator" runat="server" ControlToValidate="txtAge"
                MinimumValue="1" MaximumValue="100" ErrorMessage ="Age must be between 1 & 100" Type="Integer"></asp:RangeValidator>

            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />

        </div>
    </form>
</body>
</html>
