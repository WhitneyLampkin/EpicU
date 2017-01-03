<%@ Page Title="" Language="C#" MasterPageFile="~/Projects.Master" AutoEventWireup="true" CodeBehind="ProjectLifeEvents.aspx.cs" Inherits="Blog.Web.WebForm14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <!--
    ================================================== 
            Global Page Section Start
        ================================================== -->
        <section class="global-page-header">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="block">
                            <h2>Science Reports & HTML5</h2>
                            <h4>A Perfect Match!</h4>
                            <ol class="breadcrumb">
                                <li>
                                    <a href="Default.aspx">
                                        <i class="ion-ios-home"></i>
                                        Home
                                    </a>
                                </li>
                                <li class="active">Life Events: A Social Project</li>
                            </ol>
                        </div>
                    </div>
                </div>
            </div> 
              
        </section><!--/#page-header-->
    <div class="report">
        <p>
            A few months ago, I started my journey to create a positive social networking website. Life Events was my first attempt at learning how 
            to accomplish this. I have put a spin on Life Events and now have a website called The Three Six Five Challenge that I hope to be able to share soon
        </p>
        <p>
            Until then, please take a look at the Life Event's gallery below. 
        </p>
    </div>
    
    <section id="gallery" class="gallery">
                <div class="container">
                    <div class="row">
                        <div class="col-sm-4 col-xs-12">
                            <figure class="wow fadeInLeft animated portfolio-item animated" data-wow-duration="500ms" data-wow-delay="0ms" style="visibility: visible; animation-duration: 300ms; -webkit-animation-duration: 300ms; animation-delay: 0ms; -webkit-animation-delay: 0ms; animation-name: fadeInLeft; -webkit-animation-name: fadeInLeft;">
                                <div class="img-wrapper">
                                    <img src="images/LifeEvents/LE_About.png" class="img-responsive" alt="this is a title">
                                    <div class="overlay">
                                        <div class="buttons">
                                            <a rel="gallery" class="fancybox" href="images/LifeEvents/LE_About.png">View</a>
                                        </div>
                                    </div>
                                </div>
                            </figure>
                        </div>
                        <div class="col-sm-4 col-xs-12">
                            <figure class="wow fadeInLeft animated animated" data-wow-duration="500ms" data-wow-delay="300ms" style="visibility: visible; animation-duration: 300ms; -webkit-animation-duration: 300ms; animation-delay: 300ms; -webkit-animation-delay: 300ms; animation-name: fadeInLeft; -webkit-animation-name: fadeInLeft;">
                                <div class="img-wrapper">
                                    <img src="images/LifeEvents/LE_Register.png" class="img-responsive" alt="this is a title">
                                    <div class="overlay">
                                        <div class="buttons">
                                            <a rel="gallery" class="fancybox" href="images/LifeEvents/LE_Register.png">View</a>
                                        </div>
                                    </div>
                                </div>
                            </figure>
                        </div>
                        <div class="col-sm-4 col-xs-12">
                            <figure class="wow fadeInLeft animated animated" data-wow-duration="500ms" data-wow-delay="500ms" style="visibility: visible; animation-duration: 300ms; -webkit-animation-duration: 300ms; animation-delay: 300ms; -webkit-animation-delay: 300ms; animation-name: fadeInLeft; -webkit-animation-name: fadeInLeft;">
                                <div class="img-wrapper">
                                    <img src="images/LifeEvents/LE_Login.png" class="img-responsive" alt="">
                                    <div class="overlay">
                                        <div class="buttons">
                                            <a rel="gallery" class="fancybox" href="images/LifeEvents/LE_Login.png">View</a>
                                        </div>
                                    </div>
                                </div>
                            </figure>
                        </div>
                        <div class="col-sm-4 col-xs-12">
                            <figure class="wow fadeInLeft animated" data-wow-duration="500ms" data-wow-delay="700ms" style="visibility: hidden; animation-duration: 300ms; -webkit-animation-duration: 300ms; animation-delay: 600ms; -webkit-animation-delay: 600ms; animation-name: none; -webkit-animation-name: none;">
                                <div class="img-wrapper">
                                    <img src="images/LifeEvents/LE_Profile.png" class="img-responsive" alt="">
                                    <div class="overlay">
                                        <div class="buttons">
                                            <a rel="gallery" class="fancybox" href="images/LifeEvents/LE_Profile.png">View</a>
                                        </div>
                                    </div>
                                </div>
                            </figure>
                        </div>
                        <div class="col-sm-4 col-xs-12">
                            <figure class="wow fadeInLeft animated" data-wow-duration="500ms" data-wow-delay="900ms" style="visibility: hidden; animation-duration: 300ms; -webkit-animation-duration: 300ms; animation-delay: 900ms; -webkit-animation-delay: 900ms; animation-name: none; -webkit-animation-name: none;">
                                <div class="img-wrapper">
                                    <img src="images/LifeEvents/LE_Comments.png" class="img-responsive" alt="">
                                    <div class="overlay">
                                        <div class="buttons">
                                            <a rel="gallery" class="fancybox" href="images/LifeEvents/LE_Comments.png">View</a>
                                        </div>
                                    </div>
                                </div>
                            </figure>
                        </div>
                       <%-- <div class="col-sm-4 col-xs-12">
                            <figure class="wow fadeInLeft animated" data-wow-duration="500ms" data-wow-delay="1100ms" style="visibility: hidden; animation-duration: 300ms; -webkit-animation-duration: 300ms; animation-delay: 1200ms; -webkit-animation-delay: 1200ms; animation-name: none; -webkit-animation-name: none;">
                                <div class="img-wrapper">
                                    <img src="images/portfolio/item-6.jpg" class="img-responsive" alt="">
                                    <div class="overlay">
                                        <div class="buttons">
                                            <a rel="gallery" class="fancybox" href="images/portfolio/item-6.jpg">View</a>
                                        </div>
                                    </div>
                                </div>
                            </figure>
                        </div>--%>
                    </div>
                </div>
            </section>
</asp:Content>
