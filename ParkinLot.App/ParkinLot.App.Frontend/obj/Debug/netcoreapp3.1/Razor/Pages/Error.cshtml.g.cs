<<<<<<< HEAD
#pragma checksum "C:\ColDevpss\ParkinLot.App\ParkinLot.App.Frontend\Pages\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f02565c188bc0cf60de1bc120acef71a3608055"
=======
#pragma checksum "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f02565c188bc0cf60de1bc120acef71a3608055"
>>>>>>> 7c3b33d8b46e4800595aa0285434400b6b89b9f0
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ParkinLot.App.Frontend.Pages.Pages_Error), @"mvc.1.0.razor-page", @"/Pages/Error.cshtml")]
namespace ParkinLot.App.Frontend.Pages
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
<<<<<<< HEAD
#line 1 "C:\ColDevpss\ParkinLot.App\ParkinLot.App.Frontend\Pages\_ViewImports.cshtml"
=======
#line 1 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\_ViewImports.cshtml"
>>>>>>> 7c3b33d8b46e4800595aa0285434400b6b89b9f0
using ParkinLot.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f02565c188bc0cf60de1bc120acef71a3608055", @"/Pages/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"242a1b8db319a713d77cd308ea2d3d2c91d49b8b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Error : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
<<<<<<< HEAD
#line 3 "C:\ColDevpss\ParkinLot.App\ParkinLot.App.Frontend\Pages\Error.cshtml"
=======
#line 3 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\Error.cshtml"
>>>>>>> 7c3b33d8b46e4800595aa0285434400b6b89b9f0
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-danger\">Error.</h1>\r\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\r\n\r\n");
#nullable restore
<<<<<<< HEAD
#line 10 "C:\ColDevpss\ParkinLot.App\ParkinLot.App.Frontend\Pages\Error.cshtml"
=======
#line 10 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\Error.cshtml"
>>>>>>> 7c3b33d8b46e4800595aa0285434400b6b89b9f0
 if (Model.ShowRequestId)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
#nullable restore
<<<<<<< HEAD
#line 13 "C:\ColDevpss\ParkinLot.App\ParkinLot.App.Frontend\Pages\Error.cshtml"
=======
#line 13 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\Error.cshtml"
>>>>>>> 7c3b33d8b46e4800595aa0285434400b6b89b9f0
                                      Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\r\n    </p>\r\n");
#nullable restore
<<<<<<< HEAD
#line 15 "C:\ColDevpss\ParkinLot.App\ParkinLot.App.Frontend\Pages\Error.cshtml"
=======
#line 15 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\Error.cshtml"
>>>>>>> 7c3b33d8b46e4800595aa0285434400b6b89b9f0
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Development Mode</h3>
<p>
    Swapping to the <strong>Development</strong> environment displays detailed information about the error that occurred.
</p>
<p>
    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel>)PageContext?.ViewData;
        public ErrorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
