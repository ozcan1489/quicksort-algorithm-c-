#pragma checksum "C:\Users\ozcnr\Desktop\OnesComp\OnesComp\OnesComp\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d673ff19dabcd44999a893b2868fd1566e1dea62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 2 "C:\Users\ozcnr\Desktop\OnesComp\OnesComp\OnesComp\Views\_ViewImports.cshtml"
using OnesComp.Models;

#line default
#line hidden
#line 3 "C:\Users\ozcnr\Desktop\OnesComp\OnesComp\OnesComp\Views\_ViewImports.cshtml"
using OnesComp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d673ff19dabcd44999a893b2868fd1566e1dea62", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a77992d78c7d7a07c556e8283804c15da9e420ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Equipment>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(26, 10, false);
#line 3 "C:\Users\ozcnr\Desktop\OnesComp\OnesComp\OnesComp\Views\Home\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(36, 42, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"thumbnail\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 78, "\"", 95, 1);
#line 6 "C:\Users\ozcnr\Desktop\OnesComp\OnesComp\OnesComp\Views\Home\Details.cshtml"
WriteAttributeValue("", 84, Model.Name, 84, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 96, "\"", 117, 1);
#line 6 "C:\Users\ozcnr\Desktop\OnesComp\OnesComp\OnesComp\Views\Home\Details.cshtml"
WriteAttributeValue("", 102, Model.ImageUrl, 102, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(118, 67, true);
            WriteLiteral(" >\r\n    <div class=\"caption-full\">\r\n        <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(186, 11, false);
#line 8 "C:\Users\ozcnr\Desktop\OnesComp\OnesComp\OnesComp\Views\Home\Details.cshtml"
                          Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(197, 45, true);
            WriteLiteral("</h3>\r\n        <h3>\r\n            <a href=\"#\">");
            EndContext();
            BeginContext(243, 10, false);
#line 10 "C:\Users\ozcnr\Desktop\OnesComp\OnesComp\OnesComp\Views\Home\Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(253, 33, true);
            WriteLiteral("</a>\r\n        </h3>\r\n        <h4>");
            EndContext();
            BeginContext(287, 22, false);
#line 12 "C:\Users\ozcnr\Desktop\OnesComp\OnesComp\OnesComp\Views\Home\Details.cshtml"
       Write(Model.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(309, 18, true);
            WriteLiteral("</h4>\r\n        <p>");
            EndContext();
            BeginContext(328, 21, false);
#line 13 "C:\Users\ozcnr\Desktop\OnesComp\OnesComp\OnesComp\Views\Home\Details.cshtml"
      Write(Model.LongDescription);

#line default
#line hidden
            EndContext();
            BeginContext(349, 26, true);
            WriteLiteral("</p>\r\n\r\n    </div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Equipment> Html { get; private set; }
    }
}
#pragma warning restore 1591
