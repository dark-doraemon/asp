using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebEmpty.CustomTagHelpers
{
    [HtmlTargetElement("div", Attributes = "theme")]
    public class CoordinateTagHelpers
    {
        public string Theme { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            context.Items["theme"] = Theme;
        }
    }
}
