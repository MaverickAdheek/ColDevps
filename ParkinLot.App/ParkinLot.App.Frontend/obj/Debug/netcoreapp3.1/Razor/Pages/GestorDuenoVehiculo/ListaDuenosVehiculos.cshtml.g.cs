#pragma checksum "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\GestorDuenoVehiculo\ListaDuenosVehiculos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c281f2e500f39b0e8bed97f8523141846aba2362"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ParkinLot.App.Frontend.Pages.GestorDuenoVehiculo.Pages_GestorDuenoVehiculo_ListaDuenosVehiculos), @"mvc.1.0.razor-page", @"/Pages/GestorDuenoVehiculo/ListaDuenosVehiculos.cshtml")]
namespace ParkinLot.App.Frontend.Pages.GestorDuenoVehiculo
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
#line 1 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\_ViewImports.cshtml"
using ParkinLot.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c281f2e500f39b0e8bed97f8523141846aba2362", @"/Pages/GestorDuenoVehiculo/ListaDuenosVehiculos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"242a1b8db319a713d77cd308ea2d3d2c91d49b8b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_GestorDuenoVehiculo_ListaDuenosVehiculos : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AgregarDuenoVehiculo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Gestión de Clientes</h1>\r\n<p>En esta página podrás gestionar los Clientes</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c281f2e500f39b0e8bed97f8523141846aba23623901", async() => {
                WriteLiteral("Agregar Cliente");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">Nombres</th>
            <th scope=""col"">Apellidos</th>
            <th scope=""col"">Documento</th>
            <th scope=""col"">Usuario</th>
            <th scope=""col"">Contraseña</th>
            <th scope=""col"">Dirección</th>
            <th scope=""col"">Teléfono</th>
            <th scope=""col"">Fecha de nacimiento</th>
        </tr>
    </thead>
");
#nullable restore
#line 21 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\GestorDuenoVehiculo\ListaDuenosVehiculos.cshtml"
     foreach (var duenoVehiculo in Model.DuenosVehiculos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\GestorDuenoVehiculo\ListaDuenosVehiculos.cshtml"
           Write(duenoVehiculo.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\GestorDuenoVehiculo\ListaDuenosVehiculos.cshtml"
           Write(duenoVehiculo.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\GestorDuenoVehiculo\ListaDuenosVehiculos.cshtml"
           Write(duenoVehiculo.Documento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\GestorDuenoVehiculo\ListaDuenosVehiculos.cshtml"
           Write(duenoVehiculo.Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\GestorDuenoVehiculo\ListaDuenosVehiculos.cshtml"
           Write(duenoVehiculo.Contrasena);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\GestorDuenoVehiculo\ListaDuenosVehiculos.cshtml"
           Write(duenoVehiculo.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\GestorDuenoVehiculo\ListaDuenosVehiculos.cshtml"
           Write(duenoVehiculo.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\GestorDuenoVehiculo\ListaDuenosVehiculos.cshtml"
           Write(duenoVehiculo.FechaNacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\GestorDuenoVehiculo\ListaDuenosVehiculos.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ParkinLot.App.Frontend.Pages.ListaDuenosVehiculosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ParkinLot.App.Frontend.Pages.ListaDuenosVehiculosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ParkinLot.App.Frontend.Pages.ListaDuenosVehiculosModel>)PageContext?.ViewData;
        public ParkinLot.App.Frontend.Pages.ListaDuenosVehiculosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
