<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewEmployees.aspx.cs" Inherits="EmployeeManagement.ViewEmployees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" ForeColor="#CC3300" Text="Employee Details"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="gridEmployees" runat="server" Height="380px" Width="1013px" AutoGenerateColumns="true">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton runat="server" ID="lnkSelect" Text="Select" CommandArgument='<%# Eval("Id") %>' OnClick="lnkSelect_Click"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
