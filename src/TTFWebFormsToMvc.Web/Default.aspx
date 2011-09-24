<%@ Page Title="" Language="C#" MasterPageFile="~/MainLayout.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="TTFWebFormsToMvc.Web.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <div class="contentFrame">
        <div class="post">
            <h2>
                Slides</h2>
            <ul>
                <li><asp:HyperLink runat="server" NavigateUrl="~/slides/me.aspx">Me</asp:HyperLink></li>
                <li>InterWorks</li>
                <li>Links</li>
            </ul>
            <h2>
                Evil</h2>
            <ul>
                <li><asp:HyperLink runat="server" NavigateUrl="~/evil/throw.aspx">Throw</asp:HyperLink></li>
            </ul>
            <h2>
                Protected</h2>
            <ul>
                <li><asp:HyperLink runat="server" NavigateUrl="~/protected/login.aspx">Login</asp:HyperLink></li>
                <li><asp:HyperLink runat="server" NavigateUrl="~/protected/default.aspx">Default</asp:HyperLink></li>
            </ul>
        </div>
        <div class="sideList">
            <h3>
                Other Posts</h3>
            <div class="projectListItem">
                <span>a week ago</span><br />
                <a href="Projects/Summary.aspx">Some other post about something great!</a>
            </div>
            <div class="projectListItem">
                <span>a week ago</span><br />
                <a href="Projects/Summary.aspx">A post about the world and things in it!</a>
            </div>
        </div>
    </div>
</asp:Content>
