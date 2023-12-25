using System;
using RazorModels;

namespace RazorServices
{
    public interface ILossesRepository
    {
        public IEnumerable<Loss> GetAllLosses();
        public Loss? GetLoss(int id);
        public Loss Add(Loss loss);
        public Loss Update(Loss uLoss);
        public Loss Delete(int id);
    }
}

