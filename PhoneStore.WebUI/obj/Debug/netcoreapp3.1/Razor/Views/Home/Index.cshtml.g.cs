#pragma checksum "D:\Studying\Learn ASP.NET CORE\PhoneStore.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98c66b2676eeb9b61f0523840c5d126f94fe7068"
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
#line 1 "D:\Studying\Learn ASP.NET CORE\PhoneStore.WebUI\Views\_ViewImports.cshtml"
using PhoneStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Studying\Learn ASP.NET CORE\PhoneStore.WebUI\Views\_ViewImports.cshtml"
using PhoneStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98c66b2676eeb9b61f0523840c5d126f94fe7068", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4261d2668a28a97911f7dd216afadbfe78f998ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PhoneStore.Domain.Entities.Phone>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Studying\Learn ASP.NET CORE\PhoneStore.WebUI\Views\Home\Index.cshtml"
  
    //ViewData["Title"] = "Список смартфонов";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98c66b2676eeb9b61f0523840c5d126f94fe70683482", async() => {
                WriteLiteral("\r\n    <title>Online PhoneStore</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98c66b2676eeb9b61f0523840c5d126f94fe70684488", async() => {
                WriteLiteral(@"
    <h3>Phones</h3>
    <table>
        <tr>
            <td>Model</td>
            <td>Brand</td>
            <td>Description</td>
            <td>Memory</td>
            <td>Quantity</td>
            <td>Price</td>
            <td></td>
        </tr>
");
#nullable restore
#line 24 "D:\Studying\Learn ASP.NET CORE\PhoneStore.WebUI\Views\Home\Index.cshtml"
         foreach (var phone in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 27 "D:\Studying\Learn ASP.NET CORE\PhoneStore.WebUI\Views\Home\Index.cshtml"
               Write(phone.Model);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "D:\Studying\Learn ASP.NET CORE\PhoneStore.WebUI\Views\Home\Index.cshtml"
               Write(phone.Brand);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "D:\Studying\Learn ASP.NET CORE\PhoneStore.WebUI\Views\Home\Index.cshtml"
               Write(phone.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "D:\Studying\Learn ASP.NET CORE\PhoneStore.WebUI\Views\Home\Index.cshtml"
               Write(phone.Memory);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "D:\Studying\Learn ASP.NET CORE\PhoneStore.WebUI\Views\Home\Index.cshtml"
               Write(phone.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "D:\Studying\Learn ASP.NET CORE\PhoneStore.WebUI\Views\Home\Index.cshtml"
               Write(phone.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "D:\Studying\Learn ASP.NET CORE\PhoneStore.WebUI\Views\Home\Index.cshtml"
               Write(Html.ActionLink("Купить", "Buy", new { controller = "Home", id = phone.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 35 "D:\Studying\Learn ASP.NET CORE\PhoneStore.WebUI\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PhoneStore.Domain.Entities.Phone>> Html { get; private set; }
    }
}
#pragma warning restore 1591
