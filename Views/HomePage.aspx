<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="FitnessApp.Views.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="div-main">
        <div class="inside">
            <div class="main-txt">
                <h1>YOUR PERSONALIZED JOURNEY TO HEALTH & FITNESS</h1>
            </div>
            <asp:Button class="join" ID="Button1" runat="server" Text="JOIN" />
        </div>
        <div class="blur-div"></div>
    </div>

        <div class="benefits">
            <h2 class="ben-title">BENEFITS</h2>
            
            <div class="outside">
                <div class="inside-benefit">
                    <div class="benefit-txt">
                        <h1>Meal Planning</h1>
                        <p>Dengan fitur Meal Plan kami yang disesuaikan, Anda akan mendapatkan panduan makanan yang dirancang khusus untuk mendukung tujuan kebugaran dan kesehatan Anda. Dengan dukungan dari ahli gizi kami, Anda akan menemukan solusi makanan yang sesuai dengan kebutuhan tubuh Anda.</p>
                    </div>
                </div>
                <div class="inside-benefit">
                    <img class="img-benefit" src="../Assets/meal.jpeg" />
                </div>
            </div>

            <div class="outside">
                <div class="inside-benefit">
                    <img class="img-benefit" src="../Assets/trainer.jpg" />
                </div>
                <div class="inside-benefit">
                    <div class="benefit-txt">
                    <h1>Hire Trainer</h1>
                    <p>Dengan fitur Meal Plan kami yang disesuaikan, Anda akan mendapatkan panduan makanan yang dirancang khusus untuk mendukung tujuan kebugaran dan kesehatan Anda. Dengan dukungan dari ahli gizi kami, Anda akan menemukan solusi makanan yang sesuai dengan kebutuhan tubuh Anda.</p>
                </div>
                </div>
            </div>
            
            
    
           
        </div>
    <div>

    </div>

</asp:Content>
