#pragma checksum "C:\Users\ELEONORA\source\repos\AppLibrary\AppLibrary\Views\BookCopies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c26f45ff90c108d8b2d5fbe03ae5f332c39ad014"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookCopies_Details), @"mvc.1.0.view", @"/Views/BookCopies/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BookCopies/Details.cshtml", typeof(AspNetCore.Views_BookCopies_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c26f45ff90c108d8b2d5fbe03ae5f332c39ad014", @"/Views/BookCopies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"390241f1b1b73cc8e5840a51f61b75d586f33dac", @"/Views/_ViewImports.cshtml")]
    public class Views_BookCopies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppLibrary.DtoModels.BookCopies>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ELEONORA\source\repos\AppLibrary\AppLibrary\Views\BookCopies\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 115, true);
            WriteLiteral("\r\n\r\n<div>\r\n    <h4>Book copies details</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(200, 38, false);
#line 12 "C:\Users\ELEONORA\source\repos\AppLibrary\AppLibrary\Views\BookCopies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(238, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(282, 34, false);
#line 15 "C:\Users\ELEONORA\source\repos\AppLibrary\AppLibrary\Views\BookCopies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(316, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(360, 48, false);
#line 18 "C:\Users\ELEONORA\source\repos\AppLibrary\AppLibrary\Views\BookCopies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Library.Name));

#line default
#line hidden
            EndContext();
            BeginContext(408, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(452, 44, false);
#line 21 "C:\Users\ELEONORA\source\repos\AppLibrary\AppLibrary\Views\BookCopies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Library.Name));

#line default
#line hidden
            EndContext();
            BeginContext(496, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(540, 46, false);
#line 24 "C:\Users\ELEONORA\source\repos\AppLibrary\AppLibrary\Views\BookCopies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Title));

#line default
#line hidden
            EndContext();
            BeginContext(586, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(630, 42, false);
#line 27 "C:\Users\ELEONORA\source\repos\AppLibrary\AppLibrary\Views\BookCopies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.Title));

#line default
#line hidden
            EndContext();
            BeginContext(672, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(716, 50, false);
#line 30 "C:\Users\ELEONORA\source\repos\AppLibrary\AppLibrary\Views\BookCopies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberOfCopies));

#line default
#line hidden
            EndContext();
            BeginContext(766, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(810, 46, false);
#line 33 "C:\Users\ELEONORA\source\repos\AppLibrary\AppLibrary\Views\BookCopies\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumberOfCopies));

#line default
#line hidden
            EndContext();
            BeginContext(856, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppLibrary.DtoModels.BookCopies> Html { get; private set; }
    }
}
#pragma warning restore 1591
