#pragma checksum "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Shared/metrics/_UtilizacionDeCache.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd7db5cbda2ed11eb1ac6fe92e95c5dae3d623cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_metrics__UtilizacionDeCache), @"mvc.1.0.view", @"/Views/Shared/metrics/_UtilizacionDeCache.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/metrics/_UtilizacionDeCache.cshtml", typeof(AspNetCore.Views_Shared_metrics__UtilizacionDeCache))]
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
#line 1 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/_ViewImports.cshtml"
using ASP.net_ORM_Test;

#line default
#line hidden
#line 2 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/_ViewImports.cshtml"
using ASP.net_ORM_Test.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd7db5cbda2ed11eb1ac6fe92e95c5dae3d623cc", @"/Views/Shared/metrics/_UtilizacionDeCache.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11ed6bd661fc0c13f71723e229b91d3b9cc6ef97", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_metrics__UtilizacionDeCache : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1096, true);
            WriteLiteral(@"<h3>
    <strong>Métrica: </strong> Utilización de caché
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
                <td>Determinar cuántas veces el caché es utilizado para realizar las mismas acciones.</td>
                <td>Determinar la utilidad de caché en el Entity Framework</td>
                <td>X = llamadas que utilizaron caché / llamadas totales</td>
                <td>Mientras mayor sea la tasa, mejor</td>
                <td>X = tasa</td>
                <td>Cantidad de operaciones que se registraron en el sistema y cantidad de llamadas que utilizaron el u");
            WriteLiteral("so del caché</td>\n            </tr>\n        </tbody>\n    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
