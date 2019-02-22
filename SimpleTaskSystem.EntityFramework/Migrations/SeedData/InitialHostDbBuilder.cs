using SimpleTaskSystem.EntityFramework;
using EntityFramework.DynamicFilters;

namespace SimpleTaskSystem.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly SimpleTaskSystemDbContext _context;

        public InitialHostDbBuilder(SimpleTaskSystemDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
