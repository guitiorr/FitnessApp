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
            <asp:Label ID="RegisterAsLbl" runat="server" Text="Register As" OnLoad="RegisterAsLbl_Load"></asp:Label>
            <br />
            <asp:DropDownList ID="RegisterAsDropdown" runat="server">
                <asp:ListItem Text="User" Value="1"></asp:ListItem>
                <asp:ListItem Text="Trainer" Value="2"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="FullNameLbl" runat="server" Text="Full Name"></asp:Label>
            <asp:TextBox ID="FullNameTB" runat="server"></asp:TextBox>
            <asp:Label ID="FullNameErrorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="AgeLbl" runat="server" Text="Age"></asp:Label>
            <br />
            <asp:TextBox ID="AgeTB" runat="server" TextMode="Number"></asp:TextBox>
            <asp:Label ID="AgeErrorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="GenderLbl" runat="server" Text="Gender"></asp:Label>
            <br />
            <asp:DropDownList ID="GenderDropdown" runat="server">
                <asp:ListItem Text="Male" Value="1"></asp:ListItem>
                <asp:ListItem Text="Female" Value="2"></asp:ListItem>
            </asp:DropDownList>
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
