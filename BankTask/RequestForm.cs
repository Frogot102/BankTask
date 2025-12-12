using System;
using System.Windows.Forms;
using BankTask.Data;
using BankTask.Models;

namespace BankTask
{
    public partial class RequestForm : Form
    {
        private Request _request;

        public RequestForm()
        {
            InitializeComponent();
            _request = new Request();
            _request.CREATE_DATE = DateTime.Now;
            _request.DATE_BEGIN = DateTime.Now;
        }

        public RequestForm(Request request)
        {
            InitializeComponent();
            _request = request ?? new Request();
            LoadData();
        }

        private void LoadData()
        {
            if (_request.ID == 0) return;
            txtClientAcc.Text = _request.CLIENT_ACC;
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
        }

        private void SaveData()
        {
            _request.CLIENT_ACC = txtClientAcc.Text.Trim();
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
            _request.CREATE_USER = string.IsNullOrWhiteSpace(txtCreateUser.Text) ? null : txtCreateUser.Text.Trim();
            _request.UPDATE_USER = string.IsNullOrWhiteSpace(txtUpdateUser.Text) ? null : txtUpdateUser.Text.Trim();
            _request.UPDATE_DATE = dtpUpdateDate.Value == DateTime.MinValue ? (DateTime?)null : dtpUpdateDate.Value;
            _request.NOTE = string.IsNullOrWhiteSpace(txtNote.Text) ? null : txtNote.Text.Trim();
            _request.ERR_MESSAGE = string.IsNullOrWhiteSpace(txtErrMessage.Text) ? null : txtErrMessage.Text.Trim();
            _request.NSO_CLIENT_ID = (int)numNsoClientId.Value;
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void numPrcJsCalc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numPrcNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void numIsEnded_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void numIkusnum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void numNsoClientId_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txtErrMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {

        }
    }
}