#pragma checksum "C:\GitHub\repositories\c-sharp_coding_projects\Knockout\Knockout\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8912b1f7fbcf971545e36ba4a72cd706eb53db64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\GitHub\repositories\c-sharp_coding_projects\Knockout\Knockout\Views\_ViewImports.cshtml"
using Knockout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GitHub\repositories\c-sharp_coding_projects\Knockout\Knockout\Views\_ViewImports.cshtml"
using Knockout.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8912b1f7fbcf971545e36ba4a72cd706eb53db64", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"882aba9b7675309b5506c6475aac4256d7dae1cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\GitHub\repositories\c-sharp_coding_projects\Knockout\Knockout\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Folders -->
<ul class=""folders"" data-bind=""foreach: folders"">
    <li data-bind=""text: $data,
                   css: { selected: $data == $root.chosenFolderId() },
                   click: $root.goToFolder""></li>
</ul>

<!-- Email Table -->
<table class=""mails"" data-bind=""with: chosenFolderData"">
    <thead>
        <tr>
            <th>From</th>
            <th>To</th>
            <th>Subject</th>
            <th>Date</th>
        </tr>
    </thead>
    <tbody data-bind=""foreach: mails"">
        <tr data-bind=""click: $root.goToMail"">
            <td data-bind=""text: from""></td>
            <td data-bind=""text: to""></td>
            <td data-bind=""text: subject""></td>
            <td data-bind=""text: date""></td>
        </tr>
    </tbody>
</table>

<!-- Chosen Mail -->
<div class=""viewMail"" data-bind=""with: chosenMailData"">
    <div class=""mailInfo"">
        <h1 data-bind=""text: subject""></h1>
        <p><label>From</label>: <span data-bind=""text: from""></span></p>
   ");
            WriteLiteral("     <p><label>To</label>: <span data-bind=\"text: to\"></span></p>\r\n        <p><label>Date</label>: <span data-bind=\"text: date\"></span></p>\r\n    </div>\r\n    <br />\r\n    <p class=\"message\" data-bind=\"html: message\" />\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
