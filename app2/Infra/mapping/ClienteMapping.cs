using app2.Entity;
using System.Data.Entity.ModelConfiguration;

namespace app2.Infra.mapping
{
    class ClienteMapping : EntityTypeConfiguration<Cliente>
    {
        public ClienteMapping(){
            ToTable("Clientes");
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(100);
            Property(p => p.Tel).IsRequired().HasMaxLength(20);
            Property(p => p.Cpf).IsRequired().HasMaxLength(11);
        }
    }
}
