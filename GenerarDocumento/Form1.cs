using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Word= Microsoft.Office.Interop.Word;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.CompilerServices;

namespace GenerarDocumento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNword_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            if (dialogo.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string ruta = dialogo.FileName;
            var wordApp = new Word.Application();
            wordApp.Visible = true;
            wordApp.Documents.Add();
            string dato = TXTtexto.Text;
            wordApp.Selection.TypeText(dato);
            wordApp.ActiveDocument.SaveAs2(ruta);
            MessageBox.Show("WORD CREADO EXITOSAMENTE");
            wordApp.Visible = true;
        }

        private void BTNexcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            if (dialogo.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string ruta = dialogo.FileName;
            var excelApp = new Excel.Application();
            excelApp.Workbooks.Add();
            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
            string dato = TXTtexto.Text;
            workSheet.Cells[4, "H"] = dato;
            workSheet.Columns[8].AutoFit();
            excelApp.ActiveWorkbook.SaveAs(ruta);
            MessageBox.Show("EXCEL CREADO EXITOSAMENTE");
            excelApp.Visible = true;
        }
    }
}
