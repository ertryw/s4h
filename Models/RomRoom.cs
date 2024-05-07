using System;
using System.Collections.Generic;

namespace s4h.Models;


public partial class RomRoom
{
    public int Id { get; set; }

    public int Rosid { get; set; }
    public RosRoomStandards? Ros { get; }
    public string? Phone { get; set; }

    public string? LockNumber { get; set; }

    public short FloorNumber { get; set; }

    public bool HaveBathroom { get; set; }

    public bool ForPeopleWithDisabilities { get; set; }

    public int OrderOnScheduler { get; set; }

    public string? Color { get; set; }

    public bool IsLocked { get; set; }

    public byte[]? RowVersion { get; set; }

    public int Number { get; set; }

    public string Name { get; set; } = null!;

    public string? Shortcut { get; set; }

    public string? Description { get; set; }

    public short Locid { get; set; }
    public LocLocals? Loc { get; }
    public string? DetailDescription { get; set; }
}
