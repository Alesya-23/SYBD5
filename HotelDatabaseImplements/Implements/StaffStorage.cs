﻿using HotelDatabaseBusinessLogic.BindingModels;
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
    public class StaffStorage : IStaffStorage
    {
        public StaffViewModel GetElement(StaffBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new HotelDatabase())
            {
                var staff = context.Staffs.Include(rec => rec.HotelRoomStaffs)
                .FirstOrDefault(rec => rec.Id == model.Id);
                return staff != null ?
                new StaffViewModel
                {
                    Id = staff.Id,
                    FIOname = staff.FIOname,
                    Post= staff.Post,
                    HotelId = (int)staff.HotelId,
                    HotelRooms = staff.HotelRoomStaffs.ToDictionary(recPC =>
                    recPC.HotelRoomId, recPC => recPC.HotelRoom.TypeRoom)
                } :
               null;
            }
        }

        public List<StaffViewModel> GetFilteredList(StaffBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new HotelDatabase())
            {
                return context.Staffs.Include(rec => rec.HotelRoomStaffs).Select(rec =>
                new StaffViewModel
                {
                    Id = rec.Id,
                    FIOname = rec.FIOname,
                    Post = rec.Post,
                    HotelId = (int)rec.HotelId,
                    HotelRooms = rec.HotelRoomStaffs.ToDictionary(recPC =>
                    recPC.HotelRoomId, recPC => recPC.HotelRoom.TypeRoom)
                })
               .ToList();
            }
        }
        public List<StaffViewModel> GetFullList()
        {
            using (var context = new HotelDatabase())
            {
                return context.Staffs.Include(rec => rec.HotelRoomStaffs).Select(rec =>
                new StaffViewModel
                {
                    Id = rec.Id,
                    FIOname = rec.FIOname,
                    Post = rec.Post,
                    HotelId = (int)rec.HotelId,
                    HotelRooms = rec.HotelRoomStaffs.ToDictionary(recPC =>
                    recPC.HotelRoomId, recPC => recPC.HotelRoom.TypeRoom)
                })
               .ToList();
            }
        }

        public void Insert(StaffBindingModel model)
        {
            using (var context = new HotelDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        Staff p = new Staff
                        {
                            Id = model.Id,
                            FIOname = model.FIOname,
                            Post = model.Post,
                        };
                        context.Staffs.Add(p);
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

        public void Update(StaffBindingModel model)
        {
            using (var context = new HotelDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var element = context.Staffs.FirstOrDefault(rec => rec.Id ==
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

        public void Delete(StaffBindingModel model)
        {
            using (var context = new HotelDatabase())
            {
                Staff element = context.Staffs.FirstOrDefault(rec => rec.Id ==
               model.Id);
                if (element != null)
                {
                    context.Staffs.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }

        }
        private Staff CreateModel(StaffBindingModel model, Staff hotelroom,
     HotelDatabase context)
        {
            hotelroom.Id = model.Id;
            hotelroom.FIOname = model.FIOname;
            hotelroom.Post = model.Post;
            hotelroom.HotelId = (int)model.HotelId;
            if (model.Id.HasValue)
            {
                var staffrooms = context.HotelRoomStaffs.Where(rec =>
               rec.StaffId == model.Id.Value).ToList();
                // удалили те, которых нет в модели
                context.HotelRoomStaffs.RemoveRange(staffrooms.Where(rec =>
               !model.HotelRooms.ContainsKey(rec.StaffId)).ToList());
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
            foreach (var pc in model.HotelRooms)
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
