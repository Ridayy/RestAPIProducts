using System;

namespace WebApplication2.Models
{
    public class Product
    {
        public int id { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public float productPrice { get; set; }
        public DateTime dateCreated { get; set; } = DateTime.Now;
        public bool isDeleted { get; set; } = false;
    }
}
