<%@ Page Title="" Language="C#" MasterPageFile="~/protected/ProtectedLayout.master"
    AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TTFWebFormsToMvc.Web.admin.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <div class="contentFrame">
        <p>
            ... imagine secure content here ...</p>
        <p runat="server" id="adminOnly">
            <b>This only shows for ADMIN users!</b></p>
    </div>
</asp:Content>
