#pragma checksum "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\Usuario\Crear.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa52fb15bcf7bdc007a6453be88b211309c6d124"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Crear), @"mvc.1.0.view", @"/Views/Usuario/Crear.cshtml")]
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
#line 1 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\_ViewImports.cshtml"
using ListaToDo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\_ViewImports.cshtml"
using ListaToDo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa52fb15bcf7bdc007a6453be88b211309c6d124", @"/Views/Usuario/Crear.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4ae196609c74a34ea85227679f21626a9b25ba6", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Crear : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListaToDo.ViewModels.UsuarioViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/categorias.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/push.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa52fb15bcf7bdc007a6453be88b211309c6d1244978", async() => {
                WriteLiteral("\r\n    <title>Manejo de usuarios</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa52fb15bcf7bdc007a6453be88b211309c6d1245281", async() => {
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
                WriteLiteral("\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa52fb15bcf7bdc007a6453be88b211309c6d1247168", async() => {
                WriteLiteral("\r\n\r\n    <h1 style=\"font-size:30px; color:#fff; padding:20px; font-weight:700; text-transform:uppercase; text-align:center;\">?????????  Registrar usuario  ?????????</h1>\r\n\r\n\r\n\r\n");
#nullable restore
#line 18 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\Usuario\Crear.cshtml"
     if (TempData["mensaje"] != null)
    {


#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"alert alert-success  alert-dismissible fade show\" role=\"alert\">\r\n\r\n            ");
#nullable restore
#line 23 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\Usuario\Crear.cshtml"
       Write(TempData["mensaje"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                <span aria-hidden=\"true\">&times;</span>\r\n            </button>\r\n\r\n        </div>\r\n");
#nullable restore
#line 29 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\Usuario\Crear.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\Usuario\Crear.cshtml"
     if (TempData["Error"] != null)
    {


#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"alert alert-danger  alert-dismissible fade show\" role=\"alert\">\r\n\r\n            ");
#nullable restore
#line 35 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\Usuario\Crear.cshtml"
       Write(TempData["Error"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                <span aria-hidden=\"true\">&times;</span>\r\n            </button>\r\n\r\n        </div>\r\n");
#nullable restore
#line 41 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\Usuario\Crear.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <div class=""container"">

        <div class=""row"">
            <div class=""col-md-12"">

                <div class=""alert alert-success"" style=""display:none;"">
                    <span class=""glyphicon glyphicon-ok""></span> Drag table row and cange Order
                </div>
                <table class=""table table-striped table-dark"">
                    <thead>
                        <tr class=""warning"">
                            <td colspan=""6"">
");
#nullable restore
#line 55 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\Usuario\Crear.cshtml"
                                 using (var form = Html.BeginForm("CrearModificar", "Usuario", FormMethod.Post))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\Usuario\Crear.cshtml"
                               Write(Html.HiddenFor(model => model.EditableItem.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <br>\r\n                                    <div class=\"wrapper\">\r\n                                        ");
#nullable restore
#line 60 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\Usuario\Crear.cshtml"
                                   Write(Html.TextBoxFor(model => model.EditableItem.Nombre, new { placeholder = "Registrar nuevo usuario" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                        ");
#nullable restore
#line 62 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\Usuario\Crear.cshtml"
                                   Write(Html.TextBoxFor(model => model.EditableItem.Clave, new { type="password", placeholder = "Agregar contrase??a" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n                                        <div>\r\n                                            <button id=\"btn\" type=\"submit\" class=\"btn btn-success btn-lg\"><i class=\"fas fa-save\">");
#nullable restore
#line 66 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\Usuario\Crear.cshtml"
                                                                                                                             Write(Model.EditableItem.Id > 0 ? "  Actualizar" : "  Agregar");

#line default
#line hidden
#nullable disable
                WriteLiteral("</i></button>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 69 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\Usuario\Crear.cshtml"
                               Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\Usuario\Crear.cshtml"
                                                             
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </td>
                        </tr>
                        <tr class=""titulo-tabla"">
                            <td></td>
                            <td class=""text-center"">Nombre</td>
                            <td class=""text-center"">Clave</td>
                            <td class=""text-center"">Fecha creaci??n</td>
                            <td></td>
                        </tr>
                    </thead>
                    <tbody>
                        <tr class=""bg-success"">
");
#nullable restore
#line 83 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\Usuario\Crear.cshtml"
                             foreach (var item in Model.Usu)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr class=\"danger\">\r\n\r\n                            <td class=\"text-center\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 3427, "\"", 3458, 2);
                WriteAttributeValue("", 3434, "/Usuario/Editar/", 3434, 16, true);
#nullable restore
#line 88 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\Usuario\Crear.cshtml"
WriteAttributeValue("", 3450, item.Id, 3450, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    ");
#nullable restore
#line 89 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\Usuario\Crear.cshtml"
                               Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </a>\r\n                            </td>\r\n                            <td class=\"text-center\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 3669, "\"", 3700, 2);
                WriteAttributeValue("", 3676, "/Usuario/Editar/", 3676, 16, true);
#nullable restore
#line 93 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\Usuario\Crear.cshtml"
WriteAttributeValue("", 3692, item.Id, 3692, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    ");
#nullable restore
#line 94 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\Usuario\Crear.cshtml"
                               Write(item.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </a>\r\n                            </td>\r\n                            <td class=\"text-center\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 3915, "\"", 3946, 2);
                WriteAttributeValue("", 3922, "/Usuario/Editar/", 3922, 16, true);
#nullable restore
#line 98 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\Usuario\Crear.cshtml"
WriteAttributeValue("", 3938, item.Id, 3938, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    *******\r\n                                </a>\r\n                            </td>\r\n                            <td class=\"text-center\">\r\n                                ");
#nullable restore
#line 103 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\Usuario\Crear.cshtml"
                           Write(item.FechaCreacion.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n\r\n\r\n                            <td class=\"text-center\">\r\n\r\n                                <button class=\"btn btn-danger delete\"\r\n                                        data-id=\"");
#nullable restore
#line 110 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\Usuario\Crear.cshtml"
                                            Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                                        data-controller=""Usuario""
                                        data-action=""Borrar""
                                        data-body-message=""Este usuario con toda la informaci??n relacionada a ??l ser?? eliminado."">
                                    <i class=""fas fa-trash"">  Eliminar</i>
                                </button>
                            </td>
                        </tr>
");
#nullable restore
#line 118 "C:\Users\ENDERSSONMENDOZA\Documents\ProyectosVisual\ToDoList_NetCore_MVC\ListaToDO\Views\Usuario\Crear.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa52fb15bcf7bdc007a6453be88b211309c6d12418531", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                Push.create('Categoria agregada', {
                    body: 'La categor??a ha sido agregada con ??xito',
                    icon: '~/img/diskette.png',
                    timeout: 5000,

                })
            }

        </script>
");
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListaToDo.ViewModels.UsuarioViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
