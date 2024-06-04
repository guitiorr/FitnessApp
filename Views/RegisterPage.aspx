<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="FitnessApp.Views.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Style/Register.css?Version=2" rel="stylesheet" />
</head>
<body>
    <div class="outer">

  
    <form id="form1" runat="server">
        <div>
            <h1>REGISTER</h1>
        </div>
        <div class="InputContainer">
            <%--<asp:Label CssClass="label" ID="RegisterAsLbl" runat="server" Text="Register As" OnLoad="RegisterAsLbl_Load"></asp:Label>--%>

            <asp:DropDownList ID="RegisterAsDropdown" runat="server" CssClass="DDLDRIZZY">
                <asp:ListItem Text="Register As" Value="1"></asp:ListItem>
                <asp:ListItem Text="User" Value="2"></asp:ListItem>
                <asp:ListItem Text="Trainer" Value="3"></asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="RegisterAsErrorLbl" runat="server" Text=""></asp:Label>


            <%--<asp:Label CssClass="label" ID="GenderLbl" runat="server" Text="Gender"></asp:Label>--%>
            
            <asp:DropDownList ID="GenderDropdown" runat="server" CssClass="DDLDRIZZY">
                <asp:ListItem Text="Gender" Value="1"></asp:ListItem>
                <asp:ListItem Text="Male" Value="2"></asp:ListItem>
                <asp:ListItem Text="Female" Value="3"></asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="GenderErrorLbl" runat="server" Text=""></asp:Label>
            <br />

        </div>

        <div class="InputContainer">
            <%--<asp:Label ID="FullNameLbl" runat="server" Text="Full Name"></asp:Label>--%>
            <div class="InsideContainer">
                <asp:TextBox CssClass="input" ID="FullNameTB" runat="server" placeholder="Fullname"></asp:TextBox>
                <asp:Label ID="FullNameErrorLbl" runat="server" Text=""></asp:Label>
            </div>
            
            <div class="InsideContainer">
                <asp:TextBox CssClass="input" ID="AgeTB" runat="server" TextMode="Number" placeholder="Age"></asp:TextBox>
                <asp:Label ID="AgeErrorLbl" runat="server" Text=""></asp:Label>
            </div>
            
            <%--<asp:Label ID="AgeLbl" runat="server" Text="Age"></asp:Label>--%>
            <br />
        </div>

        <div class="InputContainer">
            <%--<asp:Label ID="EmailLbl" runat="server" Text="Email"></asp:Label>--%>
            <div class="InsideContainer">
                <asp:TextBox CssClass="input" ID="EmailTB" runat="server" TextMode="Email" placeholder="Email"></asp:TextBox>
                <asp:Label ID="EmailErrorLbl" runat="server" Text=""></asp:Label>
            </div>
            <div class="InsideContainer">
                <asp:TextBox CssClass="input" ID="UsernameTB" runat="server" ></asp:TextBox>
                <asp:Label ID="UsernameErrorLbl" runat="server" Text=""></asp:Label>
            </div>
            
            <%--<asp:Label ID="UsernameLbl" runat="server" Text="Username"></asp:Label>--%>
            <br />
        </div>

    

        <div class="InputContainer">
            <%--<asp:Label ID="PasswordLbl" runat="server" Text="Password"></asp:Label>--%>
            <div class="InsideContainer">
                <asp:TextBox CssClass="input" ID="PasswordTB" runat="server" TextMode="Password"></asp:TextBox>
                <asp:Label ID="PasswordErrorLbl" runat="server" Text=""></asp:Label>
            </div>
            

            <%--<asp:Label ID="Password2Lbl" runat="server" Text="Re-Enter Password"></asp:Label>--%>
            <div class="InsideContainer">
                <asp:TextBox CssClass="input" ID="Password2TB" runat="server" TextMode="Password" placeholder="Re-Enter Password"></asp:TextBox>
                <asp:Label ID="Password2ErrorLbl" runat="server" Text=""></asp:Label>
            </div>

            <br />
        </div>
       
        <div>
            <asp:Button ID="RegisterBtn" runat="server" Text="Register" OnClick="RegisterBtn_Click" />
        </div>

    </form>
    </div>
</body>
</html>
