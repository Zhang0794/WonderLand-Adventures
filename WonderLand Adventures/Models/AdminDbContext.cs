using System.Data.Entity;
using WonderLandAdventures.Models;

namespace WonderLandAdventures.Models
{
    public class AdminDbContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }

        public AdminDbContext() : base("name=DefaultConnection")
        {
            // 初始化策略
            Database.SetInitializer(new AdminDbInitializer());
        }
    }

    public class AdminDbInitializer : DropCreateDatabaseIfModelChanges<AdminDbContext>
    {
        protected override void Seed(AdminDbContext context)
        {
            // 预置管理员账号
            context.Admins.AddRange(new[] {
                new Admin { AdminId = "yx", Password = "123", Name = "系统管理员" },
                new Admin { AdminId = "sss", Password = "abc", Name = "超级管理员" }
            });

            base.Seed(context);
        }
    }
}