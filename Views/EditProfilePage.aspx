<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditProfilePage.aspx.cs" Inherits="FitnessApp.Views.EditProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="ProfilePictureImage" runat="server"/>
            <asp:FileUpload ID="ProfilePictureUpload" runat="server" />
            <asp:Button ID="ChangeProfilePictureBtn" runat="server" Text="Upload Picture" OnClick="ChangeProfilePictureBtn_Click" />
            <asp:Label ID="ProfilePictureErrorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="AgeLbl" runat="server" Text="Age"></asp:Label>
            <asp:TextBox ID="AgeTB" runat="server"></asp:TextBox>
             <asp:Label ID="AgeErrorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="HeightLbl" runat="server" Text="Height"></asp:Label>
            <asp:TextBox ID="HeightTB" runat="server"></asp:TextBox>
             <asp:Label ID="HeightErrorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="WeightLbl" runat="server" Text="Weight"></asp:Label>
            <asp:TextBox ID="WeightTB" runat="server"></asp:TextBox>
             <asp:Label ID="WeightErrorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="WeightGoalLbl" runat="server" Text="Weight Goal"></asp:Label>
            <asp:TextBox ID="WeightGoalTB" runat="server"></asp:TextBox>
             <asp:Label ID="WeightGoalErrorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="SubmitBtn" runat="server" Text="Confirm change" OnClick="SubmitBtn_Click"/>
        </div>
    </form>
</body>
</html>
