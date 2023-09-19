using System.Runtime.Serialization;

namespace app2.Entity
{
    public class Venda
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int SellerId { get; set; }
        public int ClientId { get; set; }

        [IgnoreDataMember]
        public virtual Produto Produto { get; set; }

        [IgnoreDataMember]
        public virtual Cliente Cliente { get; set; }

        [IgnoreDataMember]
        public virtual Vendedor Vendedor { get; set; }
    }
}
