using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidaitonRules.GuestValidationRules
{
    public class UpdateGuestValidator : AbstractValidator<UpdateGuestDto>
    {
        public UpdateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim Alanı Boş Geçilemez");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir Alanı Boş Geçilemez");

            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Veri Girişi Yapınız");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Lütfen En Az 2 Karakter Veri Girişi Yapınız");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Veri Girişi Yapınız");

            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Lütfen En Fazla 20 Karakter Veri Girişi Yapınız");
            RuleFor(x => x.Surname).MaximumLength(30).WithMessage("Lütfen En Fazla 30 Karakter Veri Girişi Yapınız");
            RuleFor(x => x.City).MaximumLength(20).WithMessage("Lütfen En Fazla 20 Karakter Veri Girişi Yapınız");
        }
    }
}
