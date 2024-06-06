<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="FitnessApp.Views.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Style/Homee.css?Version=4" rel="stylesheet" />
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Bebas+Neue&display=swap" rel="stylesheet">
    <link href="https://unpkg.com/aos@2.3.1/dist/aos.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
   
        <div class="div-main">
                <div class="inside">
                    <div class="main-txt">
                        <h1 style="margin-top: 0;font-size:5vw">YOUR PERSONALIZED JOURNEY TO HEALTH & FITNESS</h1>
                        <br>
                        <asp:Button class="join" ID="Button1" runat="server" Text="Join" />
                    </div>
                </div>
        </div>

        <div class="benefits">
            <div class="inside-benefit" style="background-image: url('../Assets/IMG/Home/theme-photos-OwSk7UUvgBw-unsplash.jpg');" >
                <div class="benefit-txt">
                    <button class="butt">STRUCTURED PLANNING</button>
                </div>
            </div>  
            <div class="inside-benefit" style="background-image: url('../Assets/IMG/Home/food.png');" >
                <div class="benefit-txt">
                    <button class="butt">MEAL PLANNING</button>
                </div>
            </div>
            <div class="inside-benefit" style="background-image: url('../Assets/IMG/Home/edgar-chaparro-sHfo3WOgGTU-unsplash.jpg');">
                <div class="benefit-txt">
                    <button class="butt">HIRE TRAINER</button>
                </div>
            </div>
        </div>
        

        <h1 style="color: white;text-align: center;">CHOOSE YOUR PATH</h1>
        <div class="join-div">
            <div class="left" runat="server">
                <%--<h1>Be A Trainer</h1>--%>
                <asp:LinkButton CssClass="LinkBTN" ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Be A Trainer</asp:LinkButton>
            </div>
            <div class="right">
                <%--<h1>Be A Member</h1>--%>
                <asp:LinkButton CssClass="LinkBTN" ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Be A Member</asp:LinkButton>
            </div>
        </div>

        <div class="footer">
            <div>
                <h1>PerfoFIT</h1>   
                <p>Lorem, Lorem ipsum dolor sit amet consectetur adipisicing elit. Architecto explicabo debitis officiis? Reprehenderit asperiores voluptatum dolorem fugit voluptatem sed, nulla blanditiis quaerat minima officiis vitae vero dicta, aut pariatur doloremque.lorem Lorem ipsum dolor sit amet, consectetur adipisicing elit. Inventore sed officia a non aliquam explicabo vel repellat minima, soluta ad nihil tempora consequatur veniam voluptatum. Ea repudiandae ipsa magni voluptates. ipsum dolor sit amet consectetur adipisicing elit. Accusantium repudiandae nemo quibusdam facilis dolor. Ex perferendis, quidem totam nisi vel odio, vitae reiciendis voluptatum magnam neque esse, natus voluptates qui!Lorem</p>
            </div>
            <div class="button-footer">

                <%--<button class="fbutton">Contact Us</button>--%>
                <asp:Button CssClass="fbutton" ID="Contact" runat="server" Text="Contact Us" />
                <asp:Button CssClass="fbutton" ID="Premium" runat="server" Text="Get Premium" />
                <%--<button class="fbutton">Get Premium &dollar;</button>--%>
            </div>
        </div>
    

    <div>
        <asp:Button ID="becomeMemberButton" runat="server" Text="Become Member" OnClick="becomeMemberButton_Click" />
    </div>
    <div>
        <asp:Button ID="becomeTrainerButton" runat="server" Text="Become Trainer" OnClick="becomeTrainerButton_Click" />
    </div>
</asp:Content>
