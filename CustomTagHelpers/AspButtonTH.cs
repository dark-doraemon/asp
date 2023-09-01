using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebEmpty.CustomTagHelpers
{
    [HtmlTargetElement("aspbutton")]
    public class AspButtonTH : TagHelper
    {
        public string Type { get; set; } = "submit";
        public string BackgroundColor { get; set; } = "danger";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";//chỉ định aspbutton như tag button
            output.TagMode = TagMode.StartTagAndEndTag;//tab có thẻ mở và thẻ đóng
            output.Attributes.SetAttribute("class", $"btn btn-{BackgroundColor}");//set value cho class attribute
            output.Attributes.SetAttribute("type", Type);//set value cho type attribute
            output.Content.SetContent("Click to Add Record");
            //set content cho tag (i.g <button>Click to add record</button>)
        }
    }
}
