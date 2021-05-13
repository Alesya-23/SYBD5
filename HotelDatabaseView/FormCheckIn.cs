using HotelDatabaseBusinessLogic.BindingModels;
using HotelDatabaseBusinessLogic.ViewModels;
using System;
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

        public FormCheckIn(CheckInLogic CheckInLogic)
        {
            InitializeComponent();
            this.CheckInLogic = CheckInLogic;
        }

        private void FormCheckIn_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    CheckInViewModel view = CheckInLogic.Read(new CheckInBindingModel { Id = id.Value })?[0];

                    if (view != null)
                    {
                        textBoxArrival.Text = view.Name;
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
            if (string.IsNullOrEmpty(textBoxArrival.Text))
            {
                MessageBox.Show("Заполните поле \"ФИО\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                CheckInLogic.CreateOrUpdate(new CheckInBindingModel
                {
                    Id = id,
                    DateArrival = Convert.ToDateTime(textBoxArrival.Text),
                    Datedepature = Convert.ToDateTime(textBoxDepature.Text),
                    CountDays = Convert.ToInt32(textBoxDays)
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