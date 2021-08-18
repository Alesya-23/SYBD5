using System;
using System.Collections.Generic;
using BusinessLogic.BindingModels;
using BusinessLogic.ViewModels.ReportModels;

namespace BusinessLogic.Interfaces
{
    public interface IReportStorage
    {
        List<ReportRoomViewModel> GetRoomInfo();
    }
}
