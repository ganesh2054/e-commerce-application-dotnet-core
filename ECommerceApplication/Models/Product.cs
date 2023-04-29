using System;
namespace ECommerceApplication.Models
{
	public class Product
	{
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public decimal Price { get; set; }
        public bool IsTrendingItem { get; set; }
        public int SubCategoryId { get; set; }
        public string? Size { get; set; }
        public string? Quantity { get; set; }
        public string? Brand { get; set; }


    }
}

