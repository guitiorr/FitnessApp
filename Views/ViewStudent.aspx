<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="ViewStudent.aspx.cs" Inherits="FitnessApp.Views.ViewStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Style/ViewStudent.css?Version=1" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Student">
        <asp:Repeater ID="repeatStudentList" runat="server" OnItemDataBound="repeatStudentList_ItemDataBound">
            <ItemTemplate>
                <div class="item">
                <div class="img-bg">
                    <asp:Image class="image" ID="ClientImg" runat="server" ImageUrl='<%# Eval("ProfilePicture") %>' />
                </div>
                <div class="name">
                    <asp:Label ID="NameLbl" runat="server" Text='<%# Eval("FullName") %>'></asp:Label>
                </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
