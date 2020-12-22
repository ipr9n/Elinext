using AutoMapper;
using Services.DTO;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using TaskElinext.Models;

namespace TaskElinext.Controllers
{
    public class HomeController : Controller
    {
        private ICommentService _commentService { get; set; }
        private Mapper _mapper = new Mapper(TaskElinext.Configs.AutoMapperConfig.CommentMapper);

        public HomeController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public ActionResult Index()
        {
            CommentListModel commentList = new CommentListModel()
            {
                Comments = _mapper.Map <List<CommentViewModel>>(_commentService.GetComments())
            };

            return View(commentList);
        }

        [HttpPost]
        public ActionResult Index(CommentViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.Username = !String.IsNullOrEmpty(model.Username) 
                    ? model.Username
                    : "Incognito";
                model.CreateDate = DateTime.Now;

                _commentService.AddComment(_mapper.Map<CommentModelDTO>(model));

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

    }
}