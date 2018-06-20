<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Popular.aspx.cs" Inherits="OnilneBrandingSystem.pages.Popular" %>
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
                    <form method="post" action="">
                        <input type="search" name="keywords" placeholder="Search by Keywords" />
                    </form>
                </div>
                <div class="clearfix"></div>
                <!--Navigation Ends Here-->
                <div class="cat-title">POPULAR BRANDS</div>

                    <asp:Label ID="lblTest" runat="server" Text=""></asp:Label>
                <div class="clearfix"></div>
            </div>
        </div>
    
        <!--Our Customers Starts Here-->
</asp:Content>
