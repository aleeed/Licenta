<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MTP.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/my.css" rel="stylesheet" />
    

      

   <%-- <header>

         <nav>
            <ul>
               <li><a href="Adauga.aspx">Adauga student student</a></li>
                <li><a href="Cautare1.aspx">Cautare Student</a></li>
                <li><a href="Stergere.aspx">Sterge Student</a></li>
                <li><a href="WebForm1.aspx">Log out</a></li>
             </ul>
           </nav>

    </header>
           <style>
        table {
            border-collapse: collapse;
            width: 100%;
        }
        th, td {
            border: 1px solid black;
            padding: 8px;
            text-align: left;
        }
        tr:nth-child(even) {
            background-color: #f2f2f2;
        }
    </style>--%>

</head>
<%--<%--<%--<body>
    
        
        <div id="lblTable"></div>
    <script>
        var htmlTable = `
            <table>
                <tr>
                    <th>Email</th>
                    <th>Nume</th>
                    <th>Prenume</th>
                    <th>Gen</th>
                    <th>Adresa</th>
                    <th>Judet</th>
                    <th>CNP</th>
                    <th>SerieCI</th>
                    <th>NrCI</th>
                    <th>NumeMama</th>
                    <th>NumeTata</th>
                    <th>Facultatea</th>
                    <th>NrMatricol</th>
                    <th>AnStudiu</th>
                    <th>Specializarea</th>
                    <th>TeleofonParinte</th>
                    <th>TelefonStudent</th>
                </tr>
                `;

        htmlTable += `
            </table >
        `;

    </script>
        <%--<asp:Label ID="lblTable" CssClass="lbltabel" runat="server" />--%>
<%--      <asp:Label ID="LabelEroare" runat="server"></asp:Label>

</body>--%>


    <body>
    <nav>
      <div class="navbar">
        <div class="container nav-container">
            <input class="checkbox" type="checkbox" name="" id="" />
            <div class="hamburger-lines">
              <span class="line line1"></span>
              <span class="line line2"></span>
              <span class="line line3"></span>
            </div>  
          <div class="logo">
            <h1>Home</h1>
          </div>
          <div class="menu-items">
           <li><a href="Add_test.aspx">Adauga student</a></li>
   <%--             <li><a href="Cautare1.aspx">Cautare Student</a></li>--%>
                <li><a href="Stergere.aspx">Sterge Student</a></li>
                <li><a href="Vizualizare.aspx">Vizualizare studenti</a></li>
                <li><a href="Generate_test.aspx">Generare contract studenti</a></li>

                <li><a href="WebForm1.aspx">Log out</a></li>
          </div>
        </div>
      </div>
    </nav>
    <asp:Label ID="lblTable" CssClass="lbltabel" runat="server" />
    <asp:Label ID="LabelEroare" runat="server"></asp:Label>

  </body>
</html>
