<%@ Page Title="" Language="C#" MasterPageFile="~/MainLayout.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="TTFWebFormsToMvc.Web.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <div class="contentFrame">
        <div class="post">
            <span class="date">yesterday</span>
            <h2>
                Title</h2>
            <p>
                Lorem ipsum</p>
            <p>
                <a href="#">Permalink</a></p>
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
