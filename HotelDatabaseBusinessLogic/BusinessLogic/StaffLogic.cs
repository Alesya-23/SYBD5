using HotelDatabaseBusinessLogic.BindingModels;
using HotelDatabaseBusinessLogic.Interfaces;
using HotelDatabaseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseBusinessLogic.BussinessLogic
{
    public class StaffLogic
    {
        private readonly IStaffStorage staffStorage;

        public StaffLogic(IStaffStorage staffStorage)
        {
            this.staffStorage = staffStorage;
        }

        public List<StaffViewModel> Read(StaffBindingModel model)
        {
            if (model == null)
            {
                return staffStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<StaffViewModel> { staffStorage.GetElement(model) };
            }
            return staffStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(StaffBindingModel model)
        {
            var element = staffStorage.GetElement(new StaffBindingModel { Id = model.Id });

            if (element != null)
            {
                staffStorage.Update(model);
            }
            else
            {
                staffStorage.Insert(model);
            }
        }

        public void Delete(StaffBindingModel model)
        {
            var element = staffStorage.GetElement(new StaffBindingModel { Id = model.Id });

            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            staffStorage.Delete(model);
        }
    }
}
