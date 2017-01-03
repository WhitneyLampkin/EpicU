<%@ Page Title="" Language="C#" MasterPageFile="~/SingleBlogPost.Master" AutoEventWireup="true" CodeBehind="Problem1Blog.aspx.cs" Inherits="Blog.Web.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
           <section class="global-page-header">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="block">
                            <h2>Project Euler: Problem 1</h2><br />
                            <h3>Multiples of 3 and 5</h3>
                            <div class="portfolio-meta">
                                <span>July 29, 2016</span>|
                                <span>Completion Time: Untimed</span>|
                                <span> Link: <a href="https://projecteuler.net/problem=1">Project Euler P.1</a>    <%--,<a href="">people</a></span>--%></span>
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
                                    Problem 1: If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
                                    Find the sum of all the multiples of 3 or 5 below 1000.
                                </blockquote>
                                <p>
                                    I stumbled upon Project Euler while searching for c# practice problems the other night. 
                                    My search led me to several forums and blogs that referenced Project Euler. 
                                    There are currently over 500 problems and from what I understand, more problems are added periodically. 
                                </p>
                                <p>
                                    Obviously, solutions are readily available online. However, I feel that it is very important for me to attempt the 
                                    problems on my own. Otherwise, I don't see any benefit in doing the work. I truly want to use Project Euler to pinpoint 
                                    weakness and correct them. With this approach, I believe that I will definitely be able to sharpen my skills. 
                                </p>
                                <p>
                                    I didn't find that this problem was too difficult. I immediately knew how I would approach it; however, I did have to
                                    pull my notes out and review the c# operators. I am comfortable with the basic ones, but I had never used the modulus (%)
                                    operator. This exercise definitely taught me a lot about using it to calculate remainders. 
                                </p>
                                <p>
                                    Below I've attached a photo of my solution. If you have any suggestions on how I can improve it or want to share your
                                    own solution with me, vist my <a href="Contact.aspx">Contact Me</a> page.     
                                </p>
                                <p>
                                    Also, don't forget to visit the <a href="ProjectEulerDemos.aspx">Live Demo</a>.
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
                                    <img src="images/realblog1.png" class="img-responsive" alt="" >
                                    <div class="overlay">
                                        <div class="buttons">
                                            <a rel="gallery" class="fancybox" href="images/NewFolder1/realblog1.png">Enlarge</a>
                                        </div>
                                    </div>
                                </div>
                                <figcaption>
                                <h4>
                                <a href="images/NewFolder1/blogpic2.png">
                                    Multiples of 3 and 5
                                </a>
                                </h4>
                                </figcaption>
                            </figure>
                           <%-- <ul class="social-share">
                                <h4>Share this article</h4>
                                <li>
                                    <a href="#" class="Facebook">
                                        <i class="ion-social-facebook"></i>
                                    </a>
                                </li>
                                <li>
                                    <a href="#" class="Twitter">
                                        <i class="ion-social-twitter"></i>
                                    </a>
                                </li>
                                <li>
                                    <a href="#" class="Linkedin">
                                        <i class="ion-social-linkedin"></i>
                                    </a>
                                </li>
                                <li>
                                    <a href="#" class="Google Plus">
                                        <i class="ion-social-googleplus"></i>
                                    </a>
                                </li>
                                
                            </ul>
                            
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="comments">
                                <div class="media">
                                    <a href="" class="pull-left">
                                        <img alt="" src="images/avater.jpg" class="media-object">
                                    </a>
                                    <div class="media-body">
                                        <h4 class="media-heading">
                                        Jonathon Andrew</h4>
                                        <p class="text-muted">
                                            12 July 2013, 10:20 PM
                                        </p>
                                        <p>
                                            Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui.
                                        </p>
                                        <a href="">Reply</a>
                                        <hr>
                                        <!-- Nested media object -->
                                        <div class="media">
                                            <a href="" class="pull-left">
                                                <img alt="" src="images/avater-1.jpg" class="media-object">
                                            </a>
                                            <div class="media-body">
                                                <h4 class="media-heading">
                                                Tom Cruse </h4>
                                                <p class="text-muted">
                                                    12 July 2013, 10:20 PM
                                                </p>
                                                <p>
                                                    Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui.
                                                </p>
                                            </div>
                                        </div>
                                        <!--end media-->
                                        <hr>
                                        <div class="media">
                                            <a href="" class="pull-left">
                                                <img alt="" src="images/avater-1.jpg" class="media-object">
                                            </a>
                                            <div class="media-body">
                                                <h4 class="media-heading">
                                                Nicolus Carolus </h4>
                                                <p class="text-muted">
                                                    12 July 2013, 10:20 PM
                                                </p>
                                                <p>
                                                    Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui.
                                                </p>
                                            </div>
                                        </div>
                                        <!--end media-->
                                    </div>
                                </div>
                                <div class="media">
                                    <a href="" class="pull-left">
                                        <img alt="" src="images/avater-2.jpg" class="media-object">
                                    </a>
                                    <div class="media-body">
                                        <h4 class="media-heading">
                                        Rob Martin</h4>
                                        <p class="text-muted">
                                            12 July 2013, 10:20 PM
                                        </p>
                                        <p>
                                            Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui.
                                        </p>
                                        <a href="">Reply</a>
                                    </div>
                                </div>
                                <div class="media">
                                    <a href="" class="pull-left">
                                        <img alt="" src="images/avater-2.jpg" class="media-object">
                                    </a>
                                    <div class="media-body">
                                        <h4 class="media-heading">
                                        Mastarello </h4>
                                        <p class="text-muted">
                                            12 July 2013, 10:20 PM
                                        </p>
                                        <p>
                                            Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui.
                                        </p>
                                        <a href="">Reply</a>
                                    </div>
                                </div>
                            </div>
                            <div class="post-comment">
                                <h3>Leave a Reply</h3>
                                <br />
                                <%--<form role="form" class="form-horizontal">--%>
                                    <%--<div class="form-group">
                                        <div class="col-lg-6">
                                            <input type="text" class="col-lg-12 form-control" placeholder="Name">
                                        </div>
                                        <div class="col-lg-6">
                                            <input type="text" class="col-lg-12 form-control" placeholder="Email">
                                        </div>
                                    </div>
                                <br />
                                    <div class="form-group">
                                        <div class="col-lg-12">
                                            <textarea class=" form-control" rows="8" placeholder="Message"></textarea>
                                        </div>
                                    </div>
                                <br />
                                    <p>
                                    </p>
                                    <p>
                                        <button class="btn btn-send" type="submit">Comment</button>
                                    </p>
                                    
                                    <p></p>--%>
                                <%--</form>--%>
                            </div>
                            
                        </div>
                    </div>
            </section>
</asp:Content>
