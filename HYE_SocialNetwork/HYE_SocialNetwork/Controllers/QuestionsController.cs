﻿using HYE_SocialNetwork.Models;
using HYE_SocialNetwork.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace HYE_SocialNetwork.Controllers
{
    public class QuestionsController : Controller
    {
        private ApplicationDbContext db;

        public QuestionsController()
        {
            db = new ApplicationDbContext();       
        }

        [Authorize]
        public ActionResult Answered()
        {
            var currentUserId = User.Identity.GetUserId();
            var answers = db.HYEAnswers
                .Where(a => a.ResponderId == currentUserId)
                .Select(a => a.HYEQuestion)
                .Include(a => a.Inquirer)
                .ToList();

            var viewModel = new HomeViewModel()
            {
                NewQuestions = answers,
                ShowActions = User.Identity.IsAuthenticated
            };

            return View(viewModel);

        }

        [Authorize]
        public ActionResult Asked()
        {
            var currentUserId = User.Identity.GetUserId();
            var questions = db.HYEQuestions
                .Where(a => a.InquirerId == currentUserId)
                .ToList();

            //var viewModel = new QuestionFormViewModel()
            //{
            //    MyQuestions = questions,
            //    ShowActions = User.Identity.IsAuthenticated
            //};

            return View(questions);
        }


        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HYEQuestion question = db.HYEQuestions.Find(id);
            if (question == null)
            {
                return HttpNotFound();
            }
            return View(question);
        }


        // GET: Questions
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        public ActionResult Edit(int id)
        {
            var currentUser = User.Identity.GetUserId();
            var question = db.HYEQuestions.Single(q => q.Id == id && q.InquirerId == currentUser);

            var hyeQuestion = new HYEQuestion
            {
                //Initial so the form will be autopopulated with current values
                Question = question.Question,
                Id = question.Id,
            };

            //This will redirect to the view that submits a new quetion
            return View("QuestionForm", hyeQuestion);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken] //Prevents CSRF Attacks
        public ActionResult Create(HYEQuestion viewModel)
        {
            if (!ModelState.IsValid)
                return View("QuestionForm", viewModel);

            var currentUserId = User.Identity.GetUserId();
            var currentUser = db.Users.Single(u => u.Id == currentUserId);

            var question = new HYEQuestion
            {
                Inquirer = currentUser,
                DateTime = DateTime.Now,
                Question = viewModel.Question
            };

            db.HYEQuestions.Add(question);
            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}