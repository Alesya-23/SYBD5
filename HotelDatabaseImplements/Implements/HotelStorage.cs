using HotelDatabaseBusinessLogic.BindingModels;
using HotelDatabaseBusinessLogic.Interfaces;
using HotelDatabaseBusinessLogic.ViewModels;
using HotelDatabaseImplements.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelDatabaseImplements.Implements
{
    public class HotelStorage : IHotelStorage
    {
        public HotelViewModel GetElement(HotelBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new HotelDatabase())
            {
                var hotel = context.Hotels
               .FirstOrDefault(rec => rec.name == model.name ||
              rec.Id == model.Id);
                return hotel != null ?
                new HotelViewModel
                {
                    Id = hotel.Id,
                    CountRooms = hotel.CountRooms,
                    CountBusyRooms = hotel.CountBusyRooms,
                    name = hotel.name
                } :
               null;
            }
        }

        public List<HotelViewModel> GetFilteredList(HotelBindingModel model)
        {
            using (var context = new HotelDatabase())
            {
                return context.Hotels
                .Select(rec => new HotelViewModel
                {
                    Id = rec.Id,
                    CountRooms = rec.CountRooms,
                    CountBusyRooms = rec.CountBusyRooms,
                    name = rec.name
                })
               .ToList();
            }
        }

        public List<HotelViewModel> GetFullList()
        {
            using (var context = new HotelDatabase())
            {
                return context.Hotels
                .Select(rec => new HotelViewModel
                {
                    Id = rec.Id,
                    CountRooms = rec.CountRooms,
                    CountBusyRooms = rec.CountBusyRooms,
                    name = rec.name
                })
               .ToList();
            }
        }

        public void Insert(HotelBindingModel model)
        {
            using (var context = new HotelDatabase())
            {
                context.Hotels.Add(CreateModel(model, new Hotel()));
                context.SaveChanges();
            }
        }

        public void Update(HotelBindingModel model)
        {
            using (var context = new HotelDatabase())
            {
                var element = context.Hotels.FirstOrDefault(rec => rec.Id ==
               model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }
        public void Delete(HotelBindingModel model)
        {
            using (var context = new HotelDatabase())
            {
                Hotel element = context.Hotels.FirstOrDefault(rec => rec.Id ==
               model.Id);
                if (element != null)
                {
                    context.Hotels.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        private Hotel CreateModel(HotelBindingModel model, Hotel hotel)
        {
            hotel.name = model.name;
            hotel.CountRooms = model.CountRooms;
            hotel.CountBusyRooms = model.CountBusyRooms;
            return hotel;
        }
    }
}
