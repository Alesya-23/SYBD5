using System;
using System.Collections.Generic;
using BusinessLogic.Interfaces;
using BusinessLogic.BindingModels;
using BusinessLogic.ViewModels.ReportModels;

namespace BusinessLogic.BusinessLogic
{
    public class ReportLogic
    {
        public readonly IReportStorage storage;

        public ReportLogic(IReportStorage report)
        {
            storage = report;
        }


        public List<ReportRoomViewModel> GetRoomsInfo()
        {
            return storage.GetRoomInfo();
        }
        
    }
}
