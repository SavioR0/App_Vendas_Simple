using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace app2.Entity
{
    public class Cliente
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Cpf{ get; set; }
        public string Tel { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<Venda> Vendas { get; set; }

    }
}
