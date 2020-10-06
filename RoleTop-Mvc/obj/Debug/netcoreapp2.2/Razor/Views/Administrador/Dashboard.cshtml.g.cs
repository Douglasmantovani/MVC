#pragma checksum "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40130ac7187dcd202880964e755b741b554ba5cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Dashboard), @"mvc.1.0.view", @"/Views/Administrador/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Dashboard.cshtml", typeof(AspNetCore.Views_Administrador_Dashboard))]
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
#line 1 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\_ViewImports.cshtml"
using RoleTop_Mvc;

#line default
#line hidden
#line 2 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\_ViewImports.cshtml"
using RoleTop_Mvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40130ac7187dcd202880964e755b741b554ba5cf", @"/Views/Administrador/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9831b20a110a7fe8d48e85bedb72d07073eaf2a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTop_Mvc.ViewModel.DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 280, true);
            WriteLiteral(@"
<main>
    <h2 class=""titulomei"">Dashboard</h2>
    <section id=""status-pedidos"">
        <h3 class=""titulomei"">Status dos pedidos</h3>
        <div id=""painel"">
            <div class=""box-status-pedidos aprovados"">
                <h4>Aprovados</h4>
                <p>");
            EndContext();
            BeginContext(330, 26, false);
#line 10 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
              Write(Model.AgendamentoAprovados);

#line default
#line hidden
            EndContext();
            BeginContext(356, 137, true);
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"box-status-pedidos pendentes\">\r\n                <h4>Pendentes</h4>\r\n                <p>");
            EndContext();
            BeginContext(494, 26, false);
#line 14 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
              Write(Model.AgendamentoPendentes);

#line default
#line hidden
            EndContext();
            BeginContext(520, 139, true);
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"box-status-pedidos reprovados\">\r\n                <h4>Reprovados</h4>\r\n                <p>");
            EndContext();
            BeginContext(660, 27, false);
#line 18 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
              Write(Model.AgendamentoReprovados);

