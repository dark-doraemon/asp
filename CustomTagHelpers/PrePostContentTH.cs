using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Security.AccessControl;

namespace WebEmpty.CustomTagHelpers
{
    //chỉ áp dụng cho thẻ <td> có thuộc tính underline
    [HtmlTargetElement("td", Attributes = "underline")]
    public class PrePostContentTH : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.PreContent.SetHtmlContent("<u>");
            output.PostContent.SetHtmlContent("</u>");
        }
    }
    //giải thích
    //<td>Đây là content</td>
    //"Đây là content" gọi là content 

    //output.PreContent.SetHtmlContent("<u>"); sẽ thêm <u> vào trước content 
    //=> <td>
    //      <u>Đây là content
    //   </td>

    //output.PostContent.SetHtmlContent("</u>");sẽ thêm </u> vào sao content
    //=> <td>
    //      Đây là content</u>
    //   </td>

    //kết hợp lại sẽ là 
    //<td>
    //  <u>Đây là content</u>
    //</td>

}

