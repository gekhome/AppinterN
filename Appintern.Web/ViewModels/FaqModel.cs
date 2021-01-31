using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Appintern.Web.ViewModels
{
    public class FaqViewModel
    {
        public string Question { get; set; }

        public IHtmlString Answer { get; set; }

        public FaqViewModel(string question, IHtmlString answer)
        {
            Question = question;
            Answer = answer;
        }
    }
}