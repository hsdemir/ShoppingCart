using ShoppingCart.Data.Interface;
using ShoppingCart.Model;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ShoppingCart.Data
{
    public class ProductData : IProductData
    {
        //Database
        private List<Product> _productList = new List<Product> {
            new Product { Id = 100, Title = "Vincent Erkek Sweatshirt", Price = 120, Category = new Category { Id = 10, Title = "T-shirt", Parent = new Category{ Id = 1, Title = "Giyim" } } },
            new Product { Id = 101, Title = "U.S Polo Erkek Gömlek", Price = 95, Category = new Category { Id = 11, Title = "Gömlek", Parent = new Category { Id = 1, Title = "Giyim" } } },
            new Product { Id = 102, Title = "Mavi Kot Pantolon", Price = 145, Category = new Category { Id = 12, Title = "Panloton", Parent = new Category { Id = 1, Title = "Giyim" } } },
            new Product { Id = 103, Title = "Koton Gri Kanvas Pantolon", Price = 60, Category = new Category { Id = 12, Title = "Panloton", Parent = new Category { Id = 1, Title = "Giyim" } } },
            new Product { Id = 104, Title = "U.S Polo Mavi Erkek Gömlek", Price = 85, Category = new Category { Id = 11, Title = "Gömlek", Parent = new Category { Id = 1, Title = "Giyim" } } },
            new Product { Id = 105, Title = "H&M Kırmızı Bayan Gömlek", Price = 85, Category = new Category { Id = 11, Title = "Gömlek", Parent = new Category { Id = 1, Title = "Giyim" } } },
            new Product { Id = 106, Title = "Kiğılı Siyah Erkek Gömlek", Price = 85.50, Category = new Category { Id = 11, Title = "Gömlek", Parent = new Category { Id = 1, Title = "Giyim" } } },

            new Product { Id = 200, Title = "Mavi Kol Saati", Price = 560, Category = new Category { Id = 21, Title = "Saat", Parent = new Category { Id = 2, Title = "Aksesuar" } } },
            new Product { Id = 201, Title = "Siyah Güneş Gözlüğü", Price = 560, Category = new Category { Id = 20, Title = "Güneş Gözlüğü", Parent = new Category { Id = 2, Title = "Aksesuar" } } },
            new Product { Id = 202, Title = "Sarı Renk Bileklik", Price = 18, Category = new Category { Id = 22, Title = "Takı", Parent = new Category { Id = 2, Title = "Aksesuar" } } },
            new Product { Id = 203, Title = "Siyah Deri Çanta", Price = 125.90, Category = new Category { Id = 23, Title = "Çanta", Parent = new Category { Id = 2, Title = "Aksesuar" } } },
            new Product { Id = 204, Title = "Yeşil Saat", Price = 285.50, Category = new Category { Id = 21, Title = "Saat", Parent = new Category { Id = 2, Title = "Aksesuar" } } },
            new Product { Id = 205, Title = "Kahverengi Güneş Gözlüğü", Price = 380, Category = new Category { Id = 20, Title = "Güneş Gözlüğü", Parent = new Category { Id = 2, Title = "Aksesuar" } } },
            new Product { Id = 206, Title = "Kırmızı Renk Bileklik", Price = 25, Category = new Category { Id = 22, Title = "Takı", Parent = new Category { Id = 2, Title = "Aksesuar" } } },
            new Product { Id = 207, Title = "Mavi Deri Çanta", Price = 162.90, Category = new Category { Id = 23, Title = "Çanta", Parent = new Category { Id = 2, Title = "Aksesuar" } } },
            
            new Product { Id = 300, Title = "Siyah Nike Ayakkabı", Price = 350, Category = new Category { Id = 30, Title = "Spor Ayakkabı", Parent =  new Category { Id = 3, Title = "Ayakkabı" } } },
            new Product { Id = 301, Title = "Beyaz Adidas Ayakkabı", Price = 320, Category = new Category { Id = 30, Title = "Spor Ayakkabı", Parent =  new Category { Id = 3, Title = "Ayakkabı" } } },
            new Product { Id = 302, Title = "Gri Rebook Ayakkabı", Price = 150, Category = new Category { Id = 30, Title = "Spor Ayakkabı", Parent =  new Category { Id = 3, Title = "Ayakkabı" } } },
            new Product { Id = 303, Title = "Kemal Tanca Kahverengi Ayakkabı", Price = 140, Category = new Category { Id = 33, Title = "Klasik Ayakkabı", Parent =  new Category { Id = 3, Title = "Ayakkabı" } } },
            new Product { Id = 304, Title = "Kiğılı Siyah Deri Ayakkabı", Price = 380, Category = new Category { Id = 33, Title = "Klasik Ayakkabı", Parent =  new Category { Id = 3, Title = "Ayakkabı" } } },
            new Product { Id = 305, Title = "Lescon Sarı Ayakkabı", Price = 180, Category = new Category { Id = 30, Title = "Spor Ayakkabı", Parent =  new Category { Id = 3, Title = "Ayakkabı" } } },
            new Product { Id = 306, Title = "Skechers Mavi Ayakkabı", Price = 460, Category = new Category { Id = 30, Title = "Spor Ayakkabı", Parent =  new Category { Id = 3, Title = "Ayakkabı" } } },

            new Product { Id = 400, Title = "Mavi Alt Üst Eşofman", Price = 340, Category = new Category { Id = 40, Title = "Eşofman", Parent = new Category { Id = 4, Title = "Spor" } } },
            new Product { Id = 401, Title = "Beyaz Erkek Şort", Price = 120, Category = new Category { Id = 42, Title = "Şort", Parent = new Category { Id = 4, Title = "Spor" } } },
            new Product { Id = 402, Title = "Yeşil Bayan T-shirt", Price = 155.50, Category = new Category { Id = 41, Title = "T-shirt", Parent = new Category { Id = 4, Title = "Spor" } } },
            new Product { Id = 403, Title = "Siyah Alt Eşofman", Price = 95, Category = new Category { Id = 40, Title = "Eşofman", Parent = new Category { Id = 4, Title = "Spor" } } },
            new Product { Id = 404, Title = "Mavi Üst Eşofman", Price = 65, Category = new Category { Id = 40, Title = "Eşofman", Parent = new Category { Id = 4, Title = "Spor" } } },
            new Product { Id = 405, Title = "Kırmızı Çizgili Üst Eşofman", Price = 72, Category = new Category { Id = 40, Title = "Eşofman", Parent = new Category { Id = 4, Title = "Spor" } } }
        };

        public List<Product> GetList()
        {
            return _productList;
        }

        public Product GetById(int id)
        {
            return _productList.FirstOrDefault(x => x.Id == id);
        }

        public List<Product> GetByCategoryId(int categoryId)
        {
            return _productList.Where(x => x.Category.Id == categoryId).ToList();
        }

        public List<Product> GetBySearchTitle(string title)
        {
            return _productList.Where(x => x.Title.ToLower().Contains(title.ToLower())).ToList();
        }
    }
}
