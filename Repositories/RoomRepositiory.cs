using Microsoft.EntityFrameworkCore;
using s4h.Models;

namespace s4h.Repositories
{
    public class RoomRepositiory : IRoomRepository
    {
        private S4hHotelonlineContext context;
        public RoomRepositiory(S4hHotelonlineContext context)
        {
            this.context = context;
        }

        public void DeleteRoom(int roomId)
        {
            var room = context.RomRooms.Where(x => x.Id == roomId).FirstOrDefault();
            context.RomRooms.Remove(room);
            context.SaveChanges(); 
        }

        public RomRoom GetRoomByID(int roomId)
        {
            if (roomId == 0)
                return new RomRoom();

            return context.RomRooms.Where(x => x.Id == roomId).FirstOrDefault();
        }

        public IEnumerable<RomRoom> GetRooms()
        {
            return context.RomRooms.Include(x => x.Ros).Include(x => x.Loc);
        }

        public void InsertRoom(RomRoom room)
        {
            int higestNumber = context.RomRooms.Max(x => x.Number);
            var newRoom = new RomRoom()
            {
                Name = room.Name,
                Rosid = room.Rosid,
                Locid = room.Locid,
                Phone = room.Phone,
                FloorNumber = room.FloorNumber,
                HaveBathroom = room.HaveBathroom,
                ForPeopleWithDisabilities = room.ForPeopleWithDisabilities,
                Color = room.Color,
                IsLocked = room.IsLocked,
                Shortcut = room.Shortcut,
                Description = room.Description,
                Number = higestNumber + 1
            };

            context.Add(newRoom);
            int updated = context.SaveChanges();        
        }

        public void UpdateRoom(RomRoom room)
        {
            var entity = context.RomRooms.FirstOrDefault(item => item.Id == room.Id);

            if (entity != null)
            {
                // update
                entity.Name = room.Name;
                entity.Rosid = room.Rosid;
                entity.Locid = room.Locid;
                entity.Phone = room.Phone;
                entity.FloorNumber = room.FloorNumber;
                entity.HaveBathroom = room.HaveBathroom;
                entity.ForPeopleWithDisabilities = room.ForPeopleWithDisabilities;
                entity.Color = room.Color;
                entity.IsLocked = room.IsLocked;
                entity.Shortcut = room.Shortcut;
                entity.Description = room.Description;

                //context.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
