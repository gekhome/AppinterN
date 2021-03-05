using System;
using System.ComponentModel.DataAnnotations;

namespace Appintern.Web.ViewModels
{
    public class MemberCountModel
    {
        public string MemberType { get; set; }
        public decimal Percentage { get; set; }
        public bool Explode { get; set; }
        public string Color { get; set; }


        public MemberCountModel()
        { }

        public MemberCountModel(string memberType, decimal percentage, string color = null)
        {
            MemberType = memberType;
            Percentage = percentage;
            Color = color;
        }

    }
}
