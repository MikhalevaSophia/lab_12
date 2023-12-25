using System;
using RazorModels;

namespace RazorServices
{
    public interface IPrinceplesRepository
    {
        public IEnumerable<Principle> GetAllPrinceples();
        public Principle? GetPrinceples(int id);
        public Principle Add(Principle princeple);
        public Principle Update(Principle uPrinceple);
        public Principle Delete(int id);
    }
}

