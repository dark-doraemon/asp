using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebEmpty.CustomTagHelpers
{
    [HtmlTargetElement("div", Attributes = "theme")]
    public class CoordinateTagHelpers : TagHelper
    {
        public string Theme { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            context.Items["theme"] = Theme;
        }

    }

    [HtmlTargetElement("button", ParentTag = "div")]
    [HtmlTargetElement("a", ParentTag = "div")]
    public class ChildThemeTH : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (context.Items.ContainsKey("theme"))
                output.Attributes.SetAttribute("class", $"btn btn-{context.Items["theme"]}");
        }
    }
}
