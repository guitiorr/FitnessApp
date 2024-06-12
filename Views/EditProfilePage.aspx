<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditProfilePage.aspx.cs" Inherits="FitnessApp.Views.EditProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Style/EditProfile.css?Version=2" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="out">
        <div class="image-edit">
            <asp:Image CssClass="img" ID="ProfilePictureImage" runat="server" ImageUrl="../Assets/IMG/Home/food.png" Width="200" Height="200"/>
        </div>
        <div>
            <asp:FileUpload ID="ProfilePictureUpload" runat="server" />
        </div>
        <div>
            <asp:Button CssClass="img-button" ID="ChangeProfilePictureBtn" runat="server" Text="Upload Picture" OnClick="ChangeProfilePictureBtn_Click" />
        </div>
        <div>
            <asp:Label ID="ProfilePictureErrorLbl" runat="server" Text=""></asp:Label>
        </div>

        <div class="bot-div">
            <div class="inside-div">
                <div class="in-label">
                    <asp:TextBox CssClass="input" ID="AgeTB" runat="server" placeholder="Age"></asp:TextBox>
                     <asp:Label ID="AgeErrorLbl" runat="server" Text=""></asp:Label>
                </div>
                <div class="in-label">
                    <asp:TextBox CssClass="input" ID="HeightTB" runat="server" placeholder="Height"></asp:TextBox>
                     <asp:Label ID="HeightErrorLbl" runat="server" Text=""></asp:Label>
                </div>
            </div>

            <div class="inside-div">
                <div>
                    <asp:TextBox CssClass="input" ID="WeightTB" runat="server" placeholder="Weight"></asp:TextBox>
                     <asp:Label ID="WeightErrorLbl" runat="server" Text=""></asp:Label>
                </div>
                <div>
                    <asp:TextBox CssClass="input" ID="WeightGoalTB" runat="server" placeholder="Weight Goal"></asp:TextBox>
                     <asp:Label ID="WeightGoalErrorLbl" runat="server" Text=""></asp:Label>
                </div>
            </div>  

            <div class="inside-div">
                <div>
                    
                    <asp:TextBox CssClass="input" ID="PhoneTB" runat="server" placeholder="Phone"></asp:TextBox>
                    <asp:Label ID="PhoneErrorLbl" runat="server" Text=""></asp:Label>
                </div>
            </div>

        
        <div>
            <asp:Button CssClass="Change" ID="SubmitBtn" runat="server" Text="Confirm change" OnClick="SubmitBtn_Click"/>
        </div>
        </div>

        </div>
    </form>
</body>
</html>
