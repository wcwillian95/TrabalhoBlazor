#pragma checksum "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\Pages\Clientes\ListaCliente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32d69c9b31e482fccbeb3e0e7eff31acde38e3ea"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MontadoraUBBlazor.Client.Pages.Clientes
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
#line 3 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\Pages\Clientes\ListaCliente.razor"
using MontadoraUBBlazor.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/clientes/listaclientes")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/clientes")]
    public partial class ListaCliente : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\wcwil\Desktop\Programação Web\BlazorBDMontadora-master\MontadoraBlazorV23-master\MontadoraUBBlazor\Client\Pages\Clientes\ListaCliente.razor"
       
    List<Cliente> clientes;

    protected override async Task OnInitializedAsync()
    {
        await LoadClientes();
    }

    async Task LoadClientes()
    {
        clientes = await http.GetFromJsonAsync<List<Cliente>>("api/cliente");
    }

    async Task ExcluirCliente(int ID) 
    {
        await http.DeleteAsync($"api/cliente/{ID}");
        await LoadClientes();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
