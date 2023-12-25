using System;
using RazorModels;

namespace RazorServices
{
    public class MockLossesRepository : ILossesRepository
    {
        List<Loss> __losses;

        public MockLossesRepository()
        {
            __losses = new List<Loss>()
            {
                new Loss()
                {
                    LossId = 0
                },
                new Loss()
                {
                    LossId = 1
                },
                new Loss()
                {
                    LossId = 2
                }
            };
        }

        public Loss Add(Loss loss)
        {
            loss.LossId = __losses.Max(x => x.LossId) + 1;
            __losses.Add(loss);
            return loss;
        }

        public Loss Delete(int id)
        {
            var loss = __losses.FirstOrDefault(p => p.LossId == id);
            if (loss != null)
            {
                __losses.Remove(loss);
            }
            return loss;
        }

        public IEnumerable<Loss> GetAllLosses()
        {
            return __losses;
        }

        public Loss? GetLoss(int id)
        {
            return __losses.FirstOrDefault(p => p.LossId == id);
        }

        public Loss Update(Loss uTrain)
        {
            Loss loss = __losses.FirstOrDefault(p => p.LossId == uTrain.LossId);
            if (loss != null)
            {
				loss.LossId = uTrain.LossId;
            }
            return loss;
        }
    }
}

