using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using HotelDatabaseBusinessLogic.ViewModels;
using HotelDatabaseBusinessLogic.BussinessLogic;

namespace HotelDatabaseView
{
    public partial class FormStaffAdd : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id
        {
            get { return Convert.ToInt32(comboBoxSelectStaff.SelectedValue); }
            set { comboBoxSelectStaff.SelectedValue = value; }
        }
        public string StaffName { get { return comboBoxSelectStaff.Text; } }
   
        public FormStaffAdd(StaffLogic logic)
        {
            InitializeComponent();
            List<StaffViewModel> list = logic.Read(null);
            if (list != null)
            {
                comboBoxSelectStaff.DisplayMember = "FIOname";
                comboBoxSelectStaff.ValueMember = "Id";
                comboBoxSelectStaff.DataSource = list;
                comboBoxSelectStaff.SelectedItem = null;
            }
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectStaff.SelectedValue == null)
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