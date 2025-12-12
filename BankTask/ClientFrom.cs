using System;
using System.Windows.Forms;
using BankTask.Data;
using BankTask.Models;

namespace BankTask
{
    public partial class ClientForm : Form
    {
        readonly ApplicationDbContext _context = new ApplicationDbContext();
        private Client _client;

        public ClientForm()
        {
            InitializeComponent();
            _client = new Client();
            _client.DATE_BEGIN = DateTime.Now;
            _client.CREATE_DATE = DateTime.Now;
            _client.IS_ACTIVE = true;
        }

        public ClientForm(Client client)
        {
            InitializeComponent();
            _client = client ?? new Client();
            LoadData();
        }

        private void LoadData()
        {
            if (_client.ID == 0) return;

            txtClientAcc.Text = _client.CLIENT_ACC;
            dtpDateBegin.Value = _client.DATE_BEGIN;
            dtpDateEnd.Value = _client.DATE_END ?? DateTime.Now;
            numIKUSNUM.Value = _client.IKUSNUM;
            txtAgreementNum.Text = _client.AGGREMENT_NUM;
            dtpAgreementDate.Value = _client.AGGREMENT_DATE ?? DateTime.Now;
            txtAccN068.Text = _client.ACC_N068;
            txtAcc47426.Text = _client.ACC_47426;
            chkIsActive.Checked = _client.IS_ACTIVE;
            txtCreateUser.Text = _client.CREATE_USER;
            dtpCreateDate.Value = _client.CREATE_DATE;
            txtUpdateUser.Text = _client.UPDATE_USER;
            dtpUpdateDate.Value = _client.UPDATE_DATE ?? DateTime.Now;
            txtNote.Text = _client.NOTE;
            txtErrorMessage.Text = _client.ERR_MESSAGE;
            txtClientAccDop.Text = _client.CLIENT_ACC_DOP;

            MessageBox.Show($"Клиент ID: {_client.ID}\nСчет: {_client.CLIENT_ACC}\nАктивен: {_client.IS_ACTIVE}");
        }

        private void SaveData()
        {
            _client.CLIENT_ACC = txtClientAcc.Text.Trim();
            _client.DATE_BEGIN = dtpDateBegin.Value;
            _client.DATE_END = dtpDateEnd.Value == DateTime.MinValue ? (DateTime?)null : dtpDateEnd.Value;
            _client.IKUSNUM = (int)numIKUSNUM.Value;
            _client.AGGREMENT_NUM = string.IsNullOrWhiteSpace(txtAgreementNum.Text) ? null : txtAgreementNum.Text.Trim();
            _client.AGGREMENT_DATE = dtpAgreementDate.Value == DateTime.MinValue ? (DateTime?)null : dtpAgreementDate.Value;
            _client.ACC_N068 = string.IsNullOrWhiteSpace(txtAccN068.Text) ? null : txtAccN068.Text.Trim();
            _client.ACC_47426 = string.IsNullOrWhiteSpace(txtAcc47426.Text) ? null : txtAcc47426.Text.Trim();
            _client.IS_ACTIVE = chkIsActive.Checked;
            _client.CREATE_USER = txtCreateUser.Text.Trim();
            _client.CREATE_DATE = dtpCreateDate.Value;
            _client.UPDATE_USER = string.IsNullOrWhiteSpace(txtUpdateUser.Text) ? null : txtUpdateUser.Text.Trim();
            _client.UPDATE_DATE = dtpUpdateDate.Value == DateTime.MinValue ? (DateTime?)null : dtpUpdateDate.Value;
            _client.NOTE = string.IsNullOrWhiteSpace(txtNote.Text) ? null : txtNote.Text.Trim();
            _client.ERR_MESSAGE = string.IsNullOrWhiteSpace(txtErrorMessage.Text) ? null : txtErrorMessage.Text.Trim();
            _client.CLIENT_ACC_DOP = string.IsNullOrWhiteSpace(txtClientAccDop.Text) ? null : txtClientAccDop.Text.Trim();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            SaveData();

            // Проверка обязательных полей
            if (string.IsNullOrWhiteSpace(_client.CLIENT_ACC))
            {
                MessageBox.Show("Поле 'CLIENT_ACC' обязательно для заполнения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(_client.CREATE_USER))
            {
                MessageBox.Show("Поле 'CREATE_USER' обязательно для заполнения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_client.ID == 0)
                Data.DbAccess.AddClient(_client);
            else
                Data.DbAccess.UpdateClient(_client);

            MessageBox.Show("Сохранено");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
        }

       

        
    }
}