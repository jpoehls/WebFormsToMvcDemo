<%@ Page Title="" Language="C#" MasterPageFile="~/MainLayout.Master" AutoEventWireup="true"
    CodeBehind="Edit.aspx.cs" Inherits="TTFWebFormsToMvc.Web.crud.Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <asp:ScriptManagerProxy runat="server">
        <Scripts>
            <asp:ScriptReference Path="~/scripts/crud/edit.js" />
        </Scripts>
    </asp:ScriptManagerProxy>
    <div class="contentFrame">
        <p>
            <asp:HyperLink runat="server" NavigateUrl="~/crud/List.aspx">Back to the list</asp:HyperLink></p>
        <table class="side">
            <tr>
                <th>
                    <asp:Label runat="server" AssociatedControlID="txtName">Name</asp:Label>
                </th>
                <td>
                    <asp:TextBox runat="server" ID="txtName" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtName" ErrorMessage="Required" />
                </td>
            </tr>
            <tr>
                <th>
                    <asp:Label runat="server" AssociatedControlID="txtPrice">Price</asp:Label>
                </th>
                <td>
                    <asp:TextBox runat="server" ID="txtPrice" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPrice" ErrorMessage="Required"
                        Display="Dynamic" />
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="txtPrice" ErrorMessage="Must be a decimal"
                        ValidationExpression="^[0-9]+(\.[0-9][0-9])?$" />
                </td>
            </tr>
            <tr>
                <th>
                    <asp:Label runat="server" AssociatedControlID="ddlCategory">Category</asp:Label>
                </th>
                <td>
                    <asp:DropDownList runat="server" ID="ddlCategory" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="ddlCategory" ErrorMessage="Required" />
                </td>
            </tr>
            <tr>
                <th>
                    <asp:Label runat="server" AssociatedControlID="cblShippingOptions">Shipping Options</asp:Label>
                </th>
                <td>
                    <table>
                        <tr>
                            <td>
                                <asp:CheckBoxList runat="server" ID="cblShippingOptions" />
                            </td>
                            <td>
                                <!-- SUCKS: RequiredFieldValidators don't work with CheckBoxList controls. -->
                                <asp:CustomValidator runat="server" OnServerValidate="ValidateShippingOptions" ClientValidationFunction="EditPage.validateShippingOptions"
                                    ErrorMessage="Required" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <th>
                    <asp:Label runat="server" AssociatedControlID="rblStock">Stock</asp:Label>
                </th>
                <td>
                    <asp:RadioButtonList runat="server" ID="rblStock" />
                </td>
            </tr>
            <tr>
                <th>
                    &nbsp;
                </th>
                <td style="padding-top: 1em;">
                    <asp:Button runat="server" ID="btnSave" Text="Save" OnClick="btnSave_Click" />
                    <asp:HyperLink runat="server" NavigateUrl="~/crud/List.aspx">Cancel</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <th>
                    &nbsp;
                </th>
                <td style="padding-top: 1em;">
                    <asp:LinkButton runat="server" ID="btnDelete" Text="Delete" CssClass="delete" OnClick="btnDelete_Click"
                        OnClientClick="return confirm('Are you sure you want to delete this product?');"
                        CausesValidation="false" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
