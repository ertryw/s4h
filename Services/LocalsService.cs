using s4h.Models;

namespace s4h.Services
{
    public interface ILocalsService
    {
        IEnumerable<LocLocals> GetLocals();
        IEnumerable<RosRoomStandards> GetLocalStandards(int localId);
    }

    public class LocalsService : ILocalsService
    {
        private S4hHotelonlineContext context;
        public LocalsService(S4hHotelonlineContext context)
        {
            this.context = context;
        }

        public IEnumerable<LocLocals> GetLocals()
        {
            return context.LocLocals.ToList();
        }

        public IEnumerable<RosRoomStandards> GetLocalStandards(int localId)
        {
            return context.RosRoomStandards.Where(x => x.LOCID == localId).ToList();
        }
    }
}
