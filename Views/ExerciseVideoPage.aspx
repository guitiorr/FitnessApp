    <%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="ExerciseVideoPage.aspx.cs" Inherits="FitnessApp.Views.ExerciseVideoPage" Async="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Style/ExerciseVideo.css?Version=4" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="today">
        <h1>Today's Exercise</h1>


            <asp:Repeater ID="repeatTodayExercise" runat="server" OnItemDataBound="repeatTodayExercise_ItemDataBound">
                <ItemTemplate>
<<<<<<< HEAD
                    <div class="exercise-today">
                    <asp:Image ID="ExerciseImage" CssClass="image" Width="350" Height="200" runat="server" />
                    <div class="info">
                        <asp:Label ID="ExerciseNameLbl" runat="server" Text='<%# Eval("ExerciseID") %>'></asp:Label>
                        <div style="font-size:30px;">
                            <asp:Label ID="SetsLbl" runat="server" Text='<%# Eval("Reps") + " Reps" %>'></asp:Label>
                            <asp:Label ID="Repsl1" runat="server" Text='<%# Eval("Sets") + " Sets" %>'></asp:Label>
                        </div>
                        
                    </div>
                    
                    <asp:Button CssClass="remove" ID="RemoveBtn" runat="server" Text="Remove" CommandArgument='<%# Eval("ExercisePlanID") %>' OnClick="RemoveBtn_Click" />
                </div>
>>>>>>> f55115c47551daed235d207b7ed0b1630e93e56c
                </ItemTemplate>
                
            </asp:Repeater>



    </div>


    <div class="center">

        <div class="add-exercise">
            <h1>Add Exercise</h1>

            <asp:Label ID="AlertLbl" runat="server" Text="Please fill number of reps and sets" Visible="true" ForeColor="Red"></asp:Label>

            <div>
                <asp:Label ID="SetsLbl" runat="server" Text="Sets" Visible="false"></asp:Label>
                <asp:TextBox CssClass="textBox" ID="SetsTB" runat="server" Visible="true" placeholder="Number of sets"></asp:TextBox>
            </div>

            <div>
                <asp:Label ID="RepsLbl" runat="server" Text="Reps" Visible="false"></asp:Label>
                <asp:TextBox CssClass="textBox" ID="RepsTB" runat="server" Visible="true" placeholder="number os reps"></asp:TextBox>
            </div>
        </div>
        

        <div class="bottom-exercise">
 
        <h1 style="text-align:left;margin-left:4%;">Exercise List</h1>
        <div class="bottom-repeater">
        <asp:Repeater ID="repeatBrowseExercise" runat="server" OnItemDataBound="repeatBrowseExercise_ItemDataBound">
            <ItemTemplate>
                <div class="list">
                    <asp:Image Width="250" Height="250" CssClass="img-bottom" ID="ExerciseImage" runat="server"/>
                    <div class="info2">
                        <asp:Label ID="ExerciseNameLbl" runat="server" Text='<%# Eval("ExerciseName") %>'></asp:Label>
                        <asp:Button CssClass="add" ID="AddExerciseBtn" runat="server" Text="Add" OnClick="AddExerciseBtn_Click"/>
                    </div>
                    
                </div>
            </ItemTemplate>
        </asp:Repeater>
        </div>
        </div>





    </div>




    
    <div id="GIFBox">
        <div class="ButtonBox">
            <div>
                <asp:Button CssClass="BTN" ID="ChestButton" runat="server" Text="Chest" OnClick="ChestButton_Click"/>

            </div>
            <div>
                <asp:Button CssClass="BTN" ID="ShoulderButton" runat="server" Text="Shoulder" OnClick="ShoulderButton_Click" />
            </div>
            <div>
                <asp:Button CssClass="BTN" ID="BicepButton" runat="server" Text="Biceps" OnClick="BicepButton_Click" />
            </div>
            <div>
                <asp:Button CssClass="BTN" ID="AbsButton" runat="server" Text="Abs" OnClick="AbsButton_Click" />
            </div>
            <div>
                <asp:Button CssClass="BTN" ID="QuadsButton" runat="server" Text="Quads" OnClick="QuadsButton_Click" />
            </div>
            <div>
                <asp:Button CssClass="BTN" ID="ForearmsButton" runat="server" Text="Forearms" OnClick="ForearmsButton_Click" />
            </div>
            <div>
                <asp:Button CssClass="BTN" ID="BackButton" runat="server" Text="Back" OnClick="BackButton_Click"/>
            </div>
        </div>

        <div class="btm">
             <div class="GIFDIP" id="GIFDiv1">
                <asp:Label CssClass="span" ID="ExerciseLabel1" runat="server" Text=""></asp:Label>
                <asp:Label CssClass="span" ID="MuscleTargetLabel1" runat="server" Text=""></asp:Label>
                <asp:Image ID="GIFPlayer1" runat="server"/>
            </div>
            <div class="GIFDIP" id="GIFDiv2">
                <asp:Label CssClass="span" ID="ExerciseLabel2" runat="server" Text=""></asp:Label>
                <asp:Label CssClass="span" ID="MuscleTargetLabel2" runat="server" Text=""></asp:Label>
                <asp:Image ID="GIFPlayer2" runat="server"/>
            </div>
            <div class="GIFDIP" id="GIFDiv3">
                <asp:Label CssClass="span" ID="ExerciseLabel3" runat="server" Text=""></asp:Label>
                <asp:Label CssClass="span" ID="MuscleTargetLabel3" runat="server" Text=""></asp:Label>
                <asp:Image ID="GIFPlayer3" runat="server"/>
            </div>
        </div>

        
    </div>
    

</asp:Content>
