#pragma checksum "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Shared/metrics/_UtilizacionDeMemoria.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ec4130f6b8a048f8d08ef0a00b8efcc3143df4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_metrics__UtilizacionDeMemoria), @"mvc.1.0.view", @"/Views/Shared/metrics/_UtilizacionDeMemoria.cshtml")]
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
#line 1 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/_ViewImports.cshtml"
using asp3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/_ViewImports.cshtml"
using asp3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ec4130f6b8a048f8d08ef0a00b8efcc3143df4d", @"/Views/Shared/metrics/_UtilizacionDeMemoria.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da37262815d4aba60c4665b8ff809b0c1925021c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_metrics__UtilizacionDeMemoria : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h3>
    <strong>Métrica: </strong> Utilización de la memoria
</h3>
<div class=""table-responsive"">
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">Propósito de la métrica</th>
                <th scope=""col"">Método de aplicación</th>
                <th scope=""col"">Fórmula</th>
                <th scope=""col"">Interpretación</th>
                <th scope=""col""> Tipo de medida</th>
                <th scope=""col"">Origen de la medida</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>Determinar el tamaño de memoria que se utiliza para recibir una respuesta a una operación atómica.</td>
                <td>Determinar la cantidad de memoria usada por el Entity Framework.</td>
                <td>X = tamaño en bytes (calculado)</td>
                <td>Mientras menor sea el valor, mejor.</td>
                <td>X = bytes</td>
                <td>Tamaño en memoria de la respuesta de una operación atómica</td>
            </tr>
   ");
            WriteLiteral("     </tbody>\n    </table>\n</div>");
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