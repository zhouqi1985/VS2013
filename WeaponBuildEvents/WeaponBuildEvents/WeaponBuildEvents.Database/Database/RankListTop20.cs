using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WeaponBuildEvents.Database.Database
{
    public class RankListTop20 : BaseEntity, IUserEntity, IAvatarEntity
    {
        [Required]
        public long UserId
        {
            get;
            set;
        }
        [Required]
        public long AvatarId
        {
            get;
            set;
        }
        [Required]
        public int AreaId
        {
            get;
            set;
        }
        [Required]
        public string AvatarName
        {
            get;
            set;
        }
        public int RankOrder
        {
            get;
            set;
        }
        public DateTime CutOffDate
        {
            get;
            set;
        }
    }
}
