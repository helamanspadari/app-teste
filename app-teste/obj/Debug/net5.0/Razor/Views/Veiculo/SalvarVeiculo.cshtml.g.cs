#pragma checksum "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b846cfc64317855f5f3b38108ab4651699559094"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Veiculo_SalvarVeiculo), @"mvc.1.0.view", @"/Views/Veiculo/SalvarVeiculo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b846cfc64317855f5f3b38108ab4651699559094", @"/Views/Veiculo/SalvarVeiculo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01d4063372736881bddf75c8ad7ef4d5bcca5ce4", @"/Views/_ViewImports.cshtml")]
    public class Views_Veiculo_SalvarVeiculo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<app_teste.Models.DTO.Veiculo.VeiculoDTO?>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Veiculo/salvarVeiculo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
  
    ViewData["Title"] = "Novo Veiculo";

    string titulo = Model == null ? "Novo" : Model.Id > 0 ? "Alterar" : "Novo";
    var listaProprietario = ViewBag.ListaProprietario;
    var listaMarca = ViewBag.ListaMarca;
    var listaStatus = ViewBag.ListaStatus;
 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b846cfc64317855f5f3b38108ab46516995590945054", async() => {
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
#line 14 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
Write(titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Veiculo</h2>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b846cfc64317855f5f3b38108ab46516995590946336", async() => {
                WriteLiteral("\r\n\r\n    <input type=\"hidden\" name=\"id\" id=\"id\"");
                BeginWriteAttribute("value", " value=\"", 477, "\"", 494, 1);
#nullable restore
#line 18 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
WriteAttributeValue("", 485, Model.Id, 485, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"prop\" id=\"prop\"");
                BeginWriteAttribute("value", " value=\"", 546, "\"", 575, 1);
#nullable restore
#line 19 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
WriteAttributeValue("", 554, Model.ProprietarioId, 554, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"marca\" id=\"marca\"");
                BeginWriteAttribute("value", " value=\"", 629, "\"", 651, 1);
#nullable restore
#line 20 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
WriteAttributeValue("", 637, Model.MarcaId, 637, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"status\" id=\"status\"");
                BeginWriteAttribute("value", " value=\"", 707, "\"", 728, 1);
#nullable restore
#line 21 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
WriteAttributeValue("", 715, Model.Status, 715, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />

    <div class=""row"">
        <div class=""col col-md-6"">
            <div class=""form-group"">
                <label for=""lblProprietario"">Proprietario</label>
                <br />
                <div id=""_ListaProprietario"">
                    <select id=""proprietarioId"" name=""proprietarioId"" class=""form-control"" required>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b846cfc64317855f5f3b38108ab46516995590948738", async() => {
                    WriteLiteral("Selecione o Proprietario do veiculo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
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
#line 31 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
                         foreach (var item in listaProprietario)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b846cfc64317855f5f3b38108ab465169955909410313", async() => {
#nullable restore
#line 33 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
                                                Write(item.Nome);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" (");
#nullable restore
#line 33 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
                                                            Write(item.Documento);

#line default
#line hidden
#nullable disable
                    WriteLiteral(")");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 34 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </div>
            </div>
        </div>
        <div class=""col col-md-6"">
            <div class=""form-group"">
                <label for=""lblNome"">Renavam</label>
                <br />
                <input class=""form-control"" type=""text"" name=""renavam"" oninput=""somenteNumero(this)"" id=""renavam""");
                BeginWriteAttribute("value", " value=\"", 1729, "\"", 1751, 1);
#nullable restore
#line 43 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
WriteAttributeValue("", 1737, Model.Renavam, 1737, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1752, "\"", 1766, 0);
                EndWriteAttribute();
                WriteLiteral(@" required />
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col col-md-6"">
            <div class=""form-group"">
                <label for=""lblMarca"">Marca</label>
                <br />
                <div id=""_ListaMarca"">
                    <select id=""marcaId"" name=""marcaId"" class=""form-control"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b846cfc64317855f5f3b38108ab465169955909414045", async() => {
                    WriteLiteral("Selecione a Marca do veiculo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
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
#line 56 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
                         foreach (var item in listaMarca)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b846cfc64317855f5f3b38108ab465169955909415607", async() => {
#nullable restore
#line 58 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
                                                Write(item.Nome);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </div>
            </div>
        </div>
        <div class=""col col-md-6"">
            <div class=""form-group"">
                <label for=""lblNome"">Modelo</label>
                <br />
                <input class=""form-control"" type=""text"" name=""modelo"" id=""modelo""");
                BeginWriteAttribute("value", " value=\"", 2715, "\"", 2736, 1);
#nullable restore
#line 68 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
WriteAttributeValue("", 2723, Model.Modelo, 2723, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 2737, "\"", 2751, 0);
                EndWriteAttribute();
                WriteLiteral(@" required />
            </div>
        </div>
        </div>

    <div class=""row"">
        <div class=""col col-md-6"">
            <div class=""form-group"">
                <label for=""lblNome"">Ano Fabricação</label>
                <br />
                <input class=""form-control"" type=""text"" maxlength=""4"" minlength=""4"" oninput=""somenteNumero(this)"" name=""fabricacao"" id=""fabricacao""");
                BeginWriteAttribute("value", " value=\"", 3149, "\"", 3212, 1);
#nullable restore
#line 78 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
WriteAttributeValue("", 3157, Model.AnoFabricacao > 0 ? Model.AnoFabricacao : null, 3157, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder="" "" required />
            </div>
        </div>
        <div class=""col col-md-6"">
            <div class=""form-group"">
                <label for=""lblNome"">Ano Modelo</label>
                <br />
                <input class=""form-control"" type=""text"" maxlength=""4"" minlength=""4"" oninput=""somenteNumero(this)"" name=""ano"" id=""ano""");
                BeginWriteAttribute("value", " value=\"", 3567, "\"", 3622, 1);
#nullable restore
#line 85 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
WriteAttributeValue("", 3575, Model.AnoModelo > 0 ? Model.AnoModelo : null, 3575, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder="" "" required />
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col col-md-4"">
            <div class=""form-group"">
                <label for=""lblNome"">Quilometragem</label>
                <br />
                <input class=""form-control"" type=""text"" name=""quilometragem"" oninput=""somenteNumero(this)"" id=""quilometragem""");
                BeginWriteAttribute("value", " value=\"", 4009, "\"", 4072, 1);
#nullable restore
#line 95 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
WriteAttributeValue("", 4017, Model.Quilometragem > 0 ? Model.Quilometragem : null, 4017, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder="" "" required />
            </div>
        </div>
        <div class=""col col-md-4"">
            <div class=""form-group"">
                <label for=""lblNome"">Valor (R$)</label>
                <br />
                <input class=""form-control"" type=""text"" name=""valor"" id=""valor""");
                BeginWriteAttribute("value", " value=\"", 4373, "\"", 4420, 1);
#nullable restore
#line 102 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
WriteAttributeValue("", 4381, Model.Valor > 0 ? Model.Valor : null, 4381, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"  placeholder="" "" required />
            </div>
        </div>
        <div class=""col col-md-4"">
            <div class=""form-group"">
                <label for=""lblNome"">Status</label>
                <br />
                <div id=""_ListaStatus"">
                    <select id=""statusId"" name=""statusId"" class=""form-control"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b846cfc64317855f5f3b38108ab465169955909422148", async() => {
                    WriteLiteral("Selecione status do veiculo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
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
#line 112 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
                         foreach (var item in listaStatus)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b846cfc64317855f5f3b38108ab465169955909423711", async() => {
#nullable restore
#line 114 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
                                                Write(item.DscStatus);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 115 "C:\Users\helamanspadari\Desktop\DOCS\PTC\app-teste\Views\Veiculo\SalvarVeiculo.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </div>
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col col-md-12"">
            <a class=""form-control btn btn-success"" onclick=""SalvarVeiculo()"" name=""inserir"">Salvar</a>
        </div>
    </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<app_teste.Models.DTO.Veiculo.VeiculoDTO?> Html { get; private set; }
    }
}
#pragma warning restore 1591