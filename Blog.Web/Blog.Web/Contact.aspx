<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Blog.Web.WebForm6" %>
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
                            <h2>Contact</h2>
                            <ol class="breadcrumb">
                                <li>
                                    <a href="Default.aspx">
                                        <i class="ion-ios-home"></i>
                                        Home
                                    </a>
                                </li>
                                <li class="active">Contact</li>
                            </ol>
                        </div>
                    </div>
                </div>
            </div>   
        </section><!--/#page-header-->


        <!-- 
        ================================================== 
            Contact Section Start
        ================================================== -->
        <section id="contact-section">
            <div class="container">
                <div class="row">
                    <h2 style="color: #FF0000">This contact form is temporarily unavailable. Please use the email address below instead. Thanks for your cooperation.</h2>
                    <div class="col-md-6">
                        <div class="block">
                            <h2 class="subtitle wow fadeInDown" data-wow-duration="500ms" data-wow-delay=".3s">Contact Me</h2>
                            <p class="subtitle-des wow fadeInDown" data-wow-duration="500ms" data-wow-delay=".5s">
                                Please fill out the form below to share your comments, suggestions or feedback. Thank you.
                            </p>
                            <div class="contact-form">
                        
                                    <div class="form-group wow fadeInDown" data-wow-duration="500ms" data-wow-delay=".6s">
                                        <asp:TextBox id="name" placeholder="Your Name" class="form-control" runat="server" />
                                        <%--<input type="text" placeholder="Your Name" class="form-control" name="name" id="name">--%>
                                    </div>
                                    
                                    <div class="form-group wow fadeInDown" data-wow-duration="500ms" data-wow-delay=".8s">
                                        <asp:TextBox id="email" placeholder="Your Email (Not required unless you want a response.)" class="form-control" runat="server" />
                                        <%--<input type="email" placeholder="Your Email" class="form-control" name="email" id="email" >--%>
                                    </div>
                                    
                                    <div class="form-group wow fadeInDown" data-wow-duration="500ms" data-wow-delay="1s">
                                        <asp:TextBox id="subject" class="form-control" placeholder="Subject" runat="server" />
                                        <%--<input type="text" placeholder="Subject" class="form-control" name="subject" id="subject">--%>
                                    </div>
                                    
                                    <div class="form-group wow fadeInDown" data-wow-duration="500ms" data-wow-delay="1.2s">
                                        <asp:TextBox id="message" TextMode="multiline" class="form-control" placeholder="Message" Columns="50" Rows="7" runat="server" />
                                        <%--<textarea rows="6" placeholder="Message" class="form-control" name="message" id="message"></textarea> --%>   
                                    </div>
                                    
                                    
                                    <div id="submit" class="wow fadeInDown" data-wow-duration="500ms" data-wow-delay="1.4s">
                                        <asp:button runat="server" Text="Send Message" OnClick="SavePost" type="button" class="btn btn-default btn-send"></asp:button>
                                       <%-- <input type="submit" id="contact-submit" onserverclick="SavePost" class="btn btn-default btn-send" value="Send Message">--%>
                                    </div>                      
                                    
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6">
                         <div class="map-area">
                            <h2 class="subtitle  wow fadeInDown" data-wow-duration="500ms" data-wow-delay=".3s">Location</h2>
                            <p class="subtitle-des wow fadeInDown" data-wow-duration="500ms" data-wow-delay=".5s">
                                I am located in the Dallas Fort Worth area and avaiable for work. 
                                
                            </p>
                            <div class="map">
                                <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d214376.76226642277!2d-96.74579640124463!3d32.90776689011968!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x864c03c1db5fc275%3A0x71fbdcb38623cd0!2sGarland%2C+TX!5e0!3m2!1sen!2sus!4v1469944103275" width="600" height="450" style="border:0"></iframe>
                                
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row address-details">
                    <div class="col-md-4">
                        <div class="address wow fadeInLeft" data-wow-duration="500ms" data-wow-delay=".5s">
                            <i class="ion-ios-location-outline"></i>
                            <h5>DFW Area<br />Garland, TX</h5>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="email wow fadeInLeft" data-wow-duration="500ms" data-wow-delay=".7s">
                            <i class="ion-ios-email-outline"></i>
                            <p>wlampkin.davis@hotmail.com<br>eunthie@yahoo.com</p>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="phone wow fadeInLeft" data-wow-duration="500ms" data-wow-delay=".9s">
                            <i class="ion-ios-telephone-outline"></i>
                            <p>Home: Upon Request<br>Cell: Upon Request</p>
                        </div>
                    </div>
                </div>
            </div>
        </section>
</asp:Content>
