using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace leontevlaba.Controllers
{
    public class Lab1Controller : Controller
    {
        public List<string> GetVegetableList()
        {
            List<string> vegetables =new List<string>();
            vegetables.Add("томат");
            vegetables.Add("Огурец");
            vegetables.Add("Картофедь");
            vegetables.Add("Кабачок"); 
            vegetables.Add("Баклажан");
            vegetables.Add("Юроколи");

            return vegetables;
        }
        // GET: Lab1
        public ActionResult FirstViewMethod()
        {
            List<string> vegetables = GetVegetableList();
            return View(vegetables);
        }
    }
}