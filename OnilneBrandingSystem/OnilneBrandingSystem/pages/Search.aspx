<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="OnilneBrandingSystem.pages.Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Our Customers Starts Here-->
        <div class="brands">
            <div class="wrapper">
                <!--Navigation Starts Here-->
                <div class="categories">
                    <strong>Categories</strong>
                    <ul>
                        <a href="#">E-Commerce<li></li></a>
                        <a href="#">NGO<li></li></a>
                        <a href="#">Travels<li></li></a>
                        <a href="#">Clothing<li></li></a>
                        <a href="#">Gadgets<li></li></a>
                        <a href="#">Furniture<li></li></a>
                        <a href="#">Consultancy<li></li></a>
                    </ul>
                </div>
                
                <div class="search">
                    <strong> &nbsp;</strong>
                    <form id="form1" runat="server">
                        <asp:TextBox ID="txtSearch" runat="server" style="width: 70%;border: 2px solid rgb(245,124,33);">

                        </asp:TextBox><asp:Button ID="btnSearch" runat="server" Text="SEARCH" style="padding: 2%; " OnClick="btnSearch_Click" />
                    </form>
                </div>
                <div class="clearfix"></div>
                <!--Navigation Ends Here-->
                <div class="cat-title">SEARCH RESULTS</div>
                <asp:Label ID="lblError" runat="server" Text=""></asp:Label> <!--This Label denotes the looping of data from database-->
                
                <div class="clearfix"></div>
            </div>
        </div>
    
        <!--Our Customers Starts Here-->
</asp:Content>
