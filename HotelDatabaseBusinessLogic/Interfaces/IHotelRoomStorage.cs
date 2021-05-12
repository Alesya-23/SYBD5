using HotelDatabaseBusinessLogic.BindingModels;
using HotelDatabaseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseBusinessLogic.Interfaces
{
    public interface IHotelRoomStorage
    {
        List<HotelRoomViewModel> GetFullList();
        List<HotelRoomViewModel> GetFilteredList(HotelRoomBindingModel model);
        HotelRoomViewModel GetElement(HotelRoomBindingModel model);
        void Insert(HotelRoomBindingModel model);
        void Update(HotelRoomBindingModel model);
        void Delete(HotelRoomBindingModel model);
    }
}
