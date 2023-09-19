

using app2.Entity;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace app2
{
    public class Produto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
