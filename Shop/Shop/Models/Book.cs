﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public int CategoryId { get; set; }
        
        [Required(ErrorMessage = "Enter title of book")]
        [StringLength(100)]
        public string Title { get; set; }
        
        [Required(ErrorMessage = "Enter author's name")]
        [StringLength(100)]
        public string Author { get; set; }
        public DateTime DateAdded { get; set; }
        public string IcoName { get; set; }
        
        [Required(ErrorMessage = "Fill the description")]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "Set a price")]
        public decimal Price { get; set; }
        public bool Bestseller { get; set; }
        public bool Hidden { get; set; } // Option for Admin, beneath deleting it from TAB, just hide it
        public string ShortDescription { get; set; }

        /*public Book(int BookId, int CategoryId, string Title, string Author, string IcoName, string Description, decimal Price, bool Bestseller, bool Hidden)
        {
            this.BookId = BookId;
            this.CategoryId = CategoryId;
            this.Title = Title;
            this.Author = Author;
            this.DateAdded = DateTime.Now;
            this.IcoName = IcoName;
            this.Description = Description;
            this.Price = Price;
            this.Bestseller = Bestseller;
            this.Hidden = Hidden;
        }*/
        public virtual Category Category { get; set; } // One to One - 1 Category to 1 Book
    }
}