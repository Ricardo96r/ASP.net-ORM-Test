#pragma checksum "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/UtilizacionMediaDelProcesador.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83e84af6fb55f047118251744580605ce86692f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Metric_UtilizacionMediaDelProcesador), @"mvc.1.0.view", @"/Views/Metric/UtilizacionMediaDelProcesador.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83e84af6fb55f047118251744580605ce86692f7", @"/Views/Metric/UtilizacionMediaDelProcesador.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da37262815d4aba60c4665b8ff809b0c1925021c", @"/Views/_ViewImports.cshtml")]
    public class Views_Metric_UtilizacionMediaDelProcesador : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/Metrics/_CantidadMediaDeMemoriaUtilizada.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/metrics/CantidadMediaDeMemoriaUtilizada.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\n    <div class=\"col\">\n        <h1>Utilización de recursos</h1>\n    </div>\n</div>\n<hr />\n<div class=\"row\">\n    <div class=\"col\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "83e84af6fb55f047118251744580605ce86692f74513", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        <h3>Código</h3>\n        <hr />\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "83e84af6fb55f047118251744580605ce86692f75661", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        <h3>Anotaciones</h3>
        <hr />
        <p>Para obtener los resultados para la metrica de <strong>cantidad media de memoria utilizada</strong> se tuvo que usar la libreria <code>Stopwatch</code> para medir el tiempo que tarda una peticion simple al ORM, el tiempo medido es en milisegundos, ademas se utilizó la librería <code>GC (Garbage collector)</code> para obtener la cantidad de memoria usada</p>
        <p>La peticion simple realizada con el Entity Framework fue traer un estudiante de la base de datos a traves de su ID <code>context.Students.Find(1);</code>. Por lo cual para que funcione el cache se debe de traer el mismo ID del estudiante ya que se buscó con anterioridad y asi no utiliza los recursos de la computadora sin necesidad</p>
        <p>Se puede observar la cantidad de tiempo de procesamiento que toma la peticion del Entity Framework y la cantidad de memoria usada para determinar si la peticion del Entity Framework fue usada con cache o no</p>
        <h3>Resultados</h3>
        <");
            WriteLiteral(@"hr />
        <div class=""row"">
            <div class=""col-xs-3"">
                <h4>Tiempo de procesador (ms)</h4>
                <table class=""table"">
                    <tr>
                        <th>#</th>
                        <th>Miliseconds</th>
                    </tr>

");
#nullable restore
#line 30 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/UtilizacionMediaDelProcesador.cshtml"
                      int i = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/UtilizacionMediaDelProcesador.cshtml"
                     foreach (var item in ViewBag.processorList)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 34 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/UtilizacionMediaDelProcesador.cshtml"
                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 35 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/UtilizacionMediaDelProcesador.cshtml"
                   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 37 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/UtilizacionMediaDelProcesador.cshtml"
i++;
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </table>
            </div>
            <div class=""col-xs-3"">
                <h4>Tiempo de operacion (ms)</h4>

                <table class=""table"">
                    <tr>
                        <th>bytes</th>
                    </tr>


");
#nullable restore
#line 51 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/UtilizacionMediaDelProcesador.cshtml"
                     foreach (var item in ViewBag.operationList)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n\n                    <td>");
#nullable restore
#line 55 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/UtilizacionMediaDelProcesador.cshtml"
                   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 57 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/UtilizacionMediaDelProcesador.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </table>\n            </div>\n            <div class=\"col-xs-6\">\n                <h4>Utilización de cache</h4>\n                <p><strong>Cantidad de llamadas totales: </strong>");
#nullable restore
#line 63 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/UtilizacionMediaDelProcesador.cshtml"
                                                             Write(ViewBag.processorList.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p><strong>X = </strong> ");
#nullable restore
#line 64 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/UtilizacionMediaDelProcesador.cshtml"
                                    Write(ViewBag.xResult);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <hr />\n                <h4>Tiempo de procesador (ms)</h4>\n                <p><strong>Promedio: </strong>");
#nullable restore
#line 67 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/UtilizacionMediaDelProcesador.cshtml"
                                         Write(ViewBag.processorAverage);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ms</p>\n                <p><strong>Desviación estandar: </strong>");
#nullable restore
#line 68 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/UtilizacionMediaDelProcesador.cshtml"
                                                    Write(ViewBag.processorStdDev);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ms</p>\n                <p><strong>Error: </strong>");
#nullable restore
#line 69 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/UtilizacionMediaDelProcesador.cshtml"
                                      Write(ViewBag.processorStandardError);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ms</p>\n                <hr />\n                <h4>Tiempo de operacion (ms)</h4>\n                <p><strong>Promedio: </strong>");
#nullable restore
#line 72 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/UtilizacionMediaDelProcesador.cshtml"
                                         Write(ViewBag.operationAverage);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ms</p>\n                <p><strong>Desviación estandar: </strong>");
#nullable restore
#line 73 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/UtilizacionMediaDelProcesador.cshtml"
                                                    Write(ViewBag.operationStdDev);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ms</p>\n                <p><strong>Error: </strong>");
#nullable restore
#line 74 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/UtilizacionMediaDelProcesador.cshtml"
                                      Write(ViewBag.operationStandardError);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ms</p>\n\n            </div>\n        </div>\n    </div>\n</div>");
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