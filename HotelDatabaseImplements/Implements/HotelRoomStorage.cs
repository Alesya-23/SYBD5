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
    public class HotelRoomStorage : IHotelRoomStorage
    {
        public HotelRoomViewModel GetElement(HotelRoomBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new HotelDatabase())
            {
                var hotelroom = context.HotelRooms.Include(rec => rec.HotelRoomStaffs)
                .FirstOrDefault(rec => rec.Id == model.Id);
                return hotelroom != null ?
                new HotelRoomViewModel
                {
                    Id = hotelroom.Id,
                    TypeRoom = hotelroom.TypeRoom,
                    Reservation = hotelroom.Reservation,
                    Price = hotelroom.Price,
                    HotelId = (int)hotelroom.HotelId,
                    ClientId = hotelroom.ClientId,
                    Staff = hotelroom.HotelRoomStaffs.ToDictionary(recPC =>
                    recPC.StaffId, recPC => recPC.Staff.FIOname)
                } :
               null;
            }
        }

        public List<HotelRoomViewModel> GetFilteredList(HotelRoomBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new HotelDatabase())
            {
                return context.HotelRooms.Include(rec => rec.HotelRoomStaffs).Select(rec =>
                new HotelRoomViewModel
                {
                    Id = rec.Id,
                    TypeRoom = rec.TypeRoom,
                    Reservation = rec.Reservation,
                    Price = rec.Price,
                    HotelId = (int)rec.HotelId,
                    ClientId = rec.ClientId,
                    Staff = rec.HotelRoomStaffs.ToDictionary(recPC =>
                    recPC.StaffId, recPC => recPC.Staff.FIOname)
                })
               .ToList();
            }
        }
        public List<HotelRoomViewModel> GetFullList()
        {
            using (var context = new HotelDatabase())
            {
                return context.HotelRooms.Include(rec => rec.HotelRoomStaffs).Select(rec =>
                new HotelRoomViewModel
                {
                    Id = rec.Id,
                    TypeRoom = rec.TypeRoom,
                    Reservation = rec.Reservation,
                    Price = rec.Price,
                    HotelId = (int)rec.HotelId,
                    ClientId = rec.ClientId,
                    Staff = rec.HotelRoomStaffs.ToDictionary(recPC =>
                    recPC.StaffId, recPC => recPC.Staff.FIOname)
                })
               .ToList();
            }
        }

        public void Insert(HotelRoomBindingModel model)
        {
            using (var context = new HotelDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        HotelRoom p = new HotelRoom
                        {
                            TypeRoom = model.TypeRoom,
                            Reservation = model.Reservation,
                            Price = model.Price,
                        };
                        context.HotelRooms.Add(p);
                        context.SaveChanges();
                        CreateModel(model, p, context);
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Update(HotelRoomBindingModel model)
        {
            using (var context = new HotelDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var element = context.HotelRooms.FirstOrDefault(rec => rec.Id ==
                       model.Id);
                        if (element == null)
                        {
                            throw new Exception("Элемент не найден");
                        }
                        CreateModel(model, element, context);
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Delete(HotelRoomBindingModel model)
        {
            using (var context = new HotelDatabase())
            {
                HotelRoom element = context.HotelRooms.FirstOrDefault(rec => rec.Id ==
               model.Id);
                if (element != null)
                {
                    context.HotelRooms.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }

        }
        private HotelRoom CreateModel(HotelRoomBindingModel model, HotelRoom hotelroom,
     HotelDatabase context)
        {
            hotelroom.TypeRoom = model.TypeRoom;
            hotelroom.Reservation = model.Reservation;
            hotelroom.Price = model .Price;
            if (model.Id.HasValue)
            {
                var staffrooms = context.HotelRoomStaffs.Where(rec =>
               rec.HotelRoomId == model.Id.Value).ToList();
                // удалили те, которых нет в модели
                context.HotelRoomStaffs.RemoveRange(staffrooms.Where(rec =>
               !model.Staff.ContainsKey(rec.StaffId)).ToList());
                context.SaveChanges();
                //// обновили количество у существующих записей
                //foreach (var uphotelroomstaff in staffrooms)
                //{
                //    uphotelroomstaff. = model.Staff[uphotelroomstaff.StaffId].Item2;
                //    model.PackageComponents.Remove(uphotelroomstaff.ComponentId);
                //}
                //context.SaveChanges();
            }
            // добавили новые
            foreach (var pc in model.Staff)
            {
                context.HotelRoomStaffs.Add(new HotelRoomStaff
                {
                    HotelRoomId = (int)hotelroom.Id,
                    StaffId = pc.Key
                });
                context.SaveChanges();
            }
            return hotelroom;
        }
    }
}
