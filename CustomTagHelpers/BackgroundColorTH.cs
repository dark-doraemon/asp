using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Drawing;

namespace WebEmpty.CustomTagHelpers
{
    [HtmlTargetElement("button",Attributes = "backgrouncolor",ParentTag ="form")]

    public class BackgroundColorTH : TagHelper
    {
        public string? backgrouncolor { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", $"btn btn-{backgrouncolor}");
        }
    }
}