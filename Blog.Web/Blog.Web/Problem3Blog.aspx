<%@ Page Title="" Language="C#" MasterPageFile="~/SingleBlogPost.Master" AutoEventWireup="true" CodeBehind="Problem3Blog.aspx.cs" Inherits="Blog.Web.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section class="global-page-header">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="block">
                            <h2>Project Euler: Problem 3</h2><br />
                            <h3>Largest Prime Factor</h3>
                            <div class="portfolio-meta">
                                <span>July 31, 2016</span>|
                                <span>Completion Time: Untimed</span>|
                                <span> Link: <a href="https://projecteuler.net/problem=3">Project Euler P.3</a></span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            </section><!--/#Page header-->
            <section class="single-post">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            
                            <div class="post-content">
                                <blockquote>
                                    The prime factors of 13195 are 5, 7, 13 and 29.<br /><br />
                                    What is the largest prime factor of the number 600851475143?
                                </blockquote>
                                <p>
                                    I'm not ashamed to say that I have yet to find a working solution to this problem. I have definitely spent more time on it 
                                    than I did with the other two combined. I have also started from scratch several times, but I keep hitting a dead ends. 
                                </p>
                                <p>
                                    I can obviously improve the code by getting rid of all of the helper methods, but I had to divide the problem up to make sense 
                                    of it. Though, I know for a fact that it can be written with far less lines of code. I will update this post once I find a working
                                    solution. For now, I will be going on to Problem 4 to build my confidence back up. I'm sure this will make sense when I revisit
                                    it in a couple of days. 
                                </p>
                                <p>
                                    Below I've attached a photo of my solution. If you have any hints that you think I may find helpful, 
                                    vist my <a href="Contact.aspx">Contact Me</a> page.     
                                </p>
                                <br />
                                <p>Whitney</p>
                                <%--<ol>
                                    <li>Ipsum dolor sit amet.</li>
                                    <li>Lorem sit amet.</li>
                                    <li>Lorem ipsum dolor sit amet.</li>
                                    <li>Lorem ipsum dolor amet.</li>
                                </ol>--%>
                            </div>
                            <figure class="wow fadeInLeft animated" data-wow-duration="500ms" data-wow-delay="300ms">
                                <div class="img-wrapper">
                                    <img src="images/blogpic3.png" class="img-responsive" alt="" >
                                    <div class="overlay">
                                        <div class="buttons">
                                            <a rel="gallery" class="fancybox" href="images/NewFolder1/blogpic2.png">Enlarge</a>
                                        </div>
                                    </div>
                                </div>
                                <figcaption>
                                <h4>
                                <a href="images/NewFolder1/blogpic2.png">
                                    Largest Prime Factor
                                </a>
                                </h4>
                                </figcaption>
                            </figure>
                            
                        </div>
                    </div>
            </section>
</asp:Content>
