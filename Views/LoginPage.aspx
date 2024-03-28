<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="FitnessApp.Views.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Login Page</h1>
        </div>
        <div>
            <asp:Label ID="usernameLbl" runat="server" Text="Username"></asp:Label>
            <br />
            <asp:TextBox ID="usernameTB" runat="server"></asp:TextBox>
            <asp:Label ID="usernameErrorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="passwordLbl" runat="server" Text="Password"></asp:Label>
            <br />
            <asp:TextBox ID="passwordTB" runat="server"></asp:TextBox>
            <asp:Label ID="passwordErrorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click" />
        </div>
    </form>
</body>
</html>
