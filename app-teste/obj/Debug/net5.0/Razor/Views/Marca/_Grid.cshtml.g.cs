#pragma checksum "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Marca\_Grid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb555fb760f9869a7aebf2ce3537ba21b7718193"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Marca__Grid), @"mvc.1.0.view", @"/Views/Marca/_Grid.cshtml")]
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
#line 1 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\_ViewImports.cshtml"
using app_teste;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\_ViewImports.cshtml"
using app_teste.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb555fb760f9869a7aebf2ce3537ba21b7718193", @"/Views/Marca/_Grid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01d4063372736881bddf75c8ad7ef4d5bcca5ce4", @"/Views/_ViewImports.cshtml")]
    public class Views_Marca__Grid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""table table-responsive-md"">
    <table class=""table table-hover"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Nome</th>
                <th scope=""col"">Status</th>
                <th scope=""col"" class=""text-center"">Ação</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 12 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Marca\_Grid.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td id=\"idMarca\">");
#nullable restore
#line 15 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Marca\_Grid.cshtml"
                                Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td id=\"nomeMarca\">");
#nullable restore
#line 16 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Marca\_Grid.cshtml"
                                  Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td id=\"statusMarca\">");
#nullable restore
#line 17 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Marca\_Grid.cshtml"
                                     Write(item.Status ? "Ativo" : "Cancelado");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">\r\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 705, "\"", 743, 3);
            WriteAttributeValue("", 715, "AlterarStatusMarca(", 715, 19, true);
#nullable restore
#line 19 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Marca\_Grid.cshtml"
WriteAttributeValue("", 734, item.Id, 734, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 742, ")", 742, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">\r\n                            Alterar Status\r\n                        </a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 24 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Marca\_Grid.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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