#line default
#line hidden
            EndContext();
            BeginContext(687, 998, true);
            WriteLiteral(@"</p>
            </div>
        </div>
    </section>
    <section id=""lista-pedidos"">
        <h3 class=""titulomei"">Lista de pedidos</h3>
        <table>
            <thead>
                <tr>
                    <th rowspan=""1"">Data do Pedido</th>
                    <th rowspan=""1"">Nome</th>
                    <th rowspan=""1"">Endereço</th>
                    <th colspan=""1"">Evento</th>
                    <th colspan=""1"">Adicionais</th>
                    <th colspan=""1"">N°de pessoas</th>
                    <th colspan=""1"">Parcelamento</th>
                    <th colspan=""1"">Acesso</th>
                    <th colspan=""2"" rowspan=""2"">Aprovar/Reprovar</th>
                </tr>
                <tr>
                    
                    <th></th>
                    <th></th>
                </tr>
            </thead>
            <tfoot>
                <tr>
                    <td colspan=""10"">
                        <p>Pedidos atualizados em ");
            EndContext();
            BeginContext(1686, 12, false);
#line 46 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                                             Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(1698, 99, true);
            WriteLiteral("</p>\r\n                    </td>\r\n                </tr>\r\n            </tfoot>\r\n            <tbody>\r\n");
            EndContext();
#line 51 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                 foreach (var Agendamentos in Model.Agendamento){

#line default
#line hidden
            BeginContext(1864, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1911, 25, false);
#line 53 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                   Write(Agendamentos.DatadoPedido);

#line default
#line hidden
            EndContext();
            BeginContext(1936, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1968, 25, false);
#line 54 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                   Write(Agendamentos.cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1993, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2025, 21, false);
#line 55 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                   Write(Agendamentos.Endereco);

#line default
#line hidden
            EndContext();
            BeginContext(2046, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2078, 23, false);
#line 56 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                   Write(Agendamentos.NomeEvento);

#line default
#line hidden
            EndContext();
            BeginContext(2101, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2133, 23, false);
#line 57 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                   Write(Agendamentos.Adicionais);

#line default
#line hidden
            EndContext();
            BeginContext(2156, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2188, 21, false);
#line 58 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                   Write(Agendamentos.Npessoas);

#line default
#line hidden
            EndContext();
            BeginContext(2209, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2241, 25, false);
#line 59 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                   Write(Agendamentos.Parcelamento);

#line default
#line hidden
            EndContext();
            BeginContext(2266, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2298, 25, false);
#line 60 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                   Write(Agendamentos.TipodoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(2323, 33, true);
            WriteLiteral("</td>\r\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2356, "\'", 2429, 1);
#line 61 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2363, Url.Action("Aprovar", "Agendamento", new {id = @Agendamentos.Id}), 2363, 66, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2430, 66, true);
            WriteLiteral("><i class=\"fas fa-check\"></i></a></td>\r\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2496, "\'", 2570, 1);
#line 62 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2503, Url.Action("Reprovar", "Agendamento", new {id = @Agendamentos.Id}), 2503, 67, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2571, 63, true);
            WriteLiteral("><i class=\"fas fa-times\"></i></a></td>\r\n                </tr>\r\n");
            EndContext();
#line 64 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                }

#line default
#line hidden
            BeginContext(2653, 385, true);
            WriteLiteral(@"                
    <table>
        <thead>
                
    </section>
            <h1>HISTORICO DO SITE</h1>
            <tr>
                <th>Data</th>
                <th>Tipo do evento</th>
                <th>Numero de Pessoas</th>
                <th>Preço</th>
                <th>Status do pedido</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 80 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
             foreach( var all in Model.Todos ) {

#line default
#line hidden
            BeginContext(3088, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(3135, 14, false);
#line 82 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                   Write(all.DataEvento);

#line default
#line hidden
            EndContext();
            BeginContext(3149, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3181, 14, false);
#line 83 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                   Write(all.NomeEvento);

#line default
#line hidden
            EndContext();
            BeginContext(3195, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3227, 12, false);
#line 84 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                   Write(all.Npessoas);

#line default
#line hidden
            EndContext();
            BeginContext(3239, 44, true);
            WriteLiteral("</td>\r\n                    <td>10.000</td>\r\n");
            EndContext();
#line 86 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                     if(@all.Status == 0){

#line default
#line hidden
            BeginContext(3327, 41, true);
            WriteLiteral("                    <td>Em analise</td>\r\n");
            EndContext();
#line 88 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                    
                    }else if(@all.Status == 1){

#line default
#line hidden
            BeginContext(3439, 45, true);
            WriteLiteral("                        <td> Aprovado </td>\r\n");
            EndContext();
#line 91 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                    }else if(@all.Status == 2){

#line default
#line hidden
            BeginContext(3533, 46, true);
            WriteLiteral("                        <td> Reprovado </td>\r\n");
            EndContext();
#line 93 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                    }

#line default
#line hidden
            BeginContext(3602, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 95 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
            }

#line default
#line hidden
            BeginContext(3640, 396, true);
            WriteLiteral(@"        </tbody>
    </table>

    <table>
        <thead>
            <h1>Todos os Usuarios</h1>
            <tr>
                <th>Nome</th>
                <th>CPF</th>
                <th>Telefone</th>
                <th>T.U</th> 
                <th>Status</th>
                <th colspan=""1"" rowspan=""1"">Banir</th>    
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 112 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
             foreach( var all in Model.TodosClientes) {

#line default
#line hidden
            BeginContext(4093, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(4140, 8, false);
#line 114 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                   Write(all.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(4148, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(4180, 7, false);
#line 115 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                   Write(all.CPF);

#line default
#line hidden
            EndContext();
            BeginContext(4187, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(4219, 12, false);
#line 116 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                   Write(all.Telefone);

#line default
#line hidden
            EndContext();
            BeginContext(4231, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 117 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                     if(@all.TipoUsuario == 0){

#line default
#line hidden
            BeginContext(4287, 43, true);
            WriteLiteral("                    <td>Adminstrador</td>\r\n");
            EndContext();
#line 119 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                    }else if(@all.TipoUsuario== 1)
                    {

#line default
#line hidden
            BeginContext(4405, 40, true);
            WriteLiteral("                        <td>Comun</td>\r\n");
            EndContext();
#line 122 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                    }

#line default
#line hidden
            BeginContext(4468, 21, true);
            WriteLiteral("                     ");
            EndContext();
#line 123 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                      if(@all.statusUsuario == 0){

#line default
#line hidden
            BeginContext(4520, 37, true);
            WriteLiteral("                    <td>Normal</td>\r\n");
            EndContext();
#line 125 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                    }else if(@all.statusUsuario== 1)
                    {

#line default
#line hidden
            BeginContext(4634, 43, true);
            WriteLiteral("                        <td> Banido </td>\r\n");
            EndContext();
#line 128 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
                    }

#line default
#line hidden
            BeginContext(4700, 26, true);
            WriteLiteral("                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 4726, "\'", 4803, 1);
#line 129 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 4733, Url.Action("Banir", "Agendamento", new {Status = @all.statusUsuario}), 4733, 70, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4804, 66, true);
            WriteLiteral("><i class=\"fas fa-times\"></i></a></td>   \r\n                </tr>\r\n");
            EndContext();
#line 131 "C:\Users\senai\Desktop\RoleTopMvc\RoleTop-Mvc\RoleTop-Mvc\Views\Administrador\Dashboard.cshtml"
            }

#line default
#line hidden
            BeginContext(4885, 73, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n         \r\n\r\n    </section>\r\n\r\n<main>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTop_Mvc.ViewModel.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
