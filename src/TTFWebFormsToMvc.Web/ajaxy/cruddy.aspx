<%@ Page Title="" Language="C#" MasterPageFile="~/MainLayout.Master" AutoEventWireup="true" CodeBehind="cruddy.aspx.cs" Inherits="TTFWebFormsToMvc.Web.ajaxy.cruddy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="contentFrame">
                <p>
                    <asp:HyperLink runat="server" NavigateUrl="~/crud/Edit.aspx">Add new product</asp:HyperLink></p>
                <asp:GridView runat="server" ID="gv" AutoGenerateColumns="false">
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFormatString="edit.aspx?id={0}" DataNavigateUrlFields="Id"
                            Text="Edit" />
                        <asp:BoundField HeaderText="Category" DataField="Category" />
                        <asp:BoundField HeaderText="Name" DataField="Name" />
                        <asp:BoundField HeaderText="Price" DataField="Price" DataFormatString="{0:c}" />
                    </Columns>
                </asp:GridView>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
