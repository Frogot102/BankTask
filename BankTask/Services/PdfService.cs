using System;
using System.IO;
using BankTask.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace BankTask.Services
{
    public class PdfService
    {
        public void GeneratePdfForClient(Client client)
        {
            var doc = new Document();
            var fileName = Path.Combine(Path.GetTempPath(), $"Client_{client.ID}.pdf");

            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfWriter.GetInstance(doc, fs);
                doc.Open();

                doc.Add(new Paragraph("Карточка клиента", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)));
                doc.Add(new Paragraph($"ID: {client.ID}"));
                doc.Add(new Paragraph($"Счет: {client.CLIENT_ACC}"));
                doc.Add(new Paragraph($"Начало: {client.DATE_BEGIN:dd.MM.yyyy}"));
                if (client.DATE_END.HasValue) doc.Add(new Paragraph($"Окончание: {client.DATE_END.Value:dd.MM.yyyy}"));
                doc.Add(new Paragraph($"IKUSNUM: {client.IKUSNUM}"));
                if (!string.IsNullOrEmpty(client.AGGREMENT_NUM))
                    doc.Add(new Paragraph($"Соглашение: {client.AGGREMENT_NUM} от {client.AGGREMENT_DATE?.ToString("dd.MM.yyyy") ?? "—"}"));

                doc.Close();
            }

            System.Diagnostics.Process.Start(fileName);
        }
    }
}