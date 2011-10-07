<%@ Page Title="" Language="C#" MasterPageFile="Slides.Master" AutoEventWireup="true"
    CodeBehind="Me.aspx.cs" Inherits="TTFWebFormsToMvc.Web.slides.Me" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <p class="big">
        <a href="http://www.twitter.com/joshuapoehls">@JoshuaPoehls</a></p>
    <ul>
        <li>joshua@zduck.com</li>
        <li>Code is at <a href="http://goo.gl/wgnKf">http://goo.gl/wgnKf</a></li>
        <li><b>ASP.NET WebForms to MVC:</b><br />
            <span class="smaller">Real-world tricks to make the switch</span></li>
    </ul>
    <p style="text-align: right;">
        <a href="http://www.interworks.com">
            <asp:Image ID="Image1" runat="server" ImageUrl="interworks.png" Height="120" /></a>
    </p>
</asp:Content>
