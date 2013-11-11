<%@ Page Language="C#" AutoEventWireup="true" CodeFile="employee.aspx.cs" Inherits="employee" %>


<!DOCTYPE html>
<html>

<head id="Head1" runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <h2>Employee Listing</h2>  
      
     <p><a href="update.aspx">Update Employee </a>  </p>

    <form class="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server">  </asp:GridView>
         
    
    </div>
    </form>
    <br />
   
    
   
          


</body>
</html>

