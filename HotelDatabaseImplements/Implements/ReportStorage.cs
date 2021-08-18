using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels.ReportModels;
using HotelDatabaseImplements;

namespace HotelDatabaseImplements.Implements
{
    public class ReportStorage : IReportStorage
    { 

        public List<ReportRoomViewModel> GetRoomInfo()
        {
            using (var context = new HotelDatabase())
            {
                return context.HotelRooms.Where(x => x.ClientId.Equals(3008)).Select(x =>
                    new ReportRoomViewModel
                    {
                        RoomId = (int)x.Id,
                        Type = x.TypeRoom,
                        Price = x.Price,
                    }).ToList();
            }
        }

    }
}
