#pragma checksum "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\GestorVehiculo\ListaVehiculos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf4460456f8896f521d8121b7ee62926e879bc51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ParkinLot.App.Frontend.Pages.GestorVehiculo.Pages_GestorVehiculo_ListaVehiculos), @"mvc.1.0.razor-page", @"/Pages/GestorVehiculo/ListaVehiculos.cshtml")]
namespace ParkinLot.App.Frontend.Pages.GestorVehiculo
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf4460456f8896f521d8121b7ee62926e879bc51", @"/Pages/GestorVehiculo/ListaVehiculos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"242a1b8db319a713d77cd308ea2d3d2c91d49b8b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_GestorVehiculo_ListaVehiculos : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AgregarVehiculo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h1>Gestión de vehículos</h1>\r\n<p>En esta página podrás gestionar los vehículos</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf4460456f8896f521d8121b7ee62926e879bc513833", async() => {
                WriteLiteral("Agregar vehículo");
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
            <th scope=""col"">Marca</th>
            <th scope=""col"">Modelo</th>
            <th scope=""col"">Color</th>
            <th scope=""col"">Placa</th>
            <th scope=""col"">Defectos</th>
            <th scope=""col"">Tipo de vehículo</th>
            <th scope=""col"">Dueño del vehículo</th>

        </tr>
    </thead>
");
#nullable restore
#line 21 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\GestorVehiculo\ListaVehiculos.cshtml"
     foreach (var vehiculo in Model.Vehiculos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\GestorVehiculo\ListaVehiculos.cshtml"
           Write(vehiculo.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\GestorVehiculo\ListaVehiculos.cshtml"
           Write(vehiculo.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\GestorVehiculo\ListaVehiculos.cshtml"
           Write(vehiculo.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\GestorVehiculo\ListaVehiculos.cshtml"
           Write(vehiculo.Placa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\GestorVehiculo\ListaVehiculos.cshtml"
           Write(vehiculo.Defectos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\GestorVehiculo\ListaVehiculos.cshtml"
           Write(vehiculo.TipoVehiculo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\GestorVehiculo\ListaVehiculos.cshtml"
           Write(vehiculo.DuenoVehiculo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\MinTic\DS_C3\Final\ColDevps\ParkinLot.App\ParkinLot.App.Frontend\Pages\GestorVehiculo\ListaVehiculos.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ParkinLot.App.Frontend.Pages.ListaVehiculosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ParkinLot.App.Frontend.Pages.ListaVehiculosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ParkinLot.App.Frontend.Pages.ListaVehiculosModel>)PageContext?.ViewData;
        public ParkinLot.App.Frontend.Pages.ListaVehiculosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
