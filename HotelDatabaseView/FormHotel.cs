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
    public partial class FormHotel : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private int? id;
        public int Id { set { id = value; } }

        public HotelLogic hotelLogic;

        public FormHotel(HotelLogic logic)
        {
            InitializeComponent();
            hotelLogic = logic;
        }

        private void FormHotel_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    HotelViewModel view = hotelLogic.Read(new HotelBindingModel { Id = id.Value })?[0];

                    if (view != null)
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFullName.Text))
            {
                MessageBox.Show("Заполните поле \"имя отеля\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxCounroom.Text))
            {
                MessageBox.Show("Заполните поле \"кол-во комнат\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxbusyrom.Text))
            {
                MessageBox.Show("Заполните поле \"кол-во занятых комнат\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                hotelLogic.CreateOrUpdate(new HotelBindingModel
                {
                    Id = id,
                    name = textBoxFullName.Text,
                    CountRooms = Convert.ToInt32(textBoxCounroom.Text),
                    CountBusyRooms = Convert.ToInt32(textBoxbusyrom.Text)
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