using System;
using RazorModels;

namespace RazorServices
{
	public class SqlStagesRepository : IStageRepository
	{
        private AppDbContext __db;

		public SqlStagesRepository(AppDbContext db)
		{
            __db = db;
		}

        public Stage Add(Stage stage)
        {
            __db.Stages.Add(stage);
            __db.SaveChanges();
            return stage;
        }

        public Stage Delete(int id)
        {
            var passToDel = __db.Stages.Find(id);

            if (passToDel != null)
            {
                __db.Stages.Remove(passToDel);
                __db.SaveChanges();
            }
            return passToDel;
        }

        public IEnumerable<Stage> GetAllStages()
        {
            return __db.Stages;
        }

        public Stage? GetStage(int id)
        {
            return __db.Stages.Find(id);
        }

        public Stage Update(Stage uStage)
        {
            var pass = __db.Stages.Attach(uStage);
            pass.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            __db.SaveChanges();
            return uStage;
        }
    }
}

