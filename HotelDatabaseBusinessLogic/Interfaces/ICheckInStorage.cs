using HotelDatabaseBusinessLogic.BindingModels;
using HotelDatabaseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseBusinessLogic.Interfaces
{
    public interface ICheckInStorage
    {
        List<CheckInViewModel> GetFullList();
        List<CheckInViewModel> GetFilteredList(CheckInBindingModel model);
        CheckInViewModel GetElement(CheckInBindingModel model);
        void Insert(CheckInBindingModel model);
        void Update(CheckInBindingModel model);
        void Delete(CheckInBindingModel model);
    }
}
