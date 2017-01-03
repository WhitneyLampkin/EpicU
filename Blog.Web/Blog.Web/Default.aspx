<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Blog.Web.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!--
        ==================================================
        Slider Section Start
        ================================================== -->
        <section id="hero-area" >
            <div class="container">
                <div class="row">
                    <div class="col-md-12 text-center">
                        <div class="block wow fadeInUp" data-wow-delay=".3s">
                            
                            <!-- Slider -->
                            <section class="cd-intro">
                                <h1 class="wow fadeInUp animated cd-headline slide" data-wow-delay=".4s" >
                                <span>HI, MY NAME IS WHITNEY & I AM A</span><br>
                                <span class="cd-words-wrapper">
                                    <b class="is-visible">CHESS ENTHUSIAST</b>
                                    <b>FUTURE DEVELOPER</b>
                                    <b>MOTHER</b>
                                    <b>BLOGGER</b>
                                    <b>GAMER</b>
                                </span>
                                </h1>
                                </section> <!-- cd-intro -->
                                <!-- /.slider -->
                                <h2 class="wow fadeInUp animated" data-wow-delay=".6s" >
                                    A year ago, I didn't know anything about computer programming. 
                                    That's changed thanks to Bob Tabor's lesson at <a href="https://www.devu.com">DevU</a>. 
                                    If you've ever been interested in coding but were too intimidated to get started, I suggest you check his lessons out.
                                </h2>
                                <a class="btn-lines dark light wow fadeInUp animated smooth-scroll btn btn-default btn-green" data-wow-delay=".9s" href="#works" data-section="#works" >Project Euler Blog Posts</a>
                               <%-- &nbsp &nbsp 
                                <a class="btn-lines dark light wow fadeInUp animated smooth-scroll btn btn-default btn-green" href="ProjectEulerDemos.aspx">Project Euler Live Demos</a>--%>

                            </div>
                        </div>
                    </div>
                </div>
            </section>
        
            <!--/#main-slider-->
    <!--
            ==================================================
            Slider Section Start
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
            <!--
            ==================================================
            Portfolio Section Start
            ================================================== -->
            <section id="works" class="works">
                <div class="container">
                    <div class="section-heading">
                        <h1 class="title wow fadeInDown" data-wow-delay=".3s">Project Euler Blog Posts</h1>
                        <p class="wow fadeInDown" data-wow-delay=".5s">
                            Check out my Project Eujer attempts below.
                        </p>
                    </div>
                    <div class="row">
                        <div class="col-sm-4 col-xs-12">
                            <figure class="wow fadeInLeft animated portfolio-item" data-wow-duration="500ms" data-wow-delay="0ms">
                                <div class="img-wrapper">
                                    <img src="images/realblog1.png" class="img-responsive" alt="this is a title" >
                                    <div class="overlay">
                                        <div class="buttons">
                                            <a rel="gallery" class="fancybox" href="images/NewFolder1/realblog1.png">Enlarge</a>
                                            <a href="Problem1Blog.aspx">View Post</a>
                                        </div>
                                    </div>
                                </div>
                                <figcaption>
                                <h4>
                                <a href="Problem1Blog.aspx">
                                    Problem 1: Multiples of 3 and 5
                                </a>
                                </h4>
                                <p>
                                    If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
                                    Find the sum of all the multiples of 3 or 5 below 1000.

                                </p>
                                </figcaption>
                            </figure>
                        </div>
                        <div class="col-sm-4 col-xs-12">
                            <figure class="wow fadeInLeft animated" data-wow-duration="500ms" data-wow-delay="300ms">
                                <div class="img-wrapper">
                                    <img src="images/blogpic2.png" class="img-responsive" alt="this is a title" >
                                    <div class="overlay">
                                        <div class="buttons">
                                            <a rel="gallery" class="fancybox" href="images/NewFolder1/blogpic1.png">Enlarge</a>
                                            <a href="Problem2Blog.aspx">View Post</a>
                                        </div>
                                    </div>
                                </div>
                                <figcaption>
                                <h4>
                                <a href="Problem2Blog.aspx">
                                    Problem 2: Even Fibonacci Numbers
                                </a>
                                </h4>
                                <p>
                                    By considering the terms in the Fibonacci sequence (1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...) whose values do not exceed four million, find the sum of the even-valued terms.
                                    <br />
                                </p>
                                </figcaption>
                            </figure>
                        </div>
                        <div class="col-sm-4 col-xs-12">
                            <figure class="wow fadeInLeft animated" data-wow-duration="500ms" data-wow-delay="300ms">
                                <div class="img-wrapper">
                                    <img src="images/blogpic2.png" class="img-responsive" alt="" >
                                    <div class="overlay">
                                        <div class="buttons">
                                            <a rel="gallery" class="fancybox" href="images/NewFolder1/blogpic2.png">Enlarge</a>
                                            <a href="Problem3Blog.aspx">View Post</a>
                                        </div>
                                    </div>
                                </div>
                                <figcaption>
                                <h4>
                                <a href="Problem3Blog.aspx">
                                    Problem 3: The Largest Prime Factor
                                </a>
                                </h4>
                                <p>
                                    The prime factors of 13195 are 5, 7, 13 and 29. <br /><br />What is the largest prime factor of the number 600851475143?
                                </p>
                                </figcaption>
                            </figure>
                        </div>
                        <%--<div class="col-sm-4 col-xs-12">
                            <figure class="wow fadeInLeft animated" data-wow-duration="500ms" data-wow-delay="600ms">
                                <div class="img-wrapper">
                                    <img src="images/portfolio/item-4.jpg" class="img-responsive" alt="" >
                                    <div class="overlay">
                                        <div class="buttons">
                                            <a rel="gallery" class="fancybox" href="images/portfolio/item-4.jpg">Demo</a>
                                            <a target="_blank" href="single-portfolio.html">Details</a>
                                        </div>
                                    </div>
                                </div>
                                <figcaption>
                                <h4>
                                <a href="#">
                                    Make Up elements
                                </a>
                                </h4>
                                <p>
                                    Lorem ipsum dolor.
                                </p>
                                </figcaption>
                            </figure>
                        </div>
                        <div class="col-sm-4 col-xs-12">
                            <figure class="wow fadeInLeft animated" data-wow-duration="500ms" data-wow-delay="900ms">
                                <div class="img-wrapper">
                                    <img src="images/portfolio/item-5.jpg" class="img-responsive" alt="" >
                                    <div class="overlay">
                                        <div class="buttons">
                                            <a rel="gallery" class="fancybox" href="images/portfolio/item-5.jpg">Demo</a>
                                            <a target="_blank" href="single-portfolio.html">Details</a>
                                        </div>
                                    </div>
                                </div>
                                <figcaption>
                                <h4>
                                <a href="#">
                                    Shoping Bag Concept
                                </a>
                                </h4>
                                <p>
                                    Lorem ipsum dolor.
                                </p>
                                </figcaption>
                            </figure>
                        </div>
                        <div class="col-sm-4 col-xs-12">
                            <figure class="wow fadeInLeft animated" data-wow-duration="500ms" data-wow-delay="1200ms">
                                <div class="img-wrapper">
                                    <img src="images/portfolio/item-6.jpg" class="img-responsive" alt="" >
                                    <div class="overlay">
                                        <div class="buttons">
                                            <a rel="gallery" class="fancybox" href="images/portfolio/item-6.jpg">Demo</a>
                                            <a target="_blank" href="single-portfolio.html">Details</a>
                                        </div>
                                    </div>
                                </div>
                                <figcaption>
                                <h4>
                                <a href="#">
                                    Caramel Bottle
                                </a>
                                </h4>
                                <p>
                                    Lorem ipsum dolor.
                                </p>
                                </figcaption>
                            </figure>
                        </div>--%>
                    </div>
                </div>
            </section> <!-- #works -->
            <!--
            ==================================================
            Portfolio Section Start
            ================================================== -->
            <section id="feature">
                <div class="container">
                    <div class="section-heading">
                        <h1 class="title wow fadeInDown" data-wow-delay=".3s">Just For Fun</h1>
                        <p class="wow fadeInDown" data-wow-delay=".5s">
                            I understand that the Project Euler problems may be a little too much for some. I suggest
                            that you check out the projects below that I have been working on. Simply click on the titles
                            below to get started.
                       
                        </p>
                    </div>
                    <div class="row">
                        <div class="col-md-4 col-lg-4 col-xs-12">
                            <div class="media wow fadeInUp animated" data-wow-duration="500ms" data-wow-delay="300ms">
                                <div class="media-left">
                                    <div class="icon">
                                        <i class="ion-ios-flask-outline"></i>
                                    </div>
                                </div>
                                <div class="media-body">
                                    <a href="ScienceProject.aspx"><h4 class="media-heading">Science + Coding = ?</h4></a>
                                    <p>
                                        Check out this project to see how 
                                        my old lab reports helped me sharpen my HTML5 skills. 
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4 col-lg-4 col-xs-12">
                            <div class="media wow fadeInDown animated" data-wow-duration="500ms" data-wow-delay="600ms">
                                <div class="media-left">
                                    <div class="icon">
                                        <i class="ion-ios-monitor-outline"></i>
                                    </div>
                                </div>
                                <div class="media-body">
                                    <a href="ProjectEulerDemos.aspx" ><h4 class="media-heading">Project Euler Live Demos</h4></a>
                                    <p>Check out my Project Euler live demos to see the code in the blogs in action!</p>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4 col-lg-4 col-xs-12">
                            <div class="media wow fadeInDown animated" data-wow-duration="500ms" data-wow-delay="900ms">
                                <div class="media-left">
                                    <div class="icon">
                                        <i class="ion-ios-people-outline"></i>
                                    </div>
                                </div>
                                <div class="media-body">
                                    <a href="ProjectLifeEvents.aspx" ><h4 class="media-heading">Life Events</h4></a>
                                    <p>Someday, I hope to change social websites for the better. 
                                        Life Events was my first attempt at programming a social website. 
                                    </p>
                                </div>
                            </div>
                        </div>
                        <%--<div class="col-md-4 col-lg-4 col-xs-12">
                            <div class="media wow fadeInDown animated" data-wow-duration="500ms" data-wow-delay="900ms">
                                <div class="media-left">
                                    <div class="icon">
                                        <i class="ion-ios-lightbulb-outline"></i>
                                    </div>
                                </div>
                                <div class="media-body">
                                    <h4 class="media-heading">Life Events Social Site</h4>
                                    <p>Stay-tuned. This will be uploaded soon.</p>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4 col-lg-4 col-xs-12">
                            <div class="media wow fadeInDown animated" data-wow-duration="500ms" data-wow-delay="1200ms">
                                <div class="media-left">
                                    <div class="icon">
                                        <i class="ion-ios-americanfootball-outline"></i>
                                    </div>
                                </div>
                                <div class="media-body">
                                    <h4 class="media-heading">Football Throw Game</h4>
                                    <p>Stay-tuned. This will be uploaded soon.</p>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4 col-lg-4 col-xs-12">
                            <div class="media wow fadeInDown animated" data-wow-duration="500ms" data-wow-delay="1500ms">
                                <div class="media-left">
                                    <div class="icon">
                                        <i class="ion-ios-keypad-outline"></i>
                                    </div>
                                </div>
                                <div class="media-body">
                                    <h4 class="media-heading">Databases</h4>
                                    <p>Stay-tuned. This will be uploaded soon.</p>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4 col-lg-4 col-xs-12">
                            <div class="media wow fadeInDown animated" data-wow-duration="500ms" data-wow-delay="1800ms">
                                <div class="media-left">
                                    <div class="icon">
                                        <i class="ion-ios-barcode-outline"></i>
                                    </div>
                                </div>
                                <div class="media-body">
                                    <h4 class="media-heading">JavaScript Practice</h4>
                                    <p>Stay-tuned. This will be uploaded soon.</p>
                                </div>
                            </div>
                        </div>--%>
                    </div>
                </div>
            </section> <!-- /#feature -->
</asp:Content>
