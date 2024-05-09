using FluentValidation;
using s4h.Models;

namespace s4h.Validators
{
    public class RomRoomValidator : AbstractValidator<RomRoom>
    {
        public RomRoomValidator() 
        {
            RuleFor(x => x.Locid).NotNull().GreaterThan((short) 0).WithMessage("Lokal musi być wybrany!");
            RuleFor(x => x.Rosid).NotNull().GreaterThan(0).WithMessage("Standard musi być wybrany!");
            RuleFor(x => x.Name).NotNull().WithMessage("Nazwa wymagana!");
            RuleFor(x => x.FloorNumber).NotNull().GreaterThan((short) 0).WithMessage("Numer pokoju wymagany!");
            RuleFor(x => x.Description).NotNull().WithMessage("Opis wymagany!");
            RuleFor(x => x.Color).NotNull().MinimumLength(2).WithMessage("Kolor wymagany!");
        }
    }
}
