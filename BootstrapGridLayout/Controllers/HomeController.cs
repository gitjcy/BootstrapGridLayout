using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootstrapGridLayout.Models;

namespace BootstrapGridLayout.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(GenerateArticles());
        }

        private IEnumerable<Article> GenerateArticles()
        {
            return new List<Article>
            {
                new Article
                {
                    Name = "Article 1",
                    Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps.",
                    Thumbnail = "http://lorempixel.com/640/480/nightlife/1/"
                },
                new Article
                {
                    Name = "Article 2",
                    Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps.",
                    Thumbnail = "http://lorempixel.com/640/480/nightlife/2/"
                },
                new Article
                {
                    Name = "Article 3",
                    Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps.",
                    Thumbnail = "http://lorempixel.com/640/480/nightlife/3/"
                },
                new Article
                {
                    Name = "Article 4",
                    Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps.",
                    Thumbnail = "http://lorempixel.com/640/480/nightlife/4/"
                },
                new Article
                {
                    Name = "Article 5",
                    Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps.",
                    Thumbnail = "http://lorempixel.com/640/480/nightlife/5/"
                },
                new Article
                {
                    Name = "Article 6",
                    Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps.",
                    Thumbnail = "http://lorempixel.com/640/480/nightlife/6/"
                },
                new Article
                {
                    Name = "Article 7",
                    Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps.",
                    Thumbnail = "http://lorempixel.com/640/480/nightlife/7/"
                },
                new Article
                {
                    Name = "Article 8",
                    Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps.",
                    Thumbnail = "http://lorempixel.com/640/480/nightlife/8/"
                },
                new Article
                {
                    Name = "Article 9",
                    Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps.",
                    Thumbnail = "http://lorempixel.com/640/480/nightlife/9/"
                },
                new Article
                {
                    Name = "Article 10",
                    Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps.",
                    Thumbnail = "http://lorempixel.com/640/480/nightlife/10/"
                },
            };
        }
    }
}