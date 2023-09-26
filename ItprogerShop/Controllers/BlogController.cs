using Microsoft.AspNetCore.Mvc;
using ItprogerShop.Data;
using ItprogerShop.Models;
using System.Collections;
using Microsoft.EntityFrameworkCore;

namespace ItprogerShop.Controllers
{
    public class BlogController : Controller
    {

        private readonly AppDbContext _context;

        public BlogController(AppDbContext context) => _context = context;

        public IActionResult Index() // blog/
        {
            List<Blog> posts = _context.posts.ToList();
            return View(posts);
        }


        [HttpPost]
        public IActionResult Add(Blog model)
        {
            if (ModelState.IsValid)
            {
                var newBlogPost = new Blog
                {
                    Title = model.Title,
                    Anons = model.Anons,
                    FullText = model.FullText,
                };
                _context.posts.Add(newBlogPost);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        public ActionResult Add()
        {
            return View();
        }

        [Route("blog/{id:int}/edit")]
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [Route("blog/{id:int}/edit")]
        public IActionResult Edit(Blog editPost, int id)
        {
            if (ModelState.IsValid)
            {         
                var editBlogPost = _context.posts.FirstOrDefault(blog => blog.Id == id);

                if (editBlogPost != null)
                {
                    editBlogPost.Title = editPost.Title;
                    editBlogPost.Anons = editPost.Anons;
                    editBlogPost.FullText = editPost.FullText;

                    _context.SaveChanges();
                }                          
                return RedirectToAction("Index");
            }
            return View(editPost);
        }

        [HttpPost]
        [Route("blog/{id:int}/delete")]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var postRemove = _context.posts.FirstOrDefault(post => post.Id == id);

                if (postRemove != null)
                {
                    _context.Remove(postRemove);
                    _context.SaveChanges();
                }
                return RedirectToAction("Index");

            }
            return View("Index");
        }

    }
}
