using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LINQ_Homework.Models
{
    public class Book
    {
        public string name;
        public string writer;
        public int year;
        public int numOfPage;
        public int id;
        public Book(string name, string writer, int year, int numOfPage,int id)
        {
            this.name = name;
            this.writer = writer;
            this.year = year;
            this.numOfPage = numOfPage;
            this.id = id;
        }

    }
}