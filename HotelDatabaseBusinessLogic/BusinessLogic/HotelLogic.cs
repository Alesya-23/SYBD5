using HotelDatabaseBusinessLogic.BindingModels;
using HotelDatabaseBusinessLogic.Interfaces;
using HotelDatabaseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseBusinessLogic.BussinessLogic
{
    public class HotelLogic
    {
        private readonly IHotelStorage hotelStorage;

        public HotelLogic(IHotelStorage hotelStorage)
        {
            this.hotelStorage = hotelStorage;
        }

        public List<HotelViewModel> Read(HotelBindingModel model)
        {
            if (model == null)
            {
                return hotelStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<HotelViewModel> { hotelStorage.GetElement(model) };
            }
            return hotelStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(HotelBindingModel model)
        {
            var element = hotelStorage.GetElement(new HotelBindingModel { Id = model.Id });

            if (element != null)
            {
                hotelStorage.Update(model);
            }
            else
            {
                hotelStorage.Insert(model);
            }
        }

        public void Delete(HotelBindingModel model)
        {
            var element = hotelStorage.GetElement(new HotelBindingModel { Id = model.Id });

            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            hotelStorage.Delete(model);
        }
    }
}
