<%@ Page Title="" Language="C#" MasterPageFile="~/MainLayout.Master" AutoEventWireup="true"
    CodeBehind="Me.aspx.cs" Inherits="TTFWebFormsToMvc.Web.slides.Me" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <div class="slideHeader">
        <asp:Image ID="Image1" runat="server" ImageUrl="interworks.png" />
    </div>
    <div class="slideFrame">
        <p>
            <b>@JoshuaPoehls</b></p>
        <p>
            joshua@zduck.com</p>
        <p>
            www.interworks.com</p>
    </div>
</asp:Content>
