#pragma checksum "G:\Hotel-Management-Final\Views\Hotels\Hotel_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0558cd898e591453dacf469ad98f4bf403ef641"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hotels_Hotel_list), @"mvc.1.0.view", @"/Views/Hotels/Hotel_list.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "G:\Hotel-Management-Final\Views\_ViewImports.cshtml"
using Hotel_Management_Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Hotel-Management-Final\Views\_ViewImports.cshtml"
using Hotel_Management_Final.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0558cd898e591453dacf469ad98f4bf403ef641", @"/Views/Hotels/Hotel_list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"900a38ebc830d8bf0aec55a188b7bb0934fe968e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Hotels_Hotel_list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hotel_Management_Final.Models.Hotel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Hotel-Management-Final\Views\Hotels\Hotel_list.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\Hotel-Management-Final\Views\Hotels\Hotel_list.cshtml"
 foreach (var item in Model) 

      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"rcontainer\" class=\"col-lg-3 col-md-6 col-sm-12 col-xs-12\">\r\n            <img id=\"rimage\"");
            BeginWriteAttribute("src", " src=\"", 247, "\"", 262, 1);
#nullable restore
#line 10 "G:\Hotel-Management-Final\Views\Hotels\Hotel_list.cshtml"
WriteAttributeValue("", 253, item.URl, 253, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 263, "\"", 280, 1);
#nullable restore
#line 10 "G:\Hotel-Management-Final\Views\Hotels\Hotel_list.cshtml"
WriteAttributeValue("", 269, item.Title, 269, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <span id=\"rtitle\">");
#nullable restore
#line 11 "G:\Hotel-Management-Final\Views\Hotels\Hotel_list.cshtml"
                         Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span id=\"rprice\">");
#nullable restore
#line 12 "G:\Hotel-Management-Final\Views\Hotels\Hotel_list.cshtml"
                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span id=\" rquantity\"><input type=\"number\" name=\"quantity\"");
            BeginWriteAttribute("value", " value=\"", 456, "\"", 464, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"0\" style=\" display: inline; width: 45%;\" /></span>\r\n        <span id=\"cartbutton\"><button style=\" display: inline; width: 45%; text-align:center\">Booked</button></span>\r\n        </div>\r\n");
#nullable restore
#line 16 "G:\Hotel-Management-Final\Views\Hotels\Hotel_list.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Hotel_Management_Final.Models.Hotel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
