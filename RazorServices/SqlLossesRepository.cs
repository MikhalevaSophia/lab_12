using System;
using RazorModels;

namespace RazorServices
{
	public class SqlLossesRepository : ILossesRepository
	{
        private AppDbContext __db;

        public SqlLossesRepository(AppDbContext db)
		{
            __db = db;
		}

        public Loss Add(Loss loss)
        {
            throw new NotImplementedException();
        }

        public Loss Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Loss> GetAllLosses()
        {
            throw new NotImplementedException();
        }

        public Loss? GetLoss(int id)
        {
            throw new NotImplementedException();
        }

        public Loss Update(Loss uLoss)
        {
            throw new NotImplementedException();
        }
    }
}

