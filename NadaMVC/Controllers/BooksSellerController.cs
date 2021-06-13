using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NadaMVC.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NadaMVC.Controllers
{
    public class BooksSellerController : Controller
    {
        public List<BooksSellerModel> BooksSeller = new List<BooksSellerModel>()
        {

        new BooksSellerModel (1,"Jarir", "https://argaamplus.s3.amazonaws.com/08a8010f-c353-4414-8425-2bfdb9dd2c96.jpg"),
        new BooksSellerModel(2,"Amazon","https://i.guim.co.uk/img/media/b97d090f8c41f1fbefd561793f1b9c6fc8d4108f/0_182_5472_3283/master/5472.jpg?width=620&quality=45&auto=format&fit=max&dpr=2&s=0224918b9a71fb253b3a9b4483405f11"),
        new BooksSellerModel (3,"Noon", "https://read.os-cdn.com/wp-content/uploads/2020/08/موقع-نون-للتسوق.jpg"),
        new BooksSellerModel (4,"AlObaikan", "https://mapio.net/images-p/9311516.jpg"),
        new BooksSellerModel (5,"Virgin", "https://riyadh-park.com/wp-content/uploads/2019/10/virgin.jpg"),

          };


        // GET: /<BooksSeller>/
        public IActionResult Index()
        {
            ViewData["BooksSeller"] = BooksSeller;
            return View();
        }
        public IActionResult Type()
        {
            return View();
        }
        public IActionResult Details(int? id)
        {
            BooksSellerModel Books = BooksSeller.Find(ID => ID.SellerId == id);
            if (Books == null)
            {
                return Content("There is no book try another ID ");

            }
            else
            {
                ViewData["BooksSeller"] = Books;
                return View();

            }



        }
    }
}