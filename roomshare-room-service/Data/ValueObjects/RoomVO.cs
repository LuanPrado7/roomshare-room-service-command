﻿namespace roomshare_room_service.Data.ValueObjects
{
    public class RoomVO
    {
        public long Id { get; set; }
        public Guid RoomKey { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Guid LocatorKey { get; set; }
        public string? Address { get; set; }
        public long CEP { get; set; }
    }
}
