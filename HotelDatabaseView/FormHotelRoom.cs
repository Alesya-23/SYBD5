using HotelDatabaseBusinessLogic.BindingModels;
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
    public partial class FormHotelRoom : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private int? id;
        public int Id { set { id = value; } }

        public HotelRoomLogic hotelRoomLogic;
        private readonly HotelLogic HotelLogic;
        public int HotelId { get { return Convert.ToInt32(comboBoxHotel.SelectedValue); } set { comboBoxHotel.SelectedValue = value; } }

        private readonly StaffLogic StaffLogic;
        public int StaffId { get { return Convert.ToInt32(comboBoxStaff.SelectedValue); } set { comboBoxStaff.SelectedValue = value; } }

        public FormHotelRoom(HotelRoomLogic logic, HotelLogic hotel, StaffLogic staff)
        {
            InitializeComponent();
            hotelRoomLogic = logic;
            HotelLogic = hotel;
            StaffLogic = staff;
        }

        private void FormHotelRoom_Load(object sender, EventArgs e)
        {
            try
            {
                List<HotelViewModel> listHotel = HotelLogic.Read(null);
                if (listHotel != null)
                {
                    comboBoxHotel.DisplayMember = "name";
                    comboBoxHotel.ValueMember = "Id";
                    comboBoxHotel.DataSource = listHotel;
                    comboBoxHotel.SelectedItem = null;
                }
                else
                {
                    throw new Exception("Не удалось загрузить список отелей");
                }
                List<StaffViewModel> StaffHotel = StaffLogic.Read(null);
                if (listHotel != null)
                {
                    comboBoxStaff.DisplayMember = "FIOname";
                    comboBoxStaff.ValueMember = "Id";
                    comboBoxStaff.DataSource = listHotel;
                    comboBoxStaff.SelectedItem = null;
                }
                else
                {
                    throw new Exception("Не удалось загрузить список изделий");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTypeRoom.Text))
            {
                MessageBox.Show("Заполните поле \"тип\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPrice.Text))
            {
                MessageBox.Show("Заполните поле \"цена\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxHotel.SelectedValue == null)
            {
                MessageBox.Show("Заполните поле \"Hotel\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxStaff.SelectedValue == null)
            {
                MessageBox.Show("Заполните поле \"Hotel\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                hotelRoomLogic.CreateOrUpdate(new HotelRoomBindingModel
                {
                    Id = id,
                    TypeRoom = textBoxTypeRoom.Text,
                    Price = Convert.ToInt32(textBoxPrice.Text),
                    HotelId = Convert.ToInt32(comboBoxHotel.SelectedValue),
                    //Staff = Convert.ToInt32(comboBoxHotel.SelectedValue)
                });

                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}