#pragma checksum "C:\Users\Raju Rocks\Documents\Visual Studio 2017\Projects\StudentRegistration\StudentRegistration\Views\Users\GetUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88d8b7abb7b637a7aaead7d0c84b2e2d297c2b7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_GetUsers), @"mvc.1.0.view", @"/Views/Users/GetUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/GetUsers.cshtml", typeof(AspNetCore.Views_Users_GetUsers))]
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
#line 1 "C:\Users\Raju Rocks\Documents\Visual Studio 2017\Projects\StudentRegistration\StudentRegistration\Views\_ViewImports.cshtml"
using StudentRegistration;

#line default
#line hidden
#line 2 "C:\Users\Raju Rocks\Documents\Visual Studio 2017\Projects\StudentRegistration\StudentRegistration\Views\_ViewImports.cshtml"
using StudentRegistration.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d8b7abb7b637a7aaead7d0c84b2e2d297c2b7e", @"/Views/Users/GetUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"344e9d8519548a8d19873f1c55f7f50849a675a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_GetUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentRegistration.Models.PagingViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(105, 17, true);
            WriteLiteral("<div id=\"list\">\r\n");
            EndContext();
#line 4 "C:\Users\Raju Rocks\Documents\Visual Studio 2017\Projects\StudentRegistration\StudentRegistration\Views\Users\GetUsers.cshtml"
      await Html.RenderPartialAsync("_GetUsersPartial",@Model.users);

#line default
#line hidden
            BeginContext(194, 153, true);
            WriteLiteral("</div>\r\n\r\n\r\n<a class=\"Paging\" id=\"prev\">prev</a>\r\n\r\n<a style=\"margin-left:60px;\" class=\"Paging\" id=\"next\">next</a><br /><br />\r\n<div id=\"Data\">\r\n</div>\r\n");
            EndContext();
#line 13 "C:\Users\Raju Rocks\Documents\Visual Studio 2017\Projects\StudentRegistration\StudentRegistration\Views\Users\GetUsers.cshtml"
  await Html.RenderPartialAsync("_SearchedUsersPartial", new Data());

#line default
#line hidden
            BeginContext(419, 314, true);
            WriteLiteral(@"

<script src=""https://code.jquery.com/jquery-3.4.0.js"" integrity=""sha256-DYZMCC8HTC+QDr5QNaIcfR7VSPtcISykd+6eSmBW5qo="" crossorigin=""anonymous""></script>

<script type=""text/javascript"">
    var currentPage = 1;
    $("".Paging"").on('click', function () {
        var id = $(this).attr('id');
        var a=");
            EndContext();
            BeginContext(734, 16, false);
#line 22 "C:\Users\Raju Rocks\Documents\Visual Studio 2017\Projects\StudentRegistration\StudentRegistration\Views\Users\GetUsers.cshtml"
         Write(Model.TotalPages);

#line default
#line hidden
            EndContext();
            BeginContext(750, 680, true);
            WriteLiteral(@";
        if (id == 'next') {
            if (currentPage == a) {
                return false;
            }
            currentPage = currentPage + 1;
        }
        else if (id == 'prev') {
            if (currentPage == 1) {
                return false;
            }
            currentPage = currentPage - 1;
        }
        $.ajax({
            url: '/Users/Paging',
            type: 'POST',
            data: { page: currentPage },
            success: function (data) {
                $('#list').html(data);
            },
            error: function (error) {
                $('#list').hide();
            }
        });
    })
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentRegistration.Models.PagingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591