using System;
using RazorModels;

namespace RazorServices
{
	public class SqlPrinceplesRepository : IPrinceplesRepository
	{
        private AppDbContext __db;

        public SqlPrinceplesRepository(AppDbContext db)
		{
            __db = db;
		}

        public Principle Add(Principle princeple)
        {
            throw new NotImplementedException();
        }

        public Principle Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Principle> GetAllPrinceples()
        {
            throw new NotImplementedException();
        }

        public Principle? GetPrinceples(int id)
        {
            throw new NotImplementedException();
        }

        public Principle Update(Principle uPrinceple)
        {
            throw new NotImplementedException();
        }
    }
}

