using HotelDatabaseBusinessLogic.BindingModels;
using HotelDatabaseBusinessLogic.Interfaces;
using HotelDatabaseBusinessLogic.ViewModels;
using HotelDatabaseImplements.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDatabaseImplements.Implements
{
    public class ClientStorage : IClientStorage
    {
        public ClientViewModel GetElement(ClientBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new HotelDatabase())
            {
                var client = context.Clients
                .FirstOrDefault(rec => rec.Id == model.Id);
                return client != null ?
                new ClientViewModel
                {
                    Id = client.Id,
                    HotelId = client.HotelId,
                    fioname = client.fioname,
                    passport = client.passport
                } : null;
            }
        }

        public List<ClientViewModel> GetFilteredList(ClientBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new HotelDatabase())
            {
                return context.Clients.Select(rec => new ClientViewModel
                {
                    Id = rec.Id,
                    HotelId = rec.HotelId,
                    fioname = rec.fioname,
                    passport = rec.passport,
                    HotelName = context.Hotels.FirstOrDefault(r => r.Id == rec.HotelId).name,
                }).ToList();
            }
        }

        public List<ClientViewModel> GetFullList()
        {
            using (var context = new HotelDatabase())
            {
                return context.Clients.Select(rec => new ClientViewModel
                {
                    Id = rec.Id,
                    HotelId = rec.HotelId,
                    fioname = rec.fioname,
                    passport = rec.passport,
                    HotelName = context.Hotels.FirstOrDefault(r => r.Id == rec.HotelId).name,
                }).ToList();
            }
        }

        public void Insert(ClientBindingModel model)
        {
            using (var context = new HotelDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Clients.Add(CreateModel(model, new Client()));
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

        public void Update(ClientBindingModel model)
        {
            using (var context = new HotelDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var element = context.Clients.FirstOrDefault(rec => rec.Id == model.Id);
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
        public void Delete(ClientBindingModel model)
        {
            using (var context = new HotelDatabase())
            {
                Client element = context.Clients.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Clients.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        private Client CreateModel(ClientBindingModel model, Client client)
        {
            client.fioname = model.fioname;
            client.passport = model.passport;
            client.HotelId = model.HotelId;
            return client;
        }
    }
}
