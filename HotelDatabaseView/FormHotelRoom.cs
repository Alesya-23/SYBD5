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
        private readonly ClientLogic clientLogic;

        private Dictionary<int, string> staff;
        public int HotelId { get { return Convert.ToInt32(comboBoxHotel.SelectedValue); } set { comboBoxHotel.SelectedValue = value; } }
        public int ClientId { get { return Convert.ToInt32(comboBoxClient.SelectedValue); } set { comboBoxClient.SelectedValue = value; } }

        private readonly StaffLogic StaffLogic;
    
        public FormHotelRoom(HotelRoomLogic logic, HotelLogic hotel, StaffLogic staff, ClientLogic client)
        {
            InitializeComponent();
            hotelRoomLogic = logic;
            HotelLogic = hotel;
            StaffLogic = staff;
            clientLogic = client;
        }

        private void FormHotelRoom_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                   HotelRoomViewModel view = hotelRoomLogic.Read(new HotelRoomBindingModel { Id = id.Value })?[0];
                    if (view != null)
                    {
                        textBoxTypeRoom.Text = view.TypeRoom;
                        textBoxPrice.Text = view.Price.ToString();
                        comboBoxClient.Text = view.ClientId.ToString();//add name
                        comboBoxHotel.Text = view.HotelId.ToString();
                        textBoxReservation.Text = view.Reservation.ToString();
                        staff = view.Staff;
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                staff = new Dictionary<int, string>();
            }
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
                List<ClientViewModel> listClient = clientLogic.Read(null);
                if (listClient != null)
                {
                    comboBoxClient.DisplayMember = "fioname";
                    comboBoxClient.ValueMember = "Id";
                    comboBoxClient.DataSource = listClient;
                    comboBoxClient.SelectedItem = null;
                }
                else
                {
                    throw new Exception("Не удалось загрузить список отелей");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                if (staff != null)
                {
                    dataGridView.Rows.Clear();
                    foreach (var pc in staff)
                    {
                        dataGridView.Rows.Add(new object[] { pc.Value.ToString()});
                    }
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

            try
            {
                hotelRoomLogic.CreateOrUpdate(new HotelRoomBindingModel
                {
                    Id = id,
                    TypeRoom = textBoxTypeRoom.Text,
                    Price = Convert.ToInt32(textBoxPrice.Text),
                    HotelId = Convert.ToInt32(comboBoxHotel.SelectedValue),
                    ClientId = Convert.ToInt32(comboBoxClient.SelectedValue),
                    Staff = staff
                }) ;

            MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormStaffAdd>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (staff.ContainsKey(form.Id))
                {
                    staff[form.Id] = (form.StaffName);
                }
                else
                {
                    staff.Add(form.Id, form.StaffName);
                }
                LoadData();
            }
        }

        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
