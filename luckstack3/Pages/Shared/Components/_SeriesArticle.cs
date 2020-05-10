﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _17bang.Pages.Repository;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _17bang
{
    public class SeriesArticle : ViewComponent
    {
        private ArticleRepository _repository;

        public IList<Article> Articles { set; get; }

        public SeriesArticle()
        {
            _repository = new ArticleRepository();
        }
        
        public IViewComponentResult Invoke(int max)
        {
            int authorId = Convert.ToInt32(HttpContext.Request.Query[Const.USER_ID]);
            Articles = _repository.GetByAuthor(authorId).Take(max).ToList();
            
            ViewData[Const.SERIES_ARTICLE] = Articles[0].Author.NickName.ToString();

            return View(Articles);
        }
    }
}