using System;
using System.Collections.Generic;
using ShoppingCart.Data.Interface;
using ShoppingCart.Model;
using System.Linq;

namespace ShoppingCart.Data
{
    public class CategoryData : ICategoryData
    {
        //Database
        private readonly List<Category> _categoryList = new List<Category> {
            new Category { Id = 1, Title = "Giyim", Parent = null },
            new Category { Id = 10, Title = "T-shirt", Parent = new Category{ Id = 1, Title = "Giyim" } },
            new Category { Id = 11, Title = "Gömlek", Parent = { Id = 1, Title = "Giyim" } },
            new Category { Id = 12, Title = "Panloton", Parent = { Id = 1, Title = "Giyim" } },
            new Category { Id = 13, Title = "Jean", Parent = { Id = 1, Title = "Giyim" } },
            new Category { Id = 2, Title = "Aksesuar", Parent = null },
            new Category { Id = 20, Title = "Güneş Gözlüğü", Parent = new Category { Id = 2, Title = "Aksesuar"} },
            new Category { Id = 21, Title = "Saat", Parent = new Category { Id = 2, Title = "Aksesuar"} },
            new Category { Id = 22, Title = "Takı", Parent = new Category { Id = 2, Title = "Aksesuar"} },
            new Category { Id = 23, Title = "Çanta", Parent = new Category { Id = 2, Title = "Aksesuar" } },
            new Category { Id = 3, Title = "Ayakkabı", Parent = null },
            new Category { Id = 30, Title = "Spor Ayakkabı", Parent =  new Category { Id = 3, Title = "Ayakkabı" } },
            new Category { Id = 31, Title = "Günlük Ayakkabı", Parent =  new Category { Id = 3, Title = "Ayakkabı" } },
            new Category { Id = 32, Title = "Terlik", Parent = new Category { Id = 3, Title = "Ayakkabı" } },
            new Category { Id = 33, Title = "Klasik Ayakkabı", Parent = new Category { Id = 3, Title = "Ayakkabı" } },
            new Category { Id = 4, Title = "Spor", Parent = null },
            new Category { Id = 40, Title = "Eşofman", Parent = new Category { Id = 1, Title = "Spor" } },
            new Category { Id = 41, Title = "T-shirt", Parent = new Category { Id = 1, Title = "Spor" } },
            new Category { Id = 42, Title = "Şort", Parent = new Category { Id = 1, Title = "Spor" } },
            new Category { Id = 43, Title = "Spor Aletleri", Parent = new Category { Id = 1, Title = "Spor" } }
        };

        public List<Category> GetList()
        {
            return _categoryList;
        }

        public Category GetById(int id)
        {
            return _categoryList.FirstOrDefault(x => x.Id == id);
        }
        public List<Category> GetByParentId(int categoryId)
        {
            return _categoryList.Where(x => x.Parent.Id == categoryId).ToList();
        }

        public Category GetByTitle(string title)
        {
            return _categoryList.FirstOrDefault(x => x.Title == title);
        }
    }
}
