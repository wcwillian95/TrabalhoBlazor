#pragma checksum "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\Pages\Compras\ListarCompras.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26ade8067d240222b0a2341fe95e8e32a91bf09a"
// <auto-generated/>
#pragma warning disable 1591
namespace MontadoraUBBlazor.Client.Pages.Compras
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\_Imports.razor"
using MontadoraUBBlazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\_Imports.razor"
using MontadoraUBBlazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\Pages\Compras\ListarCompras.razor"
using MontadoraUBBlazor.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/compras/listacompras")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/compras/")]
    public partial class ListarCompras : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Lista de Compras feitas pela empresa</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div>\r\n    <a href=\"/compras/cadastrocompras\" class=\"btn btn-primary\">Cadastrar compras</a>\r\n</div>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 12 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\Pages\Compras\ListarCompras.razor"
     if (compras == null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "Nenhuma compra foi cadastrada no banco de dados");
#nullable restore
#line 14 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\Pages\Compras\ListarCompras.razor"
                                                                    
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "        ");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, @"<thead>
                <tr>
                    <th> Nome da Peça comprada </th>
                    <th> Valor Unit. da peça comprada </th>
                    <th> Qtd de peças </th>
                    <th> Valor Total da compra </th>
                    <th> Nome do Fornecedor </th>
                    <th> Nome do Funcionario que fez a compra </th>
                    <th> Data de compra </th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(10, "tbody");
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 31 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\Pages\Compras\ListarCompras.razor"
                 foreach (var compra in compras)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "                ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 34 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\Pages\Compras\ListarCompras.razor"
                         compra.NomePecaCompra

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 35 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\Pages\Compras\ListarCompras.razor"
                         compra.ValorUnitPecaCompra

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 36 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\Pages\Compras\ListarCompras.razor"
                         compra.QtdPecaCompra

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 37 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\Pages\Compras\ListarCompras.razor"
                         compra.ValorTotalCompra

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 38 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\Pages\Compras\ListarCompras.razor"
                         compra.NomeFornecedorCompra

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 39 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\Pages\Compras\ListarCompras.razor"
                         compra.NomeFuncionarioCompra

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 40 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\Pages\Compras\ListarCompras.razor"
                         compra.DataCompra

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "btn btn-danger");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\Pages\Compras\ListarCompras.razor"
                                                                   () => ExcluirCompra(compra.ID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "Excluir");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 45 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\Pages\Compras\ListarCompras.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 48 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\Pages\Compras\ListarCompras.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\Pages\Compras\ListarCompras.razor"
       
        List<Compra> compras;

    protected override async Task OnInitializedAsync()
    {
        await LoadCompras();
    }

    async Task LoadCompras()
    {
        compras = await http.GetFromJsonAsync<List<Compra>>("api/Compras");
    }

    async Task ExcluirCompra(int ID)
    {
        await http.DeleteAsync($"api/Compras/{ID}");
        await LoadCompras();


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591