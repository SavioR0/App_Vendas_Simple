using System.Data.Entity.ModelConfiguration;

namespace app2.Infra.mapping
{
    class ProdutoMapping : EntityTypeConfiguration<Produto>
    {
        public ProdutoMapping() {
            ToTable("Produtos");
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(100);
            Property(p => p.Description).IsRequired().HasMaxLength(500);
            Property(p => p.Stock).IsRequired();
            Property(p => p.Value).IsRequired();

        }
    }
}
