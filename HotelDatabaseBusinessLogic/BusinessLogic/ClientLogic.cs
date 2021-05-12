using HotelDatabaseBusinessLogic.Interfaces;
using HotelDatabaseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseBusinessLogic.BindingModels
{
    public class ClientLogic
    {
        private readonly IClientStorage clientStorage;

        public ClientLogic(IClientStorage clientStorage)
        {
            this.clientStorage = clientStorage;
        }

        public List<ClientViewModel> Read(ClientBindingModel model)
        {
            if (model == null)
            {
                return clientStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<ClientViewModel> { clientStorage.GetElement(model) };
            }
            return clientStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(ClientBindingModel model)
        {
            var element = clientStorage.GetElement(new ClientBindingModel { Id = model.Id });

            if (element != null)
            {
                clientStorage.Update(model);
            }
            else
            {
                clientStorage.Insert(model);
            }
        }

        public void Delete(ClientBindingModel model)
        {
            var element = clientStorage.GetElement(new ClientBindingModel { Id = model.Id });

            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            clientStorage.Delete(model);
        }
    }
}
