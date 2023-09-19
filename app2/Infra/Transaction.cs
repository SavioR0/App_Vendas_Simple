using app2.data;
using System.Data;
using System.Data.Entity;

namespace app2.Infra
{
    public class Transaction
    {
        public static DbContextTransaction CreateDbContextTransaction(TreinamentoContext db)
        {
            return db.Database.BeginTransaction(IsolationLevel.ReadUncommitted);
        }
    }
}
