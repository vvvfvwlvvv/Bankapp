using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp;
using System.IO;

namespace BankMoneyInPocket
{
    public partial class ComparisonIncome : Form
    {
        public ComparisonIncome()
        {
            InitializeComponent();
        }
        public List<IncomeKredit> incomeKredits;
        private void ComparisonIncome_Load(object sender, EventArgs e)
        {
            dgView.DataSource = incomeKredits.Select(incomeInfo => new { incomeInfo.name, incomeInfo.income, incomeLast = incomeInfo.income * 10, incomeInfo.percent }).ToList();
            dgView.Columns.AddRange(new DataGridViewColumn[] { new DataGridViewButtonColumn()});
            foreach (DataGridViewRow row in this.dgView.Rows)
            {
                row.Cells[4].Value = "Открыть вклад";
            }
        }

        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgView.CurrentCell.ColumnIndex == 4)
            {
                
            }
        }

        private void bPDF_Click(object sender, EventArgs e)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgView.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            string FONT_LOCATION = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "times.ttf");
            BaseFont baseFont = BaseFont.CreateFont(FONT_LOCATION, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font text = new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL);
            foreach (DataGridViewColumn column in dgView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }

            foreach (DataGridViewRow row in dgView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }

            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = ".pdf";
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
            MessageBox.Show("Pdf-документ сохранен");
        }
    }
}
