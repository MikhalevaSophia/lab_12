using System;
using RazorModels;

namespace RazorServices
{
	public class MockStagesRepository : IStageRepository
	{
        private List<Stage> __stage;

		public MockStagesRepository()
		{
            __stage = new List<Stage>()
            {
                new Stage()
                {
                    StageId = 1,
                    Name = "Print",
                },
                new Stage()
                {
                    StageId = 2,
                    Name = "Welding",
                },
                new Stage()
                {
                    StageId = 3,
                    Name = "Finish",
                }
            };
		}

        public Stage Add(Stage stage)
        {
            stage.StageId = __stage.Max(x => x.StageId) + 1;
            __stage.Add(stage);
            return stage;
        }

        public Stage Delete(int id)
        {
            var stage = __stage.FirstOrDefault(p => p.StageId == id);
            if (stage != null)
            {
                __stage.Remove(stage);
            }
            return stage;
        }

        public IEnumerable<Stage> GetAllStages()
        {
            return __stage;
        }

        public Stage? GetStage(int id)
        {
            return __stage.FirstOrDefault(p => p.StageId == id);
        }

        public Stage Update(Stage uStage)
        {
            Stage pass = __stage.FirstOrDefault(p => p.StageId == uStage.StageId);
            if (pass != null)
            {
                pass.Name = uStage.Name;
            }
            return pass;
        }
    }
}

