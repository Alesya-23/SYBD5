using HotelDatabaseBusinessLogic.BindingModels;
using HotelDatabaseBusinessLogic.Interfaces;
using HotelDatabaseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseBusinessLogic.BussinessLogic
{
    public class HotelRoomLogic
    {
        private readonly IHotelRoomStorage hotelRoomStorage;

        public HotelRoomLogic(IHotelRoomStorage hotelRoomStorage)
        {
            this.hotelRoomStorage = hotelRoomStorage;
        }

        public List<HotelRoomViewModel> Read(HotelRoomBindingModel model)
        {
            if (model == null)
            {
                return hotelRoomStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<HotelRoomViewModel> { hotelRoomStorage.GetElement(model) };
            }
            return hotelRoomStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(HotelRoomBindingModel model)
        {
            var element = hotelRoomStorage.GetElement(new HotelRoomBindingModel { Id = model.Id });

            if (element != null)
            {
                hotelRoomStorage.Update(model);
            }
            else
            {
                hotelRoomStorage.Insert(model);
            }
        }

        public void Delete(HotelRoomBindingModel model)
        {
            var element = hotelRoomStorage.GetElement(new HotelRoomBindingModel { Id = model.Id });

            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            hotelRoomStorage.Delete(model);
        }
    }
}
