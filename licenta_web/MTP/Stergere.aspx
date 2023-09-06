﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Stergere.aspx.cs" Inherits="MTP.Stergere" %>

<!DOCTYPE html>

<%--<html xmlns=">
<head runat="server">
    <title></title>

     <link href="css/my.css" rel="stylesheet" />
    



        <div class="container-fluid">
    <!-- Background animtion-->
        <div class="background">
           <div class="cube"></div>
           <div class="cube"></div>
           <div class="cube"></div>
           <div class="cube"></div>
          <div class="cube"></div>
        </div>
    <!-- header -->
       <header>
    <!-- navbar -->
         <nav>
            <ul>
               <li><a href="Home.aspx">Home</a></li>
             </ul>
           </nav>
    </header>
    </div>
</head>
<body>
     <section class="header-content">
      
           <div class="loginbox">
           
            <h2>Stergere Student </h2>
            <h3> Introduceti numele pe care doriti sa il stergeti</h3>
            <form runat="server">
                <asp:Label ID="Label1" Text="" CssClass="lblmail" runat="server" />
      
                <asp:TextBox ID="TextBox1" runat="server" CssClass="txtpass"  placeholder="Nume Student"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" CssClass="btn_login" OnClick="Button1_Click" Text="Sterge Student" />
                  <asp:Label ID="LabelEroare" runat="server"></asp:Label>

            </form>
        </div>
      </section>
</body>
</html>--%>
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


<div class="formbold-main-wrapper">

 
  <div class="formbold-form-wrapper">
    
    <img src="css/remove-user.png" alt="Smaller Image" class="small-image" />
      

    <form method="POST" id="Add_test" runat="server">
      <div class="formbold-form-title">
        <h2 class="">Stergere Student</h2>
        <p>
          Stergere datele unui student
        </p>
      </div>

        <div class="formbold-mb-3">
         <div>
          <label for="email" class="formbold-form-label"> Selectati numele pe care doriti sa il stergeti </label>
           <asp:DropDownList ID="DropDownList1"  style="color: black"  class="formbold-form-input" runat="server" >
                     </asp:DropDownList>
        </div>
            </div>

           

            <asp:Label ID="LabelEroare" runat="server"></asp:Label>

            <asp:Button ID="Button1" runat="server" class="formbold-btn" OnClick="Button1_Click" Text="Stergere Student"/>

      </div>


    </form>
  </div>

</html>



<style>
  @import url('https://fonts.googleapis.com/css2?family=Inter:wght@400;500;600;700&display=swap');


  .small-image {
    max-width: 200px;
    height: auto; 
  }
  * {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
  }
  body {
    font-family: 'Inter', sans-serif;
    background: linear-gradient(90deg, #C7C5F4, #776BCC);
  }
  .formbold-mb-3 {
    margin-bottom: 15px;
  }
  .formbold-relative {
    position: relative;
  }
  .formbold-opacity-0 {
    opacity: 0;
  }
  .formbold-stroke-current {
    stroke: currentColor;
  }
  #supportCheckbox:checked ~ div span {
    opacity: 1;
  }

  .formbold-main-wrapper {
    display: flex;
    align-items: center;
    justify-content: center;
    padding: 48px;
  }

  .formbold-form-wrapper {
    margin: 0 auto;
    max-width: 1000px;
    width: 100%;
    background: white;
    padding: 90px;
  }

  .formbold-img {
    margin-bottom: 45px;
  }

  .formbold-form-title {
    margin-bottom: 30px;
  }
  .formbold-form-title h2 {
    font-weight: 600;
    font-size: 28px;
    line-height: 34px;
    color: #07074d;
  }
  .formbold-form-title p {
    font-size: 16px;
    line-height: 24px;
    color: #536387;
    margin-top: 12px;
  }

  .formbold-input-flex {
    display: flex;
    gap: 20px;
    margin-bottom: 15px;
  }
  .formbold-input-flex > div {
    width: 50%;
  }
  .formbold-form-input {
    text-align: center;
    width: 100%;
    padding: 13px 22px;
    border-radius: 5px;
    border: 1px solid #dde3ec;
    background: #ffffff;
    font-weight: 500;
    font-size: 16px;
    color: #536387;
    outline: none;
    resize: none;
  }
  .formbold-form-input:focus {
    border-color: #6a64f1;
    box-shadow: 0px 3px 8px rgba(0, 0, 0, 0.05);
  }
  .formbold-form-label {
    color: #536387;
    font-size: 14px;
    line-height: 24px;
    display: block;
    margin-bottom: 10px;
  }

  .formbold-checkbox-label {
    display: flex;
    cursor: pointer;
    user-select: none;
    font-size: 16px;
    line-height: 24px;
    color: #536387;
  }
  .formbold-checkbox-label a {
    margin-left: 5px;
    color: #6a64f1;
  }
  .formbold-input-checkbox {
    position: absolute;
    width: 1px;
    height: 1px;
    padding: 0;
    margin: -1px;
    overflow: hidden;
    clip: rect(0, 0, 0, 0);
    white-space: nowrap;
    border-width: 0;
  }
  .formbold-checkbox-inner {
    display: flex;
    align-items: center;
    justify-content: center;
    width: 20px;
    height: 20px;
    margin-right: 16px;
    margin-top: 2px;
    border: 0.7px solid #dde3ec;
    border-radius: 3px;
  }

  .formbold-btn {
    font-size: 16px;
    border-radius: 5px;
    padding: 14px 25px;
    border: none;
    font-weight: 500;
    background-color: #6a64f1;
    color: white;
    cursor: pointer;
    margin-top: 25px;
  }
  .formbold-btn:hover {
    box-shadow: 0px 3px 8px rgba(0, 0, 0, 0.05);
  }
</style>
