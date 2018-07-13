using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homework1.Models.ViewModels
{
    public class MoneyViewModels
    {
        [Display(Name = "類別")]
        public string type { get; set; }

        [Display(Name = "日期")]
        public DateTime recordDate { get; set; }

        [Display(Name = "金額")]
        public int amount { get; set; }

        [Display(Name = "備註")]
        public string remark { get; set; }
    }
}