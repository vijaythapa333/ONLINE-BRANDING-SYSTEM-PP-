<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="brandDetail.aspx.cs" Inherits="OnilneBrandingSystem.pages.brandDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Our Customers Starts Here-->
        <div class="brands">
            <div class="wrapper">
                <!--Navigation Starts Here-->
                <div class="categories">
                    <strong>Categories</strong>
                    <ul>
                        <a href="~/Pages/BrandsByCategory.aspx?cat=E-Commerce" runat="server">E-Commerce<li></li></a>
                        <a href="~/Pages/BrandsByCategory.aspx?cat=NGO" runat="server">NGO<li></li></a>
                        <a href="~/Pages/BrandsByCategory.aspx?cat=Travels" runat="server">Travels<li></li></a>
                        <a href="~/Pages/BrandsByCategory.aspx?cat=Clothing" runat="server">Clothing<li></li></a>
                        <a href="~/Pages/BrandsByCategory.aspx?cat=Gadgets" runat="server">Gadgets<li></li></a>
                        <a href="~/Pages/BrandsByCategory.aspx?cat=Furniture" runat="server">Furniture<li></li></a>
                        <a href="~/Pages/BrandsByCategory.aspx?cat=Consultancy" runat="server">Consultancy<li></li></a>
                    </ul>
                </div>
                
                <div class="search">
                    <strong> &nbsp;</strong>
                    <form method="post" action="">
                        <input type="search" name="keywords" placeholder=" Search by Keywords" />
                    </form>
                </div>
                <div class="clearfix"></div>
                <!--Navigation Ends Here-->
                <asp:Label ID="lblTest" runat="server" Text=""></asp:Label>
                <asp:Label ID="lblCheck" runat="server" Text=""></asp:Label>
                 <!--Gallery Starts Here-->
                <div class='gallery'>
                    <h3>Gallery</h3>
                    <asp:Label ID="lblGallery" runat="server" Text=""></asp:Label>
                    
                    <div class='clearfix'></div>
                    
                </div>
                <hr />
                <!--Gallery Ends Here-->
                <form id="form1" runat="server">
                <div class='rate'>
                    <h3>Rate Us</h3>
                    <asp:RadioButton ID="RadioButton1" GroupName="rate" runat="server" value="1" />1
                    <asp:RadioButton ID="RadioButton2" GroupName="rate" runat="server" value="2" />2
                    <asp:RadioButton ID="RadioButton3" GroupName="rate" runat="server" value="3" />3
                    <asp:RadioButton ID="RadioButton4" GroupName="rate" runat="server" value="4" />4
                    <asp:RadioButton ID="RadioButton5" GroupName="rate" runat="server" value="5" />5
                    <asp:Button ID="btnSave" runat="server" Text="SAVE" />
                    <br />
                </ div><br />

                <!--Contact Starts Here-->
                
                <div class='contact-form'>
                    <h3>CONTACT US</h3>
                    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
                    
                        <asp:TextBox ID="txtFullName" runat="server" placeholder="Your Full Name"></asp:TextBox>
                        <asp:TextBox ID="txtEmail" runat="server" placeholder="Your Email"></asp:TextBox>
                        <asp:TextBox ID="txtSubject" runat="server" placeholder="Subject"></asp:TextBox>
                        <asp:TextBox ID="txtContact" runat="server" placeholder="Your Contact"></asp:TextBox>
                        <asp:TextBox ID="txtUrl" runat="server" placeholder="Your Web site"></asp:TextBox>
                        <asp:TextBox ID="txtMessage" runat="server" placeholder="Your Message"></asp:TextBox>
                        <asp:Button ID="btnSend" runat="server" Text="SEND" OnClick="btnSend_Click" />
                    </form>
                </div>
                <div class="clearfix"></div>
                <!--Contact Ends Here-->
            </div>
        </div>
        <!--Our Customers Starts Here-->
    </div>
</asp:Content>
