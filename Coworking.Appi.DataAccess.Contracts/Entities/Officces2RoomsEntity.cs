using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Appi.DataAccess.Contracts.Entities
{
    public class Officces2RoomsEntity
    {
        public int OfficeId { get; set; }
        public int RoomId { get; set; }

        public virtual OfficeEntity Office { get; set; }
        public virtual RoomEntity Room { get; set; }
    }
}
