#pragma checksum "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cf1e60b1131af47e8c430f94e031dfd80e627ff"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cf1e60b1131af47e8c430f94e031dfd80e627ff", @"/Views/Tareas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4ae196609c74a34ea85227679f21626a9b25ba6", @"/Views/_ViewImports.cshtml")]
    public class Views_Tareas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListaToDo.ViewModels.TareasViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/push.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cf1e60b1131af47e8c430f94e031dfd80e627ff4201", async() => {
                WriteLiteral("\r\n    <title>Lista tareas</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cf1e60b1131af47e8c430f94e031dfd80e627ff5202", async() => {
                WriteLiteral("\r\n\r\n    <h1 style=\"font-size:30px; font-weight:700; text-transform:uppercase; text-align:center;\">📗📗📗  Lista de tareas  📗📗📗</h1>\r\n\r\n    <div class=\"container\">\r\n\r\n");
#nullable restore
#line 16 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
         if (TempData["mensaje"] != null)
    {


#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"alert alert-info  alert-dismissible fade show\" role=\"alert\">\r\n\r\n            ");
#nullable restore
#line 21 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
       Write(TempData["mensaje"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                <span aria-hidden=\"true\">&times;</span>\r\n            </button>\r\n\r\n        </div>\r\n");
#nullable restore
#line 27 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
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
                <table class=""table table-striped"">
                    <thead>
                        <tr class=""warning"">
                            <td colspan=""6"">
");
#nullable restore
#line 39 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                                 using (var form = Html.BeginForm("CrearActualizar", "Tareas", FormMethod.Post))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                               Write(Html.HiddenFor(model => model.EditableItem.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                               Write(Html.TextBoxFor(model => model.EditableItem.Titulo, new { @class = "form-control", placeholder = "Ingresa una tarea", @style = "display:block; color:#000; margin:10px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"input-group\">\r\n                                        \r\n");
                WriteLiteral("\r\n                                        <div class=\"input-field col s12\">\r\n                                            ");
#nullable restore
#line 48 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                                       Write(Html.DropDownListFor(model => model.EditableItem.Prioridad, new List<SelectListItem> // esto rellena el select con datos estaticos

                                  {
                                  new SelectListItem{Text="Prioridad 1", Value="1"},
                                  new SelectListItem{Text="Prioridad 2", Value="2"},
                                  new SelectListItem{Text="Prioridad 4", Value="3"},
                                  new SelectListItem{Text="Prioridad 5", Value="4"},

                                      }, new { @class = "form-control", @style = "display:block; margin:10px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </div>\r\n\r\n");
                WriteLiteral("                                        ");
#nullable restore
#line 61 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                                   Write(Html.EditorFor(model => model.EditableItem.Fecha, "{0:dd-MM-yyyy}", new { @class = "form-control datepicker", placeholder = "Fecha vencimiento" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
                WriteLiteral("\r\n\r\n                                        ");
#nullable restore
#line 66 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                                   Write(Html.DropDownListFor(model => model.EditableItem.IdCategoria, new List<SelectListItem> // esto rellena el select con datos estaticos

                                  {
                                  
                                  new SelectListItem{Text="Hogar", Value="1"},                                  
                                      }, new { @class = "form-control", @style = "display:block; margin:10px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                                       
                                    </div>
                                     <div>
                                            <button id=""btn"" type=""submit"" class=""btn btn-info btn-block""><i class=""fas fa-save"">");
#nullable restore
#line 76 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                                                                                                                             Write(Model.EditableItem.Id > 0 ? "  Actualizar" : "  Agregar");

#line default
#line hidden
#nullable disable
                WriteLiteral("</i></button>\r\n                                        </div>\r\n");
#nullable restore
#line 78 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                               Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                                                             
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </td>
                        </tr>
                        <tr class=""bg-primary"" style=""font-size: 20px; font-weight:bold; color: #000;"">
                            <td class=""text-left"">Completada</td>
                            <td class=""text-center"">Título de la tarea</td>
                            <td class=""text-center"">Creada</td>
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
#line 94 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                             foreach (var item in Model.TodoItems)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr class=\"danger\">\r\n                                <td");
                BeginWriteAttribute("class", " class=\"", 5262, "\"", 5270, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <input type=\"checkbox\"");
                BeginWriteAttribute("checked", " checked=\"", 5332, "\"", 5358, 1);
#nullable restore
#line 98 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
WriteAttributeValue("", 5342, item.Completada, 5342, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 5359, "\"", 5427, 5);
                WriteAttributeValue("", 5369, "window.location.href", 5369, 20, true);
                WriteAttributeValue(" ", 5389, "=", 5390, 2, true);
                WriteAttributeValue(" ", 5391, "\'/Tareas/TareaCompletada/", 5392, 26, true);
#nullable restore
#line 98 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
WriteAttributeValue("", 5417, item.Id, 5417, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5425, "\';", 5425, 2, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                </td>\r\n                                <td class=\"text-center\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 5568, "\"", 5598, 2);
                WriteAttributeValue("", 5575, "/Tareas/Editar/", 5575, 15, true);
#nullable restore
#line 101 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
WriteAttributeValue("", 5590, item.Id, 5590, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        ");
#nullable restore
#line 102 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                                   Write(item.Titulo);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </a>\r\n                                </td>\r\n                                <td class=\"text-center\">\r\n                                    ");
#nullable restore
#line 106 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                               Write(item.FechaCreacion.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n\r\n                                <td class=\"text-center\">\r\n                                    ");
#nullable restore
#line 110 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                               Write(item.Prioridad.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n\r\n\r\n                                <td class=\"text-center\">\r\n                                    ");
#nullable restore
#line 115 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                               Write(item.Fecha.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n\r\n\r\n                                <td class=\"text-center\">\r\n                                    ");
#nullable restore
#line 120 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                               Write(item.IdCategoria.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </td>

                                <td class=""text-center"">
                                    
                                    <a class=""btn btn-danger delete""
                                       data-id=""");
#nullable restore
#line 126 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                                           Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n                                       data-controller=\"Tareas\"\r\n                                       data-action=\"Borrar\"\r\n                                       data-body-message =\"¿Está seguro?, esta acción es irreversible...\"");
                BeginWriteAttribute("href", "\r\n                                       href=\"", 6869, "\"", 6939, 2);
                WriteAttributeValue("", 6916, "/Tareas/Borrar/", 6916, 15, true);
#nullable restore
#line 130 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
WriteAttributeValue("", 6931, item.Id, 6931, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                                       \r\n                                       \r\n                                       ><i class=\"fas fa-trash\">  Eliminar</i></a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 136 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ListaToDo\ListaToDo\Views\Tareas\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cf1e60b1131af47e8c430f94e031dfd80e627ff19132", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
