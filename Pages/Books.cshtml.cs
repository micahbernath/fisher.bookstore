using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using Fisher.Bookstore.Models;
using System.Collections.Generic;

namespace Fisher.Bookstore.RazorPages
{

    public class Books : PageModel
    {

        public List<Book> books;


        public void OnGet()
        {
            var books = new List<Book>();

            books.Add(new Book(){
                Title = "Continuous Delivery",
                Author = new Author() { Name = "Jez Humble" }
            });

            books.Add(new Book(){
                Title = "Lean Enterprise",
                Author = new Author() { Name = "Barry O'Reilly" }
            });

            books.Add(new Book(){
                Title = "The Goal",
                Author = new Author() {Name = "Eliyahu Goldratt" }
            });

            return books; 
        }
    }
}