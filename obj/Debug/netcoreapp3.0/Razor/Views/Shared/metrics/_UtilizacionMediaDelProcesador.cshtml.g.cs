#pragma checksum "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Shared/metrics/_UtilizacionMediaDelProcesador.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb3b67fae66a82c31b8f81221e95b4dd60129d98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_metrics__UtilizacionMediaDelProcesador), @"mvc.1.0.view", @"/Views/Shared/metrics/_UtilizacionMediaDelProcesador.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb3b67fae66a82c31b8f81221e95b4dd60129d98", @"/Views/Shared/metrics/_UtilizacionMediaDelProcesador.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da37262815d4aba60c4665b8ff809b0c1925021c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_metrics__UtilizacionMediaDelProcesador : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h3>
    <strong>Métrica: </strong> Utilización media del procesador
</h3>
<div class=""table-responsive"">
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th scope=""col"">Métrica</th>
                <th scope=""col"">Descripción</th>
                <th scope=""col"">Propósito de la métrica</th>
                <th scope=""col"">Función de medida</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>Utilización media del procesador</td>
                <td>¿Cuánto tiempo de procesador se usa para ejecutar un conjunto determinado de tareas en comparación con el tiempo de operación?</td>
                <td>Determinar el tiempo de procesador en comparacion con el tiempo de operacion para un conjunto de tareas del ORM</td>
                <td>
                    <img src=""/images/formulas/otros.png""><br>
                    Ai = El tiempo del procesador que realmente se usa para ejecutar un conjunto dado de tareas en ");
            WriteLiteral("la observación<br>\r\n                    Bi = Tiempo de operación para realizar las tareas en observación<br>\r\n                    n = Numero de observaciones<br>\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n</div>");
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