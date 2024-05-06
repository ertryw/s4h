namespace s4h.Models
{
    public class RosRoomStandards
    {
        public int Id { get; set; }
        public short LOCID { get; set; }
        public short StandardNumberOfPlaces { get; set; }
        public short NumberOfExtraBeds { get; set; }
        public bool IsLocked { get; set; }

        public string? Color { get; set; }

        public bool IsVisibleOnline { get; set; }
        public bool IsVirtual { get; set; }
        public bool IsLockedExtraBedsOnline { get; set; }
        public byte[]? RowVersion { get; set; }

        public int Number { get; set; }
        public string? Name { get; set; }
        public string? Shortcut { get; set; }
        public string? Description { get; set; }
        public string? DetailDescription { get; set; }
        public bool ExtraBedsForAdult { get; set; }

    }
}
