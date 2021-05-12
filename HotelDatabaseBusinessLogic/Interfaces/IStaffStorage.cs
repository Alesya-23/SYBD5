﻿using HotelDatabaseBusinessLogic.BindingModels;
using HotelDatabaseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseBusinessLogic.Interfaces
{
    public interface IStaffStorage
    {
        List<StaffViewModel> GetFullList();
        List<StaffViewModel> GetFilteredList(StaffBindingModel model);
        StaffViewModel GetElement(StaffBindingModel model);
        void Insert(StaffBindingModel model);
        void Update(StaffBindingModel model);
        void Delete(StaffBindingModel model);
    }
}
