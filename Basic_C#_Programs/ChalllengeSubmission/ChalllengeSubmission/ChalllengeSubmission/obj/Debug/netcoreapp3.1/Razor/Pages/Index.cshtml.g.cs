#pragma checksum "C:\Users\mmcmi\OneDrive\Documents\School\C-Sharp-Projects\Basic_C#_Programs\ChalllengeSubmission\ChalllengeSubmission\ChalllengeSubmission\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "085471c2f19f11561c9f8d53d901c8a9e1ab6fd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ChalllengeSubmission.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ChalllengeSubmission.Pages
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
#line 1 "C:\Users\mmcmi\OneDrive\Documents\School\C-Sharp-Projects\Basic_C#_Programs\ChalllengeSubmission\ChalllengeSubmission\ChalllengeSubmission\Pages\_ViewImports.cshtml"
using ChalllengeSubmission;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"085471c2f19f11561c9f8d53d901c8a9e1ab6fd5", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2613b7295f5734687996272b5367380f297a3e15", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mmcmi\OneDrive\Documents\School\C-Sharp-Projects\Basic_C#_Programs\ChalllengeSubmission\ChalllengeSubmission\ChalllengeSubmission\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <!--\r\n        Design a simple ASP.NET Core web app that displays\r\n        the actual server time in the browser.\r\n    -->\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 12 "C:\Users\mmcmi\OneDrive\Documents\School\C-Sharp-Projects\Basic_C#_Programs\ChalllengeSubmission\ChalllengeSubmission\ChalllengeSubmission\Pages\Index.cshtml"
                     Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    <!--\r\n        Customize the CSHTML <h2> element with text of your choosing.\r\n    -->\r\n    <h2>| Todays Date |</h2>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591