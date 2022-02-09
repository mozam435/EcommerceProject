using BootStrap.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BootStrap.Controllers
{
    public class ProductController : Controller
    {
        private readonly rbintlContext _ORM;
        private readonly IWebHostEnvironment _env;
        public ProductController(rbintlContext ORM, IWebHostEnvironment env)
        {
            _ORM = ORM;
            _env = env;

        }


        public IActionResult ProductList()
        {
            IList<Product> PL = _ORM.Product.ToList();
            ViewBag.PList = PL;
            ViewBag.CatList = _ORM.Productcategory.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult ProductListAdmin()
        {
            IList<Product> PL = _ORM.Product.ToList();
            ViewBag.PList = PL;
            ViewBag.CatList = _ORM.Productcategory.ToList();
            return View();
            
        }

        [HttpPost]
        public IActionResult ProductListAdmin(string ProductName)
        {
            
            if (ProductName != null)
            {
                IList<Product> SearchProduct = _ORM.Product.Where(x => x.ProductName == ProductName).ToList();
                
                if (SearchProduct == null)
                {
                    ViewBag.ntfnd = "Not Found! the Product in database";
                }
                return RedirectToAction("ProductList", new { SearchProduct });
            }
            else
            {
                ViewBag.notfound = "Not found";
            }

            return RedirectToAction("ProductList");

        }


        public IActionResult ProductDelete(int id)
        {
            Product P = _ORM.Product.Find(id);
            if(P != null)
            {
                _ORM.Product.Remove(P);
                _ORM.SaveChanges();
                
            }
            return RedirectToAction("ProductListAdmin");

        }

        [HttpGet]
        public IActionResult ProductDetail(int id)
        {
            Product P = _ORM.Product.Find(id);

            if (P != null)
            {
                ViewBag.PL = P;
                return View();
            }
            return View();
        }


        [HttpGet]
        public IActionResult AddCategories()
        {
           
            return View();
            
        }
        [HttpPost]
        public IActionResult AddCategories(Productcategory c)
        {


            _ORM.Productcategory.Add(c);
            _ORM.SaveChanges();
            return RedirectToAction("CategoryList");

        }
        public IActionResult CategoryList()
        {
            IList<Productcategory> LS = _ORM.Productcategory.ToList();
            ViewBag.LSB = LS;

            return View(LS);            
        }
        public IActionResult CategoryDelete(int id)
        {
            Productcategory C = _ORM.Productcategory.Find(id);
            if(C != null)
            {
                _ORM.Productcategory.Remove(C);
                _ORM.SaveChanges();
            }
            return RedirectToAction("CategoryList");
        }


        [HttpGet]
        public IActionResult AddProduct()
        {
            IList<Productcategory> LS = _ORM.Productcategory.ToList();
            ViewBag.CatBag = LS;
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product P, IList<IFormFile> FL)
        {
            IList<Productcategory> LS = _ORM.Productcategory.ToList();
            ViewBag.CatBag = LS;

            if (FL != null && FL.Count > 0 && P != null)
            {
               

                string FLNAME = "";
                foreach (var item in FL)
                {
                    string extension = Path.GetExtension(item.FileName);
                    string FileUniqueName = Guid.NewGuid().ToString();
                    FileStream FS = new FileStream(_env.WebRootPath + "/imgs/" + FileUniqueName + extension, FileMode.Create);
                    item.CopyTo(FS);

                    FLNAME += (FileUniqueName + ",");
                }
                P.ProductImage = FLNAME.Remove(FLNAME.LastIndexOf(","), 1);

                
                _ORM.Product.Add(P);
                _ORM.SaveChanges();

                return RedirectToAction("ProductList");
            }

            return View();
        }




        public IActionResult Cart(int id)
        {
            Product P = _ORM.Product.Find(id);

            if(P != null)
            {
                Option OP = new Option();
                OP.OptionName = P.ProductName;

            }

            return RedirectToAction("ProductList");
        }

    }
}
