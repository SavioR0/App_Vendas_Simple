using app2.Entity;
using app2.Infra.mapping;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection;

namespace app2.data
{
    public class TreinamentoContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Venda> Vendas { get; set; }


        public TreinamentoContext() : base(@"Data Source=PROGRAMACAO202\SQLEXPRESS;Initial Catalog=app2;User Id=sa;Password=senh@123;Integrated Security=False;Persist Security Info=True;Multipleactiveresultsets=True;")
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
