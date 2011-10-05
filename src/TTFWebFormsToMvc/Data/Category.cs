using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTFWebFormsToMvc.Data
{
    public class Category
    {
        public static Category Movies;
        public static Category Games;
        private static List<Category> Categories;

        static Category()
        {
            var books = new Category("Books");
            var history = new Category("History", books);
            var mystery = new Category("Mystery", books);
            var travel = new Category("Travel", books);

            Movies = new Category("Movies");

            var software = new Category("Software");
            var mac = new Category("Mac OS X", software);
            var pc = new Category("Windows", software);

            var toys = new Category("Toys");
            Games = new Category("Games", toys);

            Categories = new List<Category>
            {
                books, history, mystery, travel,
                Movies,
                software, mac, pc,
                toys, Games
            };
        }

        private static int LastId;

        private Category(string name, Category parent = null)
        {
            Id = ++LastId;
            Name = name;
            Parent = parent;
        }

        public int Id { get; private set; }
        public string Name { get; set; }
        public Category Parent { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public static IEnumerable<Category> GetAll(int parentId = 0)
        {
            // return ALL categories
            return Categories;

            if (parentId == 0)
            {
                // return top level categories
                return Categories.Where(category => category.Parent == null);
            }
            else
            {
                // return sub-categories
                return Categories.Where(category => category.Parent != null
                                                 && category.Parent.Id == parentId);
            }
        }

        public static Category GetById(int id)
        {
            return Categories.Single(category => category.Id == id);
        }
    }
}
