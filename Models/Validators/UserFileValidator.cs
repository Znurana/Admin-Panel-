using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_AdminPanel.Models.VM;

namespace Test_AdminPanel.Models.Validators
{
    public class UserFileValidator : AbstractValidator<UserFileVM>
    {

        //konstruktorun icinde şərtlərimizi yazırıq
        public UserFileValidator()
        {
            RuleFor(x => x.UserFirstName).NotNull().WithMessage("Adinizi daxil edin");


            RuleFor(x => x.UserLastName).NotNull().WithMessage("Soyadinizi daxil edin");

            RuleFor(x => x.UserName).NotNull().WithMessage("UserName daxil edin");
            RuleFor(x => x.UserPassword).NotNull().WithMessage("Password daxil edin");
            RuleFor(x => x.UserFatherName).NotNull().WithMessage("Ata adi daxil edin ");
            RuleFor(x => x.KassaID).NotNull().WithMessage("Kassa ID daxil edin ");
            RuleFor(x => x.StationID).NotNull().WithMessage("Station Id daxil edin ");
            RuleFor(x => x.ProfileImage).NotNull().WithMessage("Please choose profile image");



        }


    }
}
