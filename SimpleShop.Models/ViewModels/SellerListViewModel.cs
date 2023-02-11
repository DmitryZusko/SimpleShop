using AutoMapper;
using Microsoft.Identity.Client;
using SimpleShop.Models.Commands;
using SimpleShop.Models.Mappers;
using SimpleShop.Models.Models;
using SimpleShop.Models.Services;
using SimpleShop.Models.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels
{
    public class SellerListViewModel : ViewModelBase
    {
        private readonly SimpleShopEntity _simpleShop;
        private readonly IMapper _mapper;
        public ObservableCollection<SellerVM> Sellers { get; set; }
        public ICommand ShowSellersCommand { get; }
        public ICommand ShowCustomersCommand { get; }
        public ICommand ShowOrdersCommand { get; }
        public ICommand ShowOrderFullInfoCommand { get; }
        public ICommand AddNewSellerCommand { get; }
        public ICommand UpdateSellerCommand { get; }
        public ICommand DeleteSellerCommand { get; }

        public SellerListViewModel(NavigationService navigationService, SimpleShopEntity simpleShop) : base(navigationService, simpleShop)
        {
            _simpleShop = simpleShop;
            _mapper = ConfiguredMapper.config.CreateMapper();

            Sellers = new ObservableCollection<SellerVM> (simpleShop.GetSellersList().Select(s => _mapper.Map<SellerVM>(s)));

            ShowSellersCommand = new ShowSellersCommand(NavigationService, CreateSellerListViewModel);
            ShowCustomersCommand = new ShowCustomersCommand(NavigationService, CreateCustomerListViewModel);
            ShowOrdersCommand = new ShowOrdersCommand(NavigationService, CreateOrderListViewModel);
            //ShowOrderFullInfoCommand = new ShowOrderFullInfoCommand(NavigationService);
            AddNewSellerCommand = new AddNewSellerCommand(NavigationService, CreateSellerviewModel);
            UpdateSellerCommand = new UpdateSellerCommand(NavigationService, CreateSellerviewModel);
            //DeleteSellerCommand = new DeleteSellerCommand(NavigationService);
        }

        public override bool NavigationStoreShouldStore()
        {
            return true;
        }
    }
}
