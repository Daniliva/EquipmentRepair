using EquipmentRepair.DAL.Repositories;
using EquipmentRepair.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin2DotNet;
using MaterialSkin2DotNet.Controls;

namespace EquipmentRepair.WinForm.UI.Controls
{
    public partial class RepairTypeControl : UserControl
    {
        private readonly RepairTypeRepository repairTypeRepo;

        public RepairTypeControl()
        {
            repairTypeRepo = new RepairTypeRepository("Server=DESKTOP-U9RGK02;Database=Test;Trusted_Connection=True");
            InitializeComponent();
            InitializeListView();
            LoadRepairTypes();
        }

        // Настройка MaterialListView
        private void InitializeListView()
        {
            // Настройка стиля для MaterialSkin
            var skinManager = MaterialSkinManager.Instance;
            
            skinManager.Theme = MaterialSkin2DotNet.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);

            // Инициализация ListView
            listBoxRepairTypes.View = View.Details;  // Изменяем на View.Details для многострочного вывода
            listBoxRepairTypes.FullRowSelect = true; // Поддержка выделения всей строки
            listBoxRepairTypes.GridLines = true;     // Для визуализации
            listBoxRepairTypes.HideSelection = false;

            // Задаём колонки для вывода нескольких строк
            listBoxRepairTypes.TileSize = new Size(300, 150); // Задаём размер карточек

            // Можно задать колонки, хотя они не будут видны в режиме карточек
            listBoxRepairTypes.Columns.Add("ID", 50);
            listBoxRepairTypes.Columns.Add("Name", 100);
            listBoxRepairTypes.Columns.Add("Duration", 80);
            listBoxRepairTypes.Columns.Add("Cost", 80);
            listBoxRepairTypes.Columns.Add("Notes", 150);
            // Применение шрифта и стиля
            listBoxRepairTypes.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }

        // Загрузка данных в MaterialListView
        private void LoadRepairTypes()
        {
            listBoxRepairTypes.Items.Clear(); // Очистить перед перезагрузкой
            List<RepairType> repairTypes = repairTypeRepo.GetAllRepairTypes();
            foreach (var type in repairTypes)
            {
                ListViewItem item = new ListViewItem(type.RepairTypeID.ToString());
                item.SubItems.Add(type.Name);
                item.SubItems.Add(type.Duration.ToString());
                item.SubItems.Add(type.Cost.ToString("C")); // Форматирование как денежная сумма
                item.SubItems.Add(type.Notes);
                listBoxRepairTypes.Items.Add(item);
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            int duration = int.Parse(textBoxDuration.Text);
            decimal cost = decimal.Parse(textBoxCost.Text);
            string notes = textBoxNotes.Text;

            repairTypeRepo.AddRepairType(name, duration, cost, notes);
            MessageBox.Show("Repair Type added successfully.");
            LoadRepairTypes();
        }
        private void buttonGet_Click(object sender, EventArgs e)
        {
            if (listBoxRepairTypes.SelectedItems.Count == 0) return;

            var selectedItem = listBoxRepairTypes.SelectedItems[0];
            int repairTypeID = int.Parse(selectedItem.Text);
            RepairType repairType = repairTypeRepo.GetRepairTypeByID(repairTypeID);

            textBoxName.Text = repairType.Name;
            textBoxDuration.Text = repairType.Duration.ToString();
            textBoxCost.Text = repairType.Cost.ToString();
            textBoxNotes.Text = repairType.Notes;
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxRepairTypes.SelectedItems.Count == 0) return;

            var selectedItem = listBoxRepairTypes.SelectedItems[0];
            int repairTypeID = int.Parse(selectedItem.Text);

            repairTypeRepo.UpdateRepairType(repairTypeID,
                textBoxName.Text,
                int.Parse(textBoxDuration.Text),
                decimal.Parse(textBoxCost.Text),
                textBoxNotes.Text);

            MessageBox.Show("Repair Type updated successfully.");
            LoadRepairTypes();
        }

        // Delete the selected RepairType
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxRepairTypes.SelectedItems.Count == 0) return;

            var selectedItem = listBoxRepairTypes.SelectedItems[0];
            int repairTypeID = int.Parse(selectedItem.Text);

            repairTypeRepo.DeleteRepairType(repairTypeID);
            MessageBox.Show("Repair Type deleted successfully.");
            LoadRepairTypes();
        }
    }
}
