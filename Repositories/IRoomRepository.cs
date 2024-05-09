using s4h.Models;

namespace s4h.Repositories
{
    public interface IRoomRepository
    {
        IEnumerable<RomRoom> GetRooms();
        RomRoom GetRoomByID(int roomId);
        void InsertRoom(RomRoom room);
        void DeleteRoom(int roomId);
        void UpdateRoom(RomRoom room);
    }
}
