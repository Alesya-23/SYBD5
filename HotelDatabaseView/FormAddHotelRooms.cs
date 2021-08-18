using HotelDatabaseBusinessLogic.BussinessLogic;
using HotelDatabaseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace HotelDatabaseView
{
    public partial class FormAddHotelRooms : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id
        {
            get { return Convert.ToInt32(comboBoxSelectRoom.SelectedValue); }
            set { comboBoxSelectRoom.SelectedValue = value; }
        }
        public string type { get { return comboBoxSelectRoom.Text; } }

        public FormAddHotelRooms(HotelRoomLogic logic)
        {
            InitializeComponent();
            List<HotelRoomViewModel> list = logic.Read(null);
            if (list != null)
            {
                comboBoxSelectRoom.DisplayMember = "TypeRoom";
                comboBoxSelectRoom.ValueMember = "Id";
                comboBoxSelectRoom.DataSource = list;
                comboBoxSelectRoom.SelectedItem = null;
            }
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectRoom.SelectedValue == null)
            {
                MessageBox.Show("Выберите компонент", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}