<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyFirstEmptyTemplateApp.Default"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Default Title</title>
</head>
<body>
    <form id="form1" runat="server" >
        <br />
        <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="True" Text="FirstName"></asp:Label>
        <br />
        <asp:TextBox ID="txtFirstName" runat="server" ></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="LastName"></asp:Label>
        <br />
        <asp:TextBox ID="txtLastName" runat="server" ></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblFullName" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Button ID="btnDisplayFullName" runat="server" Height="46px" OnClick="btnDisplayFullName_Click" Text="Display FullName" Width="180px" />
        
    </form>
</body>
</html>
