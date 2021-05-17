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
    public class PaymentStorage : IPaymentStorage
    {
        public PaymentViewModel GetElement(PaymentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new HotelDatabase())
            {
                var pay = context.Payments
                .FirstOrDefault(rec => rec.Id == model.Id);
                return pay != null ?
                new PaymentViewModel
                {
                    Id = pay.Id,
                    DatePayment = pay.DatePayment,
                    SumPayment = pay.SumPayment,
                    CheckInId = pay.CheckInId, 
                    ClientId = pay.ClientId,
                    HotelId = pay.HotelId
                } : null;
            }
        }

        public List<PaymentViewModel> GetFilteredList(PaymentBindingModel model)
        {
            using (var context = new HotelDatabase())
            {
                return context.Payments.Select(rec => new PaymentViewModel
                {
                    Id = rec.Id,
                    DatePayment = rec.DatePayment,
                    SumPayment = rec.SumPayment,
                    CheckInId = rec.CheckInId,
                    ClientId = rec.ClientId,
                    HotelId = rec.HotelId
                }).ToList();
            }
        }

        public List<PaymentViewModel> GetFullList()
        {
            using (var context = new HotelDatabase())
            {
                return context.Payments.Select(rec => new PaymentViewModel
                {
                    Id = rec.Id,
                    DatePayment = rec.DatePayment,
                    SumPayment = rec.SumPayment,
                    CheckInId = rec.CheckInId,
                    ClientId = rec.ClientId,
                    HotelId = rec.HotelId
                }).ToList();
            }
        }

        public void Insert(PaymentBindingModel model)
        {
            using (var context = new HotelDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Payments.Add(CreateModel(model, new Payment()));
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

        public void Update(PaymentBindingModel model)
        {
            using (var context = new HotelDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var element = context.Payments.FirstOrDefault(rec => rec.Id == model.Id);
                        if (element == null)
                        {
                            throw new Exception("Элемент не найден");
                        }
                        CreateModel(model, element);
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
        public void Delete(PaymentBindingModel model)
        {
            using (var context = new HotelDatabase())
            {
                Payment element = context.Payments.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Payments.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        private Payment CreateModel(PaymentBindingModel model, Payment pay)
        {
            pay.DatePayment = model.DatePayment;
            pay.SumPayment = model.SumPayment;
            pay.Id = (int)model.Id;
            pay.ClientId = model.ClientId;
            pay.HotelId = model.HotelId;
            pay.CheckInId = model.CheckInId;
            return pay;
        }
    }
}
