namespace WeaponBuildEvents.Database.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WeaponBuildEvents.Database.Database;

    internal sealed class Configuration : DbMigrationsConfiguration<WeaponBuildEvents.Database.Context.WeaponBuildEventsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WeaponBuildEvents.Database.Context.WeaponBuildEventsContext context)
        {
            List<RankListTop20> ranklist = new List<RankListTop20>{
    new RankListTop20{UserId=1,AreaId=0,AvatarId=1,AvatarName="aa"}


};

            context.RankListTop20.AddRange(ranklist);
            context.SaveChanges();
        }
    }
}
