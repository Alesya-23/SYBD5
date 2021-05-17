using HotelDatabaseBusinessLogic.BindingModels;
using HotelDatabaseBusinessLogic.Interfaces;
using HotelDatabaseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseBusinessLogic.BussinessLogic
{
    public class CheckInLogic
    {
        private readonly ICheckInStorage checkInStorage;

        public CheckInLogic(ICheckInStorage checkInStorage)
        {
            this.checkInStorage = checkInStorage;
        }

        public List<CheckInViewModel> Read(CheckInBindingModel model)
        {
            if (model == null)
            {
                return checkInStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<CheckInViewModel> { checkInStorage.GetElement(model) };
            }
            return checkInStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(CheckInBindingModel model)
        {
            var element = checkInStorage.GetElement(new CheckInBindingModel { Id = model.Id });

            if (element != null)
            {
                checkInStorage.Update(model);
            }
            else
            {
                checkInStorage.Insert(model);
            }
        }

        public void Delete(CheckInBindingModel model)
        {
            var element = checkInStorage.GetElement(new CheckInBindingModel { Id = model.Id });

            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            checkInStorage.Delete(model);
        }
    }
}
