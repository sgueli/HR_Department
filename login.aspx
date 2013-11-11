<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Login</title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <div class="wrapper">
    <h1>Northwind Traders Inc.</h1>
    <form id="form1" runat="server">
    <div>
        <label>user:</label>
  	    <input type="text" tabindex="1" id="txtFirst" runat="server" class="pd" /><br />
        <label>password:</label>
        <input type="password" tabindex="2" id="txtPassword" runat="server" class="pd" />
        <asp:Button runat="server" Text="login" id="btnLogin" OnClick="btnLogin_Click" />
        <div runat="server" id="rtn"></div>
    </div>
    </form>
</div>
</body>

</html>