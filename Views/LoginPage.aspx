<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="FitnessApp.Views.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Style/Login.css?Version=1" rel="stylesheet" />
</head>
<body>
    <div class="outer">
    <form id="form1" runat="server">
        
            <div>
            <h1>Welcome Back</h1>
        </div>
        <div>
            
            <asp:Label ID="usernameErrorLbl" runat="server" Text=""></asp:Label>
            <br />
            <asp:TextBox CssClass="input" ID="usernameTB" runat="server" placeholder="Username"></asp:TextBox>
        </div>
        <div>
            
            <asp:Label ID="passwordErrorLbl" runat="server" Text=""></asp:Label>
            <br />
            <asp:TextBox CssClass="input" ID="passwordTB" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>

        </div>
        <div>
            <asp:Button CssClass="login" ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click" />
        </div>
    </form>
    </div>
</body>
</html>
