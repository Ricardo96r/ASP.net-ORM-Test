#pragma checksum "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/Capacidad.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "084ad575250524fbbf3f0375621f02af0e49eb72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Metric_Capacidad), @"mvc.1.0.view", @"/Views/Metric/Capacidad.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Metric/Capacidad.cshtml", typeof(AspNetCore.Views_Metric_Capacidad))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"084ad575250524fbbf3f0375621f02af0e49eb72", @"/Views/Metric/Capacidad.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11ed6bd661fc0c13f71723e229b91d3b9cc6ef97", @"/Views/_ViewImports.cshtml")]
    public class Views_Metric_Capacidad : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/Metrics/_Capacidad.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/metrics/capacidad.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 153, true);
            WriteLiteral("<div class=\"row\">\n    <div class=\"col\">\n        <h1>Capacidad del software</h1>\n    </div>\n</div>\n<hr />\n<div class=\"row\">\n    <div class=\"col\">\n        ");
            EndContext();
            BeginContext(153, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4ff64afce25f469593dd3fbc02c2a61f", async() => {
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
            BeginContext(212, 48, true);
            WriteLiteral("\n        <h3>Código</h3>\n        <hr />\n        ");
            EndContext();
            BeginContext(260, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bc5b71c098664d1e85aea7ed5a86faf4", async() => {
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
            BeginContext(316, 469, true);
            WriteLiteral(@"

        <h3>Anotaciones</h3>
        <hr />
        <p>Para obtener los resultados para la métrica de <strong>capacidad</strong> se tuvo que usar la libreria <code>Stopwatch</code> para medir el tiempo que tarda una peticion simple al ORM, el tiempo medido es en milisegundos.</p>
        <p>La peticion simple realizada con el Entity Framework fue traer un estudiante de la base de datos a traves de su ID <code>context.Students.Find(i);</code> Se repite el proceso ");
            EndContext();
            BeginContext(786, 20, false);
#line 17 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/Capacidad.cshtml"
                                                                                                                                                                                     Write(ViewBag.msList.Count);

#line default
#line hidden
            EndContext();
            BeginContext(806, 11, true);
            WriteLiteral(" veces con ");
            EndContext();
            BeginContext(818, 20, false);
#line 17 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/Capacidad.cshtml"
                                                                                                                                                                                                                     Write(ViewBag.msList.Count);

#line default
#line hidden
            EndContext();
            BeginContext(838, 287, true);
            WriteLiteral(@" estudiantes diferentes.</p>
        <p>Se puede ver que el Entity Framework logra terminar todas las tareas encoladas y dependera de la capacidad del computador para realizarlas</p>
        <h3>Resultados</h3>
        <hr />
        <div class=""row"">
            <div class=""col-xs-6"">
");
            EndContext();
#line 23 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/Capacidad.cshtml"
                  int i = 1;

#line default
#line hidden
            BeginContext(1155, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 24 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/Capacidad.cshtml"
                 foreach (var item in ViewBag.msList)
            {

#line default
#line hidden
            BeginContext(1223, 19, true);
            WriteLiteral("                <p>");
            EndContext();
            BeginContext(1243, 1, false);
#line 26 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/Capacidad.cshtml"
              Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1244, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1248, 4, false);
#line 26 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/Capacidad.cshtml"
                   Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(1252, 9, true);
            WriteLiteral(" ms </p>\n");
            EndContext();
#line 27 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/Capacidad.cshtml"
            i++;
        }

#line default
#line hidden
            BeginContext(1288, 159, true);
            WriteLiteral("            </div>\n            <div class=\"col-xs-6\">\n                <h4>Capacidad</h4>\n                <p><strong>Cantidad de peticiones con éxito: </strong>");
            EndContext();
            BeginContext(1448, 20, false);
#line 32 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/Capacidad.cshtml"
                                                                 Write(ViewBag.msList.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1468, 76, true);
            WriteLiteral("</p>\n                <p><strong>Cantidad de peticiones realizadas: </strong>");
            EndContext();
            BeginContext(1545, 20, false);
#line 33 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/Capacidad.cshtml"
                                                                  Write(ViewBag.msList.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1565, 159, true);
            WriteLiteral("</p>\n                <p><strong>Tasa: </strong>1</p>\n                <hr />\n                <h4>Tiempo (ms)</h4>\n                <p><strong>Promedio: </strong>");
            EndContext();
            BeginContext(1725, 17, false);
#line 37 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/Capacidad.cshtml"
                                         Write(ViewBag.msAverage);

#line default
#line hidden
            EndContext();
            BeginContext(1742, 65, true);
            WriteLiteral(" ms</p>\n                <p><strong>Desviación estandar: </strong>");
            EndContext();
            BeginContext(1808, 16, false);
#line 38 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/Capacidad.cshtml"
                                                    Write(ViewBag.msStdDev);

#line default
#line hidden
            EndContext();
            BeginContext(1824, 51, true);
            WriteLiteral(" ms</p>\n                <p><strong>Error: </strong>");
            EndContext();
            BeginContext(1876, 23, false);
#line 39 "/Users/ricardorodriguez/Documents/PROYECTOS/ASP.net-ORM-Test/Views/Metric/Capacidad.cshtml"
                                      Write(ViewBag.msStandardError);

#line default
#line hidden
            EndContext();
            BeginContext(1899, 59, true);
            WriteLiteral(" ms</p>\n            </div>\n        </div>\n    </div>\n</div>");
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