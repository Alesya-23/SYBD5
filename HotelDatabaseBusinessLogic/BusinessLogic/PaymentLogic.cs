using HotelDatabaseBusinessLogic.BindingModels;
using HotelDatabaseBusinessLogic.Interfaces;
using HotelDatabaseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseBusinessLogic.BussinessLogic
{
    public class PaymentLogic
    {
        private readonly IPaymentStorage paymentStorage;

        public PaymentLogic(IPaymentStorage paymentStorage)
        {
            this.paymentStorage = paymentStorage;
        }

        public List<PaymentViewModel> Read(PaymentBindingModel model)
        {
            if (model == null)
            {
                return paymentStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<PaymentViewModel> { paymentStorage.GetElement(model) };
            }
            return paymentStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(PaymentBindingModel model)
        {
            var element = paymentStorage.GetElement(new PaymentBindingModel { Id = model.Id });

            if (element != null)
            {
                paymentStorage.Update(model);
            }
            else
            {
                paymentStorage.Insert(model);
            }
        }

        public void Delete(PaymentBindingModel model)
        {
            var element = paymentStorage.GetElement(new PaymentBindingModel { Id = model.Id });

            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            paymentStorage.Delete(model);
        }
    }
}
