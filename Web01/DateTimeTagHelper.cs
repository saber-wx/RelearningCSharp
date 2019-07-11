using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Web01
{
    [HtmlTargetElement("DateTime", Attributes = "asp-showicon,asp-only")]
    public class DateTimeTagHelper : TagHelper
    {

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "small";
            //获取文本内容
            DateTime htmlContent = Convert.ToDateTime(output.GetChildContentAsync().Result.GetContent());

            object showicon = context.AllAttributes["asp-showicon"].Value;
            object only = context.AllAttributes["asp-only"].Value;

            //判断asp-only是否有"date"属性,并返回要现实的内容
            string Content = Only(only, output, htmlContent);
            //判断asp-showicon是否为true,并返回要现实的内容
            string showiconHtmlContent = Showicon(showicon, output, Content);
            
            output.Content.SetHtmlContent(showiconHtmlContent);
        }

        //当asp-only="date"时，生成的HTML标签只显示日期，不显示时间 
        public string Only(object only, TagHelperOutput output, DateTime htmlContent)
        {
            if (only.ToString().ToLower() == "date")
            {
                string Content = $"{htmlContent.ToString("yyyy年mm月dd日")}";
                return Content;
            }
            else
            {
                return htmlContent.ToString();
            }
        }

        //当asp-showicon="true"时，生成的HTML标签包含一个日历图标： 
        public string Showicon(object showicon, TagHelperOutput output, string Content)
        {
            if (showicon.ToString().ToLower() == "true")
            {
                string htmlContent = $"<div class=\"glyphicon glyphicon-calendar\">{Content}</div>";
                return htmlContent;
            }
            else
            {
                return Content;
            }
        }

    }
}
