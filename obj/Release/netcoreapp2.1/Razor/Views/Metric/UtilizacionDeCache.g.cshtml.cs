#pragma checksum "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/UtilizacionDeCache.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bd46438658270b29d82edeb739db935b8874636"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Metric_UtilizacionDeCache), @"mvc.1.0.view", @"/Views/Metric/UtilizacionDeCache.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Metric/UtilizacionDeCache.cshtml", typeof(AspNetCore.Views_Metric_UtilizacionDeCache))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bd46438658270b29d82edeb739db935b8874636", @"/Views/Metric/UtilizacionDeCache.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11ed6bd661fc0c13f71723e229b91d3b9cc6ef97", @"/Views/_ViewImports.cshtml")]
    public class Views_Metric_UtilizacionDeCache : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/Metrics/_UtilizacionDeCache.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/metrics/cache.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 154, true);
            WriteLiteral("<div class=\"row\">\n    <div class=\"col\">\n        <h1>Utilización de recursos</h1>\n    </div>\n</div>\n<hr />\n<div class=\"row\">\n    <div class=\"col\">\n        ");
            EndContext();
            BeginContext(154, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b2f84ee967d54033b700eac038609dcb", async() => {
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
            EndContext();
            BeginContext(222, 48, true);
            WriteLiteral("\n        <h3>Código</h3>\n        <hr />\n        ");
            EndContext();
            BeginContext(270, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "61395654c8b743b897a9dea089332f65", async() => {
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
            EndContext();
            BeginContext(322, 1289, true);
            WriteLiteral(@"

        <h3>Anotaciones</h3>
        <hr />
        <p>Para obtener los resultados para la metrica de <strong>utilización de cache</strong> se tuvo que usar la libreria <code>Stopwatch</code> para medir el tiempo que tarda una peticion simple al ORM, el tiempo medido es en milisegundos, ademas se utilizó la librería <code>GC (Garbage collector)</code> para obtener la cantidad de memoria usada</p>
        <p>La peticion simple realizada con el Entity Framework fue traer un estudiante de la base de datos a traves de su ID <code>context.Students.Find(1);</code>. Por lo cual para que funcione el cache se debe de traer el mismo ID del estudiante ya que se buscó con anterioridad y asi no utiliza los recursos de la computadora sin necesidad</p>
        <p>Se puede observar la cantidad de tiempo de procesamiento que toma la peticion del Entity Framework y la cantidad de memoria usada para determinar si la peticion del Entity Framework fue usada con cache o no</p>
        <h3>Resultados</h3>
        <hr />
        <");
            WriteLiteral(@"div class=""row"">
            <div class=""col-xs-3"">
                <h4>Tiempo (ms)</h4>
                <table class=""table"">
                    <tr>
                        <th>#</th>
                        <th>Miliseconds</th>
                    </tr>

");
            EndContext();
#line 30 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/UtilizacionDeCache.cshtml"
                      int i = 1;

#line default
#line hidden
            BeginContext(1646, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 31 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/UtilizacionDeCache.cshtml"
                     foreach (var item in ViewBag.msList)
    {

#line default
#line hidden
            BeginContext(1712, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1759, 1, false);
#line 34 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/UtilizacionDeCache.cshtml"
                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1760, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1792, 4, false);
#line 35 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/UtilizacionDeCache.cshtml"
                   Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(1796, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 37 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/UtilizacionDeCache.cshtml"
i++;
}

#line default
#line hidden
            BeginContext(1835, 256, true);
            WriteLiteral(@"
                </table>
            </div>
            <div class=""col-xs-3"">
                <h4>Memoria (kb)</h4>

                <table class=""table"">
                    <tr>
                        <th>bytes</th>
                    </tr>


");
            EndContext();
#line 51 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/UtilizacionDeCache.cshtml"
                     foreach (var item in ViewBag.kbList)
    {

#line default
#line hidden
            BeginContext(2157, 48, true);
            WriteLiteral("                <tr>\r\n\r\n                    <td>");
            EndContext();
            BeginContext(2206, 4, false);
#line 55 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/UtilizacionDeCache.cshtml"
                   Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(2210, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 57 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/UtilizacionDeCache.cshtml"
}

#line default
#line hidden
            BeginContext(2243, 193, true);
            WriteLiteral("\r\n                </table>\n            </div>\n            <div class=\"col-xs-6\">\n                <h4>Utilización de cache</h4>\n                <p><strong>Cantidad de llamadas totales: </strong>");
            EndContext();
            BeginContext(2437, 20, false);
#line 63 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/UtilizacionDeCache.cshtml"
                                                             Write(ViewBag.msList.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2457, 311, true);
            WriteLiteral(@"</p>
                <p><strong>Cantidad de llamadas con cache: </strong>99</p>
                <p><strong>Cantidad de llamadas sin cache: </strong>1</p>
                <p><strong>Tasa: </strong>0.99</p>
                <hr />
                <h4>Tiempo (ms)</h4>
                <p><strong>Promedio: </strong>");
            EndContext();
            BeginContext(2769, 17, false);
#line 69 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/UtilizacionDeCache.cshtml"
                                         Write(ViewBag.msAverage);

#line default
#line hidden
            EndContext();
            BeginContext(2786, 65, true);
            WriteLiteral(" ms</p>\n                <p><strong>Desviación estandar: </strong>");
            EndContext();
            BeginContext(2852, 16, false);
#line 70 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/UtilizacionDeCache.cshtml"
                                                    Write(ViewBag.msStdDev);

#line default
#line hidden
            EndContext();
            BeginContext(2868, 51, true);
            WriteLiteral(" ms</p>\n                <p><strong>Error: </strong>");
            EndContext();
            BeginContext(2920, 23, false);
#line 71 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/UtilizacionDeCache.cshtml"
                                      Write(ViewBag.msStandardError);

#line default
#line hidden
            EndContext();
            BeginContext(2943, 115, true);
            WriteLiteral(" ms</p>\n                <hr />\n                <h4>Memoria (ms)</h4>\n                <p><strong>Promedio: </strong>");
            EndContext();
            BeginContext(3059, 17, false);
#line 74 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/UtilizacionDeCache.cshtml"
                                         Write(ViewBag.kbAverage);

#line default
#line hidden
            EndContext();
            BeginContext(3076, 65, true);
            WriteLiteral(" ms</p>\n                <p><strong>Desviación estandar: </strong>");
            EndContext();
            BeginContext(3142, 16, false);
#line 75 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/UtilizacionDeCache.cshtml"
                                                    Write(ViewBag.kbStdDev);

#line default
#line hidden
            EndContext();
            BeginContext(3158, 51, true);
            WriteLiteral(" ms</p>\n                <p><strong>Error: </strong>");
            EndContext();
            BeginContext(3210, 23, false);
#line 76 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/UtilizacionDeCache.cshtml"
                                      Write(ViewBag.kbStandardError);

#line default
#line hidden
            EndContext();
            BeginContext(3233, 60, true);
            WriteLiteral(" ms</p>\n\n            </div>\n        </div>\n    </div>\n</div>");
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
