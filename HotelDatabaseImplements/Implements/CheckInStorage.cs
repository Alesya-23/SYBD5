//using HotelDatabaseBusinessLogic.BindingModels;
//using HotelDatabaseBusinessLogic.Interfaces;
//using HotelDatabaseBusinessLogic.ViewModels;
//using HotelDatabaseImplements.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace HotelDatabaseImplements.Implements
//{
//    public class CheckInStorage : ICheckInStorage
//    {
//        public List<CheckInViewModel> GetFilteredList(CheckInBindingModel model)
//        {
//            if (model == null)
//            {
//                return null;
//            }

//            using (var context = new HotelDatabase())
//            {
//                return context.CheckIns
//                    .Where(rec => rec.Name.Contains(model.Name))
//                    .Select(rec => new CheckInViewModel
//                    {
//                        Id = rec.Id,
//                        CountDays = rec.CountDays,
//                        Datedepature = rec.Datedepature,
//                        DateArrival = rec.DateArrival
//                    }).ToList();
//            }
//        }

//        public CheckInViewModel GetElement(CheckInBindingModel model)
//        {
//            if (model == null)
//            {
//                return null;
//            }

//            using (var context = new HotelDatabase())
//            {
//                var checkIn = context.CheckIns
//                .FirstOrDefault(rec => rec.Id == model.Id);
//                return checkIn != null ?
//                new CheckInViewModel
//                {
//                    Id = checkIn.Id,
//                    CountDays = checkIn.CountDays,
//                    Datedepature = checkIn.Datedepature,
//                    DateArrival = checkIn.DateArrival
//                } : null;
//            }
//        }

//        public void Insert(CheckInBindingModel model)
//        {
//            using (var context = new HotelDatabase())
//            {
//                context.CheckIns.Add(CreateModel(model, new CheckIn()));
//                context.SaveChanges();
//            }
//        }

//        public void Update(CheckInBindingModel model)
//        {
//            using (var context = new HotelDatabase())
//            {
//                var checkIn = context.CheckIns.FirstOrDefault(rec => rec.Id == model.Id);

//                if (checkIn == null)
//                {
//                    throw new Exception("Сотрудник не найден");
//                }
//                CreateModel(model, checkIn);
//                context.SaveChanges();
//            }
//        }

//        public void Delete(CheckInBindingModel model)
//        {
//            using (var context = new HotelDatabase())
//            {
//                CheckIn checkIn = context.CheckIns.FirstOrDefault(rec => rec.Id == model.Id);

//                if (checkIn != null)
//                {
//                    context.CheckIns.Remove(checkIn);
//                    context.SaveChanges();
//                }
//                else
//                {
//                    throw new Exception("Сотрудник не найден");
//                }
//            }
//        }

//        private CheckIn CreateModel(CheckInBindingModel model, CheckIn checkIn)
//        {
//            checkIn.Name = model.Name;
//            return checkIn;
//        }

//        public List<CheckInViewModel> GetFullList()
//        {
//            using (var context = new HotelDatabase())
//            {
//                return context.CheckIns
//                    .Select(rec => new CheckInViewModel
//                    {
//                        Id = rec.Id,
//                        CountDays = rec.CountDays,
//                        Datedepature = rec.Datedepature,
//                        DateArrival = rec.DateArrival
//                    }).ToList();
//            }
//        }
//    }
//}