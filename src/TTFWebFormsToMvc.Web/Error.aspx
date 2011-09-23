<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="TTFWebFormsToMvc.Web.Web.Error" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        @import url(http://fonts.googleapis.com/css?family=Antic);

        body
        {
            font-family: 'Antic', sans-serif;
            font-size: 38px;
            letter-spacing: .08em;
            margin: 2em auto;
            width: 600px;
            background-color: #eee;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        Oops.<br />Something bad happened.
    </p>
    <p>
        <asp:HyperLink runat="server" NavigateUrl="~/default.aspx">Go home</asp:HyperLink></p>
    </form>
</body>
</html>
