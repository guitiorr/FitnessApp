<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="FitnessApp.Views.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Register Page</h1>
        </div>
        <div>
            <asp:Label ID="EmailLbl" runat="server" Text="Email"></asp:Label>
            <br />
            <asp:TextBox ID="EmailTB" runat="server" TextMode="Email"></asp:TextBox>
            <asp:Label ID="EmailErrorLbl" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Label ID="UsernameLbl" runat="server" Text="Username"></asp:Label>
            <br />
            <asp:TextBox ID="UsernameTB" runat="server"></asp:TextBox>
            <asp:Label ID="UsernameErrorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="PasswordLbl" runat="server" Text="Password"></asp:Label>
            <br />
            <asp:TextBox ID="PasswordTB" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Label ID="PasswordErrorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Password2Lbl" runat="server" Text="Re-Enter Password"></asp:Label>
            <br />
            <asp:TextBox ID="Password2TB" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Label ID="Password2ErrorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="RegisterBtn" runat="server" Text="Register" OnClick="RegisterBtn_Click" />
        </div>
    </form>
</body>
</html>
