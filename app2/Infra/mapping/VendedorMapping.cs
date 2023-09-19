using app2.Entity;
using System.Data.Entity.ModelConfiguration;

namespace app2.Infra.mapping
{
    class VendedorMapping : EntityTypeConfiguration<Vendedor>
    {
        public VendedorMapping() {
            ToTable("Vendedores");
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(100);
            Property(p => p.DateOfBirth).IsRequired();
            Property(p => p.Cpf).IsRequired().HasMaxLength(11);
        }
    }
}
