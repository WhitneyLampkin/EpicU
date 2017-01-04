using HYE_SocialNetwork.DTOs;
using HYE_SocialNetwork.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HYE_SocialNetwork.Controllers
{
    [Authorize]
    public class HYEAnswersController : ApiController
    {
        private ApplicationDbContext db;
        
        public HYEAnswersController()
        {
            db = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Answer(HYEAnswerDto dto)
        {
            var currentUserId = User.Identity.GetUserId();
            var hasAnswered = db.HYEAnswers.Any(a => a.ResponderId == currentUserId && a.HYEQuestionId == dto.HYEQuestionId);

            if (hasAnswered)
                return BadRequest("Silly Rabbit! You've already answered this question. Try another.");

            var answer = new HYEAnswer
            {
                //This is hardcoded so that "yes" will always be saved in the database as the answer. 
                //Come back to fix this later!
                Answer = true,
                HYEQuestionId = dto.HYEQuestionId,
                ResponderId = currentUserId,
                DateTime = DateTime.Now,
            };
            db.HYEAnswers.Add(answer);
            db.SaveChanges();

            return Ok();
        }
    }
}
