#pragma checksum "C:\Users\Raju Rocks\Documents\Visual Studio 2017\Projects\StudentRegistration\StudentRegistration\Views\Users\_GetUsersPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81f215ffc5a1feef6f0e6ebe0b6a00c29b8f3c69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users__GetUsersPartial), @"mvc.1.0.view", @"/Views/Users/_GetUsersPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/_GetUsersPartial.cshtml", typeof(AspNetCore.Views_Users__GetUsersPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81f215ffc5a1feef6f0e6ebe0b6a00c29b8f3c69", @"/Views/Users/_GetUsersPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"344e9d8519548a8d19873f1c55f7f50849a675a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Users__GetUsersPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StudentRegistration.Models.Data>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 99, true);
            WriteLiteral("\r\n\r\n<table class=\"table\" border=\"1\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(153, 40, false);
#line 8 "C:\Users\Raju Rocks\Documents\Visual Studio 2017\Projects\StudentRegistration\StudentRegistration\Views\Users\_GetUsersPartial.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(193, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(249, 43, false);
#line 11 "C:\Users\Raju Rocks\Documents\Visual Studio 2017\Projects\StudentRegistration\StudentRegistration\Views\Users\_GetUsersPartial.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(292, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(348, 43, false);
#line 14 "C:\Users\Raju Rocks\Documents\Visual Studio 2017\Projects\StudentRegistration\StudentRegistration\Views\Users\_GetUsersPartial.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNo));

#line default
#line hidden
            EndContext();
            BeginContext(391, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(447, 41, false);
#line 17 "C:\Users\Raju Rocks\Documents\Visual Studio 2017\Projects\StudentRegistration\StudentRegistration\Views\Users\_GetUsersPartial.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(488, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(544, 41, false);
#line 20 "C:\Users\Raju Rocks\Documents\Visual Studio 2017\Projects\StudentRegistration\StudentRegistration\Views\Users\_GetUsersPartial.cshtml"
           Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(585, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(641, 44, false);
#line 23 "C:\Users\Raju Rocks\Documents\Visual Studio 2017\Projects\StudentRegistration\StudentRegistration\Views\Users\_GetUsersPartial.cshtml"
           Write(Html.DisplayNameFor(model => model.Approved));

#line default
#line hidden
            EndContext();
            BeginContext(685, 65, true);
            WriteLiteral("\r\n            </th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 29 "C:\Users\Raju Rocks\Documents\Visual Studio 2017\Projects\StudentRegistration\StudentRegistration\Views\Users\_GetUsersPartial.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(799, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(860, 39, false);
#line 33 "C:\Users\Raju Rocks\Documents\Visual Studio 2017\Projects\StudentRegistration\StudentRegistration\Views\Users\_GetUsersPartial.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(899, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(967, 42, false);
#line 36 "C:\Users\Raju Rocks\Documents\Visual Studio 2017\Projects\StudentRegistration\StudentRegistration\Views\Users\_GetUsersPartial.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1009, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1077, 42, false);
#line 39 "C:\Users\Raju Rocks\Documents\Visual Studio 2017\Projects\StudentRegistration\StudentRegistration\Views\Users\_GetUsersPartial.cshtml"
               Write(Html.DisplayFor(modelItem => item.PhoneNo));

#line default
#line hidden
            EndContext();
            BeginContext(1119, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1187, 40, false);
#line 42 "C:\Users\Raju Rocks\Documents\Visual Studio 2017\Projects\StudentRegistration\StudentRegistration\Views\Users\_GetUsersPartial.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1227, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1295, 40, false);
#line 45 "C:\Users\Raju Rocks\Documents\Visual Studio 2017\Projects\StudentRegistration\StudentRegistration\Views\Users\_GetUsersPartial.cshtml"
               Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
            EndContext();
            BeginContext(1335, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1403, 43, false);
#line 48 "C:\Users\Raju Rocks\Documents\Visual Studio 2017\Projects\StudentRegistration\StudentRegistration\Views\Users\_GetUsersPartial.cshtml"
               Write(Html.DisplayFor(modelItem => item.Approved));

#line default
#line hidden
            EndContext();
            BeginContext(1446, 68, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                     ");
            EndContext();
            BeginContext(1515, 57, false);
#line 51 "C:\Users\Raju Rocks\Documents\Visual Studio 2017\Projects\StudentRegistration\StudentRegistration\Views\Users\_GetUsersPartial.cshtml"
                Write(Html.ActionLink("Edit", "Edit", new { name = item.Name }));

#line default
#line hidden
            EndContext();
            BeginContext(1572, 46, true);
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 55 "C:\Users\Raju Rocks\Documents\Visual Studio 2017\Projects\StudentRegistration\StudentRegistration\Views\Users\_GetUsersPartial.cshtml"
        }

#line default
#line hidden
            BeginContext(1629, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StudentRegistration.Models.Data>> Html { get; private set; }
    }
}
#pragma warning restore 1591