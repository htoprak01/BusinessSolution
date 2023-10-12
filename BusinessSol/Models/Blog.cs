﻿namespace BusinessSol.Models
{
    public class Blog
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
