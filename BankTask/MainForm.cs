using System;
using System.Windows.Forms;
using BankTask.Data;
using BankTask.Models;
using BankTask.Services;

namespace BankTask
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            if (Services.AuthService.IsAdmin)
            {
                dgvClients.DataSource = Data.DbAccess.GetClients();
                dgvRequests.DataSource = Data.DbAccess.GetRequests();
            }
            else
            {
                string currentUser = Services.AuthService.CurrentUser;
                dgvClients.DataSource = Data.DbAccess.GetClientsByUser(currentUser);
                dgvRequests.DataSource = Data.DbAccess.GetRequestsByUser(currentUser);
            }
        }

        // === Методы для фильтрации ===
        private void LoadClientsWithFilter()
        {
            DateTime from = dtpClientDateFrom.Value.Date;
            DateTime to = dtpClientDateTo.Value.Date;

            if (AuthService.IsAdmin)
                dgvClients.DataSource = DbAccess.GetClientsByDate(from, to);
            else
                dgvClients.DataSource = DbAccess.GetClientsByUserAndDate(AuthService.CurrentUser, from, to);
        }

        private void LoadRequestsWithFilter()
        {
            DateTime from = dtpRequestDateFrom.Value.Date;
            DateTime to = dtpRequestDateTo.Value.Date;

            if (AuthService.IsAdmin)
                dgvRequests.DataSource = DbAccess.GetRequestsByDate(from, to);
            else
                dgvRequests.DataSource = DbAccess.GetRequestsByUserAndDate(AuthService.CurrentUser, from, to);
        }

        // === Клиенты ===
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            new ClientForm().ShowDialog();
            LoadData();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow?.DataBoundItem is Client client)
            {
                new ClientForm(client).ShowDialog();
                LoadData();
            }
            else
            {
                MessageBox.Show("Выберите клиента для редактирования.");
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow?.DataBoundItem is Client client)
            {
                if (MessageBox.Show($"Удалить клиента ID={client.ID}?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DbAccess.DeleteClient(client.ID);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Выберите клиента для удаления.");
            }
        }

        // === Заявки ===
        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            new RequestForm().ShowDialog();
            LoadData();
        }

        private void btnEditRequest_Click(object sender, EventArgs e)
        {
            if (dgvRequests.CurrentRow?.DataBoundItem is Request request)
            {
                new RequestForm(request).ShowDialog();
                LoadData();
            }
            else
            {
                MessageBox.Show("Выберите заявку для редактирования.");
            }
        }

        private void btnDeleteRequest_Click(object sender, EventArgs e)
        {
            if (dgvRequests.CurrentRow?.DataBoundItem is Request request)
            {
                if (MessageBox.Show($"Удалить заявку ID={request.ID}?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DbAccess.DeleteRequest(request.ID);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Выберите заявку для удаления.");
            }
        }

        // === Прочее ===
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            var clients = Services.AuthService.IsAdmin
                ? Data.DbAccess.GetClients()
                : Data.DbAccess.GetClientsByUser(Services.AuthService.CurrentUser);
            new ExcelService().ExportClientsToExcel(clients);
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            new ExcelService().ImportClientsFromExcel();
            LoadData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Печать PDF (заглушка)", "Информация");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        // === Обработчики событий для фильтрации ===
        private void btnFilterClients_Click(object sender, EventArgs e)
        {
            LoadClientsWithFilter();
        }

        private void btnClearClientFilter_Click(object sender, EventArgs e)
        {
            dtpClientDateFrom.Value = DateTime.Now.AddYears(-1);
            dtpClientDateTo.Value = DateTime.Now;
            LoadClientsWithFilter();
        }

        private void btnFilterRequests_Click(object sender, EventArgs e)
        {
            LoadRequestsWithFilter();
        }

        private void btnClearRequestFilter_Click(object sender, EventArgs e)
        {
            dtpRequestDateFrom.Value = DateTime.Now.AddYears(-1);
            dtpRequestDateTo.Value = DateTime.Now;
            LoadRequestsWithFilter();
        }

        private void lblClientDateFrom_Click(object sender, EventArgs e)
        {

        }

        private void lblClientDateTo_Click(object sender, EventArgs e)
        {

        }

        private void dtpClientDateTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dtpClientDateFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dtpRequestDateTo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}