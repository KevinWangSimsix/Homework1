using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homework1.Models.ViewModels;

namespace Homework1.Controllers
{
    public class MoneyController : Controller
    {
        // GET: Money
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult GetMoneyList()
        {
            var moneyList = new List<MoneyViewModels>();

            Random rnd = new Random();

            for (int i = 0; i < 50; i++)
            {
                moneyList.Add(new MoneyViewModels
                {
                    type = (rnd.Next() % 2 == 0 ? "支出" : "收入"),
                    recordDate = DateTime.Now.AddDays(-i),
                    amount = rnd.Next(0, short.MaxValue)
                });
            }


            return View(moneyList);
        }
    }
}