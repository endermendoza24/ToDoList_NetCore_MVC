#pragma checksum "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecb5100b621fd63b62cd74f9eaa741d18c763284"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tareas_Index), @"mvc.1.0.view", @"/Views/Tareas/Index.cshtml")]
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
#line 1 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\_ViewImports.cshtml"
using ListaToDo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\_ViewImports.cshtml"
using ListaToDo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecb5100b621fd63b62cd74f9eaa741d18c763284", @"/Views/Tareas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4ae196609c74a34ea85227679f21626a9b25ba6", @"/Views/_ViewImports.cshtml")]
    public class Views_Tareas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListaToDo.ViewModels.TareasViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/tareas.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/push.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecb5100b621fd63b62cd74f9eaa741d18c7632845376", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>Lista tareas</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ecb5100b621fd63b62cd74f9eaa741d18c7632845705", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecb5100b621fd63b62cd74f9eaa741d18c7632847588", async() => {
                WriteLiteral("\r\n\r\n    <h1 style=\"font-size:30px; color:#fff; font-weight:700; padding:10px; text-transform:uppercase; text-align:center;\">📗📗📗  Lista de tareas por hacer 📗📗📗</h1>\r\n    \r\n    <div class=\"container\">\r\n\r\n        ");
#nullable restore
#line 18 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
   Write(TempData["Hola"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("  \r\n\r\n");
#nullable restore
#line 20 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
         if (TempData["mensaje"] != null)
        {


#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"alert alert-success  alert-dismissible fade show\" role=\"alert\">\r\n\r\n                ");
#nullable restore
#line 25 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
           Write(TempData["mensaje"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                    <span aria-hidden=\"true\">&times;</span>\r\n                </button>\r\n\r\n            </div>\r\n");
#nullable restore
#line 31 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
         if (TempData["Error"] != null)
        {


#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"alert alert-danger  alert-dismissible fade show\" role=\"alert\">\r\n\r\n                ");
#nullable restore
#line 38 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
           Write(TempData["Error"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                    <span aria-hidden=\"true\">&times;</span>\r\n                </button>\r\n\r\n            </div>\r\n");
#nullable restore
#line 44 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

        <div class=""row"">
            <div class=""col-md-12"">

                <div class=""alert alert-success"" style=""display:none;"">
                    <span class=""glyphicon glyphicon-ok""></span> Drag table row and cange Order
                </div>
                <table class=""table table-striped table-dark"">
                    <thead>
                        <tr class=""warning"">
                            <td colspan=""6"">
                                <br>
");
#nullable restore
#line 58 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                                 using (var form = Html.BeginForm("CrearActualizar", "Tareas", FormMethod.Post))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                               Write(Html.HiddenFor(model => model.EditableItem.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"contenedor-inputs\">\r\n\r\n                                <div class=\"wrapper\">\r\n                                    ");
#nullable restore
#line 65 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                               Write(Html.TextBoxFor(model => model.EditableItem.Titulo, new { placeholder = "Agregar tarea" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("                                </div>\r\n\r\n                                <div class=\"prioridad\">\r\n                                    ");
#nullable restore
#line 70 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                               Write(Html.DropDownListFor(model => model.EditableItem.Prioridad, new List<SelectListItem> // esto rellena el select con datos estaticos

                                   {
                                   new SelectListItem{Text="Baja", Value="Baja"},
                                   new SelectListItem{Text="Media", Value="Media"},
                                   new SelectListItem{Text="Alta", Value="Alta"}


                                       }, new { @class = "selector" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n\r\n                                <div class=\"fecha\">\r\n                                    ");
#nullable restore
#line 82 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                               Write(Html.EditorFor(model => model.EditableItem.Fecha, "{0:dd-MM-yyyy}", new { @class = "calendario" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n\r\n\r\n");
                WriteLiteral("\r\n\r\n\r\n                               \r\n                            <div class=\"categoria\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecb5100b621fd63b62cd74f9eaa741d18c76328413844", async() => {
                    WriteLiteral("\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 97 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.EditableItem.IdCategoria);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 98 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.ListOfProduct, "Value", "Text"));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </div>\r\n\r\n                                <div class=\"boton\">\r\n                                    <button id=\"btn\" type=\"submit\" class=\"btn-agregar\"><i class=\"fas fa-save\">");
#nullable restore
#line 103 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                                                                                                          Write(Model.EditableItem.Id > 0 ? "  Actualizar" : "  Agregar");

#line default
#line hidden
#nullable disable
                WriteLiteral("</i></button>\r\n                                </div>\r\n\r\n                            </div>\r\n");
#nullable restore
#line 109 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                               Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                                                             
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </td>
                        </tr>
                        <tr class=""titulo-tabla"" style=""font-size: 20px; font-weight:bold; color: #000;"">
                            
                            <td class=""text-left"">Completada</td>
                            <td class=""text-center"">Título de la tarea</td>
                            
                            <td class=""text-center"">Prioridad</td>
                            <td class=""text-center"">Fecha Vencimiento</td>
                            <td class=""text-center"">Categoria</td>
                            <td></td>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
");
#nullable restore
#line 126 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                             foreach (var item in Model.TodoItems)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr class=\"danger\">\r\n                                <td>\r\n                                   <label class=\"switch\">\r\n                                        <input  type=\"checkbox\"");
                BeginWriteAttribute("checked", " checked=\"", 5526, "\"", 5552, 1);
#nullable restore
#line 131 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
WriteAttributeValue("", 5536, item.Completada, 5536, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 5553, "\"", 5621, 5);
                WriteAttributeValue("", 5563, "window.location.href", 5563, 20, true);
                WriteAttributeValue(" ", 5583, "=", 5584, 2, true);
                WriteAttributeValue(" ", 5585, "\'/Tareas/TareaCompletada/", 5586, 26, true);
#nullable restore
#line 131 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
WriteAttributeValue("", 5611, item.Id, 5611, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5619, "\';", 5619, 2, true);
                EndWriteAttribute();
                WriteLiteral(@" />
                                    <span class=""slider round""></span>                                  
                                   </label>
                                </td>
                                <td class=""text-center"">
                                    <a");
                BeginWriteAttribute("href", " href=\"", 5913, "\"", 5943, 2);
                WriteAttributeValue("", 5920, "/Tareas/Editar/", 5920, 15, true);
#nullable restore
#line 136 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
WriteAttributeValue("", 5935, item.Id, 5935, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                                        ");
#nullable restore
#line 138 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                                   Write(item.Titulo);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </a>\r\n                                </td>\r\n");
                WriteLiteral("\r\n                                <td class=\"text-center\">\r\n                                    ");
#nullable restore
#line 146 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                               Write(item.Prioridad);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n\r\n\r\n                                <td class=\"text-center\">\r\n                                    ");
#nullable restore
#line 151 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                               Write(item.Fecha.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n\r\n\r\n                                <td class=\"text-center\">\r\n                                    ");
#nullable restore
#line 156 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                               Write(item.IdCategoria.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n\r\n                                <td class=\"text-center\">\r\n\r\n                                    <a class=\"btn btn-danger btn-md\"\r\n                                       data-id=\"");
#nullable restore
#line 162 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                                           Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n                                       data-controller=\"Tareas\"\r\n                                       data-action=\"Borrar\"\r\n                                       data-body-message=\"¿Está seguro?, esta acción es irreversible...\"");
                BeginWriteAttribute("href", "\r\n                                       href=\"", 7174, "\"", 7244, 2);
                WriteAttributeValue("", 7221, "/Tareas/Borrar/", 7221, 15, true);
#nullable restore
#line 166 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
WriteAttributeValue("", 7236, item.Id, 7236, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-trash\">  Borrar</i></a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 169 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecb5100b621fd63b62cd74f9eaa741d18c76328423958", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

        <script>
            window.onload = function () {
                Push.Permission.request();
            }
            document.getElementById('btn').onclick = function () {
                Push.create('Tarea agregada', {
                    body: 'Su tarea ha sido agregada con éxito',
                    icon: '~/img/diskette.png',
                    timeout: 5000,
                })
            }
        </script>

    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListaToDo.ViewModels.TareasViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
