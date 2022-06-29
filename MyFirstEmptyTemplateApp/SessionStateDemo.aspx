<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionStateDemo.aspx.cs" Inherits="MyFirstEmptyTemplateApp.SessionStateDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtCounter" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCounter" runat="server" OnClick="btnCounter_Click" Text="Increment" />
        </div>
    </form>
</body>
</html>
