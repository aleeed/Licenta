<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="MTP.WebForm6" %>


<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/my.css" rel="stylesheet" />


      <div class="container-fluid">

        <div class="background">
           <div class="cube"></div>
           <div class="cube"></div>
           <div class="cube"></div>
           <div class="cube"></div>
          <div class="cube"></div>
        </div>

    <header>

         <nav>
            <ul>
               <li><a href="WebForm1.aspx">Login</a></li>
                <li><a href="Register.aspx">Register</a></li>
                <li><a href="https://ac.upt.ro">Contact</a></li>
             </ul>
           </nav>

    </header>

    
</head>
<body>
  <section class="header-content">
    <div class="loginbox">
        <img src="user1.png" alt "Altenarte Text" class ="user"/>
        <h2>Register Here </h2>
        <form runat="server">
            <asp:Label ID="LabelEroare" Text="" CssClass="lblmail" runat="server" />
            <asp:TextBox ID="TextBox1" runat="server" CssClass="txtemail" placeholder="Enter your email" />

            <asp:TextBox ID="TextBox2" runat="server" CssClass="txtpass" TextMode="Password"  placeholder="Password"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="txtpass" TextMode="Password"  placeholder="Confirm password"></asp:TextBox>


            <asp:Button ID="Button1" runat="server" CssClass="btn_login" OnClick="Button1_Click" Text="Register" />

        </form>
    </div>

    </section>
 
</body>
</html>




<style>




nav {
color: #FFF;
float: right;
margin: 30px 90px;
}

nav ul {
    list-style: none;
}

    nav ul li {
        float:left;
        transition: .3s;
    }

        nav ul li a {
            text-decoration: none;
            color: #EFEEF5;
            transition: .5;
            font-size: 20px;
            margin-left: 16px;
        }

        nav ul li:hover a {
            text-decoration: none;
            color: black;
            ;
        }

        nav ul li:hover {
            height: 20px;
            padding-top: 5px;
            margin-top: -10px;
            text-decoration:double;
            transform:inherit;
        }
</style>