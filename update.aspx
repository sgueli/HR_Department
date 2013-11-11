


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
           
                
                 <label>   Employee ID: </label>
                
                   <asp:TextBox ID="txtID" runat="server" BackColor="#E0E0E0" Enabled="False"></asp:TextBox> 
                   
            
            
               
               
              <label>     Last Name: </label> 
                
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            
            
                
              <label>      First Name:  </label>
                
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            
            
                
             <label>      Title: </label> 
                
                    <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
            
            
            
                
              <label>     TitleOfCourtesy:  </label> 
                
                    <asp:TextBox ID="txtTitleOfCourtesy" runat="server"></asp:TextBox>
            
            
               
                
             <label>      BirthDate: </label> 
                
                    <asp:TextBox ID="txtBirthDate" runat="server"></asp:TextBox>
             
               
             
                
            <label>      HireDate: </label>  
                
                    <asp:TextBox ID="txtHireDate" runat="server"></asp:TextBox>
              
               
               
                
               <label>    Address:  </label> 
                
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
              
               
            
                
           <label>        City:  </label> 
                
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
             
                  
             
                
             <label>      Region:   </label> 
                
                    <asp:TextBox ID="txtRegion" runat="server"></asp:TextBox>
              
                  
               
               
                
              <label>     Postal Code: </label> 
                
                    <asp:TextBox ID="txtPostalCode" runat="server"></asp:TextBox>
             
                 
            
                
             <label>      Country:  </label> 
                
                    <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
             
                 
               
                
              <label>     Home Phone:  </label> 
                
                    <asp:TextBox ID="txtHomePhone" runat="server"></asp:TextBox>
                 
               
               
           <label>         Extension:  </label>
                
                    <asp:TextBox ID="txtExtension" runat="server"></asp:TextBox> <br />
                 
                
               
                   <asp:Button ID="btnUpdate" runat="server" Text="update" OnClick="btnUpdate_Click" style="height: 26px" />
                
                
                   <asp:Label ID="lblRowsAffected" runat="server" Width="360px"></asp:Label>
           
      
     </div>
    </form>
  
        </div>

</body>
</html>

