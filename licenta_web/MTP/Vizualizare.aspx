<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Vizualizare.aspx.cs" Inherits="MTP.Vizualizare" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/table.css" rel="stylesheet" />


    <link href="css/templatemo-topic-listing.css" rel="stylesheet"> 



     <nav class="navbar navbar-expand-lg">
                <div class="container">
                    <a class="navbar-brand" href="index.html">
                        <i class="bi-back"></i>
                        <span></span>
                    </a>

                    <div class="collapse navbar-collapse" id="navbarNav">
                        <ul class="navbar-nav ms-lg-5 me-lg-auto">
                            

                            <li class="nav-item dropdown">
                                

                                    <li><a class="dropdown-item" href="view_test.aspx">Home</a></li>
                                
                            </li>
                        </ul>
                        
                    </div>
                </div>
            </nav>



        




</head>
<body>
    <form id="form1" runat="server">
        <div>


            <asp:GridView ID="GridView1" runat ="server">  </asp:GridView>
            
        </div>
    

      <asp:Label ID="LabelEroare" runat="server"></asp:Label>

        </form>
</body>
</html>
