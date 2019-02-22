using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using SimpleTaskSystem.EntityFramework;

namespace SimpleTaskSystem
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(SimpleTaskSystemCoreModule))]
    public class SimpleTaskSystemDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<SimpleTaskSystemDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
