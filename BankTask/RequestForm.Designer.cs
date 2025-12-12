namespace BankTask
{
    partial class RequestForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtClientAcc = new System.Windows.Forms.MaskedTextBox();
            this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.txtSumm = new System.Windows.Forms.MaskedTextBox();
            this.txtAddAgreementNum = new System.Windows.Forms.TextBox();
            this.txtPrcStr = new System.Windows.Forms.TextBox();
            this.dtpDateBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.txtDaysCount = new System.Windows.Forms.TextBox();
            this.numPrcJsCalc = new System.Windows.Forms.NumericUpDown();
            this.numPrcNum = new System.Windows.Forms.NumericUpDown();
            this.dtpDateBreak = new System.Windows.Forms.DateTimePicker();
            this.numIsEnded = new System.Windows.Forms.NumericUpDown();
            this.dtpAddAgreementDate = new System.Windows.Forms.DateTimePicker();
            this.numIkusnum = new System.Windows.Forms.NumericUpDown();
            this.txtCreateUser = new System.Windows.Forms.TextBox();
            this.txtUpdateUser = new System.Windows.Forms.TextBox();
            this.dtpUpdateDate = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtErrMessage = new System.Windows.Forms.TextBox();
            this.numNsoClientId = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPrcJsCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrcNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIsEnded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIkusnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNsoClientId)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClientAcc
            // 
            this.txtClientAcc.Location = new System.Drawing.Point(220, 47);
            this.txtClientAcc.Mask = "00000-000-0-0000-0000000";
            this.txtClientAcc.Name = "txtClientAcc";
            this.txtClientAcc.Size = new System.Drawing.Size(200, 22);
            this.txtClientAcc.TabIndex = 2;
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.Enabled = false;
            this.dtpCreateDate.Location = new System.Drawing.Point(220, 77);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.Size = new System.Drawing.Size(200, 22);
            this.dtpCreateDate.TabIndex = 4;
            // 
            // txtSumm
            // 
            this.txtSumm.Location = new System.Drawing.Point(220, 107);
            this.txtSumm.Mask = "000,000,000,000,000,000,000,";
            this.txtSumm.Name = "txtSumm";
            this.txtSumm.Size = new System.Drawing.Size(200, 22);
            this.txtSumm.TabIndex = 6;
            // 
            // txtAddAgreementNum
            // 
            this.txtAddAgreementNum.Location = new System.Drawing.Point(220, 137);
            this.txtAddAgreementNum.Name = "txtAddAgreementNum";
            this.txtAddAgreementNum.Size = new System.Drawing.Size(200, 22);
            this.txtAddAgreementNum.TabIndex = 8;
            // 
            // txtPrcStr
            // 
            this.txtPrcStr.Location = new System.Drawing.Point(220, 167);
            this.txtPrcStr.Name = "txtPrcStr";
            this.txtPrcStr.Size = new System.Drawing.Size(200, 22);
            this.txtPrcStr.TabIndex = 10;
            // 
            // dtpDateBegin
            // 
            this.dtpDateBegin.Enabled = false;
            this.dtpDateBegin.Location = new System.Drawing.Point(220, 197);
            this.dtpDateBegin.Name = "dtpDateBegin";
            this.dtpDateBegin.Size = new System.Drawing.Size(200, 22);
            this.dtpDateBegin.TabIndex = 12;
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Enabled = false;
            this.dtpDateEnd.Location = new System.Drawing.Point(220, 227);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(200, 22);
            this.dtpDateEnd.TabIndex = 14;
            // 
            // txtDaysCount
            // 
            this.txtDaysCount.Enabled = false;
            this.txtDaysCount.Location = new System.Drawing.Point(220, 257);
            this.txtDaysCount.Name = "txtDaysCount";
            this.txtDaysCount.Size = new System.Drawing.Size(200, 22);
            this.txtDaysCount.TabIndex = 16;
            // 
            // numPrcJsCalc
            // 
            this.numPrcJsCalc.Location = new System.Drawing.Point(220, 429);
            this.numPrcJsCalc.Name = "numPrcJsCalc";
            this.numPrcJsCalc.Size = new System.Drawing.Size(200, 22);
            this.numPrcJsCalc.TabIndex = 18;
            this.numPrcJsCalc.Visible = false;
            this.numPrcJsCalc.ValueChanged += new System.EventHandler(this.numPrcJsCalc_ValueChanged);
            // 
            // numPrcNum
            // 
            this.numPrcNum.Location = new System.Drawing.Point(220, 457);
            this.numPrcNum.Name = "numPrcNum";
            this.numPrcNum.Size = new System.Drawing.Size(200, 22);
            this.numPrcNum.TabIndex = 20;
            this.numPrcNum.Visible = false;
            this.numPrcNum.ValueChanged += new System.EventHandler(this.numPrcNum_ValueChanged);
            // 
            // dtpDateBreak
            // 
            this.dtpDateBreak.Enabled = false;
            this.dtpDateBreak.Location = new System.Drawing.Point(220, 285);
            this.dtpDateBreak.Name = "dtpDateBreak";
            this.dtpDateBreak.Size = new System.Drawing.Size(200, 22);
            this.dtpDateBreak.TabIndex = 22;
            // 
            // numIsEnded
            // 
            this.numIsEnded.Location = new System.Drawing.Point(220, 487);
            this.numIsEnded.Name = "numIsEnded";
            this.numIsEnded.Size = new System.Drawing.Size(200, 22);
            this.numIsEnded.TabIndex = 24;
            this.numIsEnded.Visible = false;
            this.numIsEnded.ValueChanged += new System.EventHandler(this.numIsEnded_ValueChanged);
            // 
            // dtpAddAgreementDate
            // 
            this.dtpAddAgreementDate.Enabled = false;
            this.dtpAddAgreementDate.Location = new System.Drawing.Point(220, 313);
            this.dtpAddAgreementDate.Name = "dtpAddAgreementDate";
            this.dtpAddAgreementDate.Size = new System.Drawing.Size(200, 22);
            this.dtpAddAgreementDate.TabIndex = 26;
            // 
            // numIkusnum
            // 
            this.numIkusnum.Location = new System.Drawing.Point(220, 515);
            this.numIkusnum.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numIkusnum.Name = "numIkusnum";
            this.numIkusnum.Size = new System.Drawing.Size(200, 22);
            this.numIkusnum.TabIndex = 28;
            this.numIkusnum.Visible = false;
            this.numIkusnum.ValueChanged += new System.EventHandler(this.numIkusnum_ValueChanged);
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.Enabled = false;
            this.txtCreateUser.Location = new System.Drawing.Point(220, 341);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Size = new System.Drawing.Size(200, 22);
            this.txtCreateUser.TabIndex = 30;
            // 
            // txtUpdateUser
            // 
            this.txtUpdateUser.Enabled = false;
            this.txtUpdateUser.Location = new System.Drawing.Point(220, 371);
            this.txtUpdateUser.Name = "txtUpdateUser";
            this.txtUpdateUser.Size = new System.Drawing.Size(200, 22);
            this.txtUpdateUser.TabIndex = 32;
            // 
            // dtpUpdateDate
            // 
            this.dtpUpdateDate.Enabled = false;
            this.dtpUpdateDate.Location = new System.Drawing.Point(220, 401);
            this.dtpUpdateDate.Name = "dtpUpdateDate";
            this.dtpUpdateDate.Size = new System.Drawing.Size(200, 22);
            this.dtpUpdateDate.TabIndex = 34;
            // 
            // txtNote
            // 
            this.txtNote.Enabled = false;
            this.txtNote.Location = new System.Drawing.Point(220, 543);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(200, 22);
            this.txtNote.TabIndex = 36;
            this.txtNote.Visible = false;
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            // 
            // txtErrMessage
            // 
            this.txtErrMessage.Enabled = false;
            this.txtErrMessage.Location = new System.Drawing.Point(220, 573);
            this.txtErrMessage.Name = "txtErrMessage";
            this.txtErrMessage.Size = new System.Drawing.Size(200, 22);
            this.txtErrMessage.TabIndex = 38;
            this.txtErrMessage.Visible = false;
            this.txtErrMessage.TextChanged += new System.EventHandler(this.txtErrMessage_TextChanged);
            // 
            // numNsoClientId
            // 
            this.numNsoClientId.Enabled = false;
            this.numNsoClientId.Location = new System.Drawing.Point(220, 601);
            this.numNsoClientId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNsoClientId.Name = "numNsoClientId";
            this.numNsoClientId.Size = new System.Drawing.Size(200, 22);
            this.numNsoClientId.TabIndex = 40;
            this.numNsoClientId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNsoClientId.Visible = false;
            this.numNsoClientId.ValueChanged += new System.EventHandler(this.numNsoClientId_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(224, 633);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(330, 633);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер счета:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата создания заявки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сумма:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Номер дополнения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Заявка на:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Дата начала:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Дата конца:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Количество дней:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 431);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "PRC_JS_CALC:";
            this.label9.Visible = false;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 459);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "PRC_NUM:";
            this.label10.Visible = false;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Дата расторжения:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 489);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "IS_ENDED:";
            this.label12.Visible = false;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 315);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Дата дополнения:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 517);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "IKUSNUM:";
            this.label14.Visible = false;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Location = new System.Drawing.Point(20, 343);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(165, 16);
            this.label15.TabIndex = 29;
            this.label15.Text = "Создан пользователем:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Enabled = false;
            this.label16.Location = new System.Drawing.Point(20, 373);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(182, 16);
            this.label16.TabIndex = 31;
            this.label16.Text = "Обновлен пользователем:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 403);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(170, 32);
            this.label17.TabIndex = 33;
            this.label17.Text = "Дата обновления заявки\r\n:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Enabled = false;
            this.label18.Location = new System.Drawing.Point(20, 545);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 16);
            this.label18.TabIndex = 35;
            this.label18.Text = "NOTE:";
            this.label18.Visible = false;
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Enabled = false;
            this.label19.Location = new System.Drawing.Point(20, 575);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 16);
            this.label19.TabIndex = 37;
            this.label19.Text = "ERR_MESSAGE:";
            this.label19.Visible = false;
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Enabled = false;
            this.label20.Location = new System.Drawing.Point(20, 603);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 16);
            this.label20.TabIndex = 39;
            this.label20.Text = "NSO_CLIENT_ID:";
            this.label20.Visible = false;
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(96, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(254, 25);
            this.label21.TabIndex = 0;
            this.label21.Text = "Редактирование заявки";
            // 
            // RequestForm
            // 
            this.ClientSize = new System.Drawing.Size(482, 698);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClientAcc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpCreateDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSumm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddAgreementNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrcStr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDateBegin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDateEnd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDaysCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numPrcJsCalc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numPrcNum);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpDateBreak);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numIsEnded);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpAddAgreementDate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.numIkusnum);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtCreateUser);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtUpdateUser);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dtpUpdateDate);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtErrMessage);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.numNsoClientId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "RequestForm";
            this.Text = "Редактирование заявки";
            this.Load += new System.EventHandler(this.RequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrcJsCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrcNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIsEnded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIkusnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNsoClientId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MaskedTextBox txtClientAcc;
        private System.Windows.Forms.DateTimePicker dtpCreateDate;
        private System.Windows.Forms.MaskedTextBox txtSumm;
        private System.Windows.Forms.TextBox txtAddAgreementNum;
        private System.Windows.Forms.TextBox txtPrcStr;
        private System.Windows.Forms.DateTimePicker dtpDateBegin;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.TextBox txtDaysCount;
        private System.Windows.Forms.NumericUpDown numPrcJsCalc;
        private System.Windows.Forms.NumericUpDown numPrcNum;
        private System.Windows.Forms.DateTimePicker dtpDateBreak;
        private System.Windows.Forms.NumericUpDown numIsEnded;
        private System.Windows.Forms.DateTimePicker dtpAddAgreementDate;
        private System.Windows.Forms.NumericUpDown numIkusnum;
        private System.Windows.Forms.TextBox txtCreateUser;
        private System.Windows.Forms.TextBox txtUpdateUser;
        private System.Windows.Forms.DateTimePicker dtpUpdateDate;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtErrMessage;
        private System.Windows.Forms.NumericUpDown numNsoClientId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}