#pragma checksum "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f924dee5bd3568c7e1cf4207b11d19931c5c553b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CTRestaurant.App.Frontend.Pages.Listas.Pages_Listas_Eliminar), @"mvc.1.0.razor-page", @"/Pages/Listas/Eliminar.cshtml")]
namespace CTRestaurant.App.Frontend.Pages.Listas
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
#line 1 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\_ViewImports.cshtml"
using CTRestaurant.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f924dee5bd3568c7e1cf4207b11d19931c5c553b", @"/Pages/Listas/Eliminar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5be17943c42a4face8beb0e494631c52be4975fc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Listas_Eliminar : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
     switch (@Model.item)
    {
        case 1:
            ViewData["Title"] = "Eliminar Profesor";
            break;
        case 2:
            ViewData["Title"] = "Eliminar Registro";
            break;
        case 3:
            ViewData["Title"] = "Eliminar Administrativo";
            break;
        case 4:
            ViewData["Title"] = "Eliminar Estudiante";
            break;
        case 5:
            ViewData["Title"] = "Eliminar Personal Aseo";
            break;
        default:
            break;
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
 switch (@Model.item)
{
    case 1:


#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Desea Eliminar el profesor</h1>\r\n        <table class=\"table\">\r\n            <tr>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.profesor.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.profesor.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.profesor.Facultad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.profesor.Cubiculo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.profesor.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.profesor.estadoCovid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n        </table>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f924dee5bd3568c7e1cf4207b11d19931c5c553b6923", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f924dee5bd3568c7e1cf4207b11d19931c5c553b7193", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 43 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.profesor.id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-primary\">Confirmar Eliminar</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
        break;
    case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Eliminar Registro ");
#nullable restore
#line 48 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
                         Write(Model.registro.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
        <table class=""table"" style=""text-align:center;"">
            <tr>

                <th>Fecha</th>
                <th>Aforo</th>
                <th>Cantidad Mesas</th>
                <th>Puestos Por Mesa</th>
            </tr>
            <tr>
                <td>");
#nullable restore
#line 58 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.registro.FechaRegistro.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 59 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.registro.Aforo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 60 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.registro.CantidadMesas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 61 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.registro.PuestosPorMesa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n        </table>\r\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f924dee5bd3568c7e1cf4207b11d19931c5c553b12430", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f924dee5bd3568c7e1cf4207b11d19931c5c553b12701", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 67 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.registro.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input class=\"btn btn-primary\" type=\"button\" onclick=\"history.back()\" name=\"volver atrás\" value=\"Volver Atrás\">\r\n            <button type=\"submit\" class=\"btn btn-danger\">Confirmar Eliminar</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 71 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
        break;
    case 3:


#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Desea Eliminar el administrativo</h1>\r\n        <table class=\"table\">\r\n            <tr>\r\n                <td>");
#nullable restore
#line 77 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.administrativo.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 78 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.administrativo.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 79 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.administrativo.Oficina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 80 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.administrativo.Dependencia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 81 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.administrativo.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 82 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.administrativo.estadoCovid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n        </table>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f924dee5bd3568c7e1cf4207b11d19931c5c553b18188", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f924dee5bd3568c7e1cf4207b11d19931c5c553b18459", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 87 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.administrativo.id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-primary\">Confirmar Eliminar</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 90 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
        break;
     case 4:


#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Desea Eliminar el Estudiante</h1>\r\n        <table class=\"table\">\r\n            <tr>\r\n                <td>");
#nullable restore
#line 96 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.estudiante.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 97 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.estudiante.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 98 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.estudiante.Programa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 99 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.estudiante.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 100 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.estudiante.estadoCovid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n        </table>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f924dee5bd3568c7e1cf4207b11d19931c5c553b23474", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f924dee5bd3568c7e1cf4207b11d19931c5c553b23745", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 105 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.estudiante.id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-primary\">Confirmar Eliminar</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 108 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
        break;
         case 5:


#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Desea Eliminar el Personal de Aseo</h1>\r\n        <table class=\"table\">\r\n            <tr>\r\n                <td>");
#nullable restore
#line 114 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.personalAseo.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 115 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.personalAseo.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 116 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.personalAseo.Turno_servcio_aseo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 117 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.personalAseo.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 118 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
               Write(Model.personalAseo.estadoCovid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n        </table>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f924dee5bd3568c7e1cf4207b11d19931c5c553b28792", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f924dee5bd3568c7e1cf4207b11d19931c5c553b29063", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 123 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.personalAseo.id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-primary\">Confirmar Eliminar</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 126 "C:\Users\blanca\Desktop\Restaurante UC\CyberTeam5\CTRestaurant.App\CTRestaurant.App.Frontend\Pages\Listas\Eliminar.cshtml"
        break;
    default:
        break;
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CTRestaurant.App.Frontend.Pages.EliminarModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CTRestaurant.App.Frontend.Pages.EliminarModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CTRestaurant.App.Frontend.Pages.EliminarModel>)PageContext?.ViewData;
        public CTRestaurant.App.Frontend.Pages.EliminarModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
