using DevCard_project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_project.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1, "بهترین مقالات علمی سال", "در این مقالە شما با بهترین مالات سال آشنا میشوید و از خواندن آن می آموزید کە ...", "blog-post-thumb-1.jpg"),
                new Article(2, "بهترین مقالات علمی سال", "در این مقالە شما با بهترین مالات سال آشنا میشوید و از خواندن آن می آموزید کە ...", "blog-post-thumb-2.jpg"),
                new Article(3, "بهترین مقالات علمی سال", "در این مقالە شما با بهترین مالات سال آشنا میشوید و از خواندن آن می آموزید کە ...", "blog-post-thumb-3.jpg"),
            };
            return View("Articles", articles);
        }
    }
}
