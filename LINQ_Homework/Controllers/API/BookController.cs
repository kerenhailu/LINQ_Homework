using LINQ_Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LINQ_Homework.Controllers.API
{
    public class BookController : Controller
    {
        // GET: Book
        Random random = new Random();
        List<Book> booksList = new List<Book>();
        public ActionResult Index()
        {
            Create8Books();
            return Json(booksList, JsonRequestBehavior.AllowGet);
        }
        public void Create8Books()
        {
            Book book1 = new Book("HarriPoter", "sum", 1990, random.Next(100, 500), 0);
            Book book2 = new Book("batmen", "keren", 1980, random.Next(100, 500), 1);
            Book book3 = new Book("Snow White", "loli", 1970, random.Next(100, 500), 2);
            Book book4 = new Book("one piece", "shilat", 1999, random.Next(100, 500), 3);
            Book book5 = new Book("Aladdin", "sum", 1998, random.Next(100, 500), 4);
            Book book6 = new Book("The sleeping beauty", "shiraz", 2000, random.Next(100, 500), 5);
            Book book7 = new Book("Queen", "eden", 2002, random.Next(100, 500), 6);
            Book book8 = new Book("Friends", "idan", 1989, random.Next(100, 500), 7);
            booksList.Add(book1);
            booksList.Add(book2);
            booksList.Add(book3);
            booksList.Add(book4);
            booksList.Add(book5);
            booksList.Add(book6);
            booksList.Add(book7);
            booksList.Add(book8);
        }
        //5.	getById – מקבל id ומחזיר ספר אחד.


        //GET: Book/Details/5
        public ActionResult Details(int id)
        {
            //Book oneBook = booksList.Find(item => item.id == id);
            //return Json(oneBook, JsonRequestBehavior.AllowGet);
            Create8Books();
            return Json(booksList[id], JsonRequestBehavior.AllowGet);
        }
        //6.	Create – יוצר ספר חדש ושומר ברשימה.
        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {

            Create8Books();
            booksList.Add(
                new Book(collection["name"],
                collection["writer"],
               int.Parse(collection["year"]),
                int.Parse(collection["numOfPage"]),
                int.Parse(collection["id"])));

            return Json("you creat", JsonRequestBehavior.AllowGet);
        }
        //7.	Update – עריכה של ספר.
        //לא עובדדדדדד
        // Put: Book/Edit/5

        //[HttpPut]
        //public ActionResult Edit(int id, Book BookFromUser)
        //{
        //    for (int i = 0; i < booksList.Count; i++)
        //    {
        //        if (BookFromUser.id == id)
        //        {
        //            BookFromUser.name = booksList[i].name;
        //            BookFromUser.writer = booksList[i].writer;
        //            BookFromUser.year = booksList[i].year;
        //            BookFromUser.numOfPage = booksList[i].numOfPage;
        //            return Json("work", JsonRequestBehavior.AllowGet);
        //        }
        //    }
        //}
        //8.	Delete – מחיקה של ספר.
        public void DeleteBook(int index)
        {
            Create8Books();
            booksList.RemoveAt(index);
        }

        // Delete: Person/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            for (int i = 0; i < booksList.Count; i++)
            {
                if (booksList[i].id == id)
                {
                    booksList.RemoveAt(i);
                    return Json("work", JsonRequestBehavior.AllowGet);
                }
            }
            return Json("not work", JsonRequestBehavior.AllowGet);
        }

    }
}