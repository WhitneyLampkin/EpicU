<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Blog.Web.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--
    ================================================== 
            Global Page Section Start
        ================================================== -->
        <section class="global-page-header">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="block">
                            <h2>About Me</h2>
                            <ol class="breadcrumb">
                                <li>
                                    <a href="Default.aspx">
                                        <i class="ion-ios-home"></i>
                                        Home
                                    </a>
                                </li>
                                <li class="active">About Me</li>
                            </ol>
                        </div>
                    </div>
                </div>
            </div>   
        </section><!--/#page-header-->
    
    <!-- 
        ================================================== 
            About Me Section Start
        ================================================== -->
        <section id="about">
                <div class="container">
                    <div class="row">
                        <div class="col-md-6 col-sm-6">
                            <div class="block wow fadeInLeft" data-wow-delay=".3s" data-wow-duration="500ms">
                                <h2>
                                ABOUT ME
                                </h2>
                                <p>
                                    Who am I? A Christian, mother, daughter, friend, and student of life. I studied chemistry at the University of Texas
                                    at Dallas, but I've now fallen in love with coding. If computers bore you, then we can always chat about chess or 
                                    video games.
                                </p>
                                <p>
                                    Was that a little too general for you?
                                    If so, I can definitely understand. Unfortunately, I'm not a fan of About Me sections. I am more than just a 
                                    few lines on a page. Why don't you visit the <a href="Contact.aspx">contact me</a> section and ask anything you'd like.
                                </p>
                            </div>
                            
                        </div>
                        <div class="col-md-6 col-sm-6">
                            <div class="block wow fadeInRight; img-responsive; .img-rounded !important" style="width:400px;height:600px;" data-wow-delay=".3s" data-wow-duration="500ms">
                                <img src="images/FullSizeRender.jpg" alt="">
                            </div>
                        </div>
                    </div>
                </div>
            </section> <!-- /#about -->
</asp:Content>
