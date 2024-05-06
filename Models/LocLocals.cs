namespace s4h.Models
{
    public class LocLocals
    {
        public short Id { get; set; }

        public bool IsLocked { get; set; }

        public byte[]? RowVersion { get; set; }

        public int Number { get; set; }

        public string? Name { get; set; }

        public string? Shortcut { get; set; }

        public string? Description { get; set; }

        public int CURID { get; set; }

    }
}
