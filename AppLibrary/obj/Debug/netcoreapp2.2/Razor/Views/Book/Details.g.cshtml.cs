#pragma checksum "C:\Users\ELEONORA\source\repos\AppLibrary\AppLibrary\Views\Book\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8309e3e73d8adf6edfee9c65c052300409bd76b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Details), @"mvc.1.0.view", @"/Views/Book/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Details.cshtml", typeof(AspNetCore.Views_Book_Details))]
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
#line 1 "C:\Users\ELEONORA\source\repos\AppLibrary\AppLibrary\Views\_ViewImports.cshtml"
using AppLibrary;

#line default
#line hidden
#line 2 "C:\Users\ELEONORA\source\repos\AppLibrary\AppLibrary\Views\_ViewImports.cshtml"
using AppLibrary.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8309e3e73d8adf6edfee9c65c052300409bd76b", @"/Views/Book/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"390241f1b1b73cc8e5840a51f61b75d586f33dac", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppLibrary.DtoModels.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ELEONORA\source\repos\AppLibrary\AppLibrary\Views\Book\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(78, 106, true);
            WriteLiteral("\r\n<div>\r\n    <h4>Book details</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(185, 38, false);
#line 11 "C:\Users\ELEONORA\source\repos\AppLibrary\AppLibrary\Views\Book\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(223, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(267, 34, false);
#line 14 "C:\Users\ELEONORA\source\repos\AppLibrary\AppLibrary\Views\Book\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(301, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(345, 49, false);
#line 17 "C:\Users\ELEONORA\source\repos\AppLibrary\AppLibrary\Views\Book\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberOfPages));

#line default
#line hidden
            EndContext();
            BeginContext(394, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(438, 45, false);
#line 20 "C:\Users\ELEONORA\source\repos\AppLibrary\AppLibrary\Views\Book\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumberOfPages));

#line default
#line hidden
            EndContext();
            BeginContext(483, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(527, 47, false);
#line 23 "C:\Users\ELEONORA\source\repos\AppLibrary\AppLibrary\Views\Book\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.YearOfIssue));

#line default
#line hidden
            EndContext();
            BeginContext(574, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(618, 43, false);
#line 26 "C:\Users\ELEONORA\source\repos\AppLibrary\AppLibrary\Views\Book\Details.cshtml"
       Write(Html.DisplayFor(model => model.YearOfIssue));

#line default
#line hidden
            EndContext();
            BeginContext(661, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(705, 50, false);
#line 29 "C:\Users\ELEONORA\source\repos\AppLibrary\AppLibrary\Views\Book\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Publisher.Name));

#line default
#line hidden
            EndContext();
            BeginContext(755, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(799, 46, false);
#line 32 "C:\Users\ELEONORA\source\repos\AppLibrary\AppLibrary\Views\Book\Details.cshtml"
       Write(Html.DisplayFor(model => model.Publisher.Name));

#line default
#line hidden
            EndContext();
            BeginContext(845, 35, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppLibrary.DtoModels.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
