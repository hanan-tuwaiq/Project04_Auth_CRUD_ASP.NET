#pragma checksum "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Gallery\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4af05cf955f7c4265d59d3ef83daf2db35574965"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gallery_Index), @"mvc.1.0.view", @"/Views/Gallery/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4af05cf955f7c4265d59d3ef83daf2db35574965", @"/Views/Gallery/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d4000318c7e40b7063edb67f2612d479a0eebe0", @"/Views/_ViewImports.cshtml")]
    public class Views_Gallery_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Gallery\Index.cshtml"
  
    var performers = (List<PerformerModel>)ViewData["performers"];
    var venues = (List<VenueModel>)ViewData["venues"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Gallery</h2>\r\n");
#nullable restore
#line 6 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Gallery\Index.cshtml"
 foreach (var p in performers)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <img");
            BeginWriteAttribute("src", " src=\"", 192, "\"", 206, 1);
#nullable restore
#line 8 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Gallery\Index.cshtml"
WriteAttributeValue("", 198, p.Image, 198, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 9 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Gallery\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Gallery\Index.cshtml"
 foreach (var v in venues)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <img");
            BeginWriteAttribute("src", " src=\"", 254, "\"", 268, 1);
#nullable restore
#line 12 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Gallery\Index.cshtml"
WriteAttributeValue("", 260, v.Image, 260, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 13 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Gallery\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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