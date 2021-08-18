using HotelDatabaseBusinessLogic.BindingModels;
using HotelDatabaseBusinessLogic.BussinessLogic;
using HotelDatabaseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace HotelDatabaseView
{
    public partial class FormPayment : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private int? id;
        public int Id { set { id = value; } }

        public PaymentLogic paymentLogic;
        public ClientLogic clientLogic;
        public CheckInLogic checkInLogic;
        public HotelLogic hotelLogic;

        public int CheckInId { get { return Convert.ToInt32(comboBoxCheckIn.SelectedValue); } set { comboBoxCheckIn.SelectedValue = value; } }
        public int ClientId { get { return Convert.ToInt32(comboBoxClient.SelectedValue); } set { comboBoxClient.SelectedValue = value; } }
        public int HotelId { get { return Convert.ToInt32(comboBoxHotel.SelectedValue); } set { comboBoxHotel.SelectedValue = value; } }

        public FormPayment(PaymentLogic logic, ClientLogic ClientLogic, CheckInLogic CheckInLogic, HotelLogic HotelLogic)
        {
            InitializeComponent();
            paymentLogic = logic;
            hotelLogic = HotelLogic;
            clientLogic = ClientLogic;
            checkInLogic = CheckInLogic;
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            try
            {
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
                    throw new Exception("Не удалось загрузить список изделий");
                }
                List<HotelViewModel> listHotel = hotelLogic.Read(null);
                if (listHotel != null)
                {
                    comboBoxHotel.DisplayMember = "name";
                    comboBoxHotel.ValueMember = "Id";
                    comboBoxHotel.DataSource = listHotel;
                    comboBoxHotel.SelectedItem = null;
                }

                else
                {
                    throw new Exception("Не удалось загрузить список изделий");
                }
                List<CheckInViewModel> checkInlist = checkInLogic.Read(null);
                if (checkInlist != null)
                {
                    comboBoxCheckIn.DisplayMember = "ClientName";
                    comboBoxCheckIn.ValueMember = "Id";
                    comboBoxCheckIn.DataSource = checkInlist;
                    comboBoxCheckIn.SelectedItem = null;
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
            if (string.IsNullOrEmpty(textBoxSum.Text))
            {
                MessageBox.Show("Заполните поле \"FIO\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxCheckIn.SelectedValue == null)
            {
                MessageBox.Show("Заполните поле \"Passport\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxClient.SelectedValue == null)
            {
                MessageBox.Show("Заполните поле \"Hotel\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxHotel.SelectedValue == null)
            {
                MessageBox.Show("Заполните поле \"Hotel\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(datePay.Text))
            {
                MessageBox.Show("Заполните поле \"Hotel\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                paymentLogic.CreateOrUpdate(new PaymentBindingModel
                {
                    Id = id,
                    SumPayment = Convert.ToDouble(textBoxSum.Text),
                    DatePayment = datePay.Value,
                    ClientId = Convert.ToInt32(comboBoxClient.SelectedValue),
                    HotelId = Convert.ToInt32(comboBoxHotel.SelectedValue),
                    CheckInId = Convert.ToInt32(comboBoxCheckIn.SelectedValue),
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

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}