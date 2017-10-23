using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeaponBuildEvents.Database.Database
{
    public interface IEntity
    {
        long Id { get; set; }
        string ToString();
    }
}
