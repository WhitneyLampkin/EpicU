using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Persistence
{
    public class Repository
    {
        public static void SaveContactForm(Blog.DTO.ContactDTO contactDTO)
        {
            var db = new FeedbackEntities();

            var newContactPost = convertToEntity(contactDTO);
            db.Feedbacks.Add(newContactPost);
            db.SaveChanges();

        }

        private static Feedback convertToEntity(DTO.ContactDTO contactDTO)
        {
            var newContactPost = new Feedback();

            newContactPost.Id = contactDTO.Id;
            newContactPost.Name = contactDTO.Name;
            newContactPost.Subject = contactDTO.Subject;
            newContactPost.Email = contactDTO.Email;
            newContactPost.Message = contactDTO.Message;

            return newContactPost;
        }

        public static List<DTO.ContactDTO> GetPost()
        {
            var db = new FeedbackEntities();
            var feedbacks = db.Feedbacks.ToList();
            var ContactDTO = convertToDTO(feedbacks);
            return ContactDTO;
        }

        public static List<DTO.ContactDTO> convertToDTO(List<Feedback> Feedback)
        {
            var ContactDTO = new List<DTO.ContactDTO>();

            foreach (var feedback in Feedback)
            {
                var contactDTO = new DTO.ContactDTO();

                contactDTO.Id = feedback.Id;
                contactDTO.Name = feedback.Name;
                contactDTO.Subject = feedback.Subject;
                contactDTO.Message = feedback.Message;
                contactDTO.Email = feedback.Email;

                
            }
            return ContactDTO;
        }
    }
}
