<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewEmployees.aspx.cs" Inherits="EmployeeMnagementTemplated.ViewEmployees" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

    <asp:Label ID="header" runat="server" Text ="Employees" Font-Bold="true"></asp:Label>

    <asp:GridView ID="gridEmployees" runat ="server" Height="341px" Width="705px">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="lnkDelete" runat="server" Text="Delete" OnClick="lnkDelete_Click" CommandArgument='<%#Eval("Id") %>'></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>


</asp:Content>