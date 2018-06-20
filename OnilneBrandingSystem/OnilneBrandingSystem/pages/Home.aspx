<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="OnilneBrandingSystem.pages.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<!--Banner Part Starts Here-->
        <div class="banner">
            <div class="wrapper">
                <div class="slider">
                    <!-- Start WOWSlider.com BODY section -->
                    <div id="wowslider-container1">
                    <div class="ws_images"><ul>
                    		<li><img src="~/assets/slider/data1/images/a1757.jpg" runat="server" alt="Online Branding System" title="Online Branding System" id="wows1_0"/></li>
                    		<li><img src="~/assets/slider/data1/images/bp02.jpg" runat="server" alt="Brands All Over The World" title="Brands All Over The World" id="wows1_1"/></li>
                    		<li><img src="~/assets/slider/data1/images/brandbehaviour.jpg" runat="server" alt="http://wowslider.net/" title="Brand-Behaviour" id="wows1_2"/></li>
                    		<li><img src="~/assets/slider/data1/images/brandmarketingtips1170x716.jpg" runat="server" alt="Brand Marketing Techniques" title="Brand Marketing Techniques" id="wows1_3"/></li>
                    	</ul></div>
                    	<div class="ws_bullets"><div>
                    		<a href="#" title="Online Branding System"><span><img src="~/assets/slider/data1/tooltips/a1757.jpg" runat="server" alt="Online Branding System"/>1</span></a>
                    		<a href="#" title="Brands All Over The World"><span><img src="~/assets/slider/data1/tooltips/bp02.jpg" runat="server" alt="Brands All Over The World"/>2</span></a>
                    		<a href="#" title="Brand-Behaviour"><span><img src="~/assets/slider/data1/tooltips/brandbehaviour.jpg" runat="server" alt="Brand-Behaviour"/>3</span></a>
                    		<a href="#" title="Brand Marketing Techniques"><span><img src="~/assets/slider/data1/tooltips/brandmarketingtips1170x716.jpg" runat="server" alt="Brand Marketing Techniques"/>4</span></a>
                    	</div></div>
                    <div class="ws_shadow"></div>
                    </div>	
                    <script type="text/javascript" src="~/assets/slider/engine1/wowslider.js"></script>
                    <script type="text/javascript" src="~/assets/slider/engine1/script.js"></script>
                    <!-- End WOWSlider.com BODY section -->
                </div>
                
                <div class="register">
                    Register For Free
                    <hr />
                    <div class="register-form">
                            <input type="text" name="full_name" placeholder="Your Full Name" />
                            <input type="email" name="email" placeholder="Your Working Email" />
                            <input type="tel" name="contact" placeholder="Your Contact Number" />
                            <input type="text" name="company" placeholder="Your Company Name" />
                            <input type="password" name="password" placeholder="Unique Password" />
                            <input type="submit" name="submit" value="Get Started" />
                    </div>
                </div>
                
                <div class="clearfix"></div>
            </div>
        </div>
        <!--Banner Part Ends Here-->
        
        <!--Services Starts Here-->
            <div class="services">
                <div class="wrapper">
                    <asp:Label ID="lblTest" runat="server" Text=""></asp:Label>
                    <h2>OUR SERVICES</h2>
                    
                    <div class="service-box">
                        <i class="fa fa-money" aria-hidden="true"></i>
                        <h3>MONETIZE</h3>
                        Description
                    </div>
                    
                    <div class="service-box">
                        <i class="fa fa-address-card-o" aria-hidden="true"></i>
                        <h3>IDENTITY</h3>
                        Description
                    </div>
                    
                    <div class="service-box">
                        <i class="fa fa-line-chart" aria-hidden="true"></i>
                        <h3>TRAFFIC</h3>
                        Description
                    </div>
                    <div class="clearfix"></div>
                </div>
            </div>
        <!--Services Starts Here-->
        
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
                    <form id="form1" runat="server">
                        <asp:TextBox ID="txtSearch" runat="server" style="width: 70%;border: 2px solid rgb(245,124,33);">

                        </asp:TextBox><asp:Button ID="btnSearch" runat="server" Text="SEARCH" style="padding: 2%; " OnClick="btnSearch_Click" />
                    </form>
                </div>
                <div class="clearfix"></div>
                <!--Navigation Ends Here-->
                <div class="cat-title">TOP BRANDS</div>
                <asp:Label ID="lblNewBrands" runat="server" Text=""></asp:Label>
                
                <div class="clearfix"></div>
                <div class="cat-title">POPULAR BRANDS</div>
                <asp:Label ID="lblPopularBrands" runat="server" Text=""></asp:Label>
                
                <div class="clearfix"></div>
            </div>
        </div>
        <!--Our Customers Starts Here-->
    </asp:Content>