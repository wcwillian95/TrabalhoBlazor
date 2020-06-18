using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MontadoraUBBlazor.Server.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCliente = table.Column<string>(nullable: true),
                    CPFCliente = table.Column<string>(nullable: true),
                    NascimentoCliente = table.Column<DateTime>(nullable: false),
                    TelefoneCliente = table.Column<string>(nullable: true),
                    EmailCliente = table.Column<string>(nullable: true),
                    CEPCliente = table.Column<string>(nullable: true),
                    RuaCliente = table.Column<string>(nullable: true),
                    BairroCliente = table.Column<string>(nullable: true),
                    CidadeCliente = table.Column<string>(nullable: true),
                    EstadoCliente = table.Column<string>(nullable: true),
                    DataCadastroCliente = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePecaCompra = table.Column<string>(nullable: true),
                    IDPecaCompra = table.Column<int>(nullable: false),
                    CodigoPecaCompra = table.Column<string>(nullable: true),
                    ValorUnitPecaCompra = table.Column<decimal>(nullable: false),
                    QtdPecaCompra = table.Column<int>(nullable: false),
                    ValorTotalCompra = table.Column<decimal>(nullable: false),
                    IDFornecedorCompra = table.Column<int>(nullable: false),
                    NomeFornecedorCompra = table.Column<string>(nullable: true),
                    IDFuncionarioCompra = table.Column<int>(nullable: false),
                    NomeFuncionarioCompra = table.Column<string>(nullable: true),
                    DataCompra = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFornecedor = table.Column<string>(nullable: true),
                    CNPJFornecedor = table.Column<string>(nullable: true),
                    TelefoneFornecedor = table.Column<string>(nullable: true),
                    EmailFornecedor = table.Column<string>(nullable: true),
                    DataCadastroFornecedor = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFunc = table.Column<string>(nullable: true),
                    CPFFunc = table.Column<string>(nullable: true),
                    TelefoneFunc = table.Column<string>(nullable: true),
                    EmailFunc = table.Column<string>(nullable: true),
                    CEPFunc = table.Column<string>(nullable: true),
                    RuaFunc = table.Column<string>(nullable: true),
                    BairroFunc = table.Column<string>(nullable: true),
                    CidadeFunc = table.Column<string>(nullable: true),
                    EstadoFunc = table.Column<string>(nullable: true),
                    NascimentoFunc = table.Column<DateTime>(nullable: false),
                    EntradaFunc = table.Column<DateTime>(nullable: false),
                    SaidaFunc = table.Column<DateTime>(nullable: false),
                    CargoFunc = table.Column<string>(nullable: true),
                    StatusFunc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pecas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePeca = table.Column<string>(nullable: true),
                    ValorUnitPeca = table.Column<decimal>(nullable: false),
                    IDFornecedorPeca = table.Column<int>(nullable: false),
                    NomeFornecedorPeca = table.Column<string>(nullable: true),
                    CodigoPeca = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pecas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodPecaVenda = table.Column<string>(nullable: true),
                    QtdPecaVenda = table.Column<decimal>(nullable: false),
                    ValorUnitPecaVenda = table.Column<decimal>(nullable: false),
                    ValorTotalVenda = table.Column<decimal>(nullable: false),
                    IDClienteVenda = table.Column<int>(nullable: false),
                    NomeClienteVenda = table.Column<string>(nullable: true),
                    IDFuncVenda = table.Column<int>(nullable: false),
                    NomeFuncVenda = table.Column<string>(nullable: true),
                    DataVenda = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Fornecedores");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Pecas");

            migrationBuilder.DropTable(
                name: "Vendas");
        }
    }
}
