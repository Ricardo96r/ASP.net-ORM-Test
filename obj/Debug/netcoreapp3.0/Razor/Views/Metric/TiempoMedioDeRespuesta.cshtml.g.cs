#pragma checksum "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/TiempoMedioDeRespuesta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc853f36a231f099f2298ee05321d6374881a977"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Metric_TiempoMedioDeRespuesta), @"mvc.1.0.view", @"/Views/Metric/TiempoMedioDeRespuesta.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc853f36a231f099f2298ee05321d6374881a977", @"/Views/Metric/TiempoMedioDeRespuesta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da37262815d4aba60c4665b8ff809b0c1925021c", @"/Views/_ViewImports.cshtml")]
    public class Views_Metric_TiempoMedioDeRespuesta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/Metrics/_TiempoMedioDeRespuesta.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/metrics/TiempoMedioDeRespuesta.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"row\">\n    <div class=\"col\">\n        <h1>Comportamiento temporal</h1>\n    </div>\n</div>\n<hr /> \n<div class=\"row\">\n    <div class=\"col\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bc853f36a231f099f2298ee05321d6374881a9774461", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bc853f36a231f099f2298ee05321d6374881a9775609", async() => {
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
        <p>Para obtener los resultados para la metrica de <strong>tiempo de respuesta</strong> se tuvo que usar la libreria <code>Stopwatch</code> para medir el tiempo que tarda una peticion simple al ORM, el tiempo medido es en milisegundos.</p>
        <p>La peticion simple realizada con el Entity Framework fue traer un estudiante de la base de datos a traves de su ID <code>context.Students.Find(i);</code> Se repite el proceso ");
#nullable restore
#line 17 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/TiempoMedioDeRespuesta.cshtml"
                                                                                                                                                                                     Write(ViewBag.msList.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" veces con ");
#nullable restore
#line 17 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/TiempoMedioDeRespuesta.cshtml"
                                                                                                                                                                                                                     Write(ViewBag.msList.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" estudiantes diferentes.</p>
        <h3>Resultados</h3>
        <hr />
        <div class=""row"">
            <div class=""col-xs-6"">
                <h4>Tiempo (ms)</h4>
                <table class=""table"">
                    <tr>
                        <th>#</th>
                        <th>Miliseconds</th>
                    </tr>

");
#nullable restore
#line 29 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/TiempoMedioDeRespuesta.cshtml"
                      int i = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/TiempoMedioDeRespuesta.cshtml"
                     foreach (var item in ViewBag.msList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 33 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/TiempoMedioDeRespuesta.cshtml"
                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 34 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/TiempoMedioDeRespuesta.cshtml"
                           Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 36 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/TiempoMedioDeRespuesta.cshtml"
                    i++;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\n                </div>\n            <div class=\"col-xs-6\">\n                <h4>Tiempo de respuesta</h4>\n                <h5><strong>X = </strong>");
#nullable restore
#line 42 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/TiempoMedioDeRespuesta.cshtml"
                                    Write(ViewBag.xResult);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                <p><strong>Cantidad de pruebas: </strong>");
#nullable restore
#line 43 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/TiempoMedioDeRespuesta.cshtml"
                                                    Write(ViewBag.msList.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p><strong>Promedio: </strong>");
#nullable restore
#line 44 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/TiempoMedioDeRespuesta.cshtml"
                                         Write(ViewBag.msAverage);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ms</p>\n                <p><strong>Desviación estandar: </strong>");
#nullable restore
#line 45 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/TiempoMedioDeRespuesta.cshtml"
                                                    Write(ViewBag.msStdDev);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ms</p>\n                <p><strong>Error: </strong>");
#nullable restore
#line 46 "/Users/ricardorodriguez/Documents/PROYECTOS/asp3/Views/Metric/TiempoMedioDeRespuesta.cshtml"
                                      Write(ViewBag.msStandardError);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ms</p>\n            </div>\n        </div>\n\n    </div>\n</div>");
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
