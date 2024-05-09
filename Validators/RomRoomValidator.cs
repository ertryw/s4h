using FluentValidation;
using s4h.Models;

namespace s4h.Validators
{
    public class RomRoomValidator : AbstractValidator<RomRoom>
    {
        public RomRoomValidator() 
        {
            RuleFor(x => x.Locid).NotNull().GreaterThan((short) 0);
            RuleFor(x => x.Rosid).NotNull().GreaterThan(0);
            RuleFor(x => x.Name).NotNull().MinimumLength(1);
            RuleFor(x => x.FloorNumber).NotNull().GreaterThan((short) 0);
            RuleFor(x => x.Description).NotNull().MinimumLength(1);
            RuleFor(x => x.Color).NotNull().MinimumLength(2);
        }
    }
}
