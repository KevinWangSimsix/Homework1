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
        public string Type { get; set; }

        [Display(Name = "日期")]
        public DateTime RecordDate { get; set; }

        [Display(Name = "金額")]
        public int Amount { get; set; }

        [Display(Name = "備註")]
        public string Remark { get; set; }
    }
}