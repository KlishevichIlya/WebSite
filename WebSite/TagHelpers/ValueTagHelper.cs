using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Models;
using Microsoft.EntityFrameworkCore;

namespace WebSite.TagHelpers
{
    public class ValueTagHelper : TagHelper
    {
         private readonly CarContext db;
        public ValueTagHelper(CarContext context)
        {
            db = context;
        }
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.PreElement.SetHtmlContent("<h1>Курсы валют на сегодня: </h1>");
            output.Content.SetContent($"1 EUR : {(await db.Moneys.FirstAsync(item => item.MoneyId == 1)).Euro} BYN");
            output.PostElement.SetHtmlContent($"1 USD : {(await db.Moneys.FirstAsync(item => item.MoneyId == 1)).Dollar} BYN");
        }

    }
}
