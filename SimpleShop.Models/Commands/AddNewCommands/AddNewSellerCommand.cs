﻿using SimpleShop.Models.Services.Navigation;
using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Commands.AddNewCommands
{
    internal class AddNewSellerCommand : CommandBase
    {
        private NavigationService _navigationService;
        private Func<ViewModelBase> _sellerViewModel;

        public AddNewSellerCommand(NavigationService navigationService, Func<ViewModelBase> sellerViewModel)
        {
            _navigationService = navigationService;
            _sellerViewModel = sellerViewModel;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.CreateViewModel(_sellerViewModel);
        }
    }
}
