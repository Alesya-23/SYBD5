using HotelDatabaseBusinessLogic.BindingModels;
using HotelDatabaseBusinessLogic.Interfaces;
using HotelDatabaseBusinessLogic.ViewModels;
using HotelDatabaseImplements.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelDatabaseImplements.Implements
{
    public class CheckInStorage : ICheckInStorage
    {
        public List<CheckInViewModel> GetFilteredList(CheckInBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new HotelDatabase())
            {
                return context.CheckIns
                    .Include(rec => rec.Client)
                    .Select(rec => new CheckInViewModel
                    {
                        Id = rec.Id,
                        Datedepature = rec.Datedepature,
                        DateArrival = rec.DateArrival,
                        ClientId = (int)rec.Client.Id
                    }).ToList();
            }
        }

        public CheckInViewModel GetElement(CheckInBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new HotelDatabase())
            {
                var checkIn = context.CheckIns
                .FirstOrDefault(rec => rec.Id == model.Id);
                return checkIn != null ?
                new CheckInViewModel
                {
                    Id = checkIn.Id,
                    Datedepature = checkIn.Datedepature,
                    DateArrival = checkIn.DateArrival,
                    ClientId = (int)checkIn.Client.Id
                } : null;
            }
        }

        public void Insert(CheckInBindingModel model)
        {
            using (var context = new HotelDatabase())
            {
                context.CheckIns.Add(CreateModel(model, new CheckIn()));
                context.SaveChanges();
            }
        }

        public void Update(CheckInBindingModel model)
        {
            using (var context = new HotelDatabase())
            {
                var checkIn = context.CheckIns.FirstOrDefault(rec => rec.Id == model.Id);

                if (checkIn == null)
                {
                    throw new Exception("Заезд не найден");
                }
                CreateModel(model, checkIn);
                context.SaveChanges();
            }
        }

        public void Delete(CheckInBindingModel model)
        {
            using (var context = new HotelDatabase())
            {
                CheckIn checkIn = context.CheckIns.FirstOrDefault(rec => rec.Id == model.Id);

                if (checkIn != null)
                {
                    context.CheckIns.Remove(checkIn);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Заезд не найден");
                }
            }
        }

        private CheckIn CreateModel(CheckInBindingModel model, CheckIn checkIn)
        {
            checkIn.Id = model.Id;
            checkIn.DateArrival = model.DateArrival;
            checkIn.Datedepature = model.Datedepature;
            checkIn.ClientId = model.ClientId;
            return checkIn;
        }

        public List<CheckInViewModel> GetFullList()
        {
            using (var context = new HotelDatabase())
            {
                return context.CheckIns
                    .Select(rec => new CheckInViewModel
                    {
                        Id = rec.Id,
                        Datedepature = rec.Datedepature,
                        DateArrival = rec.DateArrival,
                        ClientId = (int)rec.Client.Id
                    }).ToList();
            }
        }
    }
}