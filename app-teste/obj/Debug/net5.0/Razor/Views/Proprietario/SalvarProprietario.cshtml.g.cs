#pragma checksum "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Proprietario\SalvarProprietario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c48abefa2efadb93fd4e5cda78edb297d124128"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Proprietario_SalvarProprietario), @"mvc.1.0.view", @"/Views/Proprietario/SalvarProprietario.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c48abefa2efadb93fd4e5cda78edb297d124128", @"/Views/Proprietario/SalvarProprietario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01d4063372736881bddf75c8ad7ef4d5bcca5ce4", @"/Views/_ViewImports.cshtml")]
    public class Views_Proprietario_SalvarProprietario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<app_teste.Models.DTO.Proprietario.ProprietarioDTO?>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Proprietario/salvarProprietario.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Proprietario\SalvarProprietario.cshtml"
  
    ViewData["Title"] = "Novo proprietario";

    string titulo = Model == null ? "Novo" : Model.Id > 0 ? "Alterar" : "Novo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c48abefa2efadb93fd4e5cda78edb297d1241284571", async() => {
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
            WriteLiteral("\r\n\r\n<h2>");
#nullable restore
#line 11 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Proprietario\SalvarProprietario.cshtml"
Write(titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Proprietario</h2>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c48abefa2efadb93fd4e5cda78edb297d1241285868", async() => {
                WriteLiteral("\r\n\r\n    <input type=\"hidden\" name=\"id\" id=\"id\"");
                BeginWriteAttribute("value", " value=\"", 364, "\"", 405, 1);
#nullable restore
#line 15 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Proprietario\SalvarProprietario.cshtml"
WriteAttributeValue("", 372, Model.Id > 0 ? Model.Id : null, 372, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />

    <div class=""row"">
        <div class=""col col-md-12"">
            <div class=""form-group"">
                <label for=""lblNome"">Nome Completo</label>
                <br />
                <input class=""form-control"" type=""text"" name=""nome"" id=""nome""");
                BeginWriteAttribute("value", " value=\"", 672, "\"", 736, 1);
#nullable restore
#line 22 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Proprietario\SalvarProprietario.cshtml"
WriteAttributeValue("", 680, !string.IsNullOrEmpty(Model.Nome) ? Model.Nome : null, 680, 56, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 737, "\"", 751, 0);
                EndWriteAttribute();
                WriteLiteral(@" required />
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col col-md-8"">
            <div class=""form-group"">
                <label for=""lblNome"">E-mail</label>
                <br />
                <input class=""form-control"" type=""text"" name=""email"" id=""email""");
                BeginWriteAttribute("value", " value=\"", 1069, "\"", 1135, 1);
#nullable restore
#line 32 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Proprietario\SalvarProprietario.cshtml"
WriteAttributeValue("", 1077, !string.IsNullOrEmpty(Model.Email) ? Model.Email : null, 1077, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1136, "\"", 1150, 0);
                EndWriteAttribute();
                WriteLiteral(@" required />
            </div>
        </div>
        <div class=""col col-md-4"">
            <div class=""form-group"">
                <label for=""lblNome"">Documento</label>
                <br />
                <input class=""form-control"" type=""text"" oninput=""somenteNumero(this)"" name=""documento"" id=""documento""");
                BeginWriteAttribute("value", " value=\"", 1472, "\"", 1496, 1);
#nullable restore
#line 39 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Proprietario\SalvarProprietario.cshtml"
WriteAttributeValue("", 1480, Model.Documento, 1480, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1497, "\"", 1511, 0);
                EndWriteAttribute();
                WriteLiteral(@" required />
            </div>
        </div>

    </div>

    <div class=""row"">
        <div class=""col col-md-2"" hidden>
            <div class=""form-group"">
                <label for=""lblNome"">CEP</label>
                <br />
                <input class=""form-control"" type=""text"" name=""endereco"" id=""endereco""");
                BeginWriteAttribute("value", " value=\"", 1841, "\"", 1864, 1);
#nullable restore
#line 50 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Proprietario\SalvarProprietario.cshtml"
WriteAttributeValue("", 1849, Model.Endereco, 1849, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1865, "\"", 1879, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
            </div>
        </div>
        <div class=""col col-md-2"">
            <div class=""form-group"">
                <label for=""lblNome"">CEP</label>
                <br />
                <input class=""form-control"" type=""text"" oninput=""somenteNumero(this)"" name=""cep"" id=""cep""");
                BeginWriteAttribute("value", " value=\"", 2174, "\"", 2192, 1);
#nullable restore
#line 57 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Proprietario\SalvarProprietario.cshtml"
WriteAttributeValue("", 2182, Model.CEP, 2182, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 2193, "\"", 2207, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
            </div>
        </div>
        <div class=""col col-md-8"">
            <div class=""form-group"">
                <label for=""lblNome"">Endere??o</label>
                <br />
                <input class=""form-control"" type=""text"" name=""rua"" id=""rua""");
                BeginWriteAttribute("value", " value=\"", 2477, "\"", 2485, 0);
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 2486, "\"", 2500, 0);
                EndWriteAttribute();
                WriteLiteral(@" required readonly />
            </div>
        </div>
        <div class=""col col-md-2"">
            <div class=""form-group"">
                <label for=""lblNome"">Logradouro</label>
                <br />
                <input class=""form-control"" type=""text"" name=""logradouro"" id=""logradouro""");
                BeginWriteAttribute("value", " value=\"", 2804, "\"", 2812, 0);
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 2813, "\"", 2827, 0);
                EndWriteAttribute();
                WriteLiteral(@" required />
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col col-md-4"">
            <div class=""form-group"">
                <label for=""lblNome"">Bairro</label>
                <br />
                <input class=""form-control"" type=""text"" name=""bairro"" id=""bairro""");
                BeginWriteAttribute("value", " value=\"", 3147, "\"", 3155, 0);
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 3156, "\"", 3170, 0);
                EndWriteAttribute();
                WriteLiteral(@" required readonly />
            </div>
        </div>
        <div class=""col col-md-4"">
            <div class=""form-group"">
                <label for=""lblNome"">Cidade</label>
                <br />
                <input class=""form-control"" type=""text"" name=""cidade"" id=""cidade""");
                BeginWriteAttribute("value", " value=\"", 3462, "\"", 3470, 0);
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 3471, "\"", 3485, 0);
                EndWriteAttribute();
                WriteLiteral(@" required readonly />
            </div>
        </div>
        <div class=""col col-md-4"">
            <div class=""form-group"">
                <label for=""lblNome"">UF</label>
                <br />
                <input class=""form-control"" type=""text"" name=""uf"" id=""uf""");
                BeginWriteAttribute("value", " value=\"", 3765, "\"", 3773, 0);
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 3774, "\"", 3788, 0);
                EndWriteAttribute();
                WriteLiteral(@" required readonly />
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col col-md-2 offset-md-5"">
            <div class=""form-group text-center"">
                <label for=""lblNome"">Status</label>
                <br />
                <input class=""form-control"" type=""checkbox"" name=""status"" id=""status""");
                BeginWriteAttribute("value", " value=\"", 4145, "\"", 4166, 1);
#nullable restore
#line 105 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Proprietario\SalvarProprietario.cshtml"
WriteAttributeValue("", 4153, Model.Status, 4153, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 105 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Proprietario\SalvarProprietario.cshtml"
                                                                                                        Write(Model.Status ? "checked='checked'" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col col-md-12\">\r\n            <a class=\"form-control btn btn-success\" onclick=\"SalvarProprietario()\" name=\"inserir\">Salvar</a>\r\n        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<app_teste.Models.DTO.Proprietario.ProprietarioDTO?> Html { get; private set; }
    }
}
#pragma warning restore 1591
