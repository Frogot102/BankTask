using System;
using System.Linq;
using System.Windows.Forms;
using BankTask.Data;
using BankTask.Models;
using BankTask.Services;

namespace BankTask
{
    public partial class MainForm : Form
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Для теста — выводим количество записей
            var clientCount = _context.Clients.Count();
            var requestCount = _context.Requests.Count();

            MessageBox.Show($"Клиентов: {clientCount}\nЗаявок: {requestCount}", "Данные загружены");
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добавление клиента (заглушка)", "Информация");
            // new ClientForm().ShowDialog();
            // LoadData();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Редактирование клиента (заглушка)", "Информация");
            // if (dgvClients.SelectedRows.Count > 0) ...
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удаление клиента (заглушка)", "Информация");
            // if (dgvClients.SelectedRows.Count > 0) ...
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Экспорт в Excel (заглушка)", "Информация");
            // new ExcelService().ExportClientsToExcel(_context.Clients.ToList());
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Импорт из Excel (заглушка)", "Информация");
            // new ExcelService().ImportClientsFromExcel();
            // LoadData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Печать PDF (заглушка)", "Информация");
            // if (dgvClients.SelectedRows.Count > 0) ...
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _context.Dispose();
            base.OnFormClosed(e);
        }
    }
}