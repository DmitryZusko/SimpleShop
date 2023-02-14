﻿using SimpleShop.Models.Models;
using SimpleShop.Models.Services.MVMServices.MVMRemovers;
using SimpleShop.Models.Services.Navigation;
using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels;
using SimpleShop.Models.ViewModels.DeleteViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Commands.DeleteCommands
{
    internal class DeleteSellerCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        private readonly SellerMVMRemover _sellerRemover;
        private readonly SellerDeleteViewModel _parentviewModel;
        private readonly Func<ViewModelBase> _createNewView;
        private int _id;

        public DeleteSellerCommand(NavigationService navigationService, SellerMVMRemover sellerRemover, int ID, Func<ViewModelBase> createNewView, SellerDeleteViewModel parentViewModel)
        {
            _navigationService = navigationService;
            _sellerRemover = sellerRemover;
            _id = ID;
            _parentviewModel = parentViewModel;
            _createNewView = createNewView;
            _parentviewModel.PropertyChanged += _parentviewModel_PropertyChanged;
        }

        private void _parentviewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            _id = _parentviewModel.ID;
        }

        public override void Execute(object? parameter)
        {
            _sellerRemover.Remove(_id);
            _navigationService.CreateViewModel(_createNewView);
        }
    }
}
