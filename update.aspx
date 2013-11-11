


<%@ Page Language="C#" AutoEventWireup="true" CodeFile="update.aspx.cs" Inherits="update" %>

<!DOCTYPE html>
<html>

<head id="Head1" runat="server">
    <title></title>

 <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <div class="wrapper">
    
        
        <div class="update"> <a href="employee.aspx">Employee Listing</a> </div>

    <form id="form1" runat="server">
    <div>
           <table class="table" >
            <tr>
                <td>
                    Employee ID:</td>
                <td >
                    <asp:TextBox ID="txtID" runat="server" BackColor="#E0E0E0" Enabled="False"></asp:TextBox></td>
                   
            </tr>
            
               <tr>
                <td >
                    Last Name :</td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    First Name:</td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    Title:</td>
                <td>
                    <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox></td>
            </tr>
            
            <tr>
                <td>
                    TitleOfCourtesy:</td>
                <td>
                    <asp:TextBox ID="txtTitleOfCourtesy" runat="server"></asp:TextBox></td>
            </tr>
            
               <tr>
                <td>
                    BirthDate:</td>
                <td>
                    <asp:TextBox ID="txtBirthDate" runat="server"></asp:TextBox></td>
            </tr>   
               
             <tr>
                <td>
                    HireDate:</td>
                <td>
                    <asp:TextBox ID="txtHireDate" runat="server"></asp:TextBox></td>
            </tr>  
               
               <tr>
                <td>
                    Address:</td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td>
            </tr>  
               
            <tr>
                <td>
                    City:</td>
                <td>
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
            </tr>  
                  
             <tr>
                <td>
                    Region:</td>
                <td>
                    <asp:TextBox ID="txtRegion" runat="server"></asp:TextBox></td>
            </tr>  
                  
               
               <tr>
                <td>
                    Postal Code:</td>
                <td>
                    <asp:TextBox ID="txtPostalCode" runat="server"></asp:TextBox></td>
            </tr>  
                 
            <tr>
                <td>
                    Country:</td>
                <td>
                    <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox></td>
            </tr>  
                 
               <tr>
                <td>
                    Home Phone:</td>
                <td>
                    <asp:TextBox ID="txtHomePhone" runat="server"></asp:TextBox></td>
            </tr>     
               <tr>
                <td>
                    Extension:</td>
                <td>
                    <asp:TextBox ID="txtExtension" runat="server"></asp:TextBox></td>
            </tr>     
                
               
               <tr>
                <td>
                    <asp:Button ID="btnUpdate" runat="server" Text="update" OnClick="btnUpdate_Click" style="height: 26px" /></td>
                <td style="width: 81px">
                </td>
            </tr>
            <tr>
                <td colspan="2" style="width: 163px">
                    <asp:Label ID="lblRowsAffected" runat="server" Width="360px"></asp:Label></td>
            </tr>
      
           
           
           
           
           </table>
    
    </div>
    </form>
  
        </div>

</body>
</html>

