#pragma checksum "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Tickets\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbcb6525337c23dd6cb1343304ed355b09b6e932"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tickets_Index), @"mvc.1.0.view", @"/Views/Tickets/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Tickets\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbcb6525337c23dd6cb1343304ed355b09b6e932", @"/Views/Tickets/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d4000318c7e40b7063edb67f2612d479a0eebe0", @"/Views/_ViewImports.cshtml")]
    public class Views_Tickets_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Tickets\Index.cshtml"
  
    var tickets = (List<TicketModel>)ViewData["tickets"];
    var shows = (List<ShowModel>)ViewData["shows"];

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Tickets\Index.cshtml"
  /*UserManager.GetUserId(User)*/

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h3>Tickets</h3>\r\n    <h5>");
#nullable restore
#line 10 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Tickets\Index.cshtml"
   Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    \r\n</div>\r\n");
#nullable restore
#line 13 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Tickets\Index.cshtml"
 foreach(var t in tickets)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    Day: <b>");
#nullable restore
#line 16 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Tickets\Index.cshtml"
       Write(shows.Find(x => x.Id == t.ShowId).Date.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n    Performer:  <b>");
#nullable restore
#line 17 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Tickets\Index.cshtml"
              Write(shows.Find(x => x.Id == t.ShowId).PerformerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n    Quantity: <b>");
#nullable restore
#line 18 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Tickets\Index.cshtml"
            Write(t.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n</div>\r\n");
#nullable restore
#line 20 "C:\Users\SAFCSP\Desktop\hanan\projects\Project04_Auth_CRUD_ASP.NET\circus\circus\Views\Tickets\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
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
