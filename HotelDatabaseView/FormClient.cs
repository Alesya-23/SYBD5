using HotelDatabaseBusinessLogic.BindingModels;
using HotelDatabaseBusinessLogic.BussinessLogic;
using HotelDatabaseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace HotelDatabaseView
{
    public partial class FormClient : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private int? id;
        public int Id { set { id = value; } }

        public ClientLogic clientLogic;

        private readonly HotelLogic HotelLogic;
        public int HotelId { get { return Convert.ToInt32(comboBoxHotel.SelectedValue); } set { comboBoxHotel.SelectedValue = value; } }
        public FormClient(ClientLogic logic, HotelLogic hotel)
        {
            InitializeComponent();
            clientLogic = logic;
            HotelLogic = hotel;
        }

        private void FormClient_Load(object sender, EventArgs e)
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
            if (string.IsNullOrEmpty(textBoxFullName.Text))
            {
                MessageBox.Show("Заполните поле \"FIO\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPassport.Text))
            {
                MessageBox.Show("Заполните поле \"Passport\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxHotel.SelectedValue == null)
            {
                MessageBox.Show("Заполните поле \"Hotel\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                clientLogic.CreateOrUpdate(new ClientBindingModel
                {
                    Id = id,
                    fioname = textBoxFullName.Text,
                    passport = Convert.ToInt32(textBoxPassport.Text),
                    HotelId = Convert.ToInt32(comboBoxHotel.SelectedValue)
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