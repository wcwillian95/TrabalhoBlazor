#pragma checksum "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Compras\CadastrarCompras.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99da42c0d89f9c48949de2f750b829996dc653e3"
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
#line 11 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\_Imports.razor"
using MontadoraUBBlazor.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/compras/cadastrocompras")]
    public partial class CadastrarCompras : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Cadastrar Compras</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Compras\CadastrarCompras.razor"
                  compra

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Compras\CadastrarCompras.razor"
                                          CadastrarCompra

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group");
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.AddMarkupContent(9, "<label>Nome Da Peça Comprada</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Compras\CadastrarCompras.razor"
                                 compra.NomePecaCompra

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => compra.NomePecaCompra = __value, compra.NomePecaCompra))));
                __builder2.AddAttribute(13, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => compra.NomePecaCompra));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n\r\n    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group");
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.AddMarkupContent(19, "<label>ID da Peça comprada</label>\r\n        ");
                __Blazor.MontadoraUBBlazor.Client.Pages.Compras.CadastrarCompras.TypeInference.CreateInputNumber_0(__builder2, 20, 21, 
#nullable restore
#line 14 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Compras\CadastrarCompras.razor"
                                   compra.IDPecaCompra

#line default
#line hidden
#nullable disable
                , 22, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => compra.IDPecaCompra = __value, compra.IDPecaCompra)), 23, () => compra.IDPecaCompra);
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n\r\n    ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.AddMarkupContent(29, "<label>Codigo da peça comprada</label>>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Compras\CadastrarCompras.razor"
                                 compra.CodigoPecaCompra

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => compra.CodigoPecaCompra = __value, compra.CodigoPecaCompra))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => compra.CodigoPecaCompra));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n\r\n    ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.AddMarkupContent(39, "<label>Valor Unit. Peça Comprada</label>\r\n        ");
                __Blazor.MontadoraUBBlazor.Client.Pages.Compras.CadastrarCompras.TypeInference.CreateInputNumber_1(__builder2, 40, 41, 
#nullable restore
#line 24 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Compras\CadastrarCompras.razor"
                                   compra.ValorUnitPecaCompra

#line default
#line hidden
#nullable disable
                , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => compra.ValorUnitPecaCompra = __value, compra.ValorUnitPecaCompra)), 43, () => compra.ValorUnitPecaCompra);
                __builder2.AddMarkupContent(44, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n\r\n    ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-group");
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.AddMarkupContent(49, "<label>Qtd. Peças Compradas</label>\r\n        ");
                __Blazor.MontadoraUBBlazor.Client.Pages.Compras.CadastrarCompras.TypeInference.CreateInputNumber_2(__builder2, 50, 51, 
#nullable restore
#line 29 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Compras\CadastrarCompras.razor"
                                   compra.QtdPecaCompra

#line default
#line hidden
#nullable disable
                , 52, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => compra.QtdPecaCompra = __value, compra.QtdPecaCompra)), 53, () => compra.QtdPecaCompra);
                __builder2.AddMarkupContent(54, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\r\n    ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group");
                __builder2.AddMarkupContent(58, "\r\n        ");
                __builder2.AddMarkupContent(59, "<label>Valor Total da Compra</label>\r\n        ");
                __Blazor.MontadoraUBBlazor.Client.Pages.Compras.CadastrarCompras.TypeInference.CreateInputNumber_3(__builder2, 60, 61, 
#nullable restore
#line 34 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Compras\CadastrarCompras.razor"
                                   compra.ValorTotalCompra

#line default
#line hidden
#nullable disable
                , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => compra.ValorTotalCompra = __value, compra.ValorTotalCompra)), 63, () => compra.ValorTotalCompra);
                __builder2.AddMarkupContent(64, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n\r\n    ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group");
                __builder2.AddMarkupContent(68, "\r\n        ");
                __builder2.AddMarkupContent(69, "<label>ID do Fornecedor</label>\r\n        ");
                __Blazor.MontadoraUBBlazor.Client.Pages.Compras.CadastrarCompras.TypeInference.CreateInputNumber_4(__builder2, 70, 71, 
#nullable restore
#line 39 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Compras\CadastrarCompras.razor"
                                   compra.IDFornecedorCompra

#line default
#line hidden
#nullable disable
                , 72, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => compra.IDFornecedorCompra = __value, compra.IDFornecedorCompra)), 73, () => compra.IDFornecedorCompra);
                __builder2.AddMarkupContent(74, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n\r\n    ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "form-group");
                __builder2.AddMarkupContent(78, "\r\n        ");
                __builder2.AddMarkupContent(79, "<label>Nome do fornecedor</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(80);
                __builder2.AddAttribute(81, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Compras\CadastrarCompras.razor"
                                 compra.NomeFornecedorCompra

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => compra.NomeFornecedorCompra = __value, compra.NomeFornecedorCompra))));
                __builder2.AddAttribute(83, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => compra.NomeFornecedorCompra));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n\r\n    ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-group");
                __builder2.AddMarkupContent(88, "\r\n        ");
                __builder2.AddMarkupContent(89, "<label>ID do funcionario</label>\r\n        ");
                __Blazor.MontadoraUBBlazor.Client.Pages.Compras.CadastrarCompras.TypeInference.CreateInputNumber_5(__builder2, 90, 91, 
#nullable restore
#line 49 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Compras\CadastrarCompras.razor"
                                   compra.IDFuncionarioCompra

#line default
#line hidden
#nullable disable
                , 92, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => compra.IDFuncionarioCompra = __value, compra.IDFuncionarioCompra)), 93, () => compra.IDFuncionarioCompra);
                __builder2.AddMarkupContent(94, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n\r\n    ");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "form-group");
                __builder2.AddMarkupContent(98, "\r\n        ");
                __builder2.AddMarkupContent(99, "<label>Nome do funcionario</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(100);
                __builder2.AddAttribute(101, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 54 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Compras\CadastrarCompras.razor"
                                 compra.NomeFuncionarioCompra

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(102, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => compra.NomeFuncionarioCompra = __value, compra.NomeFuncionarioCompra))));
                __builder2.AddAttribute(103, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => compra.NomeFuncionarioCompra));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n\r\n    ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "form-group");
                __builder2.AddMarkupContent(108, "\r\n        ");
                __builder2.AddMarkupContent(109, "<label>Data da compra</label>\r\n        ");
                __Blazor.MontadoraUBBlazor.Client.Pages.Compras.CadastrarCompras.TypeInference.CreateInputDate_6(__builder2, 110, 111, 
#nullable restore
#line 59 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Compras\CadastrarCompras.razor"
                                 compra.DataCompra

#line default
#line hidden
#nullable disable
                , 112, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => compra.DataCompra = __value, compra.DataCompra)), 113, () => compra.DataCompra);
                __builder2.AddMarkupContent(114, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n\r\n    ");
                __builder2.AddMarkupContent(116, "<button type=\"submit\" class=\"btn btn-primary\">Cadastrar</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Compras\CadastrarCompras.razor"
       
    Compra compra = new Compra();
    async Task CadastrarCompra()
    {
        await http.PostAsJsonAsync("api/compra", compra);
        navigation.NavigateTo("compra");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.MontadoraUBBlazor.Client.Pages.Compras.CadastrarCompras
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
