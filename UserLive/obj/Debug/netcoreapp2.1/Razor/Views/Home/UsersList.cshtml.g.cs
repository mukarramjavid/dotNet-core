#pragma checksum "C:\Users\mukarram.javaid\Desktop\User\UserLive\Views\Home\UsersList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32e850b2af0cfd4bc4a4f5426260554acc8802d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UsersList), @"mvc.1.0.view", @"/Views/Home/UsersList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UsersList.cshtml", typeof(AspNetCore.Views_Home_UsersList))]
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
#line 1 "C:\Users\mukarram.javaid\Desktop\User\UserLive\Views\_ViewImports.cshtml"
using UserLive;

#line default
#line hidden
#line 2 "C:\Users\mukarram.javaid\Desktop\User\UserLive\Views\_ViewImports.cshtml"
using UserLive.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32e850b2af0cfd4bc4a4f5426260554acc8802d8", @"/Views/Home/UsersList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc3a3262aaca43f72383e090e6438ed720a4e2bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UsersList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserLive.Models.UserViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mukarram.javaid\Desktop\User\UserLive\Views\Home\UsersList.cshtml"
  
    ViewData["Title"] = "UsersList";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var list = ViewBag.list;

#line default
#line hidden
            BeginContext(175, 34, true);
            WriteLiteral("\r\n<h2>Users List</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(209, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3834b7c9fda643fd82e6849715f858fa", async() => {
                BeginContext(254, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(268, 323, true);
            WriteLiteral(@"
</p>
<table class=""table table-hover table-striped"">
    <thead>
        <tr>
            <th>Name</th>
            <th>Email</th>
            <th>Password</th>
            <th>Phone</th>
            <th>Age</th>
            <th>City</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 27 "C:\Users\mukarram.javaid\Desktop\User\UserLive\Views\Home\UsersList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(623, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(654, 14, false);
#line 29 "C:\Users\mukarram.javaid\Desktop\User\UserLive\Views\Home\UsersList.cshtml"
           Write(item.user_name);

#line default
#line hidden
            EndContext();
            BeginContext(668, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(692, 15, false);
#line 30 "C:\Users\mukarram.javaid\Desktop\User\UserLive\Views\Home\UsersList.cshtml"
           Write(item.user_email);

#line default
#line hidden
            EndContext();
            BeginContext(707, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(731, 13, false);
#line 31 "C:\Users\mukarram.javaid\Desktop\User\UserLive\Views\Home\UsersList.cshtml"
           Write(item.user_pwd);

#line default
#line hidden
            EndContext();
            BeginContext(744, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(768, 15, false);
#line 32 "C:\Users\mukarram.javaid\Desktop\User\UserLive\Views\Home\UsersList.cshtml"
           Write(item.user_phone);

#line default
#line hidden
            EndContext();
            BeginContext(783, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(807, 13, false);
#line 33 "C:\Users\mukarram.javaid\Desktop\User\UserLive\Views\Home\UsersList.cshtml"
           Write(item.user_age);

#line default
#line hidden
            EndContext();
            BeginContext(820, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(844, 13, false);
#line 34 "C:\Users\mukarram.javaid\Desktop\User\UserLive\Views\Home\UsersList.cshtml"
           Write(item.cityName);

#line default
#line hidden
            EndContext();
            BeginContext(857, 55, true);
            WriteLiteral("</td>\r\n            \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(913, 69, false);
#line 37 "C:\Users\mukarram.javaid\Desktop\User\UserLive\Views\Home\UsersList.cshtml"
           Write(Html.ActionLink("Edit", "GetById", "Home", new { id = item.user_id }));

#line default
#line hidden
            EndContext();
            BeginContext(982, 22, true);
            WriteLiteral(" |\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1004, "\'", 1067, 1);
#line 38 "C:\Users\mukarram.javaid\Desktop\User\UserLive\Views\Home\UsersList.cshtml"
WriteAttributeValue("", 1011, Url.Action("DeleteRecord","Home",new {id=item.user_id}), 1011, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1068, 41, true);
            WriteLiteral(" onclick=\"return Confirm()\">Delete </a>\r\n");
            EndContext();
            BeginContext(1208, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 42 "C:\Users\mukarram.javaid\Desktop\User\UserLive\Views\Home\UsersList.cshtml"
}

#line default
#line hidden
            BeginContext(1245, 157, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n<script>\r\n    const Confirm=()=> {\r\n        return confirm(\'Are you sure you want to delete this record???\');\r\n    }\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserLive.Models.UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
