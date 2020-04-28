using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Appi.DataAccess.Contracts.Entities
{
    public class Room2ServicesEntity
    {
        public int RoomId { get; set; }
        public int ServiceId { get; set; }

        public virtual RoomEntity Room { get; set; }

        public virtual ServiceEntity Service { get; set; }
    }
}
