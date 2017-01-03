<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BlogPosts.aspx.cs" Inherits="Blog.Web.WebForm7" %>
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
                            <h2>Project Euler Blog</h2>
                            <ol class="breadcrumb">
                                <li>
                                    <a href="Default.aspx">
                                        <i class="ion-ios-home"></i>
                                        Home
                                    </a>
                                </li>
                                <li class="active">Blog</li>
                            </ol>
                        </div>
                    </div>
                </div>
            </div>
            </section><!--/#Page header-->

            <section id="blog-full-width">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">

                            <h3>
                                Hi there! Thanks for visiting my blog. Below are the most recent entries.
                                Don't be intimated by the photos. You can still enjoy reading the posts even if you don't know anything about coding!
                                The posts do not contain much code. Instead, I'm sharing my journey as I work through the Project Euler problems, in 
                                an effort to identify areas of opportunity to build my c# programming skills.
                                <br /><br />
                                Also, don't forget to check out my 
                                <a href="ProjectEulerDemos.aspx">Project Euler Demos</a> to see live examples of the solutions. 
                            </h3>

                            <article class="wow fadeInDown" data-wow-delay=".3s" data-wow-duration="500ms">
                                <div class="blog-post-image">
                                    <a href="post-fullwidth.html"><img class="img-responsive" src="images/realblog1.png" alt="Problem 1 Photo" /></a>
                                </div>
                                <div class="blog-content">
                                    <h2 class="blogpost-title">
                                    <a href="Problem1Blog.aspx">Project Euler: Multiples of 3 and 5</a>
                                    </h2>
                                    <div class="blog-meta">
                                        <span>July 29, 2016</span>
                                        <span>by <a href="About.aspx">Whitney Lampkin</a></span>
                                        <span><a href="https://projecteuler.net/problem=1">View at problem 1 Project Euler</a></span>
                                    </div>
                                    <p>
                                    Problem 1: If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
                                    Find the sum of all the multiples of 3 or 5 below 1000.    
                                    </p>
                                    <a href="Problem1Blog.aspx" class="btn btn-dafault btn-details">Continue Reading</a>
                                </div>
                                
                            </article>
                            <article class="wow fadeInDown" data-wow-delay=".5s" data-wow-duration="500ms">
                                <div class="blog-post-image">
                                    <a href="post-fullwidth.html"><img class="img-responsive" src="images/blogpic2.png" alt="Problem 2 Photo" /></a>
                                </div>
                                <div class="blog-content">
                                    <h2 class="blogpost-title">
                                    <a href="Problem2Blog.aspx">Project Euler: Even Fibonacci numbers</a>
                                    </h2>
                                    <div class="blog-meta">
                                         <span>July 30, 2016</span>
                                        <span>by <a href="About.aspx">Whitney Lampkin</a></span>
                                        <span><a href="https://projecteuler.net/problem=2">View problem 2at Project Euler</a></span>
                                    </div>
                                    <p>
                                        Problem 2: Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:

                                            1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

                                         By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

                                    </p>
                                    <a href="Problem2Blog.aspx" class="btn btn-dafault btn-details">Continue Reading</a>
                                </div>
                                
                            </article>
                            <article class="wow fadeInDown" data-wow-delay=".7s" data-wow-duration="500ms">
                                <div class="blog-post-image">
                                    <a href="post-fullwidth.html"><img class="img-responsive" src="images/blogpic3.png" alt="Problem 3 Photo" /></a>
                                </div>
                                <div class="blog-content">
                                    <h2 class="blogpost-title">
                                    <a href="post-fullwidth.html">Project Euler: Largest prime factor</a>
                                    </h2>
                                    <div class="blog-meta">
                                         <span>July 31, 2016</span>
                                        <span>by <a href="About.aspx">Whitney Lampkin</a></span>
                                        <span><a href="https://projecteuler.net/problem=3">View problem 3 at Project Euler</a></span>
                                    </div>
                                    <p>
                                        The prime factors of 13195 are 5, 7, 13 and 29.
                                        What is the largest prime factor of the number 600851475143?

                                    </p>
                                    <a href="Problem3Blog.aspx" class="btn btn-dafault btn-details">Continue Reading</a>
                                </div>
                                
                            </article>
                        </div>
                    </div>
                </div>
            </section>
</asp:Content>
