using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace app2.Entity
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Cpf { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
