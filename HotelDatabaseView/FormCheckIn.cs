using HotelDatabaseBusinessLogic.BindingModels;
using HotelDatabaseBusinessLogic.BussinessLogic;
using HotelDatabaseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace HotelDatabaseView
{
    public partial class FormCheckIn : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private int? id;
        public int Id { set { id = value; } }

        private readonly CheckInLogic CheckInLogic;

        private readonly ClientLogic clientLogic;
        public int ClientId { get { return Convert.ToInt32(comboBoxClient.SelectedValue); } set { comboBoxClient.SelectedValue = value; } }

        public FormCheckIn(CheckInLogic CheckInLogic, ClientLogic ClientLogic)
        {
            InitializeComponent();
            this.CheckInLogic = CheckInLogic;
            this.clientLogic = ClientLogic;
        }

        private void FormCheckIn_Load(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dateArrives.Text))
            {
                MessageBox.Show("Заполните приезд \"приезд\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(dateDeparture.Text))
            {
                MessageBox.Show("Заполните отъезд \"отъезд\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxClient.SelectedValue == null)
            {
                MessageBox.Show("Заполните клиента \"клиент\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                CheckInLogic.CreateOrUpdate(new CheckInBindingModel
                {
                    Id = id,
                    DateArrival = Convert.ToDateTime(dateArrives.Text),
                    Datedepature = Convert.ToDateTime(dateDeparture.Text),
                    ClientId = Convert.ToInt32(comboBoxClient.SelectedValue)
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