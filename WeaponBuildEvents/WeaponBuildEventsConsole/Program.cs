using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeaponBuildEvents.Database.Database;

namespace WeaponBuildEventsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WeaponBuildEvents.Database.Context.WeaponBuildEventsContext ctx = new WeaponBuildEvents.Database.Context.WeaponBuildEventsContext();
            RankListTop20 list = ctx.RankListTop20.FirstOrDefault();
            Console.WriteLine(list.CreateTime);
            Console.ReadKey();
        }
    }
}
