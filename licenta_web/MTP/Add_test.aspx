<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_test.aspx.cs" Inherits="MTP.Add_test" %>



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
    
    <img src="add.png">

    <form method="POST" id="Add_test" runat="server">
      <div class="formbold-form-title">
        <h2 class="">Adaugare date studenti</h2>
        <p>
          Date studenti pentru cazarea in camin
        </p>
      </div>

      <div class="formbold-input-flex">
        <div>
          <label for="firstname" class="formbold-form-label">
            Nume
          </label>
          <asp:TextBox ID="TextBox2" runat="server" class="formbold-form-input" ></asp:TextBox>
          
        </div>
        <div>
          <label for="lastname" class="formbold-form-label"> Prenume </label>
          <asp:TextBox ID="TextBox3" runat="server" class="formbold-form-input"></asp:TextBox>
        </div>
         
          <div>
          <label for="lastname" class="formbold-form-label"> Gen </label>
           <asp:DropDownList ID="DropDownList3" class="formbold-form-input" runat="server" > 
                        
                        <asp:ListItem Value=""></asp:ListItem>
                        <asp:ListItem style="color: black"> Masculin </asp:ListItem>
                        <asp:ListItem style="color: black"> Feminin </asp:ListItem>
                        
                </asp:DropDownList>

              </div>
      </div>


        <div class="formbold-mb-3">
         <div>
          <label for="email" class="formbold-form-label"> Email </label>
            <asp:TextBox ID="TextBox1" runat="server" class="formbold-form-input"></asp:TextBox>
        </div>
        </div>

      <div class="formbold-input-flex">
        <div>
          <label for="email" class="formbold-form-label"> Numar Telefon Parinte </label>
             <asp:Label ID="Label4" runat="server" Text="Telefon Parinte incorect! Numar de telefon trebuie sa contina 10 cifre" Visible="False"></asp:Label>

          <asp:TextBox ID="TextBox13" runat="server" class="formbold-form-input"></asp:TextBox>
        </div>
        <div>
          <label for="phone" class="formbold-form-label"> Numar Telefon Student </label>
            
             <asp:Label ID="Label5" runat="server" Text="Telefon Student incorect! Numar de telefon trebuie sa contina 10 cifre" Visible="False"></asp:Label>
    
          <asp:TextBox ID="TextBox14" runat="server" class="formbold-form-input"></asp:TextBox>
        </div>
      </div>

      <div class="formbold-mb-3">
        <label for="address" class="formbold-form-label">
          Adresa
        </label>
        <asp:TextBox ID="TextBox4" runat="server" class="formbold-form-input"></asp:TextBox>
      </div>

      <div class="formbold-mb-3">
        <label for="address2" class="formbold-form-label">
          Judet
        </label>
        <asp:TextBox ID="TextBox10" runat="server" class="formbold-form-input"></asp:TextBox>
      </div>

      <div class="formbold-input-flex">
        <div>
          <label for="state" class="formbold-form-label"> CNP </label>
              <asp:Label ID="Label1" runat="server" Text="CNP incorect! CNP trebuie sa contina 13 numere" Visible="False"></asp:Label>
          <asp:TextBox ID="TextBox5" runat="server" class="formbold-form-input"></asp:TextBox>
        </div>
        <div>
          <label for="country" class="formbold-form-label"> SerieCI </label>
                <asp:Label ID="Label2" runat="server" Text="Seria CI incorecta! Seria CI trebuie sa contina 2 litere" Visible="False"></asp:Label>
 
          <asp:TextBox ID="TextBox6" runat="server" class="formbold-form-input"></asp:TextBox>
        </div>
      </div>

      <div class="formbold-input-flex">
        <div>
          <label for="post" class="formbold-form-label"> Numar CI </label>
           <asp:Label ID="Label3" runat="server" Text="Numar CI incorect! Numar CI trebuie sa contina 6 cifre" Visible="False"></asp:Label>
   
          <asp:TextBox ID="TextBox7" runat="server" class="formbold-form-input"></asp:TextBox>
        </div>
        <div>
          <label for="area" class="formbold-form-label"> Nume Mama </label>
          <asp:TextBox ID="TextBox8" runat="server" class="formbold-form-input"></asp:TextBox>
        </div>

          <div>
          <label for="area" class="formbold-form-label"> Nume Tata </label>
          <asp:TextBox ID="TextBox9" runat="server" class="formbold-form-input"></asp:TextBox>
        </div>

      </div>


         <div class="formbold-input-flex">
        <div>
          <label for="area" class="formbold-form-label"> Selectati Facultatea </label>
            <asp:Label ID="Label6" runat="server" Text="Va rugam alegeti o facultate" Visible="False"></asp:Label>
    
            <asp:DropDownList ID="DropDownList1" class="formbold-form-input" runat="server"  placeholder="Facultatea"> 
                        
                        <asp:ListItem Value=""></asp:ListItem>
                        <asp:ListItem style="color: black"> Facultatea Automatica si Calculatoare </asp:ListItem>

                        <asp:ListItem style="color: black"> Facultatea Mecanica </asp:ListItem>
                        <asp:ListItem style="color: black"> Facultatea Electotehnica </asp:ListItem>
                        <asp:ListItem style="color: black"> Facultatea Stinte ale comunicarii </asp:ListItem>
                        <asp:ListItem style="color: black"> Facultatea Management </asp:ListItem>
                        <asp:ListItem style="color: black"> Facultatea Arhitectura </asp:ListItem>
                        <asp:ListItem style="color: black"> Facultatea Constructii </asp:ListItem>


                    </asp:DropDownList>
         
        </div>


         <div>
          <label for="area" class="formbold-form-label"> Selectati Anul de Studiu </label>
             <asp:Label ID="Label7" runat="server" Text="Va rugam alegeti anul de studiu" Visible="False"></asp:Label>
                <asp:DropDownList ID="DropDownList2" class="formbold-form-input" runat="server"  placeholder="Anul de Studiu"> 
                        
                        <asp:ListItem Value=""></asp:ListItem>
                        <asp:ListItem style="color: black"> 1 </asp:ListItem>
                        <asp:ListItem style="color: black"> 2 </asp:ListItem>
                        <asp:ListItem style="color: black"> 3 </asp:ListItem>
                        <asp:ListItem style="color: black"> 4 </asp:ListItem>
                        <asp:ListItem style="color: black"> 5 </asp:ListItem>
                        <asp:ListItem style="color: black"> 6 </asp:ListItem>


                </asp:DropDownList>
        </div>
         </div>   
              <div class="formbold-input-flex">

             <div>
          <label for="area" class="formbold-form-label"> Specializarea </label>
          <asp:TextBox ID="TextBox12" runat="server" class="formbold-form-input"></asp:TextBox>
        </div>
            
              <div>
          <label for="area" class="formbold-form-label"> NrMatricol </label>
         <asp:TextBox ID="TextBox11" runat="server" class="formbold-form-input"></asp:TextBox>
        </div>

                   <div>
          <label for="area" class="formbold-form-label"> NrCamera </label>
         <asp:TextBox ID="TextBox15" runat="server" class="formbold-form-input"></asp:TextBox>
        </div>
                  
         </div>


        
  
    
    <asp:Label ID="LabelEroare" runat="server" Text="Introduceti toate datele" Visible="False"></asp:Label>
    

    <asp:Button ID="Button1" runat="server" class="formbold-btn" OnClick="Button1_Click" Text="Adauga Student" />

      </div>


    </form>
  </div>
</div>



<style>
  @import url('https://fonts.googleapis.com/css2?family=Inter:wght@400;500;600;700&display=swap');
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