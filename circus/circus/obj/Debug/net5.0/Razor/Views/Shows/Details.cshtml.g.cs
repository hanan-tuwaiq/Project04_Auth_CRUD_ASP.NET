#pragma checksum "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Shows\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f3e615ab6a015070b063551b70e41e0b861e3f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shows_Details), @"mvc.1.0.view", @"/Views/Shows/Details.cshtml")]
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
#line 1 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\_ViewImports.cshtml"
using circus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\_ViewImports.cshtml"
using circus.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f3e615ab6a015070b063551b70e41e0b861e3f8", @"/Views/Shows/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d4000318c7e40b7063edb67f2612d479a0eebe0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shows_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-full px-6 py-2 uppercase font-bold bg-yellow-400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Shows\Details.cshtml"
  
    var show = (ShowModel)ViewData["show"];
    var performers = (List<PerformerModel>)ViewData["performers"];
    var venues = (List<VenueModel>)ViewData["venues"];
    string[] month = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""h-72 w-3/4 m-auto pt-12"">
    <div class=""my-auto"">
        <h1 class=""text-7xl font-bold hero text-center"">Show Details</h1>
    </div>
</section>
<section class=""mb-12"">
    <div class=""grid grid-cols-2 w-3/4 m-auto bg-gradient-to-b from-gray-100 shadow-lg rounded-lg mt-6 overflow-hidden"">
        <div class=""p-8"">
            <h3 class=""text-4xl font-bold text-center mb-6 hero"">");
#nullable restore
#line 16 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Shows\Details.cshtml"
                                                            Write(performers.Find(x => x.Id == show.PerformerId).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h5 class=\"ttext-lg font-bold text-gray-500 italic\">");
#nullable restore
#line 17 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Shows\Details.cshtml"
                                                           Write(show.Date.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 17 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Shows\Details.cshtml"
                                                                           Write(month[show.Date.Month - 1]);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 17 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Shows\Details.cshtml"
                                                                                                        Write(show.Date.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n            <div class=\" w-3/4 text-lg leading-relaxed mb-4\">\r\n                <h4>\r\n                    With their amazing ");
#nullable restore
#line 21 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Shows\Details.cshtml"
                                  Write(performers.Find(x => x.Id == show.PerformerId).Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral(" team performance at\r\n                    ");
#nullable restore
#line 22 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Shows\Details.cshtml"
               Write(venues.Find(x => x.Id == show.VenueId).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 22 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Shows\Details.cshtml"
                                                             Write(venues.Find(x => x.Id == show.VenueId).Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    on ");
#nullable restore
#line 23 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Shows\Details.cshtml"
                  Write(show.Date.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 23 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Shows\Details.cshtml"
                                  Write(month[show.Date.Month - 1]);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 23 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Shows\Details.cshtml"
                                                               Write(show.Date.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h4>\r\n\r\n            </div>\r\n            <div class=\"text-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f3e615ab6a015070b063551b70e41e0b861e3f88010", async() => {
                WriteLiteral("Attend show!");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1474, "~/tickets/create/", 1474, 17, true);
#nullable restore
#line 28 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Shows\Details.cshtml"
AddHtmlAttributeValue("", 1491, show.Id, 1491, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 1586, "\"", 1645, 1);
#nullable restore
#line 32 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Shows\Details.cshtml"
WriteAttributeValue("", 1592, performers.Find(x => x.Id == show.PerformerId).Image, 1592, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"performers img\" />\r\n        </div>\r\n    </div>\r\n</section>");
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
