using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using OnlineShoppingWebApp.Models;
using OnlineShoppingWebApp.Services;
namespace OnlineShoppingWebApp.Controllers
{
    public class HomeController : Controller
    {

        //ActionResult: is abstract class
        //ViewResult, JsonResult are extended classes

        // GET: Home
        public ActionResult Index()
        {
            ProductService svc = new ProductService();
            List<Product> products = svc.GetAll();
            //this.ViewBag.flowers = products;
           // this.ViewData["flowers"] = products;
            return View(products);   // send as Model
           // return View();
        }
        public ActionResult Details(int id)
        {
            ProductService svc=new ProductService();
            Product theProduct=svc.GetById(id);
            this.ViewData["flower"] = theProduct;
            return View();
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(int id, string title, string description, int unitprice, int quantity, string imageurl,string category)
        {
            Product product = new Product
            {
                Id = id,
                Title = title,
                Description = description,                                                               
                UnitPrice = unitprice,
                ImageUrl = imageurl,                                         
                Category = category
            };
            ProductService svc = new ProductService();
            svc.Insert(product);
            return View();
        }

        //behave like a Web service
        public ActionResult List()
        {
            ProductService svc = new ProductService();
            List<Product> products = svc.GetAll();
            return Json(products, JsonRequestBehavior.AllowGet);
        }

       
    }
}