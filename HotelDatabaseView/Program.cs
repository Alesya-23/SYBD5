using BusinessLogic.BusinessLogic;
using BusinessLogic.Interfaces;
using HotelDatabaseBusinessLogic.BussinessLogic;
using HotelDatabaseBusinessLogic.Interfaces;
using HotelDatabaseImplements.Implements;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace HotelDatabaseView
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormMain>());
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IClientStorage, ClientStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ICheckInStorage, CheckInStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IHotelStorage, HotelStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IHotelRoomStorage, HotelRoomStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IPaymentStorage, PaymentStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IStaffStorage, StaffStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IReportStorage, ReportStorage>(new
            HierarchicalLifetimeManager());

            currentContainer.RegisterType<ClientLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<CheckInLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<HotelLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<HotelRoomLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<PaymentLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<StaffLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ReportLogic>(new HierarchicalLifetimeManager());

            return currentContainer;
        }
    }
}