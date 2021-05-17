using HotelDatabaseBusinessLogic.BindingModels;
using HotelDatabaseBusinessLogic.BussinessLogic;
using HotelDatabaseBusinessLogic.ViewModels;
using System;
using System.Windows.Forms;
using Unity;

namespace HotelDatabaseView
{
    public partial class FormStaff : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private int? id;
        public int Id { set { id = value; } }

        public StaffLogic staffLogic;

        public FormStaff(StaffLogic logic)
        {
            InitializeComponent();
            staffLogic = logic;
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    StaffViewModel view = staffLogic.Read(new StaffBindingModel { Id = id.Value })?[0];

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
            if (string.IsNullOrEmpty(textBoxEmpName.Text))
            {
                MessageBox.Show("Заполните поле \"FIO\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPost.Text))
            {
                MessageBox.Show("Заполните поле \"Post\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxHotel.Text))
            {
                MessageBox.Show("Заполните поле \"Hotel\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                staffLogic.CreateOrUpdate(new StaffBindingModel
                {
                    Id = id,
                    FIOname = textBoxEmpName.Text,
                    Post = textBoxPost.Text,
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