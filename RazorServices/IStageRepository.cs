using System;
using RazorModels;

namespace RazorServices
{
    public interface IStageRepository
    {
        public IEnumerable<Stage> GetAllStages();
        public Stage? GetStage(int id);
        public Stage Add(Stage stage);
        public Stage Update(Stage uStage);
        public Stage Delete(int id);
    }
}

