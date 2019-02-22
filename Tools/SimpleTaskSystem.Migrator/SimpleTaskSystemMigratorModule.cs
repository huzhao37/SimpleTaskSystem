using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using SimpleTaskSystem.EntityFramework;

namespace SimpleTaskSystem.Migrator
{
    [DependsOn(typeof(SimpleTaskSystemDataModule))]
    public class SimpleTaskSystemMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<SimpleTaskSystemDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}