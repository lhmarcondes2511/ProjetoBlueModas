#pragma checksum "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\PedidoRealizado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1df94e6ed9f3d77722e19e8e4309c031d42c6ff9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PedidoRealizado), @"mvc.1.0.view", @"/Views/Home/PedidoRealizado.cshtml")]
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
#line 1 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\_ViewImports.cshtml"
using ProjetoBlueModas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\_ViewImports.cshtml"
using ProjetoBlueModas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1df94e6ed9f3d77722e19e8e4309c031d42c6ff9", @"/Views/Home/PedidoRealizado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73308b915ffb160ae9f92d1de16035f3f2679580", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PedidoRealizado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjetoBlueModas.Models.Historico>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-primary col-lg-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FecharPedidoRealizado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\PedidoRealizado.cshtml"
  
    decimal totalGeral = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n");
            WriteLiteral(" ");
            WriteLiteral(@"@import url('https://fonts.googleapis.com/css2?family=Quicksand:wght@300&display=swap');

    #Dashboard, #ProdutoAdmin, #Categoria, #Historico, #Sair {
        display: none;
    }

    .lh-title {
        font-family: 'Quicksand', sans-serif;
    }

    .lh-qtd {
        font-size: 8pt;
    }

    .lh-precoTotal {
        padding-right: 20px
    }
</style>

<div class=""container"">
    <div class=""lh-title text-center"">
        <h5>Seu Comprovante</h5>
    </div>
    <hr class=""lh-hr"" />
    <div class=""row col-12 col-lg-7 mx-lg-auto"">
        <div class=""col-12"">
            <table");
            BeginWriteAttribute("class", " class=\"", 739, "\"", 747, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <tr class=\"row\">\r\n");
#nullable restore
#line 36 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\PedidoRealizado.cshtml"
                     foreach (var item in Model.Select(x => x.Protocolo).Distinct()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>                    \r\n                        <th class=\"col-6 text-left\">Protocolo</th>\r\n                        <td class=\"col-6 text-right\">");
#nullable restore
#line 39 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\PedidoRealizado.cshtml"
                                                Write(Html.DisplayFor(x => item));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 41 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\PedidoRealizado.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n                <tr class=\"row\">\r\n");
#nullable restore
#line 44 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\PedidoRealizado.cshtml"
                     foreach (var item in Model.Select(x => x.NomeCliente).Distinct()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>                    \r\n                        <th class=\"col-6 text-left\">Nome</th>\r\n                        <td class=\"col-6 text-right\">");
#nullable restore
#line 47 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\PedidoRealizado.cshtml"
                                                Write(Html.DisplayFor(x => item));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 49 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\PedidoRealizado.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n                <tr class=\"row\">\r\n");
#nullable restore
#line 52 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\PedidoRealizado.cshtml"
                     foreach (var item in Model.Select(x => x.EmailCliente).Distinct()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th class=\"col-6 text-left\">Email</th>\r\n                        <td class=\"col-6 text-right\">");
#nullable restore
#line 55 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\PedidoRealizado.cshtml"
                                                Write(Html.DisplayFor(x => item));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 57 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\PedidoRealizado.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n                <tr class=\"row\">\r\n");
#nullable restore
#line 60 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\PedidoRealizado.cshtml"
                     foreach (var item in Model.Select(x => x.TelefoneCliente).Distinct()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th class=\"col-6 text-left\">Telefone</th>\r\n                        <td class=\"col-6 text-right\">");
#nullable restore
#line 63 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\PedidoRealizado.cshtml"
                                                Write(Html.DisplayFor(x => item));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 65 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\PedidoRealizado.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n            </table>\r\n        </div>\r\n        <div class=\"lh-title text-center col-12\">\r\n            <h5>Itens Comprados</h5>\r\n            <hr class=\"lh-hr\" />\r\n        </div>\r\n        <div class=\"col-12\">\r\n            <table");
            BeginWriteAttribute("class", " class=\"", 2521, "\"", 2529, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <tr class=\"row mx-lg-auto\">\r\n");
#nullable restore
#line 76 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\PedidoRealizado.cshtml"
                     foreach (var item in Model) {
                        var total = item.QuantidadeCesta * item.PrecoProduto;
                        totalGeral += total;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"col-7 text-left\">");
#nullable restore
#line 80 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\PedidoRealizado.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.NomeProduto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"col-1 text-right lh-qtd\">");
#nullable restore
#line 81 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\PedidoRealizado.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.QuantidadeCesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>x</span></td>\r\n                        <td class=\"col-4 text-right\">");
#nullable restore
#line 82 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\PedidoRealizado.cshtml"
                                                Write(Html.DisplayFor(modelItem => item.PrecoProduto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 84 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\PedidoRealizado.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n            </table>\r\n            <hr class=\"lh-hr\" />\r\n            <div class=\"text-dark lh-precoTotal text-right\">\r\n                <b>\r\n                    Total R$ <i class=\"lh-valorTotal\">");
#nullable restore
#line 90 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\PedidoRealizado.cshtml"
                                                 Write(Html.DisplayFor(x => totalGeral));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                </b>\r\n            </div>\r\n            <div class=\"text-right\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1df94e6ed9f3d77722e19e8e4309c031d42c6ff912722", async() => {
                WriteLiteral("\r\n                    <h6>Fechar</h6>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjetoBlueModas.Models.Historico>> Html { get; private set; }
    }
}
#pragma warning restore 1591
