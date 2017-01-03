using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain
{
    public class ContactManager
    {
        public static void SaveContactForm(DTO.ContactDTO contactDTO)
        {
            Persistence.Repository.SaveContactForm(contactDTO);
        }
        public static object GetPost()
        {
            return Persistence.Repository.GetPost();
        }
    }
}
