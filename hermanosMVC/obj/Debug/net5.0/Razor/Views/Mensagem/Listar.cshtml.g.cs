#pragma checksum "C:\Projetos\Hamburgueria\hermanosMVC\hermanosMVC\Views\Mensagem\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9820272827afdea83812b60c1d07d21fc97d9c3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mensagem_Listar), @"mvc.1.0.view", @"/Views/Mensagem/Listar.cshtml")]
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
#line 1 "C:\Projetos\Hamburgueria\hermanosMVC\hermanosMVC\Views\_ViewImports.cshtml"
using hermanosMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projetos\Hamburgueria\hermanosMVC\hermanosMVC\Views\_ViewImports.cshtml"
using hermanosMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9820272827afdea83812b60c1d07d21fc97d9c3a", @"/Views/Mensagem/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0273c4e31c0317cebe2f34deb68a10e4bb3f4205", @"/Views/_ViewImports.cshtml")]
    public class Views_Mensagem_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Mensagem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Projetos\Hamburgueria\hermanosMVC\hermanosMVC\Views\Mensagem\Listar.cshtml"
  
    ViewData["Title"] = "Lista";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    td{
        border: 3px solid #ffffff;
        color: #5d5d5d;
        font-size: 14px;
        font-weight: normal;
        font-family: Verdana, Arial, Helvetica, sans-serif;
        background-color: #efeeee;
        text-align: center;
        table-layout: fixed;
        height: 100px;
        transition: height 0.4s;
        /*propriedade desejada*/
          max-width: 100px;
          overflow: hidden;
          text-overflow: ellipsis;
          white-space: nowrap;
          transition: all ease 0.7s;
        }

        td.texto:hover {
            height: 300px;
            max-width: 100px;
            overflow: auto;
            text-overflow: ellipsis;
            white-space: initial;
        }
</style>

<h2 style=""margin-top: 50px;"">Mensagens dos Clientes</h2><br>

<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Email</th>
            <th>Texto</th>
        </");
            WriteLiteral("tr>\r\n    </thead>\r\n\r\n");
#nullable restore
#line 47 "C:\Projetos\Hamburgueria\hermanosMVC\hermanosMVC\Views\Mensagem\Listar.cshtml"
         foreach (Mensagem u in Model) //Para pegar as informações do banco de dados, criando um objeto chamado "u" do tipo "PacoresTuristicos" que será alimentado pela Model
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 50 "C:\Projetos\Hamburgueria\hermanosMVC\hermanosMVC\Views\Mensagem\Listar.cshtml"
               Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 51 "C:\Projetos\Hamburgueria\hermanosMVC\hermanosMVC\Views\Mensagem\Listar.cshtml"
               Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 52 "C:\Projetos\Hamburgueria\hermanosMVC\hermanosMVC\Views\Mensagem\Listar.cshtml"
               Write(u.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"texto\">");
#nullable restore
#line 53 "C:\Projetos\Hamburgueria\hermanosMVC\hermanosMVC\Views\Mensagem\Listar.cshtml"
                             Write(u.Texto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n            </tr> \r\n");
#nullable restore
#line 55 "C:\Projetos\Hamburgueria\hermanosMVC\hermanosMVC\Views\Mensagem\Listar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tbody>\r\n\r\n        </tbody>\r\n</table> \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Mensagem>> Html { get; private set; }
    }
}
#pragma warning restore 1591