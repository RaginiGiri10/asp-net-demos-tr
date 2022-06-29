<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStateDemo.aspx.cs" Inherits="MyFirstEmptyTemplateApp.ViewStateDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="txtCount" runat="server" ></asp:TextBox>
            <br />
            <asp:Button ID="btnCounter" runat="server" OnClick="btnCounter_Click" Text="Click" />

        </div>
    </form>
</body>
</html>
