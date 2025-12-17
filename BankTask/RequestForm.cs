using System;
using System.Linq;
using System.Windows.Forms;
using BankTask.Data;
using BankTask.Models;
using BankTask.Services;

namespace BankTask
{
    public partial class RequestForm : Form
    {
        private Request _request;
        private BindingSource _clientsBindingSource = new BindingSource();

        public RequestForm()
        {
            InitializeComponent();
            _request = new Request();
            _request.CREATE_DATE = DateTime.Now;
            _request.DATE_BEGIN = DateTime.Now;

            LoadClientsIntoComboBox();
            if (!Services.AuthService.IsAdmin)
            {
                // У не-admin должна быть возможность выбрать только своих клиентов
                var currentUser = Services.AuthService.CurrentUser;
                var userClients = Data.DbAccess.GetClientsByUser(currentUser);
                if (userClients.Any())
                {
                    _clientsBindingSource.DataSource = userClients;
                    cmbClient.DataSource = _clientsBindingSource;
                    cmbClient.DisplayMember = "CLIENT_ACC";
                    cmbClient.ValueMember = "ID";
                }
                else
                {
                    MessageBox.Show("У вас нет клиентов. Сначала создайте карточку клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbClient.Enabled = false;
                }
            }
            else
            {
                var allClients = Data.DbAccess.GetClients();
                _clientsBindingSource.DataSource = allClients;
                cmbClient.DataSource = _clientsBindingSource;
                cmbClient.DisplayMember = "CLIENT_ACC";
                cmbClient.ValueMember = "ID";
            }
        }

        public RequestForm(Request request)
        {
            InitializeComponent();
            _request = request ?? new Request();
            LoadData();
        }

        private void LoadClientsIntoComboBox()
        {
            // Уже загружено в конструкторе
        }

        private void LoadData()
        {
            if (_request.ID == 0) return;

            // Загрузка клиента по ID для отображения в ComboBox
            var allClients = Services.AuthService.IsAdmin
                ? Data.DbAccess.GetClients()
                : Data.DbAccess.GetClientsByUser(Services.AuthService.CurrentUser);
            _clientsBindingSource.DataSource = allClients;
            cmbClient.DataSource = _clientsBindingSource;
            cmbClient.DisplayMember = "CLIENT_ACC";
            cmbClient.ValueMember = "ID";

            cmbClient.SelectedValue = _request.NSO_CLIENT_ID;
            dtpCreateDate.Value = _request.CREATE_DATE;
            txtSumm.Text = _request.SUMM;
            txtAddAgreementNum.Text = _request.ADDAGGREMENT_NUM;
            txtPrcStr.Text = _request.PRC_STR;
            dtpDateBegin.Value = _request.DATE_BEGIN;
            dtpDateEnd.Value = _request.DATE_END ?? DateTime.Now;
            txtDaysCount.Text = _request.DAYS_COUNT;
            numPrcJsCalc.Value = _request.PRC_JS_CALC ?? 0;
            numPrcNum.Value = _request.PRC_NUM ?? 0;
            dtpDateBreak.Value = _request.DATE_BREAK ?? DateTime.Now;
            numIsEnded.Value = _request.IS_ENDED ?? 0;
            dtpAddAgreementDate.Value = _request.ADDAGGREMENT_DATE ?? DateTime.Now;
            numIkusnum.Value = _request.IKUSNUM;
            txtCreateUser.Text = _request.CREATE_USER;
            txtUpdateUser.Text = _request.UPDATE_USER;
            dtpUpdateDate.Value = _request.UPDATE_DATE ?? DateTime.Now;
            txtNote.Text = _request.NOTE;
            txtErrMessage.Text = _request.ERR_MESSAGE;
            numNsoClientId.Value = _request.NSO_CLIENT_ID;

            // Только admin может менять клиента
            cmbClient.Enabled = Services.AuthService.IsAdmin;
            txtDaysCount.ReadOnly = true;
        }

        private void SaveData()
        {
            var selectedClient = (Client)cmbClient.SelectedItem;
            if (selectedClient == null)
            {
                MessageBox.Show("Выберите клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _request.CLIENT_ACC = selectedClient.CLIENT_ACC;
            _request.NSO_CLIENT_ID = selectedClient.ID;

            _request.CREATE_DATE = dtpCreateDate.Value;
            _request.SUMM = string.IsNullOrWhiteSpace(txtSumm.Text) ? null : txtSumm.Text.Trim();
            _request.ADDAGGREMENT_NUM = string.IsNullOrWhiteSpace(txtAddAgreementNum.Text) ? null : txtAddAgreementNum.Text.Trim();
            _request.PRC_STR = string.IsNullOrWhiteSpace(txtPrcStr.Text) ? null : txtPrcStr.Text.Trim();
            _request.DATE_BEGIN = dtpDateBegin.Value;
            _request.DATE_END = dtpDateEnd.Value == DateTime.MinValue ? (DateTime?)null : dtpDateEnd.Value;
            _request.DAYS_COUNT = string.IsNullOrWhiteSpace(txtDaysCount.Text) ? null : txtDaysCount.Text.Trim();
            _request.PRC_JS_CALC = (int)numPrcJsCalc.Value == 0 ? null : (int?)numPrcJsCalc.Value;
            _request.PRC_NUM = (int)numPrcNum.Value == 0 ? null : (int?)numPrcNum.Value;
            _request.DATE_BREAK = dtpDateBreak.Value == DateTime.MinValue ? (DateTime?)null : dtpDateBreak.Value;
            _request.IS_ENDED = (int)numIsEnded.Value == 0 ? null : (int?)numIsEnded.Value;
            _request.ADDAGGREMENT_DATE = dtpAddAgreementDate.Value == DateTime.MinValue ? (DateTime?)null : dtpAddAgreementDate.Value;
            _request.IKUSNUM = (int)numIkusnum.Value;
            _request.NOTE = string.IsNullOrWhiteSpace(txtNote.Text) ? null : txtNote.Text.Trim();
            _request.ERR_MESSAGE = string.IsNullOrWhiteSpace(txtErrMessage.Text) ? null : txtErrMessage.Text.Trim();

            string currentUser = Services.AuthService.CurrentUser;
            if (_request.ID == 0)
            {
                _request.CREATE_USER = currentUser;
                _request.CREATE_DATE = DateTime.Now;
            }
            _request.UPDATE_USER = currentUser;
            _request.UPDATE_DATE = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            if (string.IsNullOrWhiteSpace(_request.CLIENT_ACC))
            {
                MessageBox.Show("CLIENT_ACC обязателен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_request.ID == 0)
                Data.DbAccess.AddRequest(_request);
            else
                Data.DbAccess.UpdateRequest(_request);
            MessageBox.Show("Сохранено");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
        }

        private void CalculateDaysCount()
        {
            if (dtpDateEnd.Value != DateTime.MinValue && dtpDateBegin.Value != DateTime.MinValue)
            {
                int days = (dtpDateEnd.Value.Date - dtpDateBegin.Value.Date).Days;
                txtDaysCount.Text = days.ToString();
            }
            else
            {
                txtDaysCount.Text = string.Empty;
            }
        }

        private void dtpDateBegin_ValueChanged(object sender, EventArgs e)
        {
            CalculateDaysCount();
        }

        private void dtpDateEnd_ValueChanged(object sender, EventArgs e)
        {
            CalculateDaysCount();
        }

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClient.SelectedItem is Client client)
            {
                txtClientAcc.Text = client.CLIENT_ACC;
                numNsoClientId.Value = client.ID;
            }
        }
    }
}