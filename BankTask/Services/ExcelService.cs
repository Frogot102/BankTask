using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BankTask.Models;
using ClosedXML.Excel;

namespace BankTask.Services
{
    public class ExcelService
    {
        public void ExportClientsToExcel(List<Client> clients)
        {
            using (var wb = new XLWorkbook())
            {
                var ws = wb.Worksheets.Add("Клиенты");

                // Заголовки
                ws.Cell(1, 1).Value = "ID";
                ws.Cell(1, 2).Value = "CLIENT_ACC";
                ws.Cell(1, 3).Value = "DATE_BEGIN";
                ws.Cell(1, 4).Value = "DATE_END";
                ws.Cell(1, 5).Value = "IKUSNUM";
                ws.Cell(1, 6).Value = "AGGREMENT_NUM";
                ws.Cell(1, 7).Value = "AGGREMENT_DATE";
                ws.Cell(1, 8).Value = "ACC_N068";
                ws.Cell(1, 9).Value = "ACC_47426";
                ws.Cell(1, 10).Value = "IS_ACTIVE";
                ws.Cell(1, 11).Value = "CREATE_USER";
                ws.Cell(1, 12).Value = "CREATE_DATE";
                ws.Cell(1, 13).Value = "UPDATE_USER";
                ws.Cell(1, 14).Value = "UPDATE_DATE";
                ws.Cell(1, 15).Value = "NOTE";
                ws.Cell(1, 16).Value = "ERR_MESSAGE";
                ws.Cell(1, 17).Value = "CLIENT_ACC_DOP";

                // Данные
                for (int i = 0; i < clients.Count; i++)
                {
                    var c = clients[i];
                    ws.Cell(i + 2, 1).Value = c.ID;
                    ws.Cell(i + 2, 2).Value = c.CLIENT_ACC;
                    ws.Cell(i + 2, 3).Value = c.DATE_BEGIN;
                    ws.Cell(i + 2, 4).Value = c.DATE_END ?? default(DateTime);
                    ws.Cell(i + 2, 5).Value = c.IKUSNUM;
                    ws.Cell(i + 2, 6).Value = c.AGGREMENT_NUM;
                    ws.Cell(i + 2, 7).Value = c.AGGREMENT_DATE ?? default(DateTime);
                    ws.Cell(i + 2, 8).Value = c.ACC_N068;
                    ws.Cell(i + 2, 9).Value = c.ACC_47426;
                    ws.Cell(i + 2, 10).Value = c.IS_ACTIVE;
                    ws.Cell(i + 2, 11).Value = c.CREATE_USER;
                    ws.Cell(i + 2, 12).Value = c.CREATE_DATE;
                    ws.Cell(i + 2, 13).Value = c.UPDATE_USER;
                    ws.Cell(i + 2, 14).Value = c.UPDATE_DATE ?? default(DateTime);
                    ws.Cell(i + 2, 15).Value = c.NOTE;
                    ws.Cell(i + 2, 16).Value = c.ERR_MESSAGE;
                    ws.Cell(i + 2, 17).Value = c.CLIENT_ACC_DOP;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Сохранить как Excel"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    wb.SaveAs(saveFileDialog.FileName);
                }
            }
        }

        public void ImportClientsFromExcel()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Выберите Excel файл"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var wb = new XLWorkbook(openFileDialog.FileName))
                {
                    var ws = wb.Worksheet(1);
                    var rows = ws.RowsUsed().Skip(1); // Пропускаем заголовок

                    foreach (var row in rows)
                    {
                        var client = new Client
                        {
                            CLIENT_ACC = row.Cell(2).GetValue<string>(),
                            DATE_BEGIN = row.Cell(3).GetValue<DateTime>(),
                            DATE_END = row.Cell(4).IsEmpty() ? (DateTime?)null : row.Cell(4).GetValue<DateTime>(), 
                            IKUSNUM = row.Cell(5).GetValue<int>(),
                            AGGREMENT_NUM = row.Cell(6).GetValue<string>(),
                            AGGREMENT_DATE = row.Cell(7).IsEmpty() ? (DateTime?)null : row.Cell(7).GetValue<DateTime>(),
                            ACC_N068 = row.Cell(8).GetValue<string>(),
                            ACC_47426 = row.Cell(9).GetValue<string>(),
                            IS_ACTIVE = row.Cell(10).GetValue<bool>(),
                            CREATE_USER = row.Cell(11).GetValue<string>(),
                            CREATE_DATE = row.Cell(12).GetValue<DateTime>(),
                            UPDATE_USER = row.Cell(13).GetValue<string>(),
                            UPDATE_DATE = row.Cell(14).IsEmpty() ? (DateTime?)null : row.Cell(14).GetValue<DateTime>(),
                            NOTE = row.Cell(15).GetValue<string>(),
                            ERR_MESSAGE = row.Cell(16).GetValue<string>(),
                            CLIENT_ACC_DOP = row.Cell(17).GetValue<string>()
                        };


                    }



                }
            }
        }
    }
}