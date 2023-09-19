using app2.Entity;
using System.Data.Entity.ModelConfiguration;

namespace app2.Infra.mapping
{
    class VendaMapping : EntityTypeConfiguration<Venda>
    {
        public VendaMapping()
        {
            ToTable("Venda");
            HasKey(p => p.Id);

            // Relação com a tabela Vendedor (um-para-um ou muitos-para-um)
            HasRequired(p => p.Vendedor).WithMany(p => p.Vendas).HasForeignKey(v => v.SellerId);

            // Relação com a tabela Comprador (um-para-um ou muitos-para-um)
            HasRequired(v => v.Cliente).WithMany(p => p.Vendas).HasForeignKey(v => v.ClientId);

            // Relação com a tabela Produto (um-para-um ou muitos-para-um)
            HasRequired(v => v.Produto).WithMany(p => p.Vendas).HasForeignKey(v => v.ProductId);
        }
    }
}
