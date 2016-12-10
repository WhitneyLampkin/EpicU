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
    public class FriendshipsController : ApiController
    {
        private ApplicationDbContext db;

        public FriendshipsController()
        {
            db = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Friend(FriendshipDto dto)
        {
            var currentUserId = User.Identity.GetUserId();
            var areFriends = db.Friendships.Any(r => r.RequesteeId == currentUserId && r.RequesteeId == dto.RequesteeId);

            if (areFriends)
                return BadRequest("Wait a minute...you guys are already friends!");

            var friendship = new Friendship
            {
                ResquesterId = currentUserId,
                RequesteeId = dto.RequesteeId,
            };
            db.Friendships.Add(friendship);
            db.SaveChanges();
           
            return Ok();
        }


    }
}
