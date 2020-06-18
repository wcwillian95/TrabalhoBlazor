#pragma checksum "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Funcionarios\ListarFuncionarios.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56cc773ea4b76148d36ec8cef53246a721c8c40e"
// <auto-generated/>
#pragma warning disable 1591
namespace MontadoraUBBlazor.Client.Pages.Funcionarios
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\_Imports.razor"
using MontadoraUBBlazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\_Imports.razor"
using MontadoraUBBlazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Funcionarios\ListarFuncionarios.razor"
using MontadoraUBBlazor.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/funcionarios/listafuncionarios")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/funcionarios/")]
    public partial class ListarFuncionarios : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Lista de Fornecedores</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div>\r\n    <a href=\"/funcionarios/cadastrofuncionarios\" class=\"btn btn-primary\">Cadastrar Funcionarios</a>\r\n</div>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 12 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Funcionarios\ListarFuncionarios.razor"
     if (funcionarios == null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "Carregando...");
#nullable restore
#line 14 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Funcionarios\ListarFuncionarios.razor"
                                  
    }
    else if (funcionarios.Count == 0)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "Nenhuma compra foi cadastrada no banco de dados");
#nullable restore
#line 18 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Funcionarios\ListarFuncionarios.razor"
                                                                    
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "        ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, @"<thead>
                <tr>
                    <th> Id </th>
                    <th> Nome </th>
                    <th> CPF </th>
                    <th> Telefone</th>
                    <th> E-mail </th>
                    <th> Rua e numero, apartamento e andar se for o caso </th>
                    <th> Bairro </th>
                    <th> Cidade </th>
                    <th> Estado </th>
                    <th> Data de Nascimento </th>
                    <th> Data de entrada na empresa</th>
                    <th> Data de saida da empresa</th>
                    <th> Cargo </th>
                    <th> Status </th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(11, "tbody");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 42 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Funcionarios\ListarFuncionarios.razor"
                 foreach (var funcionarios in funcionarios)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 45 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Funcionarios\ListarFuncionarios.razor"
                         funcionarios.ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 46 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Funcionarios\ListarFuncionarios.razor"
                         funcionarios.NomeFunc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 47 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Funcionarios\ListarFuncionarios.razor"
                         funcionarios.CPFFunc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 48 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Funcionarios\ListarFuncionarios.razor"
                         funcionarios.TelefoneFunc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 49 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Funcionarios\ListarFuncionarios.razor"
                         funcionarios.EmailFunc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 50 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Funcionarios\ListarFuncionarios.razor"
                         funcionarios.RuaFunc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 51 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Funcionarios\ListarFuncionarios.razor"
                         funcionarios.BairroFunc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 52 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Funcionarios\ListarFuncionarios.razor"
                         funcionarios.CidadeFunc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 53 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Funcionarios\ListarFuncionarios.razor"
                         funcionarios.EstadoFunc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 54 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Funcionarios\ListarFuncionarios.razor"
                         funcionarios.NascimentoFunc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 55 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Funcionarios\ListarFuncionarios.razor"
                         funcionarios.EntradaFunc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 56 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Funcionarios\ListarFuncionarios.razor"
                         funcionarios.SaidaFunc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "td");
            __builder.AddContent(53, 
#nullable restore
#line 57 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Funcionarios\ListarFuncionarios.razor"
                         funcionarios.CargoFunc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.OpenElement(55, "td");
            __builder.AddContent(56, 
#nullable restore
#line 58 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Funcionarios\ListarFuncionarios.razor"
                         funcionarios.StatusFunc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 60 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Funcionarios\ListarFuncionarios.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 63 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Funcionarios\ListarFuncionarios.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Funcionarios\ListarFuncionarios.razor"
       
    List<Funcionario> funcionarios;

    protected override async Task OnInitializedAsync()
    {
        await LoadFuncionarios();
    }

    async Task LoadFuncionarios()
    {
        funcionarios = await http.GetFromJsonAsync<List<Funcionario>>("api/funcionarios");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
