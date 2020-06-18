using MontadoraUBBlazor.Server.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MontadoraUBBlazor.Shared.Models;
using Microsoft.AspNetCore.SignalR;

namespace MontadoraUBBlazor.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Peca> Pecas { get; set; }
        public DbSet<Venda> Vendas { get; set; }
    }

}
