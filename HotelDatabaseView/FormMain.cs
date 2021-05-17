using HotelDatabaseBusinessLogic.BindingModels;
using System;
using System.Windows.Forms;
using Unity;

namespace HotelDatabaseView
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
       // private readonly EquipmentLogic equipmentLogic;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                //var list = equipmentLogic.Read(null);
                //if (list != null)
                //{
                //    dataGridView.DataSource = list;
                //    dataGridView.Columns[0].Visible = false;
                //    dataGridView.Columns[8].Visible = false;
                //    dataGridView.Columns[9].Visible = false;
                //    dataGridView.Columns[10].Visible = false;
                //    dataGridView.Columns[2].Width = 500;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            FormClient form = Container.Resolve<FormClient>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void ButtonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                FormClient form = Container.Resolve<FormClient>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                    try
                    {
                       // equipmentLogic.Delete(new EquipmentBindingModel { Id = id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void ButtonEqByDates_Click(object sender, EventArgs e)
        {
            //FormEquipmentByDates form = Container.Resolve<FormEquipmentByDates>();
            //if (form.ShowDialog() == DialogResult.OK)
            //{
            //    LoadData();
            //}
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