using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.Web
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SavePost(object sender, EventArgs e)
        {
            //OnClick Event
                var post = newContactPost();

                Blog.Domain.ContactManager.SaveContactForm(post);

            name.Text = "";
            email.Text = "";
            subject.Text = "";
            message.Text = "";
        }

        private DTO.ContactDTO newContactPost()
        {            var post = new DTO.ContactDTO();

            post.Name = name.Text;
            post.Email = email.Text;
            post.Subject = subject.Text;
            post.Message = message.Text;

            //post.Name = Request.Form["name"];
            //post.Email = Request.Form["email"];
            //post.Message = Request.Form["message"];
            //post.Subject = Request.Form["subject"];

            return post;

        }
    }
}