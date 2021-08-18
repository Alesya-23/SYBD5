using HotelDatabaseBusinessLogic.BindingModels;
using HotelDatabaseBusinessLogic.BussinessLogic;
using HotelDatabaseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
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
        private readonly HotelLogic HotelLogic;
        public int HotelId { get { return Convert.ToInt32(comboBoxHotel.SelectedValue); } set { comboBoxHotel.SelectedValue = value; } }

        private Dictionary<int, string> hotelroom;

        public FormStaff(StaffLogic logic, HotelLogic hotel)
        {
            InitializeComponent();
            staffLogic = logic;
            HotelLogic = hotel;
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
                        comboBoxHotel.Text = view.HotelId.ToString();
                        textBoxEmpName.Text = view.FIOname.ToString();
                        textBoxPost.Text = view.Post.ToString();
                        hotelroom = view.HotelRooms;
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
                hotelroom = new Dictionary<int, string>();
                List<HotelViewModel> listHotel = HotelLogic.Read(null);
                if (listHotel != null)
                {
                    comboBoxHotel.DisplayMember = "name";
                    comboBoxHotel.ValueMember = "Id";
                    comboBoxHotel.DataSource = listHotel;
                    comboBoxHotel.SelectedItem = null;
                }
            }
        }
        private void LoadData()
        {
            try
            {
                if (hotelroom != null)
                {
                    dataGridView.Rows.Clear();
                    foreach (var pc in hotelroom)
                    {
                        dataGridView.Rows.Add(new object[] { pc.Value});
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
                    HotelId = Convert.ToInt32(comboBoxHotel.SelectedValue),
                    HotelRooms = hotelroom
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormAddHotelRooms>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (hotelroom.ContainsKey(form.Id))
                {
                    hotelroom[form.Id] = (form.type);
                }
                else
                {
                    hotelroom.Add(form.Id, form.type);
                }
                LoadData();
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView.SelectedRows.Count == 1)
                {
                    var form = Container.Resolve<FormAddHotelRooms>();
                    int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                    form.Id = id;
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        hotelroom[form.Id] = form.type;
                        LoadData();
                    }
                }
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
                if (dataGridView.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            hotelroom.Remove(Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                        }
                        LoadData();
                    }
                }
            }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
                LoadData();
            }
    }
}