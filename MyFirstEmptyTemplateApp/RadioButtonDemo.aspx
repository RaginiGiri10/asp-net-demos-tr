<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadioButtonDemo.aspx.cs" Inherits="MyFirstEmptyTemplateApp.RadioButtonDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Gender"></asp:Label>
            <asp:RadioButton ID="radioMale" runat="server" AutoPostBack="False" GroupName="genderGroup"  Text="Male" />
            <asp:RadioButton ID="radioFemale" runat="server" GroupName="genderGroup" Text="Female" />
            <br />
            <br />
            <asp:Label ID="lblGender" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Display Gender" />
        </div>
    </form>
</body>
</html>
