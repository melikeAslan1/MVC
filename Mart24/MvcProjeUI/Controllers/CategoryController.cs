﻿using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeUI.Controllers
{
    // sadece kategori işlemleri burada tutulacak. 
    public class CategoryController : Controller
    {   // GET: Default
        CategoryManager cm = new CategoryManager();
       
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetAll();
            return View(categoryvalues);
        }


    }

    
}