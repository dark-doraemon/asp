using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebEmpty.CustomTagHelpers
{
    //chỉ áp dụng cho thẻ div và có thuộc tình pre-post
    [HtmlTargetElement("div", Attributes = "pre-post")]
    public class PrePostElementTH : TagHelper
    {
        public bool AddHeader { get; set; } = true;
        public bool AddFooter { get; set; } = true;
        public string PrePost { get; set; } 
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", "m-1 p-1");//set value cho class property 

            TagBuilder title = new TagBuilder("h1");//tạo thẻ <h1>
            title.InnerHtml.Append(PrePost);//đặt nội dụng của prepost bên trong <h1>

            TagBuilder container = new TagBuilder("div");//tạo thẻ div
            container.Attributes["class"] = "bg-info m-1 p-1";//set value cho class của thẻ <div>
            container.InnerHtml.AppendHtml(title);//đặt thẻ <h1> trên trong thẻ <div>

            if (AddHeader)// nếu thuộc tính addheader = true thì thêm header
                output.PreElement.SetHtmlContent(container);
            if (AddFooter)//nếu thuộc tính addfooter = true thì thêm footer
                output.PostElement.SetHtmlContent(container);
        }
    }
}
