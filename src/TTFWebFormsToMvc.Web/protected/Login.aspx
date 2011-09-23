<%@ Page Title="" Language="C#" MasterPageFile="~/MainLayout.Master" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs" Inherits="TTFWebFormsToMvc.Web.Web.admin.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <div class="horzFrame">
        <table>
            <tr>
                <th class="side">
                    <asp:Label runat="server" AssociatedControlID="txtUser" Text="Username" />
                </th>
                <td>
                    <asp:TextBox runat="server" ID="txtUser" Style="width: 300px;" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtUser" ErrorMessage="Required" />
                </td>
            </tr>
            <tr>
                <th class="side">
                    <asp:Label runat="server" AssociatedControlID="txtPassword" Text="Password" />
                </th>
                <td>
                    <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" Style="width: 300px;" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword" ErrorMessage="Required" />
                </td>
            </tr>
            <tr>
                <th>
                    &nbsp;
                </th>
                <td>
                    <asp:Button runat="server" ID="btnLogin" Text="Login" OnClick="btnLogin_Click" />
                    &nbsp;
                    <asp:HyperLink runat="server" NavigateUrl="~/default.aspx">Nevermind</asp:HyperLink>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
