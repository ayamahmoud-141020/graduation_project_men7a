﻿namespace book.Models
{
    public class Borrow
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowDate { get; set; }

        public ApplicationUser User { get; set; }
        public Book Book { get; set; }
    }
}