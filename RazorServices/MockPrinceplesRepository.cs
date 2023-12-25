using System;
using RazorModels;

namespace RazorServices
{
	public class MockPrinceplesRepository : IPrinceplesRepository
	{
        List<Principle> __tprinceples { get; set; }
		public MockPrinceplesRepository()
		{
            __tprinceples = new List<Principle>()
            {
                new Principle()
                {
                    PrincepleId = 1,
                    StageID = 0,
                    Price = 50
                },
                new Principle()
                {
                    PrincepleId = 2,
                    StageID = 1,
                    Price = 100
                }
            };
		}

        public Principle Add(Principle princeple)
        {
            princeple.StageID = __tprinceples.Max(x => x.PrincepleId) + 1;
            __tprinceples.Add(princeple);
            return princeple;
        }

        public Principle Delete(int id)
        {
            var ticket = __tprinceples.FirstOrDefault(p => p.PrincepleId == id);
            if (ticket != null)
            {
                __tprinceples.Remove(ticket);
            }
            return ticket;
        }

        public IEnumerable<Principle> GetAllPrinceples()
        {
            return __tprinceples;
        }

        public Principle? GetPrinceples(int id)
        {
            return __tprinceples.FirstOrDefault(p => p.PrincepleId == id);
        }

        public Principle Update(Principle uTicket)
        {
            Principle ticket = __tprinceples.FirstOrDefault(t => t.PrincepleId == uTicket.PrincepleId);
            if (ticket != null)
            {
                ticket.Price = uTicket.Price;
            }
            return ticket;
        }
    }
}

