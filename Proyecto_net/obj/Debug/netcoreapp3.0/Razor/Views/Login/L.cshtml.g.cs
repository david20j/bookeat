#pragma checksum "C:\Users\david\Desktop\bookeat\Proyecto_net\Proyecto_net\Views\Login\L.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "089f8b257edb59caa0633a0366e6f573eee71765"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_L), @"mvc.1.0.view", @"/Views/Login/L.cshtml")]
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
#line 1 "C:\Users\david\Desktop\bookeat\Proyecto_net\Proyecto_net\Views\_ViewImports.cshtml"
using Proyecto_net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\david\Desktop\bookeat\Proyecto_net\Proyecto_net\Views\_ViewImports.cshtml"
using Proyecto_net.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"089f8b257edb59caa0633a0366e6f573eee71765", @"/Views/Login/L.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91b0c58ec89b02dafd21e54ac37f0be760f1a2e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_L : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Login/L2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\david\Desktop\bookeat\Proyecto_net\Proyecto_net\Views\Login\L.cshtml"
  
    ViewData["Title"] = "L";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\david\Desktop\bookeat\Proyecto_net\Proyecto_net\Views\Login\L.cshtml"
 if (ViewBag.local != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "089f8b257edb59caa0633a0366e6f573eee717654011", async() => {
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label for=\"exampleInputEmail1\">Nombre</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"exampleInputEmail1\" name=\"nombreForm\"");
                BeginWriteAttribute("value", " value=", 291, "", 319, 1);
#nullable restore
#line 11 "C:\Users\david\Desktop\bookeat\Proyecto_net\Proyecto_net\Views\Login\L.cshtml"
WriteAttributeValue("", 298, ViewBag.local.Nombre, 298, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"exampleInputPassword1\">Password</label>\r\n            <input type=\"password\" class=\"form-control\" id=\"exampleInputPassword1\" name=\"passwordForm\"");
                BeginWriteAttribute("value", " value=", 539, "", 563, 1);
#nullable restore
#line 15 "C:\Users\david\Desktop\bookeat\Proyecto_net\Proyecto_net\Views\Login\L.cshtml"
WriteAttributeValue("", 546, ViewBag.local.Pw, 546, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"exampleInputEmail1\">Email</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"exampleInputEmail1\" aria-describedby=\"emailHelp\" name=\"correoForm\"");
                BeginWriteAttribute("value", " value=", 797, "", 825, 1);
#nullable restore
#line 19 "C:\Users\david\Desktop\bookeat\Proyecto_net\Proyecto_net\Views\Login\L.cshtml"
WriteAttributeValue("", 804, ViewBag.local.Correo, 804, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"exampleInputEmail1\">Telefono</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"exampleInputEmail1\" aria-describedby=\"emailHelp\" name=\"telefonoForm\"");
                BeginWriteAttribute("value", " value=", 1064, "", 1094, 1);
#nullable restore
#line 23 "C:\Users\david\Desktop\bookeat\Proyecto_net\Proyecto_net\Views\Login\L.cshtml"
WriteAttributeValue("", 1071, ViewBag.local.Telefono, 1071, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"exampleInputEmail1\">Direccion</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"exampleInputEmail1\" aria-describedby=\"emailHelp\" name=\"direccionForm\"");
                BeginWriteAttribute("value", " value=", 1335, "", 1366, 1);
#nullable restore
#line 27 "C:\Users\david\Desktop\bookeat\Proyecto_net\Proyecto_net\Views\Login\L.cshtml"
WriteAttributeValue("", 1342, ViewBag.local.Direccion, 1342, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"exampleInputEmail1\">CPostal</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"exampleInputEmail1\" aria-describedby=\"emailHelp\" name=\"cpostalForm\"");
                BeginWriteAttribute("value", " value=", 1603, "", 1632, 1);
#nullable restore
#line 31 "C:\Users\david\Desktop\bookeat\Proyecto_net\Proyecto_net\Views\Login\L.cshtml"
WriteAttributeValue("", 1610, ViewBag.local.CPostal, 1610, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n\r\n");
#nullable restore
#line 34 "C:\Users\david\Desktop\bookeat\Proyecto_net\Proyecto_net\Views\Login\L.cshtml"
         if (ViewBag.menu != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <label for=\"exampleInputPassword1\">Menú</label>\r\n");
#nullable restore
#line 37 "C:\Users\david\Desktop\bookeat\Proyecto_net\Proyecto_net\Views\Login\L.cshtml"
            foreach (var a in ViewBag.menu)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"form-group\" id=\"menues\">\r\n                    <input type=\"text\" class=\"form-control\" id=\"exampleInputPassword1\"");
                BeginWriteAttribute("value", " value=", 1961, "", 1977, 1);
#nullable restore
#line 40 "C:\Users\david\Desktop\bookeat\Proyecto_net\Proyecto_net\Views\Login\L.cshtml"
WriteAttributeValue("", 1968, a.Nombre, 1968, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <input type=\"text\" class=\"form-control\" id=\"exampleInputPassword1\"");
                BeginWriteAttribute("value", " value=", 2066, "", 2082, 1);
#nullable restore
#line 41 "C:\Users\david\Desktop\bookeat\Proyecto_net\Proyecto_net\Views\Login\L.cshtml"
WriteAttributeValue("", 2073, a.Precio, 2073, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n");
#nullable restore
#line 43 "C:\Users\david\Desktop\bookeat\Proyecto_net\Proyecto_net\Views\Login\L.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <button type=\"submit\" class=\"btn btn-primary\">Actializar datos</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <div class=""form-group"" id=""anadirMenu"">
        <input type=""text"" class=""form-control"" id=""nombre"" placeholder=""Nombre del menú"">
        <input type=""text"" class=""form-control"" id=""precio"" placeholder=""Precio"">
        <button id=""crearMenuBtn""  class=""btn btn-primary"">Crear Menu</button>
    </div>
");
            WriteLiteral("    <div class=\"form-group\" id=\"anadirMenu\">\r\n        <input type=\"text\" class=\"form-control\" id=\"capacidad\" placeholder=\"Capacidad de la mesa\">\r\n        <button id=\"crearMesaBtn\"  class=\"btn btn-primary\">Crear Mesa</button>\r\n    </div>\r\n");
#nullable restore
#line 57 "C:\Users\david\Desktop\bookeat\Proyecto_net\Proyecto_net\Views\Login\L.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).on(""click"", ""#crearMenuBtn"", function () {
            $.ajax({
                type: ""GET"",
                url: ""/Local/crearMenu/"",
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                data: {
                    nombre: $(""#nombre"").val(),
                    precio: $(""#precio"").val()
                },
                success: function (result, status, xhr) {
                    if (result == true) {
                        alert(""true"")
                    }
                    else {
                        alert(""false"");

                    }
                }
            })

        });

        $(document).on(""click"", ""#crearMesaBtn"", function () {
            $.ajax({
                type: ""GET"",
                url: ""/Local/crearMesa/"",
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
               ");
                WriteLiteral(@" data: {
                    capacidad: $(""#capacidad"").val()
                },
                success: function (result, status, xhr) {
                    if (result == true) {
                        alert(""true"")
                    }
                    else {
                        alert(""false"");

                    }
                }
            })

        });

    </script>
");
            }
            );
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
