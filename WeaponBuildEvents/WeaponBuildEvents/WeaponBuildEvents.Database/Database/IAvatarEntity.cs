using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WeaponBuildEvents.Database.Database
{
    public interface IAvatarEntity
    {
        long AvatarId { get; set; }
        int AreaId { get; set; }

    }
}
