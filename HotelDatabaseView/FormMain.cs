using BusinessLogic.BindingModels;
using BusinessLogic.BusinessLogic;
using HotelDatabaseBusinessLogic.BindingModels;
using HotelDatabaseBusinessLogic.BussinessLogic;
using HotelDatabaseImplements.Models;
using System;
using System.Windows.Forms;
using Unity;

namespace HotelDatabaseView
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ReportLogic _reportLogic;


        public FormMain(ReportLogic report)
        {
            _reportLogic = report;
            InitializeComponent();
        }


        private void RefreshDataGrid(object sender, EventArgs e)
        {
            var list = _reportLogic.GetRoomsInfo();
            if (list == null) { return; }
            dataGridView.DataSource = list;
            dataGridView.Columns[0].Visible = false;
        }
        private void ToolStripMenuItemStaffs_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormStaffs>();
            form.ShowDialog();
        }

        private void ToolStripMenuItemClients_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormClients>();
            form.ShowDialog();
        }

        private void ToolStripMenuItemHotels_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormHotels>();
            form.ShowDialog();
        }

        private void ToolStripMenuItemRooms_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormHotelRooms>();
            form.ShowDialog();
        }

        private void ToolStripMenuItemPays_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormPayments>();
            form.ShowDialog();
        }

        private void заездToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCheckIns>();
            form.ShowDialog();
        }
    }
}