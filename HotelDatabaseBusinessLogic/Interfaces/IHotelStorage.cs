using HotelDatabaseBusinessLogic.BindingModels;
using HotelDatabaseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseBusinessLogic.Interfaces
{
    public interface IHotelStorage
    {
        List<HotelViewModel> GetFullList();
        List<HotelViewModel> GetFilteredList(HotelBindingModel model);
        HotelViewModel GetElement(HotelBindingModel model);
        void Insert(HotelBindingModel model);
        void Update(HotelBindingModel model);
        void Delete(HotelBindingModel model);
    }
}
