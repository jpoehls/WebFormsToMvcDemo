﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TTFWebFormsToMvc.Data
{
    public class Product
    {
        private static List<Product> Products;

        static Product()
        {
            var p = Products = new List<Product>();

            p.Add(new Product()
            {
                Name = "Captain America",
                Category = Category.Movies,
                Price = 18.99m,
                ShippingOptions = new List<ShippingOption> { ShippingOption.GiftWrap },
                Stock = StockOption.Available
            });

            p.Add(new Product()
            {
                Name = "X-Men: First Class",
                Category = Category.Movies,
                Price = 15.99m,
                ShippingOptions = new List<ShippingOption> { ShippingOption.GiftWrap, ShippingOption.Overnight },
                Stock = StockOption.Available
            });

            p.Add(new Product()
            {
                Name = "Scrabble",
                Category = Category.Games,
                Price = 12.99m,
                ShippingOptions = new List<ShippingOption> { ShippingOption.Overnight },
                Stock = StockOption.Backordered
            });
        }

        private static int LastId;

        public Product()
        {
            Id = ++LastId;
            ShippingOptions = new List<ShippingOption>();
        }

        public int Id { get; private set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        public IList<ShippingOption> ShippingOptions { get; set; }

        [Required]
        public StockOption Stock { get; set; }

        public static IEnumerable<Product> GetAll()
        {
            return Products;
        }

        public static Product GetById(int id)
        {
            return Products.SingleOrDefault(product => product.Id == id);
        }

        public static void Add(Product product)
        {
            Products.Add(product);
        }

        public static void Delete(Product product)
        {
            Products.Remove(product);
            Products.RemoveAll(p => p.Id == product.Id);
        }

        public static void Save(Product product)
        {
            if (!Products.Contains(product))
            {
                Products.RemoveAll(p => p.Id == product.Id);
                Products.Add(product);
            }
        }
    }
}
