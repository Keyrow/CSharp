#pragma checksum "C:\Users\Keyro\C#\ORMs\EntityFramework\CRUDelicious\Views\Home\DishInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e03548e76f3a535683e0200d0ab01908450e112"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DishInfo), @"mvc.1.0.view", @"/Views/Home/DishInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DishInfo.cshtml", typeof(AspNetCore.Views_Home_DishInfo))]
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
#line 1 "C:\Users\Keyro\C#\ORMs\EntityFramework\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 1 "C:\Users\Keyro\C#\ORMs\EntityFramework\CRUDelicious\Views\Home\DishInfo.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e03548e76f3a535683e0200d0ab01908450e112", @"/Views/Home/DishInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DishInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dishes>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 34, true);
            WriteLiteral("\r\n<h1 style=\"text-align: center;\">");
            EndContext();
            BeginContext(78, 24, false);
#line 4 "C:\Users\Keyro\C#\ORMs\EntityFramework\CRUDelicious\Views\Home\DishInfo.cshtml"
                           Write(ViewBag.DishInfo[0].Name);

#line default
#line hidden
            EndContext();
            BeginContext(102, 39, true);
            WriteLiteral("</h1>\r\n<h2 style=\"text-align: center;\">");
            EndContext();
            BeginContext(142, 24, false);
#line 5 "C:\Users\Keyro\C#\ORMs\EntityFramework\CRUDelicious\Views\Home\DishInfo.cshtml"
                           Write(ViewBag.DishInfo[0].Chef);

#line default
#line hidden
            EndContext();
            BeginContext(166, 81, true);
            WriteLiteral("</h2>\r\n<hr>\r\n<div class=\"container\">\r\n    <h4><a href=\"/\">Home</a></h4>\r\n    <h4>");
            EndContext();
            BeginContext(248, 31, false);
#line 9 "C:\Users\Keyro\C#\ORMs\EntityFramework\CRUDelicious\Views\Home\DishInfo.cshtml"
   Write(ViewBag.DishInfo[0].Description);

#line default
#line hidden
            EndContext();
            BeginContext(279, 25, true);
            WriteLiteral("</h4>\r\n    <h5>Calories: ");
            EndContext();
            BeginContext(305, 28, false);
#line 10 "C:\Users\Keyro\C#\ORMs\EntityFramework\CRUDelicious\Views\Home\DishInfo.cshtml"
             Write(ViewBag.DishInfo[0].Calories);

#line default
#line hidden
            EndContext();
            BeginContext(333, 26, true);
            WriteLiteral("</h5>\r\n    <h5>Tastiness: ");
            EndContext();
            BeginContext(360, 29, false);
#line 11 "C:\Users\Keyro\C#\ORMs\EntityFramework\CRUDelicious\Views\Home\DishInfo.cshtml"
              Write(ViewBag.DishInfo[0].Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(389, 13, true);
            WriteLiteral("</h5>\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 402, "\"", 440, 2);
            WriteAttributeValue("", 409, "/delete/", 409, 8, true);
#line 12 "C:\Users\Keyro\C#\ORMs\EntityFramework\CRUDelicious\Views\Home\DishInfo.cshtml"
WriteAttributeValue("", 417, ViewBag.dishinfo[0].id, 417, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(441, 60, true);
            WriteLiteral("><button class=\"btn btn-primary\">Delete</button></a>\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 501, "\"", 537, 2);
            WriteAttributeValue("", 508, "/edit/", 508, 6, true);
#line 13 "C:\Users\Keyro\C#\ORMs\EntityFramework\CRUDelicious\Views\Home\DishInfo.cshtml"
WriteAttributeValue("", 514, ViewBag.dishinfo[0].id, 514, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(538, 58, true);
            WriteLiteral("><button class=\"btn btn-primary\">Edit</button></a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dishes> Html { get; private set; }
    }
}
#pragma warning restore 1591